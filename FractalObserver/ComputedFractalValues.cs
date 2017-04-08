// programmed by Adrian Magdina in 2012
// in this file is the implementation of output values of fractal computation
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace FractalObserverApplication
{
    public enum TypesOfShape
    {
        None,
        Point,
        Lines,
        Rectangle
    }

    public enum TypesOfCoordinateSystem
    {
        Screen,
        Plane
    }

    // in the following two classes are stored the computed fractal output values
    public class ComputedFractalValue
    {
        public ComputedFractalValue()
        {
            myFractalColorValue = new FractalColorValue(0, 0, 0, 0);
            myListOfScreenPositions = new List<Point>();
            myListOfPlanePositions = new List<PointInPlane>();
            myTypeOfShape = TypesOfShape.None;
        }

        public void AddComputedPoint(PointInPlane pointIn)
        {
            myListOfPlanePositions.Add(pointIn);
        }

        public void AddComputedPoint(Point pointIn)
        {
            myListOfScreenPositions.Add(pointIn);
        }

        public IList<Point> GetComputedScreenPoints()
        {
            return myListOfScreenPositions;
        }

        public IList<PointInPlane> GetComputedPlanePoints()
        {
            return myListOfPlanePositions;
        }

        public FractalColorValue ColorValue
        {
            get
            {
                return myFractalColorValue;
            }
            set
            {
                myFractalColorValue = value;
            }
        }

        public TypesOfShape TypeOfShape
        {
            get
            {
                return myTypeOfShape;
            }
            set
            {
                myTypeOfShape = value;
            }
        }

        public TypesOfCoordinateSystem UsedTypeOfCoordinateSystem
        {
            get
            {
                return myUsedTypeOfCoordinateSystem;
            }
            set
            {
                myUsedTypeOfCoordinateSystem = value;
            }
        }

        private FractalColorValue myFractalColorValue;
        private List<Point> myListOfScreenPositions = null;
        private List<PointInPlane> myListOfPlanePositions = null;
        private TypesOfShape myTypeOfShape;
        private TypesOfCoordinateSystem myUsedTypeOfCoordinateSystem;
    }

    public class ComputedFractalValues
    {
        #region Constructors

        public ComputedFractalValues()
        {
            myComputedFractalValues = new List<ComputedFractalValue>();
        }

        #endregion

        #region Methods

        public IList<ComputedFractalValue> GetComputedFractalValues()
        {
            return myComputedFractalValues;
        }

        public void AddComputedFractalValue(ComputedFractalValue cfvIn)
        {
            myComputedFractalValues.Add(cfvIn);
        }

        public bool IsPixelData()
        {
            bool aIsPixelData = false;
            bool aIsVectorData = false;

            foreach (ComputedFractalValue tempCFValue in myComputedFractalValues)
            {
                if (tempCFValue.TypeOfShape == TypesOfShape.Point)
                {
                    aIsPixelData = true;
                }

                if (tempCFValue.TypeOfShape != TypesOfShape.Point)
                {
                    aIsVectorData = true;
                }
            }

            if (aIsPixelData == true && aIsVectorData == true)
            {
                throw new FractalObserverException("In the computed values list are both pixel and vector data. This is not permitted!");
            }

            return aIsPixelData;
        }

        public bool IsVectorData()
        {
            return !IsPixelData();
        }

        #endregion

        #region Properties

        public bool ShallFillInterior
        {
            get
            {
                return myShallFillInterior;
            }
            set
            {
                myShallFillInterior = value;
            }
        }

        #endregion

        #region Members

        private IList<ComputedFractalValue> myComputedFractalValues = null;
        private bool myShallFillInterior = false;

        #endregion
    }
}

