using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcolatrice_A_S_L
{
   internal class Grafico_conf
    {
        public const int numerocellemax = 80;
        public const int numerocellemin = 4;
        private readonly PointF _centro;
        private readonly float _altezza;
        private readonly Size _dimensione;
        private readonly float _wlarghezza;
        private int _numerocelle;

        public Grafico_conf(Size dimensione, int numerodicelle)
        {
            _dimensione = dimensione;
            _numerocelle = numerodicelle;
            _wlarghezza = dimensione.Width;
            _altezza = dimensione.Height;
            _centro = new PointF((float)dimensione.Width / 2, (float)dimensione.Height / 2);
            passo = Calcolatrice_A_S_L.Properties.Settings.Default.precisione;
        }

        public PointF centro
        {
            get { return _centro; }
        }

        public Size dimensionee
        {
            get { return _dimensione; }
        }

        public int numerocelle
        {
            get { return _numerocelle; }
            set { _numerocelle = value; }
        }

        public float dimensionicelle
        {
            get { return _wlarghezza / _numerocelle; }
        }

        public float larghezza
        {
            get { return _wlarghezza; }
        }

        public float altezza
        {
            get { return _altezza; }
        }

        public float dimensionitacca
        {
            get { return dimensionicelle / 3; }
        }

        public float passo { get; set; }
    }
}
