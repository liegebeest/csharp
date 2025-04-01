using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectZonderNaam
{
    public class Naam
    {
        private String _voornaam;
        private String _familienaam;

        public Naam(String voornaam, String familienaam)
        {
            _voornaam = voornaam;
            _familienaam = familienaam;
        }

        public String Voornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }

        public String Familienaam
        {
            get { return _familienaam; }
            set { _familienaam = value; }
        }
        
        public String VolledigeNaam(bool formeel)
        {
            String naam;

            if (formeel == true)
            {
                naam = _familienaam + " " + _voornaam;
            }
            else
            {
                naam = _voornaam + " " + _familienaam;
             }

            return naam;
        }

        public String Initialen()
        {
            return _voornaam.Substring(0, 1) + "." + _familienaam.Substring(0, 1) + ".";
        }

        public String AlfaVoornaam()
        {
            return Alfa(_voornaam);
        }

        public String AlfaFamilienaam()
        {
            return Alfa(_familienaam);
        }

        private String Alfa(String tekst)
        {
            String hulp = tekst;

            hulp = hulp.Replace("-", "");
            hulp = hulp.Replace(" ", "");
            hulp = hulp.Replace("é", "e");
            hulp = hulp.Replace("è", "e");
            hulp = hulp.ToLower();

            return hulp;
        }
    }
}
