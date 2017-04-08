// programmed by Adrian Magdina in 2012
// in this file is the implementation of fractal - Koch snowflake
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace FractalObserverApplication
{
    class KochSnowflake : IFractal
    { 
        #region Constructors

        public KochSnowflake()
        {
            myFractalArea = new RectangleInPlane(-1.0, 1.0, -1.0, 1.0);
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
            aComputedFractalValues.ShallFillInterior = false;

            ComputedFractalValue aCFValue = new ComputedFractalValue();

            FractalColorValue aFractalColorValue = ReturnColor(fractalColorValuesIn);

            aCFValue.ColorValue = aFractalColorValue;
            aCFValue.TypeOfShape = TypesOfShape.Lines;
            aCFValue.UsedTypeOfCoordinateSystem = TypesOfCoordinateSystem.Plane;

            PointInPlane aStartingPoint = new PointInPlane(myFractalArea.MinX, myFractalArea.MaxY);
            PointInPlane aEndingPoint = new PointInPlane(myFractalArea.MaxX, myFractalArea.MaxY);

            const int aStartingIteration = 0;

            const double aAngle = Math.PI / 3.0; // angle of -60 degrees - equilateral triangle

            PointInPlane tempPointInPlane = RotateLine(aStartingPoint, aEndingPoint, aAngle);

            CreateNewCurveAndAddItToCFV(aEndingPoint, aStartingPoint, fractalColorValuesIn, ref aCFValue, aStartingIteration);

            CreateNewCurveAndAddItToCFV(aStartingPoint, tempPointInPlane, fractalColorValuesIn, ref aCFValue, aStartingIteration);

            CreateNewCurveAndAddItToCFV(tempPointInPlane, aEndingPoint, fractalColorValuesIn, ref aCFValue, aStartingIteration);

            aComputedFractalValues.AddComputedFractalValue(aCFValue);

            return aComputedFractalValues;
        }

        //help method for line rotation
        private PointInPlane RotateLine(PointInPlane startPointIn, PointInPlane endPointIn, double angleIn)
        {
            PointInPlane aPointInPlane = new PointInPlane();

            aPointInPlane.x = (endPointIn.x - startPointIn.x) * Math.Cos(angleIn) - (endPointIn.y - startPointIn.y) * Math.Sin(angleIn) + startPointIn.x; // calculation of x coordinate of rotated point (triangle vertex)
            aPointInPlane.y = (endPointIn.x - startPointIn.x) * Math.Sin(angleIn) + (endPointIn.y - startPointIn.y) * Math.Cos(angleIn) + startPointIn.y; // calculation of y coordinate of rotated point (triangle vertex)

            return aPointInPlane;
        }

        // recursive method - this method computes the points of snowflake
        private void CreateNewCurveAndAddItToCFV(PointInPlane startPointIn, PointInPlane endPointIn, IList<FractalColorValue> fractalColorValuesIn, ref ComputedFractalValue cfvIn, int currentIterationIn)
        {
            if ( currentIterationIn < (MaximumNumberOfIterations -1 ))
            {
                const double aAngle = Math.PI / 3.0; // angle of 60 degrees - equilateral triangle

                PointInPlane aOneThirdPoint = new PointInPlane(startPointIn.x + (endPointIn.x - startPointIn.x) / 3.0, startPointIn.y + (endPointIn.y - startPointIn.y) / 3.0);

                PointInPlane aTwoThirdPoint = new PointInPlane(startPointIn.x + (endPointIn.x - startPointIn.x) / 1.5, startPointIn.y + (endPointIn.y - startPointIn.y) / 1.5);

                PointInPlane aRotatedLinePoint = RotateLine(aOneThirdPoint, aTwoThirdPoint, aAngle);

                CreateNewCurveAndAddItToCFV(startPointIn, aOneThirdPoint, fractalColorValuesIn, ref cfvIn, currentIterationIn + 1);
                CreateNewCurveAndAddItToCFV(aOneThirdPoint, aRotatedLinePoint, fractalColorValuesIn, ref cfvIn, currentIterationIn + 1);
                CreateNewCurveAndAddItToCFV(aRotatedLinePoint, aTwoThirdPoint, fractalColorValuesIn, ref cfvIn, currentIterationIn + 1);
                CreateNewCurveAndAddItToCFV(aTwoThirdPoint, endPointIn, fractalColorValuesIn, ref cfvIn, currentIterationIn + 1);
            }
            else
            {
                cfvIn.AddComputedPoint(startPointIn);
                cfvIn.AddComputedPoint(endPointIn);
            }
        }

        private FractalColorValue ReturnColor(IList<FractalColorValue> fractalColorValuesIn)
        {
            FractalColorValue aFractalColorValue = fractalColorValuesIn[1];

            return aFractalColorValue;
        }

        #endregion

        #region Properties

        public  int MaximumNumberOfIterations
        {
            get
            {
                return myMaximumNumberOfIterations;
            }
        }

        public  int NumberOfColorUsed
        {
            get
            {
                return myNumberOfColorUsed;
            }
        }

        #endregion

        #region Members

        private const int myMaximumNumberOfIterations = 9;
        private const int myNumberOfColorUsed = 2;
        private readonly RectangleInPlane myFractalArea = null;
        #endregion
    }
}