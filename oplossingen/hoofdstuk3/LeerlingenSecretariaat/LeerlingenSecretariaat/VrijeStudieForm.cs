using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeerlingenSecretariaat
{
    public partial class VrijeStudieForm : Form
    {
        private VrijeStudie _vrijeStudie;

        public VrijeStudieForm()
        {
            InitializeComponent();

            // veld _vrijeStudie initialiseren (vrije studie gaat door in lokaal KSZ, 40 plaatsen, 24 laptops)
            _vrijeStudie = new VrijeStudie("KSZ", 40, 24);

            // nodige informatie aan opvragen_vrijeStudie en weergeven in tekstvakken
            lokaalTextBox.Text = _vrijeStudie.Lokaal;
            capaciteitTextBox.Text = _vrijeStudie.Capaciteit.ToString();
            laptopsTextBox.Text = _vrijeStudie.Laptops.ToString();
            bezetTextBox.Text = _vrijeStudie.GereserveerdePlaatsen.ToString();
            laptopsGereserveerdTextBox.Text = _vrijeStudie.GereserveerdeLaptops.ToString();
        }

        private void inschrijvenButton_Click(object sender, EventArgs e)
        {
            String boodschap = "";
            
            // nagaan hoeveel leerlingen willen inschrijven
            int aantal = Convert.ToInt32(aantalInschrijvenTextBox.Text);
            // nagaan hoeveel laptops de leerlingen willen gebruiken
            int laptops = Convert.ToInt32(aantalLaptopsReserverenTextBox.Text);

            // object _vrijeStudie controleert of er nog plaats is voor deze leerlingen
            if (_vrijeStudie.IsErNogPlaats(aantal) == true && _vrijeStudie.ZijnErNogLaptops(laptops) == true)
            {
                // aantal bezette plaatsen bij _vrijeStudie bijwerken
                _vrijeStudie.GereserveerdePlaatsen += aantal;

                // aantal gereserveerde laptops bij _vrijeStudie bijwerken
                _vrijeStudie.GereserveerdeLaptops += laptops;

                // nodige tekstvakken updaten
                boodschapTextBox.Text = "Inschrijving geslaagd";
                bezetTextBox.Text = _vrijeStudie.GereserveerdePlaatsen.ToString();
                laptopsGereserveerdTextBox.Text = _vrijeStudie.GereserveerdeLaptops.ToString();
            }
            else
            {
                if (_vrijeStudie.IsErNogPlaats(aantal) == false)
                {
                    boodschap = "ONVOLDOENDE capaciteit in lokaal " + _vrijeStudie.Lokaal + "!  ";
                }

                if (_vrijeStudie.ZijnErNogLaptops(laptops) == false)
                {
                    boodschap += "ONVOLDOENDE laptops beschikbaar!";
                }

                // boodschap tonen in tekstvak
                boodschapTextBox.Text = boodschap;
            }

            // tekstvak met aantal in te schrijven leerlingen en aantal te reserveren laptops leegmaken
            aantalInschrijvenTextBox.Text = "";
            aantalLaptopsReserverenTextBox.Text = "";
        }
    }
}
