using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcolatrice_A_S_L
{
    public partial class Calcolatrice : Form
    {
        public static bool deg = true;
        public Calcolatrice()
        {
            InitializeComponent();
           

        }
        bool t_c = true;

        public static List<string> risultati_x = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {

            risultati_x.Clear();
            Grafico_Form.ciao.Close();
            textBoxRisultatoNumeri.Clear();
            textBoxRisultatoParole.Clear();
            string risultato_lettere = "";
            string risultato_cifre = "";
            if (t_c)
                calcola_da_testo();
            else
                calcola_da_numero();

            textBoxRisultatoParole.BackColor = Color.LightGreen;
            textBoxRisultatoNumeri.BackColor = Color.LightGreen;

        }
        public void calcola_da_numero()
        {

            string numero = textBoxNumeri.Text;
            string testo = esp_numero_testo(numero);
            textBoxParole.Text = testo;
            if (numero.Contains("±"))
            {
                int numm = numero.Count(x => x == '±');

                string[] espressioni = { };
                for (int i = 0; i < Math.Pow(2, numm); i++)
                {
                    string test = numero;
                    string tesst = Convert.ToString(i, 2).PadLeft(Convert.ToString((int)Math.Pow(2, numm) - 1, 2).Length, '0');
                    for (int j = tesst.Length - 1; j >= 0; j--)
                    {
                        if (tesst[j] == '1')
                        {
                            StringBuilder bb = new StringBuilder(test);
                            bb[prendi_Indice(test, '±', j + 1)] = '+';
                            test = bb.ToString();
                        }
                    }
                    test = test.Replace('±', '-');
                    double risultato;
                    if (Parser.EspressioneCorretta(test, false, out risultato))
                    {
                        textBoxRisultatoNumeri.Text += test + " = " + risultato.ToString() + "\r\n";

                        textBoxRisultatoParole.Text += esp_numero_testo(test) + " = " + esp_numero_testo(risultato.ToString()) + "\r\n";
                    }
                    else
                    {
                        textBoxRisultatoNumeri.Text += test + " = Non valido\r\n";
                    }


                    //MessageBox.Show(test);


                    Array.Resize(ref espressioni, espressioni.Length + 1);
                    espressioni[espressioni.Length - 1] = test;
                    // MessageBox.Show(Parser.CalcolaEspressione(test, 0, 0, deg).ToString());
                    test = numero;
                }

                if (numero.Contains("x"))
                {
                    if (MessageBox.Show("L'espressione contine una incognita, visualizzarne il grafico posto y= epressione?", "Calcolatrice", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        bool yy = false;
                        if (numero.Contains("y"))
                            yy = true;
                        Grafico_Form.inizio(espressioni, deg, yy);
                        richTextBoxX.Text = "X= " + string.Join(" X= ", risultati_x.ToArray()) + "\n";
                    }
                }
                return;

            }
            double Risultato;
            if (Parser.EspressioneCorretta(numero, deg, out Risultato))
            {
                textBoxRisultatoNumeri.Text += numero + " = " + Risultato.ToString() + "\r\n";

                textBoxRisultatoParole.Text += testo + " = " + esp_numero_testo(Risultato.ToString()) + "\r\n";
                if (numero.Contains("x"))
                {
                    if (MessageBox.Show("L'espressione contine una incognita, visualizzarne il grafico posto y= epressione?", "Calcolatrice", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        bool yy = false;
                        if (numero.Contains("y"))
                            yy = true;
                        Grafico_Form.inizio(new string[] { numero }, deg, yy);
                        richTextBoxX.Text = "X= " + string.Join(" X= ", risultati_x.ToArray()) + "\n";
                    }
                }



            }
        }
        public void calcola_da_testo()
        {
            string testo = textBoxParole.Text;
            string numero = esp_testo_numero(testo);
            textBoxNumeri.Text = numero;
            if (testo.Contains("piuomeno"))
            {
                int numm = Regex.Matches(testo, "piuomeno").Count;

                string[] espressioni = { };
                for (int i = 0; i < Math.Pow(2, numm); i++)
                {
                    string test = testo;
                    string tesst = Convert.ToString(i, 2).PadLeft(Convert.ToString((int)Math.Pow(2, numm) - 1, 2).Length, '0');
                    for (int j = tesst.Length - 1; j >= 0; j--)
                    {
                        if (tesst[j] == '1')
                        {
                            test = sostituisci(test, j + 1, "piuomeno", "piu");
                        }
                    }
                    string riss;
                    test = test.Replace("piuomeno", "meno");
                    double risultato;
                    if (Parser.EspressioneCorretta(esp_testo_numero(test), false, out risultato))
                    {

                        textBoxRisultatoParole.Text += test + " = " + esp_numero_testo(risultato.ToString()) + "\r\n";

                        textBoxRisultatoNumeri.Text += esp_testo_numero(test) + " = " + risultato.ToString() + "\r\n";
                    }
                    else
                    {
                        textBoxRisultatoParole.Text += test + " = Non valido\r\n";
                    }


                    //MessageBox.Show(test);


                    Array.Resize(ref espressioni, espressioni.Length + 1);
                    espressioni[espressioni.Length - 1] = test;
                    // MessageBox.Show(Parser.CalcolaEspressione(test, 0, 0, deg).ToString());
                    test = testo;
                }
                if (testo.Contains("x"))
                {
                    if (MessageBox.Show("L'espressione contine una incognita, visualizzarne il grafico posto y= epressione?", "Calcolatrice", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        bool yy = false;
                        if (testo.Contains("y"))
                            yy = true;
                        Grafico_Form.inizio(espressioni, deg, yy);
                        richTextBoxX.Text = "X= " + string.Join(" X= ", risultati_x.ToArray()) + "\n";
                    }
                }
                return;

            }
            double Risultato;
            if (Parser.EspressioneCorretta(numero, deg, out Risultato))
            {

                textBoxRisultatoNumeri.Text = esp_testo_numero(testo) + " = " + Risultato;
                textBoxRisultatoParole.Text = testo + " = " + esp_numero_testo(Risultato.ToString());
                if (testo.Contains("x"))
                {
                    if (MessageBox.Show("L'espressione contine una incognita, visualizzarne il grafico posto y= epressione?", "Calcolatrice", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        bool yy = false;
                        if (testo.Contains("y"))
                            yy = true;
                        Grafico_Form.inizio(new string[] { numero }, deg, yy);
                        richTextBoxX.Text = "X= " + string.Join(" X= ", risultati_x.ToArray()) + "\n";
                    }
                }



            }

        }
        public string esp_testo_numero(string testo)
        {
            deg = radioButtonRadianti.Checked;
            string[] termini = testo.ToLower().Split(' ');
            termini = termini.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            string[] risultato = new string[0];
            string precedente = "";

            foreach (string termine in termini)
            {

                long riss;
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
                else if (termine == "virgola")
                {
                    risultato[risultato.Length - 1] += ",";
                }
                else if (is_Numero(termine, out riss))
                {
                    if (precedente == "virgola")
                    {
                        risultato[risultato.Length - 1] += riss.ToString();
                    }
                    else
                    {
                        Array.Resize(ref risultato, risultato.Length + 1);
                        risultato[risultato.Length - 1] = riss.ToString();
                    }
                }

                precedente = termine;
            }


            return string.Join(" ", risultato);
        }
        string sostituisci(string stringa, int numero, string cerca, string rimpiazza)
        {
            string[] test = stringa.Split(' ');
            int conto = 0;
            for (int i = 0; i < test.Length; i++)
            {
                if (test[i] == cerca)
                {
                    conto++;
                    if (conto == numero)
                    {
                        test[i] = rimpiazza;
                        return string.Join(" ", test);
                    }
                }
            }
            return stringa;
        }
        public string esp_numero_testo(string numero)
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
                            if (op.Substring(inizio, num_cifre - inizio) == ",")
                            {
                                Array.Resize(ref risultato, risultato.Length + 1);
                                risultato[risultato.Length - 1] = "virgola";
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

            return string.Join(" ", risultato);


        }
        public int prendi_Indice(string s, char t, int n)
        {
            int conta = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == t)
                {
                    conta++;
                    if (conta == n)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        public bool is_Numero(string numero, out long risultato)
        {
            risultato = Numeri.testo_a_cifra(numero);
            if (risultato >= 0)
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
            t_c = radioButtonTestoCifra.Checked;
            if (t_c)
            {
                textBoxParole.ReadOnly = false;
                textBoxNumeri.ReadOnly = true;
                textBoxParole.BackColor = Color.FromKnownColor(KnownColor.Control);
                textBoxParole.Focus();
            }
            else
            {
                textBoxParole.ReadOnly = true;
                textBoxNumeri.ReadOnly = false;
                textBoxNumeri.BackColor = Color.FromKnownColor(KnownColor.Control);
                textBoxNumeri.Focus();
            }
        }

        bool chiudiPanel = false;

        private void ToolStripButtonInfo_Click(object sender, EventArgs e)
        {
            Istruzioni ist = new Istruzioni();
            ist.Show();

        }

        /*    Point mousegiu;
            bool moving = false;
            public void mouse_down(object sender, MouseEventArgs e)
            {
                moving = true;
                mousegiu = e.Location;
            }
            public void mouse_move(object sender, MouseEventArgs e)
            {
                if (moving)
                {
                    Panel pannello = (Panel)sender;

                    pannello.Left = e.X + pannello.Left - mousegiu.X;
                    pannello.Top = e.Y + pannello.Top - mousegiu.Y;

                }
            }
            public void mouse_up(object sender, MouseEventArgs e)
            {
                moving = false;
            }

            public void ChiudiPanel(object sender, MouseEventArgs e, Panel pannello)
            {

                if (chiudiPanel)
                {
                    pannello.Hide();
                    ToolStripButtonInfo.Enabled = true;
                }

            }*/

        private void Form1_Load(object sender, EventArgs e)
        {
            Show();
            int x = 0;
            int y = 0;
            Size = new Size(0, 0);
            for (int i = 0; i < 832; i++)
            {

                Size = new Size(x, y);
                
               
                if (x < 831)
                {
                    x++;
                    if (y < 664)
                    {
                        y++;
                    }
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Impostazioni imp = new Impostazioni();
            imp.ShowDialog();
        }



        private void textBoxParole_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(null, null);
                textBoxRisultatoParole.BackColor = Color.LightGreen;
                textBoxRisultatoNumeri.BackColor = Color.LightGreen;
            }
            else
            {
                textBoxRisultatoParole.BackColor = Color.FromKnownColor(KnownColor.ControlLight);
                textBoxRisultatoNumeri.BackColor = Color.FromKnownColor(KnownColor.ControlLight);
            }
        }

        private void textBoxNumeri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(null, null);
                textBoxRisultatoParole.BackColor = Color.LightGreen;
                textBoxRisultatoNumeri.BackColor = Color.LightGreen;
            }
            else
            {
                textBoxRisultatoParole.BackColor = Color.FromKnownColor(KnownColor.ControlLight);
                textBoxRisultatoNumeri.BackColor = Color.FromKnownColor(KnownColor.ControlLight);
            }
        }

        private void richTextBoxX_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
