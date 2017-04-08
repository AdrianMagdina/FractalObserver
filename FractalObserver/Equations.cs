// programmed by Adrian Magdina in 2012
// in this file is the implementation of equations for complex fractals
using System;
using System.Collections.Generic;
using System.Text;

namespace FractalObserverApplication
{
    public class EquationZ2 : IEquation
    {
        // used in Mandelbrot set fractal
        public ComplexNumber ComplexFunctionValue(ComplexNumber z0In)
        {
            ComplexNumber z = null;

            z = ComplexOperations.Multiply(z0In, z0In);

            return z;
        }

        public ComplexNumber ComplexFunctionDerivativeValue(ComplexNumber z0In)
        {
            ComplexNumber z = null;

            z = ComplexOperations.Multiply(z0In, 2.0);

            return z;
        }

        public EquationTypes EquationType
        {
            get
            {
                return EquationTypes.z2;
            }
        }
    }

    public class EquationZ3Minus1 : IEquation
    {
        public ComplexNumber ComplexFunctionValue(ComplexNumber z0In)
        {
            ComplexNumber z = null;

            z = ComplexOperations.Multiply(z0In, z0In);
            z = ComplexOperations.Multiply(z, z0In);

            z.Re -= 1.0;

            return z;
        }

        public ComplexNumber ComplexFunctionDerivativeValue(ComplexNumber z0In)
        {
            ComplexNumber z = null;

            z = ComplexOperations.Multiply(z0In, z0In);
            z = ComplexOperations.Multiply(z, 3.0);

            return z;
        }

        public EquationTypes EquationType
        {
            get
            {
                return EquationTypes.z3Minus1;
            }
        }
    }

    public class EquationZ3MinusZ : IEquation
    {
        public ComplexNumber ComplexFunctionValue(ComplexNumber z0In)
        {
            ComplexNumber z = null;

            z = ComplexOperations.Multiply(z0In, z0In);
            z = ComplexOperations.Multiply(z, z0In);
            z = ComplexOperations.Substract(z, z0In);

            return z;
        }

        public ComplexNumber ComplexFunctionDerivativeValue(ComplexNumber z0In)
        {
            ComplexNumber z = null;

            z = ComplexOperations.Multiply(z0In, z0In);
            z = ComplexOperations.Multiply(z, 3.0);
            z.Re -= 1.0;

            return z;
        }

        public EquationTypes EquationType
        {
            get
            {
                return EquationTypes.z3Minus1;
            }
        }
    }

    public class EquationZPFZ3Minus05ZPF : IEquation
    {
        public ComplexNumber ComplexFunctionValue(ComplexNumber z0In)
        {
            ComplexNumber z = null;

            z = ComplexOperations.Multiply(z0In, z0In);
            z = ComplexOperations.Multiply(z, z0In);
            z = ComplexOperations.Multiply(z, 0.5);
            z.Re -= 0.5;

            return z;
        }

        public ComplexNumber ComplexFunctionDerivativeValue(ComplexNumber z0In)
        {
            ComplexNumber z = null;

            z = ComplexOperations.Multiply(z0In, z0In);
            z = ComplexOperations.Multiply(z, 3.0);

            return z;
        }

        public EquationTypes EquationType
        {
            get
            {
                return EquationTypes.z3Minus1;
            }
        }
    }

    public class EquationZ3Minus2zPlus2 : IEquation
    {
        public ComplexNumber ComplexFunctionValue(ComplexNumber z0In)
        {
            ComplexNumber z = null;

            z = ComplexOperations.Multiply(z0In, z0In);
            z = ComplexOperations.Multiply(z, z0In);

            ComplexNumber tempZ = ComplexOperations.Multiply(z0In, 2.0);

            z = ComplexOperations.Substract(z, tempZ);

            z.Re += 2.0;

            return z;
        }

        public ComplexNumber ComplexFunctionDerivativeValue(ComplexNumber z0In)
        {
            ComplexNumber z = null;

            z = ComplexOperations.Multiply(z0In, z0In);
            z = ComplexOperations.Multiply(z, 3.0);

            z.Re -= 2.0;

            return z;
        }

        public EquationTypes EquationType
        {
            get
            {
                return EquationTypes.z3Minus2zPlus2;
            }
        }
    }

    public class EquationZ2Minus1 : IEquation
    {
        public ComplexNumber ComplexFunctionValue(ComplexNumber z0In)
        {
            ComplexNumber z = null;

            z = ComplexOperations.Multiply(z0In, z0In);
            z.Re -= 1.0;

            return z;
        }

        public ComplexNumber ComplexFunctionDerivativeValue(ComplexNumber z0In)
        {
            ComplexNumber z = null;

            z = ComplexOperations.Multiply(z0In, 2.0);

            return z;
        }

        public EquationTypes EquationType
        {
            get
            {
                return EquationTypes.z2Minus1;
            }
        }
    }
}
