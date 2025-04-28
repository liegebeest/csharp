using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly
{
    public partial class BordForm : Form
    {
        public BordForm()
        {
            InitializeComponent();
        }

        private void vak23Button_Click(object sender, EventArgs e)
        {
            MonopolyStraat s = new MonopolyStraat("Kortrijksestraat", "Gent", 18, 90, 250, 700, 875, 1050);
            StraatForm formulier = new StraatForm(s, vak23Button.BackColor);
            formulier.Show();
        }

        private void vak29Button_Click(object sender, EventArgs e)
        {
            MonopolyStraat s = new MonopolyStraat("Veldstraat", "Gent", 22, 120, 360, 850, 1025, 1200);
            StraatForm formulier = new StraatForm(s,vak29Button.BackColor);
            formulier.Show();
        }

        private void vak32Button_Click(object sender, EventArgs e)
        {
            MonopolyStraat s = new MonopolyStraat("Vlaanderenstraat", "Gent", 26, 130, 390, 900, 1000, 1275);
            StraatForm formulier = new StraatForm(s, vak32Button.BackColor);
            formulier.Show();
        }
    }
}
