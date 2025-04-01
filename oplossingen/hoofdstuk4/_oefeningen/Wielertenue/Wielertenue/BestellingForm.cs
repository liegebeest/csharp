using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Wielertenue
{
    public partial class BestellingForm : Form
    {

        private BestellingWielertenue _bestelling;  // businessobject declareren


        public BestellingForm()
        {
            InitializeComponent();

            _bestelling = new BestellingWielertenue(1, false, false, false);  // business object initialiseren

            // prijs tonen
            prijsTextBox.Text = _bestelling.GeefPrijs().ToString("C"); 
        }


        private void aantalNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            // aantal stuks van de bestelling aanpassen
            _bestelling.Aantal = (int) aantalNumericUpDown.Value;

            // prijs vernieuwen
            prijsTextBox.Text = _bestelling.GeefPrijs().ToString("C");

        }


        private void waterdichtZakjeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // werd het selectievakje ingeschakeld?
            if (waterdichtZakjeCheckBox.Checked == true)
            {
                _bestelling.WaterdichtZakje = true;
            }
            else
            {
                _bestelling.WaterdichtZakje = false;
            }

            // prijs vernieuwen
            prijsTextBox.Text = _bestelling.GeefPrijs().ToString("C");
        }


        private void broekCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // werd het selectievakje 'broek' aangevinkt
            if (broekCheckBox.Checked == true)
            {
                // selectievakje superzeem zichtbaar maken
                superzeemCheckBox.Visible = true;
                //juiste afbeelding tonen
                wielertenuePictureBox.Visible = true;
                wielertruiPictureBox.Visible = false;

                // aangeven dat men bij de bestelling ook de wielerbroek wil
                _bestelling.Broek = true;
            }
            else
            {
                // selectievakje superzeem laten uitschakelen en verbergen
                superzeemCheckBox.Visible = false;
                superzeemCheckBox.Checked = false;
                // juiste afbeelding tonen
                wielertenuePictureBox.Visible = false;
                wielertruiPictureBox.Visible = true;
                
                // aangeven dat men bij de bestelling geen wielerbroek wil
                _bestelling.Broek = false;
                // aangeven dat men bij de bestelling geen superzeem wil (want geen broek)
                _bestelling.SuperZeem = false;
            }

            // prijs vernieuwen
            prijsTextBox.Text = _bestelling.GeefPrijs().ToString("C");
        }


        private void superzeemCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // werd het selectievakje superzeem aangevinkt?
            if (superzeemCheckBox.Checked == true)
            {
                _bestelling.SuperZeem = true;
            }
            else
            {
                _bestelling.SuperZeem = false;
            }

            // prijs vernieuwen
            prijsTextBox.Text = _bestelling.GeefPrijs().ToString("C");
        }

    }
}
