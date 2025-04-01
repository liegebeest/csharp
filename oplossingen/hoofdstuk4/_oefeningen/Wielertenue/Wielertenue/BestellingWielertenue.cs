using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wielertenue
{
    class BestellingWielertenue
    {
        private int _aantal;  // hoeveel stuks bestel je
        private bool _waterdichtZakje;  // is er in het truitje een waterdicht GSM-opbergzakje voorzien
        private bool _broek;  // neem je ook de wielerbroek (of anders enkel het wielertruitje)
        private bool _superZeem; // is de wielerbroek voorzien van een zeem met hogere kwaliteit

        public BestellingWielertenue(int aantal, bool waterdichtZakje, bool broek, bool superZeem)
        {
            _aantal = aantal;
            _waterdichtZakje = waterdichtZakje;
            _broek = broek;
            _superZeem = superZeem;
        }

        public int Aantal
        {
            get { return _aantal; }
            set { _aantal = value; }
        }

        public bool WaterdichtZakje
        {
            get { return _waterdichtZakje; }
            set { _waterdichtZakje = value; }
        }

        public bool Broek
        {
            get { return _broek; }
            set { _broek = value; }
        }

        public bool SuperZeem
        {
            get { return _superZeem; }
            set { _superZeem = value; }
        }

        public decimal GeefPrijs()
        {
            decimal basisprijs = (decimal) 45.0; // prijs voor een truitje
            decimal totaalprijs;

            if (_waterdichtZakje == true)
            {
                basisprijs += (decimal) 3.50;  // prijs voor zakje in truitje bijtellen
            }

            if (_broek == true)
            {
                basisprijs += (decimal) 35.0;  // prijs van broek bijtellen

                if (_superZeem == true)
                {
                    basisprijs += (decimal) 5.50;  // prijs voor superzeem bijtellen
                }
            }

            totaalprijs = basisprijs * _aantal;

            if (_aantal >= 5)
            {
                totaalprijs = totaalprijs * (decimal) 0.9;
            }

            return totaalprijs;
        }

    }
}
