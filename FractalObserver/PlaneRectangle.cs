using System;
using System.Collections.Generic;

namespace NewtonFractalApplication
{
    public class PlaneRectangle
    {

        public PlaneRectangle()
        {
            StartX = 0.0;
            EndX = 0.0;
            StartY = 0.0;
            EndY = 0.0;
        }

        public PlaneRectangle(double startXin, double endXin, double startYin, double endYin)
        {
            StartX = startXin;
            EndX = endXin;
            StartY = startYin;
            EndY = endYin;
        }

        public double StartX
        {
            get
            {
                return myStartX;
            }
            set
            {
                myStartX = value;
            }
        }

        public double EndX
        {
            get
            {
                return myEndX;
            }
            set
            {
                myEndX = value;
            }
        }

        public double StartY
        {
            get
            {
                return myStartY;
            }
            set
            {
                myStartY = value;
            }
        }

        public double EndY
        {
            get
            {
                return myEndY;
            }
            set
            {
                myEndY = value;
            }
        }

        private double myStartX;
        private double myEndX;
        private double myStartY;
        private double myEndY;
    }
}
