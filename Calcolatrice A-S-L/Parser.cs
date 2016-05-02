using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcolatrice_A_S_L
{
    class Parser
    {
        static Operatore[] Simboli =
       {
            new IncognitaX(),
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
        static Func<double, double> AnalizzaTermini(string espressione)
        {
            var Componenti = DividiTermini(espressione);
            return AnalizzaComponenti(Componenti);
        }

        public static bool EspressioneCorretta(string espressione)
        {
            try
            {
                var Componenti = DividiTermini(espressione);
                AnalizzaComponenti(Componenti);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public static double CalcolaEspressione(string espressione, double x)
        {
            return AnalizzaTermini(espressione)(x);
        }
        static Func<double, double> AnalizzaComponenti(List<Operatore> Componenti)
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
                    if (simbolo is UnTermine)
                        return (simbolo as UnTermine).Funzione(AnalizzaComponenti(ArgomentoDestra));
                    if (simbolo is DueTermini)
                        return (simbolo as DueTermini).Funzione(AnalizzaComponenti(ArgomentoSinistra), AnalizzaComponenti(ArgomentoDestra));


                }
            }
            throw new ArgumentException("Errore");
        }

        static List<Operatore> DividiTermini(string espressione)
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
                    risultato.Add(new Parentesi(AnalizzaTermini(espressione.Substring(indice + 1, indice2 - indice - 1))));
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
