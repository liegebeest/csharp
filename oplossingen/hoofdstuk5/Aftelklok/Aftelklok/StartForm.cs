using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aftelklok
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void minuutAftellenButton_Click(object sender, EventArgs e)
        {
            AftelklokForm formulier = new AftelklokForm(1, 0);
            formulier.Show();
        }

        private void vijfMinutenAftellenButton_Click(object sender, EventArgs e)
        {
            AftelklokForm formulier = new AftelklokForm(5, 0);
            formulier.Show();
        }

        private void aftellenButton_Click(object sender, EventArgs e)
        {
            int minuten = (int) minutenNumericUpDown.Value;
            int seconden = (int)secondenNumericUpDown.Value;

            AftelklokForm formulier = new AftelklokForm(minuten, seconden);
            formulier.Show();
        }
    }
}
