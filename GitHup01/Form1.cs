using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHup01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            double soucet = x + y;
            double rozdil = x - y;
            double soucin = x * y;
            double podil = x / y;
            MessageBox.Show("Soucet je Lmao " + soucet);
            MessageBox.Show("Rozdil " + rozdil);
            MessageBox.Show("Soucin " + soucin);
            MessageBox.Show("Podil " + podil);



        }
    }
}
