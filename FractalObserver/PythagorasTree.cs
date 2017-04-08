// programmed by Adrian Magdina in 2012
// in this file is the implementation of fractal - Pythagoras Tree
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace FractalObserverApplication
{
    class PythagorasTree : IFractal
    {
        #region Constructors

        public PythagorasTree()
        {
            myFractalArea = new RectangleInPlane(-0.5, 0.0, 0.5, 1.0);
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

            PointInPlane[] aStartingRectanglePoints = new PointInPlane[4];
            aStartingRectanglePoints[0] = new PointInPlane(myFractalArea.MinX, myFractalArea.MaxY);
            aStartingRectanglePoints[1] = new PointInPlane(myFractalArea.MaxX, myFractalArea.MaxY);
            aStartingRectanglePoints[2] = new PointInPlane(myFractalArea.MaxX, myFractalArea.MinY);
            aStartingRectanglePoints[3] = new PointInPlane(myFractalArea.MinX, myFractalArea.MinY);

            const int aStartingIteration = 0;

            CreateSquare(aStartingRectanglePoints, fractalColorValuesIn, ref aComputedFractalValues, aStartingIteration);
            
            return aComputedFractalValues;
        }

        // recursive method - here are computed the squares of pythagoras tree
        private void CreateSquare(PointInPlane[] rectanglePointsIn, IList<FractalColorValue> fractalColorValuesIn/*, SquareOrientation squareOrientationIn*/, ref ComputedFractalValues cfvIn, int currentIterationIn)
        {
            if (rectanglePointsIn.Length < 4)
            {
                throw new FractalObserverException("The input parameter rectanglePointsIn in Methode CreateSquare must have at least four values (for each vertex one) !");
            }

            ComputedFractalValue aCFValue = new ComputedFractalValue();

            FractalColorValue aFractalColorValue = ReturnColor(currentIterationIn, fractalColorValuesIn);

            aCFValue.ColorValue = aFractalColorValue;
            aCFValue.TypeOfShape = TypesOfShape.Rectangle;
            aCFValue.UsedTypeOfCoordinateSystem = TypesOfCoordinateSystem.Plane;

            aCFValue.AddComputedPoint(rectanglePointsIn[0]);
            aCFValue.AddComputedPoint(rectanglePointsIn[1]);
            aCFValue.AddComputedPoint(rectanglePointsIn[2]);
            aCFValue.AddComputedPoint(rectanglePointsIn[3]);

            cfvIn.AddComputedFractalValue(aCFValue);

            if (currentIterationIn < MaximumNumberOfIterations)
            {
                double aScalingCoefficient = 1.0 / Math.Sqrt(2.0);
                double aRotationAngle = Math.PI / 4.0;

                { // right rectangle values computed
                    PointInPlane[] aNewRightRectangle = new PointInPlane[4];

                    PointInPlane aMovingVector = rectanglePointsIn[2] - rectanglePointsIn[1];

                    // scale to new rectangle
                    aNewRightRectangle[1] = rectanglePointsIn[1];
                    aNewRightRectangle[0] = PointInPlane.ScalePoint(rectanglePointsIn[1], rectanglePointsIn[0], aScalingCoefficient);
                    aNewRightRectangle[2] = PointInPlane.ScalePoint(rectanglePointsIn[1], rectanglePointsIn[2], aScalingCoefficient);
                    aNewRightRectangle[3] = PointInPlane.ScalePoint(rectanglePointsIn[1], rectanglePointsIn[3], aScalingCoefficient);

                    // rotate to new rectangle
                    aNewRightRectangle[0] = PointInPlane.RotatePoint(aNewRightRectangle[0], aNewRightRectangle[1], aRotationAngle);
                    aNewRightRectangle[1] = PointInPlane.RotatePoint(aNewRightRectangle[1], aNewRightRectangle[1], aRotationAngle);
                    aNewRightRectangle[2] = PointInPlane.RotatePoint(aNewRightRectangle[2], aNewRightRectangle[1], aRotationAngle);
                    aNewRightRectangle[3] = PointInPlane.RotatePoint(aNewRightRectangle[3], aNewRightRectangle[1], aRotationAngle);

                    // move to new rectangle position
                    aNewRightRectangle[0] = PointInPlane.MovePoint(aNewRightRectangle[0], aMovingVector);
                    aNewRightRectangle[1] = PointInPlane.MovePoint(aNewRightRectangle[1], aMovingVector);
                    aNewRightRectangle[2] = PointInPlane.MovePoint(aNewRightRectangle[2], aMovingVector);
                    aNewRightRectangle[3] = PointInPlane.MovePoint(aNewRightRectangle[3], aMovingVector);

                    CreateSquare(aNewRightRectangle, fractalColorValuesIn, ref cfvIn, currentIterationIn + 1);
                }

                { // left rectangle values computed
                    aRotationAngle = -Math.PI / 4.0;

                    PointInPlane[] aNewLeftRectangle = new PointInPlane[4];

                    PointInPlane aMovingVector = rectanglePointsIn[3] - rectanglePointsIn[0];

                    // scale to new rectangle
                    aNewLeftRectangle[0] = rectanglePointsIn[0];
                    aNewLeftRectangle[1] = PointInPlane.ScalePoint(rectanglePointsIn[0], rectanglePointsIn[1], aScalingCoefficient);
                    aNewLeftRectangle[2] = PointInPlane.ScalePoint(rectanglePointsIn[0], rectanglePointsIn[2], aScalingCoefficient);
                    aNewLeftRectangle[3] = PointInPlane.ScalePoint(rectanglePointsIn[0], rectanglePointsIn[3], aScalingCoefficient);

                    // rotate to new rectangle
                    aNewLeftRectangle[0] = PointInPlane.RotatePoint(aNewLeftRectangle[0], aNewLeftRectangle[0], aRotationAngle);
                    aNewLeftRectangle[1] = PointInPlane.RotatePoint(aNewLeftRectangle[1], aNewLeftRectangle[0], aRotationAngle);
                    aNewLeftRectangle[2] = PointInPlane.RotatePoint(aNewLeftRectangle[2], aNewLeftRectangle[0], aRotationAngle);
                    aNewLeftRectangle[3] = PointInPlane.RotatePoint(aNewLeftRectangle[3], aNewLeftRectangle[0], aRotationAngle);

                    // move to new rectangle position
                    aNewLeftRectangle[0] = PointInPlane.MovePoint(aNewLeftRectangle[0], aMovingVector);
                    aNewLeftRectangle[1] = PointInPlane.MovePoint(aNewLeftRectangle[1], aMovingVector);
                    aNewLeftRectangle[2] = PointInPlane.MovePoint(aNewLeftRectangle[2], aMovingVector);
                    aNewLeftRectangle[3] = PointInPlane.MovePoint(aNewLeftRectangle[3], aMovingVector);

                    CreateSquare(aNewLeftRectangle, fractalColorValuesIn, ref cfvIn, currentIterationIn + 1);
                }
            }
        }

        private FractalColorValue ReturnColor(int iterationIn, IList<FractalColorValue> fractalColorValuesIn)
        {
            FractalColorValue aFractalColorValue;

            aFractalColorValue = ColorInterpolation.InterpolateColor(iterationIn, 0, MaximumNumberOfIterations, fractalColorValuesIn[1], fractalColorValuesIn[2]);

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

        #endregion

        #region Members

        private const int myMaximumNumberOfIterations = 14;
        private const int myNumberOfColorUsed = 3;
        private readonly RectangleInPlane myFractalArea = null;
        #endregion
    }
}
