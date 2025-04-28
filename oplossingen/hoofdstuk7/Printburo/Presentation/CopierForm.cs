using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace Presentation
{
    public partial class CopierForm : Form
    {
        private Copier _copier;

        public CopierForm()
        {
            InitializeComponent();

            _copier = new Copier();

            tellerTextBox.Text = _copier.Teller.ToString();
        }

        private void inWachtrijButton_Click(object sender, EventArgs e)
        {
            int paginas = (int) paginasNumericUpDown.Value;
            int kopies = (int)kopiesNumericUpDown.Value;

            _copier.VoegPrintopdrachtToe(paginas, kopies);

            wachtrijListBox.DataSource = null;
            wachtrijListBox.DataSource = _copier.Wachtrij;

        }

        private void printButton_Click(object sender, EventArgs e)
        {
            _copier.Print();

            tellerTextBox.Text = _copier.Teller.ToString();

            wachtrijListBox.DataSource = null;
            wachtrijListBox.DataSource = _copier.Wachtrij;
        }

        private void printVoorrangButton_Click(object sender, EventArgs e)
        {
            Printopdracht printopdracht = (Printopdracht) wachtrijListBox.SelectedItem;

            _copier.PrintMetVoorrang(printopdracht);

            tellerTextBox.Text = _copier.Teller.ToString();

            wachtrijListBox.DataSource = null;
            wachtrijListBox.DataSource = _copier.Wachtrij;
        }
    }
}
