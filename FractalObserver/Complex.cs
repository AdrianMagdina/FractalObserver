// programmed by Adrian Magdina in 2012
// in this file is the implementation of complex numbers and operations with complex numbers
using System;
using System.Collections.Generic;
using System.Text;

namespace FractalObserverApplication
{
    public class ComplexNumber
    {
        public ComplexNumber()
        {
            Re = 0.0;
            Im = 0.0;
        }

        public double Re
        {
            get
            {
                return myRe;
            }
            set
            {
                myRe = value;
            }
        }

        public double Im
        {
            get
            {
                return myIm;
            }
            set
            {
                myIm = value;
            }
        }

        private double myRe;
        private double myIm;
    }

    public static class ComplexOperations
    {
        public static ComplexNumber Add(ComplexNumber z0, ComplexNumber z1)
        {
            ComplexNumber z = new ComplexNumber();

            z.Re = z0.Re + z1.Re;
            z.Im = z0.Im + z1.Im;

            return z;
        }

        public static ComplexNumber Substract(ComplexNumber z0, ComplexNumber z1)
        {
            ComplexNumber z = new ComplexNumber();

            z.Re = z0.Re - z1.Re;
            z.Im = z0.Im - z1.Im;

            return z;
        }

        public static ComplexNumber Multiply(ComplexNumber z0, ComplexNumber z1)
        {
            ComplexNumber z = new ComplexNumber();

            z.Re = (z0.Re * z1.Re - z0.Im * z1.Im);
            z.Im = (z0.Im * z1.Re + z0.Re * z1.Im);

            return z;
        }

        public static ComplexNumber Multiply(ComplexNumber z0, double c)
        {
            ComplexNumber z = new ComplexNumber();

            z.Re = c * z0.Re;
            z.Im = c * z0.Im;
            
            return z;
        }

        public static ComplexNumber Divide(ComplexNumber z0, ComplexNumber z1)
        {
            ComplexNumber z = new ComplexNumber();

            z.Re = (z0.Re * z1.Re + z0.Im * z1.Im) / (z1.Re * z1.Re + z1.Im * z1.Im);
            z.Im = (z0.Im * z1.Re - z0.Re * z1.Im) / (z1.Re * z1.Re + z1.Im * z1.Im);

            return z;
        }
    }
}
