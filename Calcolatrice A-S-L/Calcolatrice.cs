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
                    if (Parser.EspressioneCorretta(test, false,out risultato))
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

                if(numero.Contains("x"))
                {
                    if (MessageBox.Show("L'espressione contine una incognita, visualizzarne il grafico posto y= epressione?", "Calcolatrice", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        bool yy = false;
                        if (numero.Contains("y"))
                            yy = true;
                        Grafico_Form.inizio(espressioni, deg, yy);
                        labelX.Text = "X= " + string.Join(" X= ", risultati_x.ToArray());
                    }
                }
                return;
               
            }
            double Risultato;
            if (Parser.EspressioneCorretta(numero, deg,out Risultato))
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
                        labelX.Text = "X= " + string.Join(" X= ", risultati_x.ToArray());
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
                    if (Parser.EspressioneCorretta(esp_testo_numero(test), false,out risultato))
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
                        labelX.Text = "X= " + string.Join(" X= ", risultati_x.ToArray());
                    }
                }
                return;

            }
            double Risultato;
           if (Parser.EspressioneCorretta(numero, deg,out Risultato))
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
                        labelX.Text = "X= " + string.Join(" X= ", risultati_x.ToArray());
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
            t_c = radioButtonTestoCifra.Checked;
            if (t_c)
            {
                textBoxParole.ReadOnly = false;
                textBoxNumeri.ReadOnly = true;
            }
            else
            {
                textBoxParole.ReadOnly = true;
                textBoxNumeri.ReadOnly = false;
            }
        }

        bool chiudiPanel = false;

        private void ToolStripButtonInfo_Click(object sender, EventArgs e)
        {
            Istruzioni ist = new Istruzioni();
            ist.Show();
           /* chiudiPanel = true;
            ToolStripButtonInfo.Enabled = false;

            int larghezza = 0;

            Button ButtonClose = new Button();
            Label labelIstruzioni = new Label();
            RichTextBox richTextBoxInfo = new RichTextBox();
            PictureBox pictureBoxSchermata = new PictureBox();

            Panel dynamicPanel = new Panel();
            dynamicPanel.Name = "dynamicPanel";
            dynamicPanel.BackColor = Color.LightGray;
            dynamicPanel.BorderStyle = BorderStyle.FixedSingle;
            dynamicPanel.Location = new System.Drawing.Point(100, 100);
            dynamicPanel.Size = new Size(600, 350);


            dynamicPanel.MouseDown += new MouseEventHandler(mouse_down);
            dynamicPanel.MouseUp += new MouseEventHandler(mouse_up);
            dynamicPanel.MouseMove += new MouseEventHandler(mouse_move);

            Controls.Add(dynamicPanel);


            ButtonClose.Name = "ButtonClose";
            ButtonClose.Text = "Chiudi";
            ButtonClose.Size = new Size(20, 20);

            larghezza = dynamicPanel.Size.Width - (ButtonClose.Size.Width);

            ButtonClose.Location = new System.Drawing.Point(larghezza, 0);
            ButtonClose.BackgroundImage = Properties.Resources.chiusura.ToBitmap();
            ButtonClose.BackgroundImageLayout = ImageLayout.Stretch;
            ButtonClose.BackColor = Color.White;
            ButtonClose.Text = "";

            labelIstruzioni.Name = "labelIstruzioni";
            labelIstruzioni.Text = "Istruzioni di utilizzo:";

            ;
            labelIstruzioni.Location = new System.Drawing.Point(20, 10);
            labelIstruzioni.Size = new Size(170, 20);
            labelIstruzioni.Font = new Font("Segoe Print", 10);

            richTextBoxInfo.ReadOnly = true;
            richTextBoxInfo.Name = "richTextBoxInfo";
            richTextBoxInfo.Text = "esempi / eccezioni / sintassi:" + "\n" +
                "200027 = duecentomilaventisettte (senza la 'e' tra duecentomila e ventisettte" + "\n" +
                "188 = centoottantotto (con 2 'o')" + "\n" +
                "numero^2 = numero alla due" + "\n" +
                "√numero = esponente radice di numero ( due radice di due ) " + "\n" +
                "6*(2+2) = numero per aperta parentesi numero piu numero chiusa parentesi" + "\n" +
                "6,2 = numero virgola numero" + "\n";
            richTextBoxInfo.Location = new System.Drawing.Point(20, 50);
            richTextBoxInfo.Size = new Size(500, 100);
            richTextBoxInfo.Font = new Font("Segoe Print", 10);

            pictureBoxSchermata.Size = new Size(380, 190);
            pictureBoxSchermata.Location = new System.Drawing.Point(20, 60 + richTextBoxInfo.Height);
            pictureBoxSchermata.BackgroundImage = Properties.Resources.schermata;
            pictureBoxSchermata.BackgroundImageLayout = ImageLayout.Stretch;

            dynamicPanel.BringToFront();
            dynamicPanel.Controls.Add(ButtonClose);
            dynamicPanel.Controls.Add(labelIstruzioni);
            dynamicPanel.Controls.Add(richTextBoxInfo);
            dynamicPanel.Controls.Add(pictureBoxSchermata);
            ButtonClose.MouseClick += new MouseEventHandler((o, s) => ChiudiPanel(o, s, dynamicPanel));*/
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

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
