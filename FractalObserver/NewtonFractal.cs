// programmed by Adrian Magdina in 2012
// in this file is the implementation of fractal - Newton fractal
using System;
using System.Collections.Generic;
using System.Text;

namespace FractalObserverApplication
{
    public class NewtonFractal : IFractal
    {
        #region Constructors

        public NewtonFractal()
        {
            myZValues = new ComplexNumber[MaximumNumberOfIterations];
            myZRoots = new List<ComplexNumber>();

            for (int i = 0; i < MaximumNumberOfIterations; i++)
            {
                myZValues[i] = new ComplexNumber();
            }

            myEquation = null;
        }

        public NewtonFractal(IEquation equationIn)
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

            ComputedFractalValues aComputedFractalValues = new ComputedFractalValues();

            myZRoots.Clear();

            for (int aCurrentYPos = 0; aCurrentYPos < yMaxIn; aCurrentYPos++)
            {
                fractalProgressIn.Value = (int)(100.0 * ((double)aCurrentYPos / (double)yMaxIn));

                for (int aCurrentXPos = 0; aCurrentXPos < xMaxIn; aCurrentXPos++)
                {
                    int tempRoot = 0;
                    int tempValue = 0;

                    int n = 0;

                    // initial values
                    myZValues[n].Re = fractalRectangleIn.StartX + Math.Abs(fractalRectangleIn.StartX - fractalRectangleIn.EndX) * ((double)aCurrentXPos / (double)xMaxIn);
                    myZValues[n].Im = fractalRectangleIn.StartY + Math.Abs(fractalRectangleIn.StartY - fractalRectangleIn.EndY) * ((double)aCurrentYPos / (double)yMaxIn);

                    // computation of next values until the maximum iteration count or until the conditions are met
                    do
                    {
                        n++;
                        myZValues[n] = ComplexOperations.Substract(myZValues[n - 1], ComplexOperations.Divide(Equation.ComplexFunctionValue(myZValues[n - 1]), Equation.ComplexFunctionDerivativeValue(myZValues[n - 1])));

                    } while (((Math.Abs(myZValues[n].Re - myZValues[n - 1].Re) > myTreshold) || (Math.Abs(myZValues[n].Im - myZValues[n - 1].Im) > myTreshold)) && (n < (MaximumNumberOfIterations - 1)));

                    ComputedFractalValue aCFValue = null;
                    FractalColorValue aFractalColorValue;

                    // if the solution did not converge to root, then return zero values
                    if (n >= (MaximumNumberOfIterations - 1) || double.IsNaN(myZValues[n].Re) || double.IsNaN(myZValues[n].Im))
                    {
                        aCFValue = new ComputedFractalValue();

                        aFractalColorValue = ReturnColor(tempRoot, tempValue, fractalColorValuesIn);
                        aCFValue.ColorValue = aFractalColorValue;
                        aCFValue.AddComputedPoint(new System.Drawing.Point(aCurrentXPos, aCurrentYPos));
                        aCFValue.TypeOfShape = TypesOfShape.Point;
                        aCFValue.UsedTypeOfCoordinateSystem = TypesOfCoordinateSystem.Screen;

                        aComputedFractalValues.AddComputedFractalValue(aCFValue);

                        continue;
                    }

                    bool aNewRoot = true;
                    int aRootNumber = 0;

                    // find out if the root is new until now, or if the current root was found already
                    for (int i = 0; i < myZRoots.Count; i++)
                    {
                        if ((Math.Abs(myZRoots[i].Re - myZValues[n].Re) < myTreshold) && (Math.Abs(myZRoots[i].Im - myZValues[n].Im) < myTreshold))
                        {
                            aNewRoot = false;
                            aRootNumber = i;
                            break;
                        }
                    }

                    // if this root is new until now, add new item to myZRoots List
                    if (aNewRoot)
                    {
                        ComplexNumber aComplexRoot = new ComplexNumber();
                        aComplexRoot.Re = myZValues[n].Re;
                        aComplexRoot.Im = myZValues[n].Im;

                        myZRoots.Add(aComplexRoot);

                        aRootNumber = myZRoots.Count - 1;
                    }

                    // sets the computed values for this pixel to return structure and return it
                    tempValue = n;

                    if (aRootNumber == 0)
                    {
                        tempRoot = 1;
                    }
                    else if (aRootNumber == 1)
                    {
                        tempRoot = 2;
                    }
                    else if (aRootNumber == 2)
                    {
                        tempRoot = 3;
                    }
                    else
                    {
                        throw new FractalObserverException("Error occured during computation of fractal, wrong number of roots was found!");
                    }

                    // storing of output of computation
                    aCFValue = new ComputedFractalValue();

                    aFractalColorValue = ReturnColor(tempRoot, tempValue, fractalColorValuesIn);
                    aCFValue.ColorValue = aFractalColorValue;
                    aCFValue.AddComputedPoint(new System.Drawing.Point(aCurrentXPos, aCurrentYPos));
                    aCFValue.TypeOfShape = TypesOfShape.Point;
                    aCFValue.UsedTypeOfCoordinateSystem = TypesOfCoordinateSystem.Screen;

                    aComputedFractalValues.AddComputedFractalValue(aCFValue);
                }
            }

            return aComputedFractalValues;
        }

        private FractalColorValue ReturnColor(int rootIn, int valueIn, IList<FractalColorValue> fractalColorValuesIn)
        {
            FractalColorValue aFractalColorValue = new FractalColorValue();

            // choosing color appropriate to root found
            switch (rootIn)
            {
                case 0:
                    aFractalColorValue.red = fractalColorValuesIn[0].red;
                    aFractalColorValue.green = fractalColorValuesIn[0].green;
                    aFractalColorValue.blue = fractalColorValuesIn[0].blue;
                    aFractalColorValue.alpha = fractalColorValuesIn[0].alpha;
                    break;
                case 1:
                    aFractalColorValue.red = fractalColorValuesIn[1].red;
                    aFractalColorValue.green = fractalColorValuesIn[1].green;
                    aFractalColorValue.blue = fractalColorValuesIn[1].blue;
                    aFractalColorValue.alpha = fractalColorValuesIn[1].alpha;
                    break;
                case 2:
                    aFractalColorValue.red = fractalColorValuesIn[2].red;
                    aFractalColorValue.green = fractalColorValuesIn[2].green;
                    aFractalColorValue.blue = fractalColorValuesIn[2].blue;
                    aFractalColorValue.alpha = fractalColorValuesIn[2].alpha;
                    break;
                case 3:
                    aFractalColorValue.red = fractalColorValuesIn[3].red;
                    aFractalColorValue.green = fractalColorValuesIn[3].green;
                    aFractalColorValue.blue = fractalColorValuesIn[3].blue;
                    aFractalColorValue.alpha = fractalColorValuesIn[3].alpha;
                    break;
                default:
                    break;
            }

            // background color is used if too many (maximum) iterations are used to converge to root
            aFractalColorValue = ColorInterpolation.InterpolateColor(valueIn, 0, MaximumNumberOfIterations, aFractalColorValue, fractalColorValuesIn[0]);

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
        private List<ComplexNumber> myZRoots = null;

        private const int myMaximumNumberOfIterations = 50;

        private const int myNumberOfColorUsed = 4;

        private const double myTreshold = 0.0001;

        private IEquation myEquation = null;

        #endregion
    }
}
