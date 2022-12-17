using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Area_LIb
{
    public class Triangle : Figure
    {
        private double A
        {
            get
            {
                return A;
            }
            set
            {
                if (value > 0)
                   A = value;
                else
                    throw new ArgumentOutOfRangeException("value cannot be negative");
            }
        }
        private double B
        {
            get
            {
                return B;
            }
            set
            {
                if (value > 0)
                    B = value;
                else
                    throw new ArgumentOutOfRangeException("value cannot be negative");
            }
        }
        private double C
        {
            get
            {
                return C;
            }
            set
            {
                if (value > 0)
                    C = value;
                else
                    throw new ArgumentOutOfRangeException("value cannot be negative");
            }
        }

        public Triangle(double a, double b, double c) 
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                A = a;
                B = b;
                C = c;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Invalid value");
            }
        }

        public override double Area()
        {
            double Area = 0;

            double semi_perimeter = (A + B + C) / 2;
            Area = Math.Sqrt(semi_perimeter * (semi_perimeter - A) * (semi_perimeter - B) * (semi_perimeter - C)); //Heron's formula
            return (Area);
        }
        public bool Right_triangle_check()
        {

            if (A > B)
            {
                if (A > C)
                {

                }
                else
                {
                    /*С - наибольшее*/
                }
            }
            else
            {
                if (B > C)
                {

                }
                *B - наибольшее*/
             else
                {

                }/*С - наибольшее*/
                        }



        }
    }
}
