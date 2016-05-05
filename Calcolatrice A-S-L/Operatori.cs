using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Calcolatrice_A_S_L
{
    public class Operatori
    {

        public static Dictionary<string, string> Operatori_diz = new Dictionary<string, string>() {
            { "piu", "+" },
             { "più", "+" },
            { "meno", "-" },
            { "per", "*" },
            { "diviso", "/" },
            {"alla","^" },
            {"aperta parentesi","(" },
            {"chiusa parentesi",")" },
            {"seno","sen" },
            {"coseno","cos" },
            {"tangente","tg" },
            {"cotangente","cotg" },
            {"radice","rad" },
            {"modulo","%" },
            {"x","x" }
        };
    }


    abstract class Operatore
    {
        protected string _Simbolo;
        public string Simbolo { get { return _Simbolo; } }
    }

    abstract class Costante : Operatore
    {
        public abstract Func<double, double> Funzione();
    }

    abstract class DueTermini : Operatore
    {
        public abstract Func<double, double> Funzione(Func<double, double> ArgomentoSinistra, Func<double, double> ArgomentoDestra);
    }
    abstract class UnTermine : Operatore
    {
        public abstract Func<double, double> Funzione(Func<double, double> ArgomentoDestra, bool radianti);
    }
    sealed class Seno : UnTermine
    {
        public Seno() { _Simbolo= "sen"; }
        public override Func<double, double> Funzione(Func<double, double> ArgomentoDestra,bool radianti )
        {

            if (radianti)
                return x => Math.Sin(ArgomentoDestra(x));
            else
                return x => Math.Sin(ArgomentoDestra(x) * Math.PI / 180);
        }
    }

    sealed class Coseno : UnTermine
    {
        public Coseno() { _Simbolo = "cos"; }
        public override Func<double, double> Funzione(Func<double, double> ArgomentoDestra,bool radianti)
        {
            if(radianti)
            return x => Math.Cos(ArgomentoDestra(x) );
            else
                return x => Math.Cos(ArgomentoDestra(x)* Math.PI / 180);
        }
    }
    sealed class Tangente : UnTermine
    {
        public Tangente() { _Simbolo = "tg"; }
        public override Func<double, double> Funzione(Func<double, double> ArgomentoDestra,bool radianti )
        {
            if (radianti)
                return x => Math.Tan(ArgomentoDestra(x));
            else
                return x => Math.Tan(ArgomentoDestra(x) * Math.PI / 180);
        }
    }
    sealed class Cotangente : UnTermine
    {
        public Cotangente() { _Simbolo = "cotg"; }
        public override Func<double, double> Funzione(Func<double, double> ArgomentoDestra,bool radianti)
        {
            if (radianti)
                return x => Math.Cos(ArgomentoDestra(x))/Math.Sin(ArgomentoDestra(x));
            else
                return x => Math.Cos(ArgomentoDestra(x) * Math.PI / 180) / Math.Sin(ArgomentoDestra(x) * Math.PI / 180);
        }
    }

    sealed class RadiceQuadrata : DueTermini
    {
        public RadiceQuadrata() { _Simbolo = "rad"; }
        public override Func<double, double> Funzione(Func<double, double> ArgomentoSinistra, Func<double, double> ArgomentoDestra)
        {
            return x => Math.Pow( ArgomentoDestra(x) ,1/ ArgomentoSinistra(x));
        }
    }
    sealed class Modulo : DueTermini
    {
        public Modulo() { _Simbolo = "%"; }
        public override Func<double, double> Funzione(Func<double, double> ArgomentoSinistra, Func<double, double> ArgomentoDestra)
        {
            return x => ArgomentoSinistra(x) % ArgomentoDestra(x);
        }

    }
    sealed class IncognitaX : Costante
    {
        public IncognitaX() { _Simbolo = "x"; }
        public override Func<double, double> Funzione()
        {
            return x => x;
        }
    }

    sealed class Numero : Costante
    {
        private double n;
        public Numero(double n) { _Simbolo = ""; this.n = n; }
        public override Func<double, double> Funzione()
        {
            return x => n;
        }
    }

    sealed class Parentesi : Costante
    {
        Func<double, double> funzione;
        public Parentesi(Func<double, double> func) { _Simbolo = ""; this.funzione = func; }
        public override Func<double, double> Funzione()
        {
            return funzione;
        }
    }



    sealed class Somma : DueTermini
    {
        public Somma() { _Simbolo = "+"; }
        public override Func<double, double> Funzione(Func<double, double> ArgomentoSinistra, Func<double, double> ArgomentoDestra)
        {
            return x => ArgomentoSinistra(x) + ArgomentoDestra(x);
        }
    }

    sealed class Sottrazione : DueTermini
    {
        public Sottrazione() { _Simbolo = "-"; }
        public override Func<double, double> Funzione(Func<double, double> ArgomentoSinistra, Func<double, double> ArgomentoDestra)
        {
            return x => ArgomentoSinistra(x) - ArgomentoDestra(x);
        }
    }

    sealed class Moltiplicazione : DueTermini
    {
        public Moltiplicazione() { _Simbolo = "*"; }
        public override Func<double, double> Funzione(Func<double, double> ArgomentoSinistra, Func<double, double> ArgomentoDestra)
        {
            return x => ArgomentoSinistra(x) * ArgomentoDestra(x);
        }
    }

    sealed class Divisione : DueTermini
    {
        public Divisione() { _Simbolo = "/"; }
        public override Func<double, double> Funzione(Func<double, double> ArgomentoSinistra, Func<double, double> ArgomentoDestra)
        {
            return x => ArgomentoSinistra(x) / ArgomentoDestra(x);
        }
    }

    sealed class Potenza : DueTermini
    {
        public Potenza() { _Simbolo = "^"; }
        public override Func<double, double> Funzione(Func<double, double> ArgomentoSinistra, Func<double, double> ArgomentoDestra)
        {
            return x => Math.Pow(ArgomentoSinistra(x), ArgomentoDestra(x));
        }

    }

}

