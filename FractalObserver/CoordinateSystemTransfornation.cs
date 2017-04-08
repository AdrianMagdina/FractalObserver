// programmed by Adrian Magdina in 2012
// in this file is the implementation of transformation of coordinate systems - screen and plane coordinates
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace FractalObserverApplication
{
    sealed public class ScreenPlaneCoordinatesTransfornation
    {
        #region Constructors

        private ScreenPlaneCoordinatesTransfornation()
        {
        }

        public ScreenPlaneCoordinatesTransfornation( int screenWidthIn, int screenHeightIn, RectangleInPlane viewRectangleIn)
        {
            ScreenWidth = screenWidthIn;
            ScreenHeight = screenHeightIn;
            ViewRectangle = viewRectangleIn;
        }
        #endregion

        #region Methods
        public PointInPlane GetPlaneCoordinates(int xIn, int yIn)
        {
            PointInPlane tempPointInPlane = new PointInPlane();

            tempPointInPlane.x = Math.Min(ViewRectangle.StartX, ViewRectangle.EndX) + (double)xIn * (Math.Abs(ViewRectangle.EndX - ViewRectangle.StartX) / (double)ScreenWidth);
            tempPointInPlane.y = Math.Min(ViewRectangle.StartY, ViewRectangle.EndY) + (double)yIn * (Math.Abs(ViewRectangle.EndY - ViewRectangle.StartY) / (double)ScreenHeight);

            return tempPointInPlane;
        }

        public Point GetScreenCoordinates(double xIn, double yIn)
        {
            Point tempPoint = new Point();
            if (xIn >= ViewRectangle.MinX && xIn <= ViewRectangle.MaxX)
            {
                tempPoint.X = (int)(Math.Abs(xIn - ViewRectangle.StartX) * ((double)ScreenWidth / Math.Abs(ViewRectangle.EndX - ViewRectangle.StartX)));
            }
            else if (xIn <= ViewRectangle.MinX)
            {
                tempPoint.X = -1;
            }
            else if (xIn >= ViewRectangle.MaxX)
            {
                tempPoint.X = ScreenWidth + 1;
            }

            if (yIn >= ViewRectangle.MinY && yIn <= ViewRectangle.MaxY)
            {
                tempPoint.Y = (int)(Math.Abs(yIn - ViewRectangle.StartY) * ((double)ScreenHeight / Math.Abs(ViewRectangle.EndY - ViewRectangle.StartY)));
            }
            else if (yIn <= ViewRectangle.MinY)
            {
                tempPoint.Y = -1;
            }
            else if (yIn >= ViewRectangle.MaxY)
            {
                tempPoint.Y = ScreenHeight + 1;
            }

            return tempPoint;
        }

        #endregion

        #region Properties

        public int ScreenWidth
        {
            get
            {
                return myScreenWidth;
            }
            set
            {
                myScreenWidth = value;
            }
        }

        public int ScreenHeight
        {
            get
            {
                return myScreenHeight;
            }
            set
            {
                myScreenHeight = value;
            }
        }

        public RectangleInPlane ViewRectangle
        {
            get
            {
                return myViewRectangle;
            }
            set
            {
                myViewRectangle = value;
            }
        }

        #endregion

        #region Members

        private int myScreenWidth = 0;
        private int myScreenHeight = 0;
        private RectangleInPlane myViewRectangle = null;

        #endregion
    }
}
