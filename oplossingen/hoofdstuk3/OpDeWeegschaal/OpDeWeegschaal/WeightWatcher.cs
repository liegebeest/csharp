using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpDeWeegschaal
{
    public class WeightWatcher
    {
        private int _gewicht;
        private double _grootte;

        public WeightWatcher(int gewicht, double grootte)
        {
            _gewicht = gewicht;
            _grootte = grootte;
        }

        public double Grootte
        {
            get { return _grootte; }
        }

        public int Gewicht
        {
            get { return _gewicht; }
            set { _gewicht = value; }
        }

        public double GeefBmi()
        {
            return _gewicht / (_grootte * _grootte);
        }

        public String GeefStatus()
        {
            double bmi = GeefBmi();
            String status = "";

            if (bmi > 30)
            {
                status = "obees";
            }
            else if (bmi > 25)
            {
                status = "overgewicht";
            }
            else if (bmi >= 20)
            {
                status = "ok";
            }
            else
            {
                status = "ondergewicht";
            }

            return status;
        }

    }
}
