using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Area_LIb
{
    public class Circle : Figure
    {
       
        private double Radius
        {
            get
            {
                return Radius;
            }
            set
            {
               if(value > 0)
                    Radius = value;
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            double Area = 0;

            Area = Math.PI * Math.Pow(Radius,2);

            return (Area);
        }
       
    }
}

