using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcolatrice_A_S_L
{
    public class Grafico_Form
    {
        static BackgroundWorker backgroundWorker1 = new System.ComponentModel.BackgroundWorker();

        public static Form ciao = new System.Windows.Forms.Form();

        public static void inizializzazione()
        {


            ciao.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ciao.ClientSize = new System.Drawing.Size(784, 761);


            ciao.MaximumSize = new System.Drawing.Size(800, 800);
            ciao.MinimumSize = new System.Drawing.Size(800, 800);

            ciao.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ciao.Text = "Grafico";
            ciao.MouseWheel += new System.Windows.Forms.MouseEventHandler(zoom);
            ciao.ResumeLayout(false);
            ciao.PerformLayout();
            // ciao.SetStyle(
            //   ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);


            var graficoo = new Grafico_conf(new Size(ciao.ClientSize.Width, ciao.ClientSize.Width), 20);
            var prova5 = new Pen(Brushes.Black, 2);
            var prova55 = new Pen(Brushes.DodgerBlue, 2);

            _disegno = new Grafico(graficoo, prova5, prova5, prova55, Color.White);

            _buffer = new Bitmap((int)graficoo.larghezza, (int)graficoo.altezza);
            _graficoprova = ciao.CreateGraphics();
            _graficoprova.CompositingQuality = CompositingQuality.HighSpeed;


            ciao.Load += new EventHandler(form1_load);
            ciao.MouseMove += new MouseEventHandler(test);
            ciao.Paint += new PaintEventHandler(xxx);
            
                _disegno.aggiungifunzione(new Espressione(funzi));
            
            ciao.ShowDialog();

        }
        
        static string funzi = "";
        static bool rad;
        static bool hay;
        static Point currentPos;
        public static void xxx(object x, PaintEventArgs e)
        {
            e.Graphics.DrawString("ciao", new Font(FontFamily.GenericMonospace, 10), Brushes.AliceBlue, currentPos);
        }
        public static void test(object sender, MouseEventArgs e)
        {
            currentPos = e.Location;
            Graphics.FromImage(_buffer).DrawString("ciao", new Font(FontFamily.GenericMonospace, 10), Brushes.AliceBlue, e.Location);
        }
        public static void inizio(string espressione,bool radianti,bool ha_y)
        {
           
                
                funzi = espressione;
            rad = radianti;
            hay = ha_y;
            /*	a = -1;
                b = 2;
                    funzi = "x^3-x-2";
                volte = 5;
                met=1;*/
            inizializzazione();



        }

        static private Bitmap _buffer;
        static private Grafico _disegno;
        static private Graphics _graficoprova;
        static private Graphics _grafico;


        /* protected override void prova7(PaintEventArgs e)
         {
             prova4();
             ciao.OnPaint(e);
         }*/






        private static void aggiorna()
        {
            disegnagrafico();
            disegnafunzione();

            _graficoprova.DrawImageUnscaledAndClipped(_buffer, ciao.ClientRectangle);
        }

        private static void disegnafunzione()
        {
            _grafico = Graphics.FromImage(_buffer);
            _grafico.SmoothingMode = SmoothingMode.AntiAlias;

            _disegno.disegnafunzioni(_grafico,rad,hay);
        }

        private static void disegnagrafico()
        {
            _grafico = Graphics.FromImage(_buffer);
            _grafico.SmoothingMode = SmoothingMode.HighSpeed;

            _disegno.disegnagrafico(_grafico);
        }

        private static void zoom(object sender, MouseEventArgs e)
        {
            _disegno.zoom(e.Delta);
            aggiorna();
        }

        static Timer xe = new Timer();
        private static void form1_load(object sender, EventArgs e)
        {

            xe.Interval = 100;
            xe.Tick += new EventHandler(x_Tick);
            xe.Start();
        }
        static int x = 0;
        private static void x_Tick(object sender, EventArgs e)
        {
            if (x >= 3)
            {
                aggiorna();
                xe.Stop();
            }
            x++;
        }
    }
}
