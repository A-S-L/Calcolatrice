﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcolatrice_A_S_L
{
    internal class Espressione
    {
        //private MethodInfo _calcolafunzione;
        private string _espressione;

        public Espressione(string f)
        {
            espressione = f;
        }

        public Espressione()
        {
        }

        public string espressione
        {
            get
            {
                return _espressione;
            }

            set
            {
                _espressione = value;
            }
        }

        public bool applica(double x, double y, bool radianti, out double risultato)
        {

            if (Parser.EspressioneCorretta(_espressione, radianti, out risultato, x, y))
                return true;
            return false;
            //  return (float) _calcolafunzione.Invoke(null, new object[] {x});
        }
    }
}
