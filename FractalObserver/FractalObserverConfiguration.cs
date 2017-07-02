// programmed by Adrian Magdina in 2012
// in this file is the implementation of reading and writing and storing of values from configuration xml
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using System.Globalization;

namespace FractalObserverApplication
{
    public struct FractalColorValue
    {
        public FractalColorValue(int alphaIn, int redIn, int greenIn, int blueIn)
        {
            alpha = alphaIn;
            red = redIn;
            green = greenIn;
            blue = blueIn;
        }

        public int alpha;
        public int red;
        public int green;
        public int blue;
    }

    public class FractalObserverConfiguration : IFractalObserverConfiguration
    {
        #region enums

        private enum CurrentReadOperation
        {
            None,
            Current,
            Zoom,
            Previous,
        }

        #endregion

        #region Constructors

        public FractalObserverConfiguration()
        {
            CurrentRectangle = new RectangleInPlane();
            ZoomRectangle = new RectangleInPlane();
            PreviousRectangle = new RectangleInPlane();
        }

        #endregion

        #region Methods

        public void ReadFromFractalObserverConfigurationXml()
        {
            ReadFromFractalObserverConfigurationXml(@"./FractalObserverConfiguration.xml");
        }

        public void ReadFromFractalObserverConfigurationXml(string filePathIn)
        {
            XmlReader aXmlReader = null;
            CurrentReadOperation aCurrentReadOperation = CurrentReadOperation.None;

            try
            {
                aXmlReader = XmlReader.Create(filePathIn);

                while (aXmlReader.Read())
                {
                    if (aXmlReader.NodeType == XmlNodeType.Element)
                    {
                        switch (aXmlReader.Name)
                        {
                            case "FractalType":
                                {
                                    FractalTypeString = aXmlReader.ReadString();
                                }
                                break;

                            case "EquationType":
                                {
                                    EquationTypeString = aXmlReader.ReadString();
                                }
                                break;

                            case "Current":
                                {
                                    aCurrentReadOperation = CurrentReadOperation.Current;
                                }
                                break;

                            case "Zoom":
                                {
                                    aCurrentReadOperation = CurrentReadOperation.Zoom;
                                }
                                break;

                            case "Previous":
                                {
                                    aCurrentReadOperation = CurrentReadOperation.Previous;
                                }
                                break;

                            case "HorizontalSpacing":
                                {
                                    HorizontalSpacing = Convert.ToDouble(aXmlReader.ReadString(), CultureInfo.InvariantCulture);
                                }
                                break;

                            case "VerticalSpacing":
                                {
                                    VerticalSpacing = Convert.ToDouble(aXmlReader.ReadString(), CultureInfo.InvariantCulture);
                                }
                                break;

                            case "BackgroundColor":
                                {
                                    BackgroundColor = ReadColorFromConfigurationXml(aXmlReader, "BackgroundColor");
                                }
                                break;

                            case "Color1":
                                {
                                    Color1 = ReadColorFromConfigurationXml(aXmlReader, "Color1");
                                }
                                break;

                            case "Color2":
                                {
                                    Color2 = ReadColorFromConfigurationXml(aXmlReader, "Color2");
                                }
                                break;

                            case "Color3":
                                {
                                    Color3 = ReadColorFromConfigurationXml(aXmlReader, "Color3");
                                }
                                break;

                            case "GridColor":
                                {
                                    GridColor = ReadColorFromConfigurationXml(aXmlReader, "GridColor");
                                }
                                break;

                            case "ZoomRectangleColor":
                                {
                                    ZoomRectangleColor = ReadColorFromConfigurationXml(aXmlReader, "ZoomRectangleColor");
                                }
                                break;

                            case "StartX":
                                {
                                    if (aCurrentReadOperation == CurrentReadOperation.Current)
                                    {
                                        CurrentRectangle.StartX = Convert.ToDouble(aXmlReader.ReadString(), CultureInfo.InvariantCulture);
                                    }
                                    else if (aCurrentReadOperation == CurrentReadOperation.Zoom)
                                    {
                                        ZoomRectangle.StartX = Convert.ToDouble(aXmlReader.ReadString(), CultureInfo.InvariantCulture);
                                    }
                                    else if (aCurrentReadOperation == CurrentReadOperation.Previous)
                                    {
                                        PreviousRectangle.StartX = Convert.ToDouble(aXmlReader.ReadString(), CultureInfo.InvariantCulture);
                                    }
                                }
                                break;

                            case "EndX":
                                {
                                    if (aCurrentReadOperation == CurrentReadOperation.Current)
                                    {
                                        CurrentRectangle.EndX = Convert.ToDouble(aXmlReader.ReadString(), CultureInfo.InvariantCulture);
                                    }
                                    else if (aCurrentReadOperation == CurrentReadOperation.Zoom)
                                    {
                                        ZoomRectangle.EndX = Convert.ToDouble(aXmlReader.ReadString(), CultureInfo.InvariantCulture);
                                    }
                                    else if (aCurrentReadOperation == CurrentReadOperation.Previous)
                                    {
                                        PreviousRectangle.EndX = Convert.ToDouble(aXmlReader.ReadString(), CultureInfo.InvariantCulture);
                                    }
                                }
                                break;

                            case "StartY":
                                {
                                    if (aCurrentReadOperation == CurrentReadOperation.Current)
                                    {
                                        CurrentRectangle.StartY = Convert.ToDouble(aXmlReader.ReadString(), CultureInfo.InvariantCulture);
                                    }
                                    else if (aCurrentReadOperation == CurrentReadOperation.Zoom)
                                    {
                                        ZoomRectangle.StartY = Convert.ToDouble(aXmlReader.ReadString(), CultureInfo.InvariantCulture);
                                    }
                                    else if (aCurrentReadOperation == CurrentReadOperation.Previous)
                                    {
                                        PreviousRectangle.StartY = Convert.ToDouble(aXmlReader.ReadString(), CultureInfo.InvariantCulture);
                                    }
                                }
                                break;

                            case "EndY":
                                {
                                    if (aCurrentReadOperation == CurrentReadOperation.Current)
                                    {
                                        CurrentRectangle.EndY = Convert.ToDouble(aXmlReader.ReadString(), CultureInfo.InvariantCulture);
                                    }
                                    else if (aCurrentReadOperation == CurrentReadOperation.Zoom)
                                    {
                                        ZoomRectangle.EndY = Convert.ToDouble(aXmlReader.ReadString(), CultureInfo.InvariantCulture);
                                    }
                                    else if (aCurrentReadOperation == CurrentReadOperation.Previous)
                                    {
                                        PreviousRectangle.EndY = Convert.ToDouble(aXmlReader.ReadString(), CultureInfo.InvariantCulture);
                                    }
                                }
                                break;
                        }
                    }
                }
            }
            finally
            {
                if (aXmlReader != null)
                {
                    aXmlReader.Close();
                }
            }
        }

