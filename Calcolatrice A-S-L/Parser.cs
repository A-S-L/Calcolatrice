using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcolatrice_A_S_L
{
    class Parser
    {
        static Operatore[] Simboli =
       {
            new IncognitaX(),
            new IncognitaY(),
            new Somma(),
            new Sottrazione(),
            new Moltiplicazione(),
            new Divisione(),
            new Potenza(),
            new Seno(),
            new Coseno(),
            new Tangente(),
            new Cotangente(),
            new RadiceQuadrata(),
            new Modulo()
        };
        static Func<double, double,double> AnalizzaTermini(string espressione, bool radianti)
        {
            var Componenti = DividiTermini(espressione, radianti);
          
            return AnalizzaComponenti(Componenti, radianti);
        }

        public static bool EspressioneCorretta(string espressione, bool radianti,out double Risultato,double x=0, double y=0)
        {
            try
            {
                Risultato = CalcolaEspressione(espressione, x, y, radianti);
                return true;
            }
            catch (Exception)
            {
                Risultato = 0;
                return false;
            }

        }
        public static double CalcolaEspressione(string espressione, double x,double y, bool radianti)
        {
           
            return AnalizzaTermini(espressione, radianti)(x,y);
        }
        static Func<double, double,double> AnalizzaComponenti(List<Operatore> Componenti, bool radianti)
        {

            if (Componenti.Count == 1)
            {
               
                if (Componenti[0] is Costante)
                    return (Componenti[0] as Costante).Funzione();
                else
                    throw new ArgumentException("Errore");
            }

            foreach (var simbolo in Simboli)
            {
                if (!(simbolo is Costante) && Componenti.Contains(simbolo))
                {
                    int n = Componenti.LastIndexOf(simbolo);
                    var ArgomentoSinistra = new List<Operatore>();
                    var ArgomentoDestra = new List<Operatore>();
                    for (int i = 0; i < n; ++i)
                        ArgomentoSinistra.Add(Componenti[i]);
                    for (int i = n + 1; i < Componenti.Count; ++i)
                        ArgomentoDestra.Add(Componenti[i]);
                    if (simbolo is Sottrazione && ArgomentoSinistra.Count == 0)
                        ArgomentoSinistra.Add(new Numero(0));
                    if (simbolo is Somma && ArgomentoSinistra.Count == 0)
                        ArgomentoSinistra.Add(new Numero(0));
                    if (simbolo is Moltiplicazione && ArgomentoSinistra.Count == 0)
                        ArgomentoSinistra.Add(new Numero(1));
                    if (simbolo is UnTermine)
                        return (simbolo as UnTermine).Funzione(AnalizzaComponenti(ArgomentoDestra, radianti), radianti);
                    if (simbolo is DueTermini)
                        return (simbolo as DueTermini).Funzione(AnalizzaComponenti(ArgomentoSinistra, radianti), AnalizzaComponenti(ArgomentoDestra, radianti));
                   

                }
               
            }
            throw new ArgumentException("Errore");
        }

        static List<Operatore> DividiTermini(string espressione, bool radianti)
        {
            List<Operatore> risultato = new List<Operatore>();
            int indice = 0;
            bool simbolonumerico = false;
            while (indice < espressione.Length)
            {
                bool trovato = false;

                foreach (var simbolo in Simboli)
                {
                   
                    if (simbolo.Simbolo.Length > 0 &&
                        indice + simbolo.Simbolo.Length <= espressione.Length &&
                        espressione.Substring(indice, simbolo.Simbolo.Length).Equals(simbolo.Simbolo))
                    {
                        risultato.Add(simbolo);
                        indice += simbolo.Simbolo.Length;
                        trovato = true;
                        break;
                    }
                }
                if (trovato)
                {
                    if (simbolonumerico && !(risultato.Last() is DueTermini))
                    {
                        risultato.Insert(risultato.Count - 1, Simboli.Where(o => o.Simbolo.Equals("*")).First());
                    }
                    simbolonumerico = false;
                    continue;
                }
                if (espressione.Substring(indice, 1).Equals(" "))
                {
                    indice++;
                    continue;
                }

                if (espressione.Substring(indice, 1).Equals("("))
                {
                    int parentesi = 1;
                    int indice2 = indice;
                    while (parentesi > 0)
                    {
                        indice2++;
                        if (indice2 >= espressione.Length)
                            throw new ArgumentException("errore");
                        if (espressione.Substring(indice2, 1).Equals("("))
                            parentesi++;
                        else if (espressione.Substring(indice2, 1).Equals(")"))
                            parentesi--;
                    }
                    risultato.Add(new Parentesi(AnalizzaTermini(espressione.Substring(indice + 1, indice2 - indice - 1), radianti)));
                    indice = indice2 + 1;

                    if (simbolonumerico && !(risultato.Last() is DueTermini))
                    {
                        risultato.Insert(risultato.Count - 1, Simboli.Where(o => o.Simbolo.Equals("*")).First());
                    }
                    simbolonumerico = false;

                    continue;
                }

                if (espressione.Substring(indice, 1).Equals(")"))
                    throw new ArgumentException("errore");

                double numero;
                if (Double.TryParse(espressione.Substring(indice, 1), out numero))
                {
                   
                    int lunghezza = 2;
                    while ((indice + lunghezza <= espressione.Length &&
                            Double.TryParse(espressione.Substring(indice, lunghezza), out numero)))
                        lunghezza++;
                    lunghezza--;
                    Double.TryParse(espressione.Substring(indice, lunghezza), out numero);
                  
                    risultato.Add(new Numero(numero));
                    indice += lunghezza;
                    simbolonumerico = true;
                    continue;
                }

                throw new ArgumentException("errore");
            }
            return risultato;
        }
    }
}
