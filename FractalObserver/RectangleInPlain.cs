// programmed by Adrian Magdina in 2012
// in this file is the implementation of rectangle in plane coordinates
using System;
using System.Collections.Generic;

namespace FractalObserverApplication
{
    sealed public class RectangleInPlane : IGeometryInPlane
    {
        #region Constructors

        public RectangleInPlane()
        {
        }

        public RectangleInPlane(double startXIn, double endXIn, double startYIn, double endYIn)
        {
            StartPoint = new PointInPlane(startXIn, startYIn);
            EndPoint = new PointInPlane(endXIn, endYIn);
        }

        public RectangleInPlane(PointInPlane startPointIn, PointInPlane endPointIn)
        {
            StartPoint = startPointIn;
            EndPoint = endPointIn;
        }

        #endregion

        #region Methods

        public RectangleInPlane ShallowCopy()
        {
            return (RectangleInPlane)this.MemberwiseClone();
        }

        public IList<PointInPlane> ReturnRectangleInPlanePoints()
        {
            List<PointInPlane> tempListOfPoints = new List<PointInPlane>();

            tempListOfPoints.Add(new PointInPlane(StartPoint.x, StartPoint.y));
            tempListOfPoints.Add(new PointInPlane(StartPoint.x, EndPoint.y));
            tempListOfPoints.Add(new PointInPlane(EndPoint.x, EndPoint.y));
            tempListOfPoints.Add(new PointInPlane(EndPoint.x, StartPoint.y));

            return tempListOfPoints;
        }

        public void ResizeRectangle(double multiplyIn)
        {
            double aNewWidthDiferrence = Width * multiplyIn - Width;
            double aNewHeightDifference = Height * multiplyIn - Height;

            MinX -= aNewWidthDiferrence / 2.0;
            MinY -= aNewHeightDifference / 2.0;

            MaxX += aNewWidthDiferrence / 2.0;
            MaxY += aNewHeightDifference / 2.0;
        }

        public IList<LineInPlane> ReturnListOfInPlaneLines()
        {
            List<LineInPlane> aListOfInPlaneLines = new List<LineInPlane>();

            PointInPlane tempPointXStartYStart = StartPoint;
            PointInPlane tempPointXStartYEnd = new PointInPlane(StartPoint.x, EndPoint.y);
            PointInPlane tempPointXEndYStart = new PointInPlane(EndPoint.x, StartPoint.y);
            PointInPlane tempPointXEndYEnd = EndPoint;

            aListOfInPlaneLines.Add(new LineInPlane(tempPointXStartYStart, tempPointXStartYEnd));
            aListOfInPlaneLines.Add(new LineInPlane(tempPointXStartYEnd, tempPointXEndYEnd));
            aListOfInPlaneLines.Add(new LineInPlane(tempPointXEndYEnd, tempPointXEndYStart));
            aListOfInPlaneLines.Add(new LineInPlane(tempPointXEndYStart, tempPointXStartYStart));

            return aListOfInPlaneLines;
        }

        #endregion

        #region Properties

        public PointInPlane StartPoint
        {
            get
            {
                return myStartPoint;
            }
            set
            {
                myStartPoint = value;
            }
        }

        public PointInPlane EndPoint
        {
            get
            {
                return myEndPoint;
            }
            set
            {
                myEndPoint = value;
            }
        }

        public double StartX
        {
            get
            {
                return StartPoint.x;
            }
            set
            {
                myStartPoint.x = value;
            }
        }

        public double EndX
        {
            get
            {
                return EndPoint.x;
            }
            set
            {
                myEndPoint.x = value;
            }
        }

        public double StartY
        {
            get
            {
                return StartPoint.y;
            }
            set
            {
                myStartPoint.y = value;
            }
        }

        public double EndY
        {
            get
            {
                return EndPoint.y;
            }
            set
            {
                myEndPoint.y = value;
            }
        }

        public double Width
        {
            get
            {
                return Math.Abs(EndX - StartX);
            }
        }

        public double Height
        {
            get
            {
                return Math.Abs(EndY - StartY);
            }
        }

        public double MinX
        {
            get
            {
                return Math.Min(StartX, EndX);
            }
            set
            {
                if (StartX > EndX)
                {
                    EndX = value;
                }
                else
                {
                    StartX = value;
                }
            }
        }

        public double MaxX
        {
            get
            {
                return Math.Max(StartX, EndX);
            }
            set
            {
                if (StartX > EndX)
                {
                    StartX = value;
                }
                else
                {
                    EndX = value;
                }
            }
        }

        public double MinY
        {
            get
            {
                return Math.Min(StartY, EndY);
            }
            set
            {
                if (StartY > EndY)
                {
                    EndY = value;
                }
                else
                {
                    StartY = value;
                }
            }
        }

        public double MaxY
        {
            get
            {
                return Math.Max(StartY, EndY);
            }
            set
            {
                if (StartY > EndY)
                {
                    StartY = value;
                }
                else
                {
                    EndY = value;
                }
            }
        }

        #endregion

        #region Members

        private PointInPlane myStartPoint;
        private PointInPlane myEndPoint;

        #endregion
    }
}