        private FractalColorValue ReadColorFromConfigurationXml(XmlReader xmlReaderIn, string colorNameIn)
        {
            FractalColorValue aFractalColorValue = new FractalColorValue();

            while (xmlReaderIn.Read())
            {
                if (xmlReaderIn.NodeType == XmlNodeType.Element)
                {
                    switch (xmlReaderIn.Name)
                    {
                        case "R":
                            {
                                aFractalColorValue.red = Convert.ToInt32(xmlReaderIn.ReadString(), CultureInfo.InvariantCulture);
                                break;
                            }
                        case "G":
                            {
                                aFractalColorValue.green = Convert.ToInt32(xmlReaderIn.ReadString(), CultureInfo.InvariantCulture);
                                break;
                            }
                        case "B":
                            {
                                aFractalColorValue.blue = Convert.ToInt32(xmlReaderIn.ReadString(), CultureInfo.InvariantCulture);
                                break;
                            }
                        case "A":
                            {
                                aFractalColorValue.alpha = Convert.ToInt32(xmlReaderIn.ReadString(), CultureInfo.InvariantCulture);
                                break;
                            }
                    }
                }
                else if (xmlReaderIn.NodeType == XmlNodeType.EndElement && xmlReaderIn.Name == colorNameIn)
                {
                    break;
                }
            }

            return aFractalColorValue;
        }

        private void WriteColorToConfigurationXml(XmlWriter xmlWriterIn, FractalColorValue fractalColorValueIn)
        {
            xmlWriterIn.WriteElementString("A", Convert.ToString(fractalColorValueIn.alpha, CultureInfo.InvariantCulture));

            xmlWriterIn.WriteElementString("R", Convert.ToString(fractalColorValueIn.red, CultureInfo.InvariantCulture));

            xmlWriterIn.WriteElementString("G", Convert.ToString(fractalColorValueIn.green, CultureInfo.InvariantCulture));

            xmlWriterIn.WriteElementString("B", Convert.ToString(fractalColorValueIn.blue, CultureInfo.InvariantCulture));
        }

