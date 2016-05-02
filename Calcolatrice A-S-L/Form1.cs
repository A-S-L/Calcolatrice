using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcolatrice_A_S_L
{
    public partial class Form1 : Form
    {
        public static bool deg = true;
        public Form1()
        {
            InitializeComponent();


        }
        bool t_c = true;

        public static List<string> risultati_x = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            string risultato_lettere = "";
            string risultato_cifre = "";
            if (t_c)
               textBox2.Text= esp_testo_numero(textBox1.Text,out risultato_cifre);
            else
               textBox1.Text= esp_numero_testo(textBox2.Text, out risultato_cifre);
            string boh = "";
            risultato_lettere = esp_numero_testo(risultato_cifre, out boh);
            textBox3.Text = risultato_lettere;
            textBox4.Text = risultato_cifre;
        }
        public string esp_testo_numero(string testo, out string Risultato)
        {
            deg = radioButton1.Checked;
            string[] termini = testo.ToLower().Split(' ');
            termini = termini.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            string[] risultato = new string[0];
            string precedente = "";

            foreach (string termine in termini)
            {


                if (is_Operatore(termine))
                {
                    Array.Resize(ref risultato, risultato.Length + 1);
                    risultato[risultato.Length - 1] = Operatori.Operatori_diz[termine];
                }
                else if (termine == "parentesi")
                {
                    if (precedente == "aperta" || precedente == "chiusa")
                    {
                        Array.Resize(ref risultato, risultato.Length + 1);
                        risultato[risultato.Length - 1] = Operatori.Operatori_diz[precedente + " " + termine];
                    }
                }
                /*else if (termine == "quadrata")
                {
                    if (precedente == "radice" )
                    {
                        Array.Resize(ref risultato, risultato.Length + 1);
                        risultato[risultato.Length - 1] = Operatori.Operatori_diz[precedente + " " + termine];
                    }
                }*/
                else if (termine == "virgola")
                {
                    risultato[risultato.Length - 1] += ",";
                }
                else if (is_Numero(termine))
                {
                    if (precedente == "virgola")
                    {
                        risultato[risultato.Length - 1] += Numeri.testo_a_cifra(termine).ToString();
                    }
                    else
                    {
                        Array.Resize(ref risultato, risultato.Length + 1);
                        risultato[risultato.Length - 1] = Numeri.testo_a_cifra(termine).ToString();
                    }
                }

                precedente = termine;
            }
            string Espressione = string.Join(" ", risultato);
            textBox2.Text = Espressione.Replace(" ", "");
            Risultato = "";
            if (Parser.EspressioneCorretta(Espressione))
            {
                if (Espressione.Contains("x"))
                {
                    if (MessageBox.Show("L'espressione contine una incognita, visualizzarne il grafico posto y= epressione?") == DialogResult.OK)
                    {
                        Grafico_Form.inizio(Espressione);
                        label1.Text = "X= " + string.Join("\nX= ", risultati_x.ToArray());
                    }
                }
                Risultato=  Parser.CalcolaEspressione(Espressione,0).ToString();


            }
            return Espressione;
        }
        public string esp_numero_testo(string numero, out string Risultato)
        {
            string num = "";
            string op = "";
            string[] risultato = new string[0];
            foreach (char c in numero.Replace(" ", ""))
            {
                if (is_Cifra(c))
                {
                    if (op != "")
                    {
                        int num_cifre = 0;
                        int inizio = 0;
                        while (num_cifre <= op.Length)
                        {
                            if (is_Operatore_lettera(op.Substring(inizio, num_cifre - inizio)))
                            {
                                Array.Resize(ref risultato, risultato.Length + 1);
                                risultato[risultato.Length - 1] = Operatori.Operatori_diz.FirstOrDefault(x => x.Value == op.Substring(inizio, num_cifre - inizio)).Key;
                                inizio = num_cifre;
                            }
                            num_cifre++;
                        }

                        op = "";
                    }
                    num += c;

                }
                else if (is_Lettera_o_simbolo(c))
                {
                    if (num != "")
                    {

                        Array.Resize(ref risultato, risultato.Length + 1);
                        risultato[risultato.Length - 1] = Numeri.cifra_a_testo(long.Parse(num));

                        num = "";
                    }
                    op += c;
                }
            }
            if (op != "")
            {
                int num_cifre = 0;
                int inizio = 0;
                while (num_cifre <= op.Length)
                {
                    if (is_Operatore_lettera(op.Substring(inizio, num_cifre - inizio)))
                    {
                        Array.Resize(ref risultato, risultato.Length + 1);
                        risultato[risultato.Length - 1] = Operatori.Operatori_diz.FirstOrDefault(x => x.Value == op.Substring(inizio, num_cifre - inizio)).Key;
                        inizio = num_cifre;
                    }
                    num_cifre++;
                }

                op = "";
            }
            if (num != "")
            {

                Array.Resize(ref risultato, risultato.Length + 1);
                risultato[risultato.Length - 1] = Numeri.cifra_a_testo(long.Parse(num));

                num = "";
            }
            Risultato = Parser.CalcolaEspressione(numero,0).ToString();
            return  string.Join(" ", risultato);

           
        }
        public bool is_Numero(string numero)
        {
            if (Numeri.testo_a_cifra(numero) >= 0)
                return true;
            return false;
        }
        public bool is_Operatore(string operatore)
        {
            return Operatori.Operatori_diz.ContainsKey(operatore);
        }
        public bool is_Operatore_lettera(string operatore)
        {
            return Operatori.Operatori_diz.ContainsValue(operatore);
        }
        public bool is_Cifra(char cifra)
        {
            return char.IsNumber(cifra);
        }
        public bool is_Lettera_o_simbolo(char simbolo)
        {
            return !char.IsNumber(simbolo);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            t_c = radioButton3.Checked;
            if(t_c)
            {
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = true;
            }
         else
            {
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = false;
            }
        }
    }
}
