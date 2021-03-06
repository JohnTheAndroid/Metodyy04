using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodyy04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Mocnina(int zaklad, int exponent)
        {
            int mocnina = 1;
            for (int i = 0; i < exponent; ++i)
            {
                mocnina *= zaklad;
            }
            return mocnina;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int zaklad = int.Parse(textBox1.Text);
            int exponent = int.Parse(textBox2.Text);
            int vysledek_mocnina;
            vysledek_mocnina = Mocnina(zaklad, exponent);
            MessageBox.Show("Mocnina je: " + vysledek_mocnina);
        }
    }
}
