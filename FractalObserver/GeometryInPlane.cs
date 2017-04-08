// programmed by Adrian Magdina in 2012
// in this file is the implementation of objects in plane - point, line, grid
using System;
using System.Collections.Generic;
using System.Text;

namespace FractalObserverApplication
{
    public struct PointInPlane
    {
        #region Constructors

        public PointInPlane(double xIn, double yIn)
        {
            x = xIn;
            y = yIn;
        }

        #endregion

        #region Methods

        public static PointInPlane operator +(PointInPlane firstIn, PointInPlane secondIn)
        {
            PointInPlane aPointInPlane = new PointInPlane(firstIn.x + secondIn.x, firstIn.y + secondIn.y);
            return aPointInPlane;
        }

        public static PointInPlane operator -(PointInPlane firstIn, PointInPlane secondIn)
        {
            PointInPlane aPointInPlane = new PointInPlane(firstIn.x - secondIn.x, firstIn.y - secondIn.y);
            return aPointInPlane;
        }

        public static PointInPlane RotatePoint(PointInPlane pointToRotateIn, PointInPlane rotationCenterIn, double rotationAngleIn)
        {
            PointInPlane aRotatedPoint = new PointInPlane();

            aRotatedPoint.x = rotationCenterIn.x + (pointToRotateIn.x - rotationCenterIn.x) * Math.Cos(rotationAngleIn) - (pointToRotateIn.y - rotationCenterIn.y) * Math.Sin(rotationAngleIn);
            aRotatedPoint.y = rotationCenterIn.y + (pointToRotateIn.x - rotationCenterIn.x) * Math.Sin(rotationAngleIn) + (pointToRotateIn.y - rotationCenterIn.y) * Math.Cos(rotationAngleIn);

            return aRotatedPoint;
        }

        public static PointInPlane MovePoint(PointInPlane pointToMoveIn, PointInPlane moveVectorIn)
        {
            PointInPlane aMovedPoint = new PointInPlane();

            aMovedPoint = pointToMoveIn + moveVectorIn;

            return aMovedPoint;
        }

        public static PointInPlane ScalePoint(PointInPlane startPointIn, PointInPlane endPointIn, double scalingIn)
        {
            PointInPlane aNewEndPoint = new PointInPlane();

            aNewEndPoint.x = startPointIn.x + (endPointIn.x - startPointIn.x) * scalingIn;
            aNewEndPoint.y = startPointIn.y + (endPointIn.y - startPointIn.y) * scalingIn;

            return aNewEndPoint;
        }

        #endregion

        #region Members

        public double x;
        public double y;

        #endregion
    }

    public struct LineInPlane
    {
        public LineInPlane(PointInPlane beginIn, PointInPlane endIn)
        {
            begin = beginIn;
            end = endIn;
        }

        public PointInPlane begin;
        public PointInPlane end;
    }

    public class GridInPlane : IGeometryInPlane
    {
        #region Constructors

        private GridInPlane()
        {
        }

        public GridInPlane(RectangleInPlane gridRectangleIn, double xSpacingIn, double ySpacingIn)
        {
            GridRectangle = gridRectangleIn;
            XSpacing = xSpacingIn;
            YSpacing = ySpacingIn;
        }

        #endregion

        #region Methods

        public IList<LineInPlane> ReturnListOfInPlaneLines()
        {
            List<LineInPlane> tempLinesInPlane = new List<LineInPlane>();

            double xValue = GridRectangle.MinX;
            double yValue = GridRectangle.MinY;

            do
            {
                xValue += XSpacing;
                yValue += YSpacing;

                if (xValue <= GridRectangle.MaxX)
                {
                    tempLinesInPlane.Add(new LineInPlane(new PointInPlane(xValue, GridRectangle.MinY), new PointInPlane(xValue, GridRectangle.MaxY)));
                }


                if (yValue <= GridRectangle.MaxY)
                {
                    tempLinesInPlane.Add(new LineInPlane(new PointInPlane(GridRectangle.MinX, yValue), new PointInPlane(GridRectangle.MaxX, yValue)));
                }

            } while (xValue <= GridRectangle.MaxX || yValue <= GridRectangle.MaxY);

            return tempLinesInPlane;
        }

        #endregion

        #region Properties

        RectangleInPlane GridRectangle
        {
            get
            {
                return myGridRectangle;
            }
            set
            {
                myGridRectangle = value;
            }
        }

        public double XSpacing
        {
            get
            {
                return myXSpacing;
            }
            set
            {
                myXSpacing = value;
            }
        }

        public double YSpacing
        {
            get
            {
                return myYSpacing;
            }
            set
            {
                myYSpacing = value;
            }
        }

        #endregion

        #region Members

        private double myXSpacing = 0.0;
        private double myYSpacing = 0.0;
        RectangleInPlane myGridRectangle = null;

        #endregion
    }
}
