// programmed by Adrian Magdina in 2012
// in this file is the of default values for fractal configuration - it is used if no configuration xml is found
using System;
using System.Collections.Generic;
using System.Text;

namespace FractalObserverApplication
{
    //Default values that are loaded from xml from this application, if configuration xml is corrupt this values will be used (if agreed by the user).
    static public class DefaultFractalObserverConfiguration
    {
        static public RectangleInPlane CurrentRectangle
        {
            get
            {
                return new RectangleInPlane(-1.0, 1.0, -1.0, 1.0);
            }
        }

        static public RectangleInPlane ZoomRectangle
        {
            get
            {
                return new RectangleInPlane(-0.5, 0.5, -0.5, 0.5);
            }
        }

        static public RectangleInPlane PreviousRectangle
        {
            get
            {
                return new RectangleInPlane(-1.0, 1.0, -1.0, 1.0);
            }
        }

        static public FractalTypes FractalType
        {
            get
            {
                return FractalTypes.NewtonFractal;
            }
        }

        static public EquationTypes EquationType
        {
            get
            {
                IList<EquationTypes> aEquationType = FractalFactory.GetAvailableEquationTypesForFractalType(FractalType);
                if (aEquationType.Count > 0)
                {
                    return aEquationType[0];
                }
                else
                {
                    throw new FractalObserverException("No equation was found for fractal type in default configuration!");
                }
            }
        }

        static public FractalColorValue BackgroundColor
        {
            get
            {
                return new FractalColorValue(255, 255, 255, 255);
            }
        }

        static public FractalColorValue Color1
        {
            get
            {
                return new FractalColorValue(255, 244, 80, 0);
            }
        }

        static public FractalColorValue Color2
        {
            get
            {
                return new FractalColorValue(255, 0, 255, 0);
            }
        }

        static public FractalColorValue Color3
        {
            get
            {
                return new FractalColorValue(255, 125, 196, 30);
            }
        }

        static public FractalColorValue GridColor
        {
            get
            {
                return new FractalColorValue(255, 111, 111, 255);
            }
        }

        static public FractalColorValue ZoomRectangleColor
        {
            get
            {
                return new FractalColorValue(255, 0, 0, 255);
            }
        }

        static public double HorizontalSpacing
        {
            get
            {
                return 1.0;
            }
        }

        static public double VerticalSpacing
        {
            get
            {
                return 1.0;
            }
        }
    }
}
