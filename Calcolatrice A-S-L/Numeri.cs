using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcolatrice_A_S_L
{
    class Numeri
    {
        public static string cifra_a_testo(long Cifra)
        {

            bool centOOttanta = false;

            string numstring = null;
            int numlen = 0;
            byte IDcent = 0;
            string subnumerostring = null;
            int subnumero = 0;
            string[] cifra = new string[3];
            string[] text = new string[3];
            int prime2cifre = 0;
            string risultato = null;
            int sezione = 0;
            string[] mono = new string[10];
            string[] duplo = new string[10];
            string[] deca = new string[10];
            string[] cento = new string[3];
            string[,] mili = new string[2, 10];
            dynamic max = null;
            max = ((Math.Pow(10, (6 * 3))) - 1) - 1;
            //   Caricamento di mono in formato esteso
            mono[0] = "";
            mono[1] = "uno";
            mono[2] = "due";
            mono[3] = "tre";
            mono[4] = "quattro";
            mono[5] = "cinque";
            mono[6] = "sei";
            mono[7] = "sette";
            mono[8] = "otto";
            mono[9] = "nove";
            //   Caricamento di duplo in formato esteso
            duplo[0] = "dieci";
            duplo[1] = "undici";
            duplo[2] = "dodici";
            duplo[3] = "tredici";
            duplo[4] = "quattordici";
            duplo[5] = "quindici";
            duplo[6] = "sedici";
            duplo[7] = "dicias" + mono[7];
            duplo[8] = "dici" + mono[8];
            duplo[9] = "dician" + mono[9];
            //   Caricamento di deca in formato esteso
            deca[0] = "";
            deca[1] = duplo[0];
            deca[2] = "venti";
            deca[3] = mono[3] + "nta";
            deca[4] = "quaranta";
            deca[5] = "cinquanta";
            deca[6] = "sessanta";
            deca[7] = "settanta";
            deca[8] = "ottanta";
            deca[9] = "novanta";
            //   Caricamento di cento in formato esteso
            cento[0] = "cent";
            cento[1] = cento[0] + "o";
            //   Caricamento di mili[0 ,] in formato esteso
            mili[0, 0] = "";
            mili[0, 1] = "mille";
            mili[0, 2] = "milione";
            mili[0, 3] = "miliardo";
            mili[0, 4] = "bilione";
            mili[0, 5] = "biliardo";
            //   Caricamento di mili[1 ,] in formato esteso
            mili[1, 0] = "";
            mili[1, 1] = "mila";
            mili[1, 2] = "milioni";
            mili[1, 3] = "miliardi";
            mili[1, 4] = "bilioni";
            mili[1, 5] = "biliardi";
            risultato = "";
            sezione = 0;
            if ((Cifra < 0))
            {
                return "err";
            }
            else if ((Cifra > max))
            {
                return ("err");
            }
            else if ((Cifra == 0))
            {
                return "zero";
            }
            else {
                numstring = Cifra.ToString();
                switch ((numstring.Length % 3))
                {
                    case 1:
                        numstring = ("00" + Cifra.ToString());
                        break;
                    case 2:
                        numstring = ("0" + Cifra.ToString());
                        break;
                    default:
                        numstring = Cifra.ToString();
                        break;
                }
                numlen = numstring.Length;
               
                while ((((sezione + 1) * 3)<= numlen))
                {
                    subnumerostring = numstring.Substring((numlen
                                    - ((sezione + 1)
                                    * 3)), 3);
                    subnumero = int.Parse(subnumerostring);
                    cifra[0] = subnumerostring.Substring(0, 1);
                    cifra[1] = subnumerostring.Substring(1, 1);
                    cifra[2] = subnumerostring.Substring(2, 1);
                     if ((subnumero != 0))
                    {
                        prime2cifre = ((int.Parse(cifra[1]) * 10)
                                    + int.Parse(cifra[2]));
                        if ((prime2cifre < 10))
                        {
                            text[2] = mono[int.Parse(cifra[2])];
                            text[1] = "";
                        }
                        else if ((prime2cifre < 20))
                        {
                            text[2] = "";
                            text[1] = duplo[(prime2cifre - 10)];
                        }
                        else {
                            // ventitre => ventitr�
                            //if (((sezione == 0)
                            //            && (int.Parse(cifra[2]) == 3)))
                            //{
                            //    text[2] = "tr�";
                            //}
                            //else {
                            text[2] = mono[int.Parse(cifra[2])];
                            // }

                            //    novantaotto => novantotto
                            if (((int.Parse(cifra[2]) == 1)
                                        || (int.Parse(cifra[2]) == 8)))
                            {
                                text[1] = deca[int.Parse(cifra[1])].Substring(0, (deca[int.Parse(cifra[1])].Length - 1));
                            }
                            else {
                                text[1] = deca[int.Parse(cifra[1])];
                            }

                        }

                        if ((int.Parse(cifra[0]) == 0))
                        {
                            text[0] = "";
                        }
                        else {
                            //  centoottanta => centottanta
                            if (((!centOOttanta
                                        && (int.Parse(cifra[1]) == 8))
                                        || ((int.Parse(cifra[1]) == 0)
                                        && (int.Parse(cifra[2]) == 8))))
                            {
                                IDcent = 0;
                            }
                            else {
                                IDcent = 1;
                            }

                            if ((int.Parse(cifra[0]) != 1))
                            {
                                text[0] = (mono[int.Parse(cifra[0])] + cento[IDcent]);
                            }
                            else {
                                text[0] = cento[IDcent];
                            }

                        }

                        //    unomille    => mille
                        //    miliardo    => unmiliardo
                        if (((subnumero == 1)
                                    && (sezione != 0)))
                        {
                            if ((sezione >= 2))
                            {
                                risultato = ("un"
                                            + (mili[0, sezione] + risultato));
                            }
                            else {
                                risultato = (mili[0, sezione] + risultato);
                            }

                        }
                        else {
                            risultato = (text[0]
                                        + (text[1]
                                        + (text[2]
                                        + (mili[1, sezione] + risultato))));
                        }

                    }

                    sezione = (sezione + 1);
                }

                return risultato;
            }

        }
        public static long testo_a_cifra(string Testo)
        {

            const long grandezza_arr = 51;
            string[] testo = new string[grandezza_arr + 1];

            // dizionario
            long[] cifra = new long[grandezza_arr + 1];
            // valore numerico parola dizionario
            long[] controlli = new long[grandezza_arr + 1];
            // tipo di numero
            string[] memI = new string[31];
            // indice parole trovate
            long memN = 0;
            // numero di parole trovate
            long memO = 0;
            // gestione errori
            long c;
            long lw;
            long i;
            // iteratore per scansionamento frase
            string w;
            string wl;
            // parola prelevata e sua lunghezza
            long n = 0;
            //risultato
            long r = 0;



            // Creo dizionario non ordinato per semplificare parser


            testo[0] = "quattordici";
            testo[1] = "diciassette";
            testo[2] = "cinquantuno";
            testo[3] = "diciannove";
            testo[4] = "quarantuno";
            testo[5] = "sessantuno";
            testo[6] = "settantuno";
            testo[7] = "ottantuno";
            testo[8] = "novantuno";
            testo[9] = "cinquanta";
            testo[10] = "quindici";
            testo[11] = "diciotto";
            testo[12] = "trentuno";
            testo[13] = "quaranta";
            testo[14] = "sessanta";
            testo[15] = "settanta";
            testo[16] = "quattro";
            testo[17] = "tredici";
            testo[18] = "ventuno";
            testo[19] = "ottanta";
            testo[20] = "novanta";
            testo[21] = "milione";
            testo[22] = "milioni";
            testo[23] = "cinque";
            testo[24] = "undici";
            testo[25] = "dodici";
            testo[26] = "sedici";
            testo[27] = "trenta";
            testo[28] = "sette";
            testo[29] = "dieci";
            testo[30] = "venti";
            testo[31] = "cento";
            testo[32] = "mille";
            testo[33] = "zero";
            testo[34] = "otto";
            testo[35] = "nove";
            testo[36] = "mila";
            testo[37] = "uno";
            testo[38] = "due";
            testo[39] = "tre";
            testo[40] = "sei";
            testo[41] = "un";
            testo[42] = "miliardo";
            testo[43] = "miliardi";
            testo[44] = "ottantotto";
            testo[45] = "novantotto";
            testo[46] = "settantotto";
            testo[47] = "sessantotto";
            testo[48] = "cinquantotto";
            testo[49] = "quarantotto";
            testo[50] = "trentotto";
            testo[51] = "ventotto";
            cifra[0] = 14;
            cifra[1] = 17;
            cifra[2] = 51;
            cifra[3] = 19;
            cifra[4] = 41;
            cifra[5] = 61;
            cifra[6] = 71;
            cifra[7] = 81;
            cifra[8] = 91;
            cifra[9] = 50;
            cifra[10] = 15;
            cifra[11] = 18;
            cifra[12] = 31;
            cifra[13] = 40;
            cifra[14] = 60;
            cifra[15] = 70;
            cifra[16] = 4;
            cifra[17] = 13;
            cifra[18] = 21;
            cifra[19] = 80;
            cifra[20] = 90;
            cifra[21] = 1000000;
            cifra[22] = 1000000;
            cifra[23] = 5;
            cifra[24] = 11;
            cifra[25] = 12;
            cifra[26] = 16;
            cifra[27] = 30;
            cifra[28] = 7;
            cifra[29] = 10;
            cifra[30] = 20;
            cifra[31] = 100;
            cifra[32] = 1000;
            cifra[33] = 0;
            cifra[34] = 8;
            cifra[35] = 9;
            cifra[36] = 1000;
            cifra[37] = 1;
            cifra[38] = 2;
            cifra[39] = 3;
            cifra[40] = 6;
            cifra[41] = 1;
            cifra[42] = 1000000000;
            cifra[43] = 1000000000;
            cifra[44] = 88;
            cifra[45] = 98;
            cifra[46] = 78;
            cifra[47] = 68;
            cifra[48] = 58;
            cifra[49] = 48;
            cifra[50] = 38;
            cifra[51] = 28;
            // assegno tipo a corrispettiva parola,evito cosi difficili costrutti if e operazioni booleanee 
            controlli[0] = 1;
            controlli[1] = 1;
            controlli[2] = 2;
            controlli[3] = 1;
            controlli[4] = 2;
            controlli[5] = 2;
            controlli[6] = 2;
            controlli[7] = 2;
            controlli[8] = 2;
            controlli[9] = 2;
            controlli[10] = 1;
            controlli[11] = 1;
            controlli[12] = 2;
            controlli[13] = 2;
            controlli[14] = 2;
            controlli[15] = 2;
            controlli[16] = 1;
            controlli[17] = 1;
            controlli[18] = 2;
            controlli[19] = 2;
            controlli[20] = 2;
            controlli[21] = 4;
            controlli[22] = 4;
            controlli[23] = 1;
            controlli[24] = 1;
            controlli[25] = 1;
            controlli[26] = 1;
            controlli[27] = 2;
            controlli[28] = 1;
            controlli[29] = 1;
            controlli[30] = 2;
            controlli[31] = 3;
            controlli[32] = 4;
            controlli[33] = 1;
            controlli[34] = 1;
            controlli[35] = 1;
            controlli[36] = 4;
            controlli[37] = 1;
            controlli[38] = 1;
            controlli[39] = 1;
            controlli[40] = 1;
            controlli[41] = 1;
            controlli[42] = 4;
            controlli[43] = 4;
            controlli[44] = 2;
            controlli[45] = 2;
            controlli[46] = 2;
            controlli[47] = 2;
            controlli[48] = 2;
            controlli[49] = 2;
            controlli[50] = 2;
            controlli[51] = 2;


            if ((Testo == testo[33]))
            {
                return 0;
            }
            // Parser estraggo parola e metto in memoria
            lw = Testo.Length;
            long stWords = 1;

            // Scansiono tutta la frase partendo da parametro funzione
            // esco se non trovo almeno una parola al primo ciclo
            // analizzo fino a quando non finisce frase o trovo parola non valida
            for (c = stWords; (c <= lw); c++)
            {
                // per ogni parola dizionario cerco corrispettiva in frase.
                for (i = 0; (i <= grandezza_arr); i++)
                {
                    wl = testo[i].Length.ToString();
                    try
                    {
                        w = Testo.Substring(int.Parse((c - 1).ToString()), testo[i].Length);
                    }
                    catch (Exception x)
                    {
                        continue;
                    }

                    if ((w == testo[i]))
                    {
                        memI[memN] = i.ToString();
                        memN = (memN + 1);
                        w = "";
                        c = (c
                                    + (int.Parse(wl) - 1));
                        break;
                    }

                }

                if ((memO == memN))
                {

                    break;


                }
                else {
                    memO = memN;
                }

            }

            // sposto la posizione carattere fino a dove sono arrivato a scansionare
            stWords = (stWords + c);

            //Analizzo le parole trovate e ne ricreo il valore

            for (i = 0; (i
                        <= (memN - 1)); i++)
            {
                if ((controlli[int.Parse(memI[i])] == 1))
                {
                    n = (n + cifra[int.Parse(memI[i])]);
                }
                else if ((controlli[int.Parse(memI[i])] == 2))
                {
                    n = (n + cifra[int.Parse(memI[i])]);
                }
                else if ((controlli[int.Parse(memI[i])] == 3))
                {
                    if ((n == 0))
                    {
                        n = 1;
                    }

                    n = (n * cifra[int.Parse(memI[i])]);
                }
                else if ((controlli[int.Parse(memI[i])] == 4))
                {
                    if ((n == 0))
                    {
                        n = 1;
                    }

                    r = (r + (n * cifra[int.Parse(memI[i])]));
                    n = 0;
                }

            }

            r = (r + n);


            if (r != 0)
                return r;
            return -1;
        }
     

      

    }
}