        public void WriteToFractalObserverConfigurationXml()
        {
            XmlWriter aXmlWriter = null;
            try
            {
                aXmlWriter = XmlWriter.Create("FractalObserverConfiguration.xml");

                aXmlWriter.WriteStartDocument();

                aXmlWriter.WriteStartElement("FractalObserverConfiguration");

                aXmlWriter.WriteElementString("FractalType", FractalTypeString);

                aXmlWriter.WriteElementString("EquationType", EquationTypeString);

                aXmlWriter.WriteStartElement("Current");

                aXmlWriter.WriteElementString("StartX", Convert.ToString(CurrentRectangle.StartX, CultureInfo.InvariantCulture));
                aXmlWriter.WriteElementString("EndX", Convert.ToString(CurrentRectangle.EndX, CultureInfo.InvariantCulture));
                aXmlWriter.WriteElementString("StartY", Convert.ToString(CurrentRectangle.StartY, CultureInfo.InvariantCulture));
                aXmlWriter.WriteElementString("EndY", Convert.ToString(CurrentRectangle.EndY, CultureInfo.InvariantCulture));

                aXmlWriter.WriteEndElement();

                aXmlWriter.WriteStartElement("Zoom");

                aXmlWriter.WriteElementString("StartX", Convert.ToString(ZoomRectangle.StartX, CultureInfo.InvariantCulture));
                aXmlWriter.WriteElementString("EndX", Convert.ToString(ZoomRectangle.EndX, CultureInfo.InvariantCulture));
                aXmlWriter.WriteElementString("StartY", Convert.ToString(ZoomRectangle.StartY, CultureInfo.InvariantCulture));
                aXmlWriter.WriteElementString("EndY", Convert.ToString(ZoomRectangle.EndY, CultureInfo.InvariantCulture));

                aXmlWriter.WriteEndElement();

                aXmlWriter.WriteStartElement("Previous");

                aXmlWriter.WriteElementString("StartX", Convert.ToString(PreviousRectangle.StartX, CultureInfo.InvariantCulture));
                aXmlWriter.WriteElementString("EndX", Convert.ToString(PreviousRectangle.EndX, CultureInfo.InvariantCulture));
                aXmlWriter.WriteElementString("StartY", Convert.ToString(PreviousRectangle.StartY, CultureInfo.InvariantCulture));
                aXmlWriter.WriteElementString("EndY", Convert.ToString(PreviousRectangle.EndY, CultureInfo.InvariantCulture));

                aXmlWriter.WriteEndElement();

                aXmlWriter.WriteStartElement("GridSpacing");

                aXmlWriter.WriteElementString("HorizontalSpacing", Convert.ToString(HorizontalSpacing, CultureInfo.InvariantCulture));
                aXmlWriter.WriteElementString("VerticalSpacing", Convert.ToString(VerticalSpacing, CultureInfo.InvariantCulture));

                aXmlWriter.WriteEndElement();

                aXmlWriter.WriteStartElement("Colors");

                aXmlWriter.WriteStartElement("BackgroundColor");
                WriteColorToConfigurationXml(aXmlWriter, BackgroundColor);
                aXmlWriter.WriteEndElement();

                aXmlWriter.WriteStartElement("Color1");
                WriteColorToConfigurationXml(aXmlWriter, Color1);
                aXmlWriter.WriteEndElement();

                aXmlWriter.WriteStartElement("Color2");
                WriteColorToConfigurationXml(aXmlWriter, Color2);
                aXmlWriter.WriteEndElement();

                aXmlWriter.WriteStartElement("Color3");
                WriteColorToConfigurationXml(aXmlWriter, Color3);
                aXmlWriter.WriteEndElement();

                aXmlWriter.WriteStartElement("GridColor");
                WriteColorToConfigurationXml(aXmlWriter, Color3);
                aXmlWriter.WriteEndElement();

                aXmlWriter.WriteStartElement("ZoomRectangleColor");
                WriteColorToConfigurationXml(aXmlWriter, ZoomRectangleColor);
                aXmlWriter.WriteEndElement();

                aXmlWriter.WriteEndElement();

                aXmlWriter.WriteEndElement();

                aXmlWriter.WriteEndDocument();
            }
            finally
            {
                if (aXmlWriter != null)
                {
                    aXmlWriter.Close();
                }
            }
        }

        public void SetDefaultValues()
        {
            CurrentRectangle = DefaultFractalObserverConfiguration.CurrentRectangle.ShallowCopy();
            ZoomRectangle = DefaultFractalObserverConfiguration.ZoomRectangle.ShallowCopy();
            PreviousRectangle = DefaultFractalObserverConfiguration.PreviousRectangle.ShallowCopy();

            FractalType = DefaultFractalObserverConfiguration.FractalType;
            EquationType = DefaultFractalObserverConfiguration.EquationType;

            BackgroundColor = DefaultFractalObserverConfiguration.BackgroundColor;
            Color1 = DefaultFractalObserverConfiguration.Color1;
            Color2 = DefaultFractalObserverConfiguration.Color2;
            Color3 = DefaultFractalObserverConfiguration.Color3;

            GridColor = DefaultFractalObserverConfiguration.GridColor;
            ZoomRectangleColor = DefaultFractalObserverConfiguration.ZoomRectangleColor;

            HorizontalSpacing = DefaultFractalObserverConfiguration.HorizontalSpacing;
            VerticalSpacing = DefaultFractalObserverConfiguration.VerticalSpacing;
        }

