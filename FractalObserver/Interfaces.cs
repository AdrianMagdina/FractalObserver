// programmed by Adrian Magdina in 2012
// in this file are all interfaces used in this application
using System;
using System.Collections.Generic;
using System.Text;

namespace FractalObserverApplication
{
    public interface IGeometryInPlane
    {
        IList<LineInPlane> ReturnListOfInPlaneLines();
    }

    //common interface for all fractals
    public interface IFractal
    {
        ComputedFractalValues ReturnComputedFractalValues(RectangleInPlane fractalRectangleIn, int xMaxIn, int yMaxIn, IList<FractalColorValue> fractalColorValuesIn, System.Windows.Forms.ProgressBar fractalProgressIn);

        int MaximumNumberOfIterations
        {
            get;
        }

        int NumberOfColorUsed
        {
            get;
        }
    }

    public interface IFractalObserverConfiguration
    {
        void ReadFromFractalObserverConfigurationXml();
        void ReadFromFractalObserverConfigurationXml(string filePathIn);
        void WriteToFractalObserverConfigurationXml();
        void SetDefaultValues();

        RectangleInPlane CurrentRectangle
        {
            get;
            set;
        }

        RectangleInPlane ZoomRectangle
        {
            get;
            set;
        }

        RectangleInPlane PreviousRectangle
        {
            get;
            set;
        }

        int NumberOfIterations
        {
            get;
            set;
        }

        FractalTypes FractalType
        {
            get;
            set;
        }

        string FractalTypeString
        {
            get;
            set;
        }

        EquationTypes EquationType
        {
            get;
            set;
        }

        string EquationTypeString
        {
            get;
            set;
        }

        FractalColorValue BackgroundColor
        {
            get;
            set;
        }

        FractalColorValue Color1
        {
            get;
            set;
        }

        FractalColorValue Color2
        {
            get;
            set;
        }

        FractalColorValue Color3
        {
            get;
            set;
        }

        FractalColorValue GridColor
        {
            get;
            set;
        }

        FractalColorValue ZoomRectangleColor
        {
            get;
            set;
        }

        double HorizontalSpacing
        {
            get;
            set;
        }

        double VerticalSpacing
        {
            get;
            set;
        }
    }

    public interface IEquation
    {
        ComplexNumber ComplexFunctionValue(ComplexNumber z0In);
        ComplexNumber ComplexFunctionDerivativeValue(ComplexNumber z0In);

        EquationTypes EquationType
        {
            get;
        }
    }
}
