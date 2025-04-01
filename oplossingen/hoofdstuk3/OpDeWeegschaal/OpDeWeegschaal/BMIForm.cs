using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpDeWeegschaal
{
    public partial class BMIForm : Form
    {
       private WeightWatcher _weightWatcher;

        public BMIForm()
        {
            InitializeComponent();

            _weightWatcher = new WeightWatcher(84, 1.74);

            grootteTextBox.Text = _weightWatcher.Grootte.ToString("0.00");
            gewichtTextBox.Text = _weightWatcher.Gewicht.ToString();
            bmiTextBox.Text = _weightWatcher.GeefBmi().ToString("0.00");
            statusTextBox.Text = _weightWatcher.GeefStatus();
        }

        private void KiloErafButton_Click(object sender, EventArgs e)
        {
            _weightWatcher.Gewicht--;

            gewichtTextBox.Text = _weightWatcher.Gewicht.ToString();
            bmiTextBox.Text = _weightWatcher.GeefBmi().ToString("0.00");
            statusTextBox.Text = _weightWatcher.GeefStatus();
        }

        private void KiloErbijButton_Click(object sender, EventArgs e)
        {
            _weightWatcher.Gewicht++;

            gewichtTextBox.Text = _weightWatcher.Gewicht.ToString();
            bmiTextBox.Text = _weightWatcher.GeefBmi().ToString("0.00");
            statusTextBox.Text = _weightWatcher.GeefStatus();
        }
    }
}
