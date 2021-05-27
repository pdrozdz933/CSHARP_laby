using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trojkat
{
    class Class1
    {
        private double a;

        public double A
        {
            get => a;
            set
            {
                if (value < 0)
                    throw new ArgumentException("wartość nie może być ujemna");

                a = value;
            }
        }

        private double b;
        public double B
        {
            get => b;
            set
            {
                if (value < 0)
                    throw new ArgumentException("wartość nie może być ujemna");

                b = value;
            }
        }

        private double c;

        public double C
        {
            get => c;
            set
            {
                if (value < 0)
                    throw new ArgumentException("wartość nie może być ujemna");

                c = value;
            }
        }


    }
}
