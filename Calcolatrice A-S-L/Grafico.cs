using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcolatrice_A_S_L
{
    internal class Grafico
    {
        //private MethodInfo _calcolafunzione;
        private const int prova12 = 120;
        private const int moltiplicatorezoom = 4;

        private readonly Pen _prova56;
        private readonly Color _colore;
        private readonly List<Espressione> _funzioni;
        private readonly Grafico_conf _grafico;

        public Grafico(Grafico_conf grafico, Pen prova86, Pen prova91, Pen prova66, Color colore)
        {
            _grafico = grafico;
            graficotest = prova86;
            funzionetest = prova66;
            _prova56 = prova91;
            _colore = colore;
            _funzioni = new List<Espressione>();
            disegnagriglia = disegnaassi = disegnatacce = true;


        }



        public Pen graficotest { get; set; }

        public Pen funzionetest { get; set; }

        public Grafico_conf grafico
        {
            get { return _grafico; }
        }

        public bool disegnagriglia { get; set; }
        public bool disegnatacce { get; set; }
        public bool disegnaassi { get; set; }

        private PointF puntotrasformato(PointF punto)
        {

            return new PointF(punto.X * grafico.dimensionicelle + grafico.centro.X, -punto.Y * grafico.dimensionicelle + grafico.centro.Y);
        }


        private void scrivifunzione(Graphics g, Espressione f)
        {

            var listapunti = new List<List<PointF>> { new List<PointF>() };

            bool provanan = false;
            double precedente = 0;
            double x_recedente = 0;
            bool fatto = false;
            Form1.risultati_x.Clear();
            for (float x = -grafico.numerocelle / 2; x < grafico.numerocelle / 2; x += grafico.passo)

            {
                double y = f.applica(x);
                PointF point = puntotrasformato(new PointF(x, (float)y));

                if (double.IsNaN(y))
                {
                    if (!provanan)
                    {
                        listapunti.Add(new List<PointF>());
                        provanan = true;
                    }
                }


                else if (point.Y > grafico.altezza)
                {
                    listapunti[listapunti.Count - 1].Add(new PointF(point.X, grafico.altezza + funzionetest.Width));
                }
                else if (point.Y < 0)
                {
                    listapunti[listapunti.Count - 1].Add(new PointF(point.X, -funzionetest.Width));
                }
                else
                {
                    provanan = false;
                    listapunti[listapunti.Count - 1].Add(point); //
                }
                if (fatto)
                {
                    if (y == 0 || (precedente < 0 && y > 0) || (precedente > 0 && y < 0))
                    {

                        if (Form1.risultati_x.Contains(Math.Abs(Math.Round((x + x_recedente) / 2, 2)).ToString()))
                        {
                            Form1.risultati_x.Remove(Math.Abs(Math.Round((x + x_recedente) / 2, 2)).ToString());
                            Form1.risultati_x.Add("±" + Math.Abs(Math.Round((x + x_recedente) / 2, 2)));
                        }
                        else if (Form1.risultati_x.Contains("-" + Math.Abs(Math.Round((x + x_recedente) / 2, 2)).ToString()))
                        {
                            Form1.risultati_x.Remove("-" + Math.Abs(Math.Round((x + x_recedente) / 2, 2)).ToString());
                            Form1.risultati_x.Add("±" + Math.Abs(Math.Round((x + x_recedente) / 2, 2)));
                        }
                        else if (!Form1.risultati_x.Contains(Math.Round((x + x_recedente) / 2, 2).ToString()))
                            Form1.risultati_x.Add(Math.Round((x + x_recedente) / 2, 2).ToString());

                    }






                }

                else {
                    if (y == 0)
                    {
                        if (!Form1.risultati_x.Contains(Math.Round(x, 2).ToString()))
                            Form1.risultati_x.Add(Math.Round(x, 2).ToString());
                    }
                    //±
                }
                fatto = true;
                precedente = y;
                x_recedente = x;
            }


            foreach (var lista in listapunti.Where(list => list.Count > 1))
            {
                g.DrawLines(funzionetest, lista.ToArray());
            }
            //nuovo




        }

        public void disegnagrafico(Graphics g)
        {
            g.Clear(_colore);

            if (disegnagriglia || disegnaassi)
            {
                for (int i = 0; i <= grafico.numerocelle; i++)
                {
                    if (disegnagriglia)
                    {

                        g.DrawLine(Pens.Gray, i * grafico.dimensionicelle, 0, i * grafico.dimensionicelle, grafico.numerocelle * grafico.dimensionicelle);
                        g.DrawLine(Pens.Gray, 0, i * grafico.dimensionicelle, grafico.numerocelle * grafico.dimensionicelle, i * grafico.dimensionicelle);
                    }

                    if (disegnatacce)
                    {

                        g.DrawLine(_prova56, grafico.centro.X - grafico.dimensionitacca / 2, i * grafico.dimensionicelle,
                                   grafico.centro.X + grafico.dimensionitacca / 2, i * grafico.dimensionicelle);
                        g.DrawLine(_prova56, i * grafico.dimensionicelle, grafico.centro.Y - grafico.dimensionitacca / 2, i * grafico.dimensionicelle,
                                   grafico.centro.Y + grafico.dimensionitacca / 2);


                        if (i - grafico.numerocelle / 2 != 0)
                            g.DrawString((i - grafico.numerocelle / 2).ToString(), new Font(FontFamily.GenericSerif, grafico.dimensionitacca, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, new RectangleF(i * grafico.dimensionicelle, grafico.centro.Y + grafico.dimensionitacca / 3, 5000, 5000));
                        g.DrawString(((grafico.numerocelle / 2) - i).ToString(), new Font(FontFamily.GenericSerif, grafico.dimensionitacca, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, new RectangleF(grafico.centro.X + grafico.dimensionitacca / 3, i * grafico.dimensionicelle, 5000, 5000));

                    }
                }
            }
            if (disegnaassi)
            {

                g.DrawLine(_prova56, 0, grafico.centro.Y, grafico.larghezza, grafico.centro.Y);
                g.DrawLine(_prova56, grafico.centro.X, 0, grafico.centro.X, grafico.altezza);
            }
        }

        public void disegnafunzioni(Graphics g)
        {

            foreach (Espressione f in _funzioni)
            {
                scrivifunzione(g, f);
            }
        }

        public void zoom(int delta)
        {
            int valore = (delta / prova12) * moltiplicatorezoom;

            if (grafico.numerocelle - valore <= Grafico_conf.numerocellemin)
            {
                grafico.numerocelle = Grafico_conf.numerocellemin;
            }
            else if (grafico.numerocelle - valore >= Grafico_conf.numerocellemax)
            {
                grafico.numerocelle = Grafico_conf.numerocellemax;
            }
            else
            {
                grafico.numerocelle -= valore;
            }
        }

        public void aggiungifunzione(Espressione f)
        {
            _funzioni.Add(f);
        }

        public void rimuovifunzioni()
        {
            if (_funzioni.Count > 0)
                _funzioni.Clear();
        }
    }
}
