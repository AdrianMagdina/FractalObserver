// programmed by Adrian Magdina in 2012
// in this file is the implementation of fractal - Mandelbrot set
using System;
using System.Collections.Generic;
using System.Text;

namespace FractalObserverApplication
{
    class MandelbrotSet : IFractal
    {
        #region Constructors

        public MandelbrotSet()
        {
            myZValues = new ComplexNumber[MaximumNumberOfIterations];

            for (int i = 0; i < MaximumNumberOfIterations; i++)
            {
                myZValues[i] = new ComplexNumber();
            }
        }

        public MandelbrotSet(IEquation equationIn)
            : this()
        {
            myEquation = equationIn;
        }

        #endregion

        #region Methods

        public ComputedFractalValues ReturnComputedFractalValues(RectangleInPlane fractalRectangleIn, int xMaxIn, int yMaxIn, IList<FractalColorValue> fractalColorValuesIn, System.Windows.Forms.ProgressBar fractalProgressIn)
        {
            if (fractalColorValuesIn.Count < NumberOfColorUsed)
            {
                throw new FractalObserverException("Fractal PythagorasTree needs more colors that are available in the input parameter fractalColorValuesIn!");
            }

            ComputedFractalValues aComputedFractalValuesValues = new ComputedFractalValues();

            for (int aCurrentYPos = 0; aCurrentYPos < yMaxIn; aCurrentYPos++)
            {
                fractalProgressIn.Value = (int)(100.0 * ((double)aCurrentYPos / (double)yMaxIn));

                for (int aCurrentXPos = 0; aCurrentXPos < xMaxIn; aCurrentXPos++)
                {
                    int tempValue = 0;

                    ComplexNumber c = new ComplexNumber();

                    c.Re = fractalRectangleIn.StartX + Math.Abs(fractalRectangleIn.StartX - fractalRectangleIn.EndX) * ((double)aCurrentXPos / (double)xMaxIn);
                    c.Im = fractalRectangleIn.StartY + Math.Abs(fractalRectangleIn.StartY - fractalRectangleIn.EndY) * ((double)aCurrentYPos / (double)yMaxIn);

                    int n = 0;

                    myZValues[n].Re = 0.0;
                    myZValues[n].Im = 0.0;

                    // computation of value for function z2+c, if it converges (if it is bounded) the point is part of mandelbrot set
                    do
                    {
                        n++;

                        myZValues[n] = ComplexOperations.Add(Equation.ComplexFunctionValue(myZValues[n - 1]), c);

                    } while (((Math.Abs(myZValues[n].Re) < myMaximumValueForConvergation) && (Math.Abs(myZValues[n].Im) < myMaximumValueForConvergation)) && (n < (MaximumNumberOfIterations - 1)));

                    tempValue = n;

                    ComputedFractalValue aCFValue = new ComputedFractalValue();

                    FractalColorValue aFractalColorValue = ReturnColor(tempValue, fractalColorValuesIn);
                    aCFValue.ColorValue = aFractalColorValue;
                    aCFValue.AddComputedPoint(new System.Drawing.Point(aCurrentXPos, aCurrentYPos));
                    aCFValue.TypeOfShape = TypesOfShape.Point;
                    aCFValue.UsedTypeOfCoordinateSystem = TypesOfCoordinateSystem.Screen;

                    aComputedFractalValuesValues.AddComputedFractalValue(aCFValue);
                }
            }

            return aComputedFractalValuesValues;
        }

        private FractalColorValue ReturnColor(int valueIn, IList<FractalColorValue> fractalColorValuesIn)
        {
            FractalColorValue aFractalColorValue;

            aFractalColorValue = ColorInterpolation.InterpolateColor(valueIn, 0, MaximumNumberOfIterations, fractalColorValuesIn[0], fractalColorValuesIn[1]);
            return aFractalColorValue;
        }

        #endregion

        #region Properties

        public int MaximumNumberOfIterations
        {
            get
            {
                return myMaximumNumberOfIterations;
            }
        }

        public int NumberOfColorUsed
        {
            get
            {
                return myNumberOfColorUsed;
            }
        }

        public IEquation Equation
        {
            get
            {
                return myEquation;
            }
            set
            {
                myEquation = value;
            }
        }

        #endregion

        #region Members

         private ComplexNumber[] myZValues = null;

        private const double myMaximumValueForConvergation = 1000;
        private const int myMaximumNumberOfIterations = 64;
        private const int myNumberOfColorUsed = 2;

        private IEquation myEquation = null;

        #endregion
    }
}