        #endregion

        #region Properties

        public RectangleInPlane CurrentRectangle
        {
            get
            {
                return myCurrentRectangle;
            }
            set
            {
                myCurrentRectangle = value;
            }
        }

        public RectangleInPlane ZoomRectangle
        {
            get
            {
                return myZoomRectangle;
            }

            set
            {
                myZoomRectangle = value;
            }
        }

        public RectangleInPlane PreviousRectangle
        {
            get
            {
                return myPreviousRectangle;
            }

            set
            {
                myPreviousRectangle = value;
            }
        }

        public int NumberOfIterations
        {
            get
            {
                return myMaximumNumberOfIterations;
            }

            set
            {
                myMaximumNumberOfIterations = value;
            }
        }

        public string FractalTypeString
        {
            get
            {
                return myFractalTypeString;
            }

            set
            {
                myFractalTypeString = value;
            }
        }

        public FractalTypes FractalType
        {
            get
            {
                FractalTypes aFractalType = FractalTypes.None;

                FractalFactory.AvailableFractalTypes.TryGetValue(FractalTypeString, out aFractalType);

                return aFractalType;
            }
            set
            {
                bool aWasFound = false;

                foreach (KeyValuePair<string, FractalTypes> tempKeyValue in FractalFactory.AvailableFractalTypes)
                {
                    if (tempKeyValue.Value == value)
                    {
                        FractalTypeString = tempKeyValue.Key;
                        aWasFound = true;
                    }
                }

                if (!aWasFound)
                {
                    throw new FractalObserverException("Unknown fractal type :" + value + "!");
                }
            }
        }

        public string EquationTypeString
        {
            get
            {
                return myEquationTypeString;
            }

            set
            {
                myEquationTypeString = value;
            }
        }

        public EquationTypes EquationType
        {
            get
            {
                EquationTypes aEquationType = EquationTypes.None;

                EquationFactory.AvailableEquationTypes.TryGetValue(EquationTypeString, out aEquationType);

                return aEquationType;
            }
            set
            {
                bool aWasFound = false;
                foreach (KeyValuePair<string, EquationTypes> tempKeyValue in EquationFactory.AvailableEquationTypes)
                {
                    if (tempKeyValue.Value == value)
                    {
                        EquationTypeString = tempKeyValue.Key;
                        aWasFound = true;
                    }
                }

                if (!aWasFound)
                {
                    throw new FractalObserverException("Unknown Equation type :" + value + "!");
                }
            }
        }

        public FractalColorValue BackgroundColor
        {
            get
            {
                return myBackgroundColor;
            }

            set
            {
                myBackgroundColor = value;
            }
        }

        public FractalColorValue Color1
        {
            get
            {
                return myColor1;
            }

            set
            {
                myColor1 = value;
            }
        }

        public FractalColorValue Color2
        {
            get
            {
                return myColor2;
            }

            set
            {
                myColor2 = value;
            }
        }

        public FractalColorValue Color3
        {
            get
            {
                return myColor3;
            }

            set
            {
                myColor3 = value;
            }
        }

        public FractalColorValue GridColor
        {
            get
            {
                return myGridColor;
            }

            set
            {
                myGridColor = value;
            }
        }

        public FractalColorValue ZoomRectangleColor
        {
            get
            {
                return myZoomRectangleColor;
            }

            set
            {
                myZoomRectangleColor = value;
            }
        }

        public double HorizontalSpacing
        {
            get
            {
                return myHorizontalSpacing;
            }

            set
            {
                myHorizontalSpacing = value;
            }
        }

        public double VerticalSpacing
        {
            get
            {
                return myVerticalSpacing;
            }

            set
            {
                myVerticalSpacing = value;
            }
        }

        #endregion

        #region Members

        private RectangleInPlane myCurrentRectangle = null;

        private RectangleInPlane myZoomRectangle = null;

        private RectangleInPlane myPreviousRectangle = null;

        private int myMaximumNumberOfIterations = 0;

        private string myFractalTypeString = null;
        private string myEquationTypeString = null;

        private FractalColorValue myBackgroundColor;
        private FractalColorValue myColor1;
        private FractalColorValue myColor2;
        private FractalColorValue myColor3;

        private FractalColorValue myGridColor;
        private FractalColorValue myZoomRectangleColor;

        private double myHorizontalSpacing = 0.0;
        private double myVerticalSpacing = 0.0;

        #endregion
    }
}
