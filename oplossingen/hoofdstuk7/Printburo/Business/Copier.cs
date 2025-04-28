using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Copier
    {
        private int _teller;
        private List<Printopdracht> _wachtrij;

        public Copier()
        {
            _teller = 0;
            _wachtrij = new List<Printopdracht>();
        }
        
        public int Teller
        {
            get { return _teller; }
        }

        public List<Printopdracht> Wachtrij
        {
            get { return _wachtrij; }
        }

        // nog te programmeren ...
        // deze methode laat een nieuwe printopdracht op de wachtrij zetten
        // ----------------------------------------------------------------
        public void VoegPrintopdrachtToe(int aantalPaginas, int aantalExemplaren)
        {
            Printopdracht printopdracht = new Printopdracht(aantalPaginas, aantalExemplaren);
            _wachtrij.Add(printopdracht);
        }

        // nog te programmeren ...
        // deze methode laat de eerste printopdracht in de wachtrij verwerken
        // ------------------------------------------------------------------
        public void Print()
        {
            Printopdracht printopdracht;

            if (_wachtrij.Count > 0)
            {
                printopdracht = _wachtrij[0];
                _teller += printopdracht.PaginasOrigineel * printopdracht.AantalExemplaren;
                _wachtrij.RemoveAt(0);
            }
        }

        public void PrintMetVoorrang(Printopdracht printopdracht)
        {
            if (printopdracht != null)
            {
                _teller += printopdracht.PaginasOrigineel * printopdracht.AantalExemplaren;
                _wachtrij.Remove(printopdracht);
            }
        }
    }
}
