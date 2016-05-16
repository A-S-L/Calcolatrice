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
    public partial class Impostazioni : Form
    {
        public Impostazioni()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.x =double.Parse( numericUpDown1.Value.ToString());
            Properties.Settings.Default.y = double.Parse(numericUpDown2.Value.ToString());
            Properties.Settings.Default.precisione = float.Parse(numericUpDown3.Value.ToString());
            Properties.Settings.Default.decimali = int.Parse(numericUpDown4.Value.ToString());
            Properties.Settings.Default.Save();
            Close();
        }

        private void Impostazioni_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value =decimal.Parse( Properties.Settings.Default.x.ToString());
          numericUpDown2.Value  = decimal.Parse(Properties.Settings.Default.y.ToString());
          numericUpDown3.Value   = decimal.Parse(Properties.Settings.Default.precisione.ToString());
         numericUpDown4.Value   = decimal.Parse(Properties.Settings.Default.decimali.ToString());
        }

       
    }
}
