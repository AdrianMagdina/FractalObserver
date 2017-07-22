using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Globalization;

namespace FractalObserverApplication
{
    public partial class MainForm : Form
    {
        // enum with available operations for zoom rectangle
        enum ZoomingRectangleOperations
        {
            None,
            LeftSizing,
            RightSizing,
            UpSizing,
            DownSizing,
            Panning
        }

        #region Constructors

        public MainForm()
        {
            InitializeComponent();
            myConfigurationXmlIsOk = false;
        }

        #endregion

        #region Methods

        private void DrawSelectedFractal()
        {
            // drawing fractal with pixel data
            IFractal aFractal = null;

            aFractal = myFractalFactory.CreateFractal(myFractalObserverConfiguration.FractalType, myFractalObserverConfiguration.EquationType);

            //read the selected fractal colors from configuration
            List<FractalColorValue> tempChosenFractalColors = new List<FractalColorValue>();
            tempChosenFractalColors.Add(myFractalObserverConfiguration.BackgroundColor);
            tempChosenFractalColors.Add(myFractalObserverConfiguration.Color1);
            tempChosenFractalColors.Add(myFractalObserverConfiguration.Color2);
            tempChosenFractalColors.Add(myFractalObserverConfiguration.Color3);

            myComputedFractalValues = aFractal.ReturnComputedFractalValues(myFractalObserverConfiguration.CurrentRectangle, FractalImage.Width, FractalImage.Height, tempChosenFractalColors, FractalProgress);

            Bitmap aBitmap = new Bitmap(FractalImage.Width, FractalImage.Height);

            foreach (ComputedFractalValue aCFValue in myComputedFractalValues.GetComputedFractalValues())
            {
                switch (aCFValue.TypeOfShape)
                {
                    case TypesOfShape.Point:
                        // drawing of pixel of fractal with x and y coordinates
                        aBitmap.SetPixel(aCFValue.GetComputedScreenPoints()[0].X, aCFValue.GetComputedScreenPoints()[0].Y, Color.FromArgb(aCFValue.ColorValue.alpha, aCFValue.ColorValue.red, aCFValue.ColorValue.green, aCFValue.ColorValue.blue));

                        break;
                }
            }

            if ( FractalImage.Image != null)
            {
                FractalImage.Image.Dispose();
            }

            FractalImage.Image = aBitmap;
        }

        private void RefreshAndShowUpdatedFractal()
        {
            if (FractalImage.Height > 0 && FractalImage.Width > 0)
            {
                // progress bar values are configured
                FractalProgress.Top = (this.Height * 9) / 20;
                FractalProgress.Height = (this.Height * 2) / 20;

                FractalProgress.Visible = true;

                DrawSelectedFractal();
                FractalImage.Invalidate();
                FractalImage.Update();

                FractalProgress.Value = 0;
                FractalProgress.Visible = false;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //loading fractal configuration during start of application
            myFractalObserverConfiguration = new FractalObserverConfiguration();

            try
            {
                myConfigurationXmlIsOk = true;
                myFractalObserverConfiguration.ReadFromFractalObserverConfigurationXml();
            }
            catch (Exception ex)
            {
                if (ex is FileNotFoundException || ex is XmlException)
                {
                    DialogResult aDialogResult = MessageBox.Show("Error ocurred during reading of configuration xml!\n" +
                                                                "Do you want to read the default configuration!? (if no the application will be closed!'\n" +
                                                                "Exception message: " + ex.Message, "FractalObserver", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0);
                    if (aDialogResult == DialogResult.Yes)
                    {
                        myFractalObserverConfiguration.SetDefaultValues();
                    }
                    else
                    {
                        myConfigurationXmlIsOk = false;
                        this.Close();
                        return;
                    }
                }
                else
                {
                    throw;
                }
            }

            tsStatusLabelFractalType.Text = "FractalType = " + myFractalObserverConfiguration.FractalType;

            tsStatusLabelGridSpacing.Text = "GridSpacing : Horizontal = " + Convert.ToString(myFractalObserverConfiguration.HorizontalSpacing, CultureInfo.CurrentCulture)
                                             + ", Vertical = " + Convert.ToString(myFractalObserverConfiguration.VerticalSpacing, CultureInfo.CurrentCulture);

            CheckZoomRectangleBoundary();

            myFractalFactory = new FractalFactory();
        }

        private void drawFractalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshAndShowUpdatedFractal();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void configureFractalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // showing dialog for fractal configuration
            using (ConfigureFractalValuesDialog aChooseFractalDialog = new ConfigureFractalValuesDialog(myFractalObserverConfiguration))
            {
                if (aChooseFractalDialog.ShowDialog(this) == DialogResult.OK)
                {
                    myFractalObserverConfiguration = aChooseFractalDialog.FractalObserverConfiguration;

                    CheckZoomRectangleBoundary();

                    FractalImage.Invalidate();
                    FractalImage.Update();

                    tsStatusLabelFractalType.Text = "FractalType = " + myFractalObserverConfiguration.FractalType;
                }
            }
        }

        private void showZoomRectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FractalImage.Invalidate();
            FractalImage.Update();
        }

        private void showGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FractalImage.Invalidate();
            FractalImage.Update();
        }

        private void FractalImage_Paint(object sender, PaintEventArgs e)
        {
            Graphics aGraphics = e.Graphics;

            // here are drawn fractals which contain vector data
            if (myComputedFractalValues != null)
            {
                if (myComputedFractalValues.IsVectorData() == true)
                {
                    using (Brush aBrush = new SolidBrush(Color.FromArgb(myFractalObserverConfiguration.BackgroundColor.alpha, myFractalObserverConfiguration.BackgroundColor.red, myFractalObserverConfiguration.BackgroundColor.green, myFractalObserverConfiguration.BackgroundColor.blue)))
                    {
                        aGraphics.FillRectangle(aBrush, e.ClipRectangle);
                    }
                }

                foreach (ComputedFractalValue aCFValue in myComputedFractalValues.GetComputedFractalValues())
                {
                    ScreenPlaneCoordinatesTransfornation tempSPCT = new ScreenPlaneCoordinatesTransfornation(FractalImage.Width, FractalImage.Height, myFractalObserverConfiguration.CurrentRectangle);
                    List<Point> tempListOfScreenPoints = new List<Point>();

                    foreach (PointInPlane tempPointInPlane in aCFValue.GetComputedPlanePoints())
                    {
                        // here for each fractal computed object are computed screen coordinates and next is check if the values are inside of screen
                        Point tempPoint = tempSPCT.GetScreenCoordinates(tempPointInPlane.x, tempPointInPlane.y);
                        if (tempPoint.X < 0)
                        {
                            tempPoint.X = 0;
                        }
                        else if (tempPoint.X > FractalImage.Width)
                        {
                            tempPoint.X = FractalImage.Width;
                        }

                        if (tempPoint.Y < 0)
                        {
                            tempPoint.Y = 0;
                        }
                        else if (tempPoint.Y > FractalImage.Height)
                        {
                            tempPoint.Y = FractalImage.Height;
                        }

                        tempListOfScreenPoints.Add(tempPoint);
                    }

                    if (tempListOfScreenPoints.Count > 0)
                    {
                        //drawing of fractal - for each computed object there is draw of object on screen
                        switch (aCFValue.TypeOfShape)
                        {
                            case TypesOfShape.Lines:       
                                if (myComputedFractalValues.ShallFillInterior == false)
                                {
                                    using (Pen aPen = new Pen(Color.FromArgb(aCFValue.ColorValue.alpha, aCFValue.ColorValue.red, aCFValue.ColorValue.green, aCFValue.ColorValue.blue), 1))
                                    {
                                        aGraphics.DrawLines(aPen, tempListOfScreenPoints.ToArray());
                                    }
                                }
                                else if (myComputedFractalValues.ShallFillInterior == true)
                                {
                                    using (Brush aBrush = new SolidBrush(Color.FromArgb(aCFValue.ColorValue.alpha, aCFValue.ColorValue.red, aCFValue.ColorValue.green, aCFValue.ColorValue.blue)))
                                    {
                                        aGraphics.FillClosedCurve(aBrush, tempListOfScreenPoints.ToArray());
                                    }
                                }

                                break;
                            case TypesOfShape.Rectangle:
                                using (Brush aBrush = new SolidBrush(Color.FromArgb(aCFValue.ColorValue.alpha, aCFValue.ColorValue.red, aCFValue.ColorValue.green, aCFValue.ColorValue.blue)))
                                {
                                    aGraphics.FillPolygon(aBrush, tempListOfScreenPoints.ToArray());
                                }

                                break;
                        }
                    }
                }
            }

            // drawing of overlay graphics - if grid should be shown, then it is drawn here
            if ( showGridToolStripMenuItem.Checked == true)
            {
                Color aGridColor = Color.FromArgb(myFractalObserverConfiguration.GridColor.alpha, myFractalObserverConfiguration.GridColor.red, myFractalObserverConfiguration.GridColor.green,
                                                    myFractalObserverConfiguration.GridColor.blue);
                using (Pen aPen = new Pen(aGridColor, 1))
                {
                    ScreenPlaneCoordinatesTransfornation tempTransformation = new ScreenPlaneCoordinatesTransfornation(FractalImage.Width, FractalImage.Height, myFractalObserverConfiguration.CurrentRectangle);

                    IGeometryInPlane aGridInPlane = new GridInPlane(myFractalObserverConfiguration.CurrentRectangle, myFractalObserverConfiguration.HorizontalSpacing, myFractalObserverConfiguration.VerticalSpacing);

                    foreach (LineInPlane tempLineInPlane in aGridInPlane.ReturnListOfInPlaneLines())
                    {
                        Point aStartPoint = tempTransformation.GetScreenCoordinates(tempLineInPlane.begin.x, tempLineInPlane.begin.y);
                        Point aEndPoint = tempTransformation.GetScreenCoordinates(tempLineInPlane.end.x, tempLineInPlane.end.y);
                        aGraphics.DrawLine(aPen, aStartPoint, aEndPoint);
                    }
                }
            }

            // drawing of overlay graphics - if zooming rectangle should be shown, then it is drawn here
            if (showZoomRectangleToolStripMenuItem.Checked == true && myShowZoomRectangleAndAllowModification)
            {
                Color aZoomInRectangleColor = Color.FromArgb(myFractalObserverConfiguration.ZoomRectangleColor.alpha, myFractalObserverConfiguration.ZoomRectangleColor.red, myFractalObserverConfiguration.ZoomRectangleColor.green,
                                                                myFractalObserverConfiguration.ZoomRectangleColor.blue);

                using (Pen aPen = new Pen(aZoomInRectangleColor, 2))
                {
                    // computing the screen coordinates
                    ScreenPlaneCoordinatesTransfornation tempTransformation = new ScreenPlaneCoordinatesTransfornation(FractalImage.Width, FractalImage.Height, myFractalObserverConfiguration.CurrentRectangle);

                    Point aStartPoint = tempTransformation.GetScreenCoordinates(myFractalObserverConfiguration.ZoomRectangle.MinX, myFractalObserverConfiguration.ZoomRectangle.MinY);
                    Point aEndPoint = tempTransformation.GetScreenCoordinates(myFractalObserverConfiguration.ZoomRectangle.MaxX, myFractalObserverConfiguration.ZoomRectangle.MaxY);

                    Rectangle aRect = new Rectangle(aStartPoint.X, aStartPoint.Y, Math.Abs(aEndPoint.X - aStartPoint.X), Math.Abs(aEndPoint.Y - aStartPoint.Y));

                    aGraphics.DrawRectangle(aPen, aRect);
                }
            }
        }

        private void FractalImage_Resize(object sender, EventArgs e)
        {
            FractalImage.Invalidate();
            FractalImage.Update();
        }

        private void FractalImage_MouseMove(object sender, MouseEventArgs e)
        {
            ScreenPlaneCoordinatesTransfornation tempTransformation = new ScreenPlaneCoordinatesTransfornation(FractalImage.Width, FractalImage.Height, myFractalObserverConfiguration.CurrentRectangle);
            Point aCurrentMouseLocation = e.Location;
            if (showZoomRectangleToolStripMenuItem.Checked == true && myShowZoomRectangleAndAllowModification)
            {
                // Getting the screen coordinates of zoom rectangle
                Point aStartPoint = tempTransformation.GetScreenCoordinates(myFractalObserverConfiguration.ZoomRectangle.StartX, myFractalObserverConfiguration.ZoomRectangle.StartY);
                Point aEndPoint = tempTransformation.GetScreenCoordinates(myFractalObserverConfiguration.ZoomRectangle.EndX, myFractalObserverConfiguration.ZoomRectangle.EndY);
                bool aModifyRectangle = false;

                // finding out if the current mouse pointer position is near or in the zoom rectangle, if yes - then change the mouse pointer shape
                if (!myMouseIsDown)
                {
                    if (Math.Abs(aCurrentMouseLocation.X - aStartPoint.X) < myLimitForZoomRectangleChange && aCurrentMouseLocation.Y > Math.Min(aStartPoint.Y, aEndPoint.Y) && aCurrentMouseLocation.Y < Math.Max(aStartPoint.Y, aEndPoint.Y))
                    {
                        myCurrentZoomRectangleOperation = ZoomingRectangleOperations.LeftSizing;
                        this.Cursor = Cursors.SizeWE;
                    }
                    else if (Math.Abs(aCurrentMouseLocation.X - aEndPoint.X) < myLimitForZoomRectangleChange && aCurrentMouseLocation.Y > Math.Min(aStartPoint.Y, aEndPoint.Y) && aCurrentMouseLocation.Y < Math.Max(aStartPoint.Y, aEndPoint.Y))
                    {
                        myCurrentZoomRectangleOperation = ZoomingRectangleOperations.RightSizing;
                        this.Cursor = Cursors.SizeWE;
                    }
                    else if (Math.Abs(aCurrentMouseLocation.Y - aStartPoint.Y) < myLimitForZoomRectangleChange && aCurrentMouseLocation.X > Math.Min(aStartPoint.X, aEndPoint.X) && aCurrentMouseLocation.X < Math.Max(aStartPoint.X, aEndPoint.X))
                    {
                        myCurrentZoomRectangleOperation = ZoomingRectangleOperations.UpSizing;
                        this.Cursor = Cursors.SizeNS;
                    }
                    else if (Math.Abs(aCurrentMouseLocation.Y - aEndPoint.Y) < myLimitForZoomRectangleChange && aCurrentMouseLocation.X > Math.Min(aStartPoint.X, aEndPoint.X) && aCurrentMouseLocation.X < Math.Max(aStartPoint.X, aEndPoint.X))
                    {
                        myCurrentZoomRectangleOperation = ZoomingRectangleOperations.DownSizing;
                        this.Cursor = Cursors.SizeNS;
                    }
                    else if (aCurrentMouseLocation.X > Math.Min(aStartPoint.X, aEndPoint.X) && aCurrentMouseLocation.X < Math.Max(aStartPoint.X, aEndPoint.X)
                            && aCurrentMouseLocation.Y > Math.Min(aStartPoint.Y, aEndPoint.Y) && aCurrentMouseLocation.Y < Math.Max(aStartPoint.Y, aEndPoint.Y))
                    {
                        myCurrentZoomRectangleOperation = ZoomingRectangleOperations.Panning;
                        this.Cursor = Cursors.Hand;
                    }
                    else
                    {
                        myCurrentZoomRectangleOperation = ZoomingRectangleOperations.None;
                        this.Cursor = Cursors.Default;
                    }
                }

                // if mouse button is pressed and the mouse pointer is on the right area then zooming rectangle will be modified
                if (myMouseIsDown)
                {
                    PointInPlane tempNewPoint = tempTransformation.GetPlaneCoordinates(aCurrentMouseLocation.X, aCurrentMouseLocation.Y);

                    // corrections of new zooming rectangle, it cannot be set outside the current view area
                    if (tempNewPoint.x <= myFractalObserverConfiguration.CurrentRectangle.MinX)
                    {
                        tempNewPoint.x = myFractalObserverConfiguration.CurrentRectangle.MinX;
                    }

                    if (tempNewPoint.y <= myFractalObserverConfiguration.CurrentRectangle.MinY)
                    {
                        tempNewPoint.y = myFractalObserverConfiguration.CurrentRectangle.MinY;
                    }

                    if (tempNewPoint.x >= myFractalObserverConfiguration.CurrentRectangle.MaxX)
                    {
                        tempNewPoint.x = myFractalObserverConfiguration.CurrentRectangle.MaxX;
                    }

                    if (tempNewPoint.y >= myFractalObserverConfiguration.CurrentRectangle.MaxY)
                    {
                        tempNewPoint.y = myFractalObserverConfiguration.CurrentRectangle.MaxY;
                    }

                    if (myCurrentZoomRectangleOperation == ZoomingRectangleOperations.LeftSizing)
                    {
                        // correction of zoom rectangle - it cannot be too small, then it is not allowed to further reduce its size
                        if (Math.Abs(aEndPoint.X - aCurrentMouseLocation.X) < myLowerSizeLimitForZoomRectangle)
                        {
                            int aSign = Math.Sign(aEndPoint.X - aStartPoint.X);
                            tempNewPoint.x = tempTransformation.GetPlaneCoordinates(aEndPoint.X - aSign * myLowerSizeLimitForZoomRectangle, aCurrentMouseLocation.Y).x;
                        }
                        myFractalObserverConfiguration.ZoomRectangle.StartX = tempNewPoint.x;
                        aModifyRectangle = true;
                    }
                    else if (myCurrentZoomRectangleOperation == ZoomingRectangleOperations.RightSizing)
                    {
                        // correction of zoom rectangle - it cannot be too small, then it is not allowed to further reduce its size
                        if (Math.Abs(aStartPoint.X - aCurrentMouseLocation.X) < myLowerSizeLimitForZoomRectangle)
                        {
                            int aSign = Math.Sign(aEndPoint.X - aStartPoint.X);
                            tempNewPoint.x = tempTransformation.GetPlaneCoordinates(aStartPoint.X + aSign * myLowerSizeLimitForZoomRectangle, aCurrentMouseLocation.Y).x;
                        }
                        myFractalObserverConfiguration.ZoomRectangle.EndX = tempNewPoint.x;
                        aModifyRectangle = true;
                    }
                    else if (myCurrentZoomRectangleOperation == ZoomingRectangleOperations.UpSizing)
                    {
                        // correction of zoom rectangle - it cannot be too small, then it is not allowed to further reduce its size
                        if (Math.Abs(aEndPoint.Y - aCurrentMouseLocation.Y) < myLowerSizeLimitForZoomRectangle)
                        {
                            int aSign = Math.Sign(aEndPoint.Y - aStartPoint.Y);
                            tempNewPoint.y = tempTransformation.GetPlaneCoordinates(aCurrentMouseLocation.X, aEndPoint.Y - aSign * myLowerSizeLimitForZoomRectangle).y;
                        }
                        myFractalObserverConfiguration.ZoomRectangle.StartY = tempNewPoint.y;
                        aModifyRectangle = true;
                    }
                    else if (myCurrentZoomRectangleOperation == ZoomingRectangleOperations.DownSizing)
                    {
                        // correction of zoom rectangle - it cannot be too small, then it is not allowed to further reduce its size
                        if (Math.Abs(aStartPoint.Y - aCurrentMouseLocation.Y) < myLowerSizeLimitForZoomRectangle)
                        {
                            int aSign = Math.Sign(aEndPoint.Y - aStartPoint.Y);
                            tempNewPoint.y = tempTransformation.GetPlaneCoordinates(aCurrentMouseLocation.X, aStartPoint.Y - aSign * myLowerSizeLimitForZoomRectangle).y;
                        }
                        myFractalObserverConfiguration.ZoomRectangle.EndY = tempNewPoint.y;
                        aModifyRectangle = true;
                    }
                    else if (myCurrentZoomRectangleOperation == ZoomingRectangleOperations.Panning)
                    {
                        // computing the new zooming rectangle coordinates if panning occured
                        if (!myIsPanNow)
                        {
                            myStartingDifferenceForPan = tempNewPoint - myFractalObserverConfiguration.ZoomRectangle.StartPoint;
                            myIsPanNow = true;
                        }

                        if (myIsPanNow) // if zoom rectangle is currenty in panning operation - then the following code is ran
                        {
                            double aRectangleWidth = myFractalObserverConfiguration.ZoomRectangle.Width;
                            double aRectangleHeight = myFractalObserverConfiguration.ZoomRectangle.Height;
                            myFractalObserverConfiguration.ZoomRectangle.StartX = tempNewPoint.x - myStartingDifferenceForPan.x;
                            myFractalObserverConfiguration.ZoomRectangle.StartY = tempNewPoint.y - myStartingDifferenceForPan.y;
                            myFractalObserverConfiguration.ZoomRectangle.EndX = myFractalObserverConfiguration.ZoomRectangle.StartX + aRectangleWidth;
                            myFractalObserverConfiguration.ZoomRectangle.EndY = myFractalObserverConfiguration.ZoomRectangle.StartY + aRectangleHeight;

                            // during panning the zoom rectangle cannot be moved outside of current view, the checks for this are following
                            if (myFractalObserverConfiguration.ZoomRectangle.MinX < myFractalObserverConfiguration.CurrentRectangle.MinX)
                            {
                                myFractalObserverConfiguration.ZoomRectangle.MinX = myFractalObserverConfiguration.CurrentRectangle.MinX;
                                myFractalObserverConfiguration.ZoomRectangle.MaxX = myFractalObserverConfiguration.ZoomRectangle.MinX + aRectangleWidth;
                            }
                            if (myFractalObserverConfiguration.ZoomRectangle.MaxX > myFractalObserverConfiguration.CurrentRectangle.MaxX)
                            {
                                myFractalObserverConfiguration.ZoomRectangle.MaxX = myFractalObserverConfiguration.CurrentRectangle.MaxX;
                                myFractalObserverConfiguration.ZoomRectangle.MinX = myFractalObserverConfiguration.ZoomRectangle.MaxX - aRectangleWidth;
                            }
                            if (myFractalObserverConfiguration.ZoomRectangle.MinY < myFractalObserverConfiguration.CurrentRectangle.MinY)
                            {
                                myFractalObserverConfiguration.ZoomRectangle.MinY = myFractalObserverConfiguration.CurrentRectangle.MinY;
                                myFractalObserverConfiguration.ZoomRectangle.MaxY = myFractalObserverConfiguration.ZoomRectangle.MinY + aRectangleHeight;
                            }
                            if (myFractalObserverConfiguration.ZoomRectangle.MaxY > myFractalObserverConfiguration.CurrentRectangle.MaxY)
                            {
                                myFractalObserverConfiguration.ZoomRectangle.MaxY = myFractalObserverConfiguration.CurrentRectangle.MaxY;
                                myFractalObserverConfiguration.ZoomRectangle.MinY = myFractalObserverConfiguration.ZoomRectangle.MaxY - aRectangleHeight;
                            }
                        }

                        aModifyRectangle = true;
                    }

                    // if zooming rectangle was modified and mouse button is pressed then modify the zoom rectangle
                    if (aModifyRectangle)
                    {
                        // invalidation of screen (onpaint will be called on this area, and new zooming rectangle will be drawn)
                        FractalImage.Invalidate();
                        FractalImage.Update();
                    }
                }
            }
            else
            {
                myCurrentZoomRectangleOperation = ZoomingRectangleOperations.None;
                this.Cursor = Cursors.Default;
            }

            // showing of current mouse position in plane coordinates in status bar
            PointInPlane tempMousePositionInPlane = tempTransformation.GetPlaneCoordinates(aCurrentMouseLocation.X, aCurrentMouseLocation.Y);
            tsStatusLabelMousePosition.Text = "Current Mouse Position : X = " + Convert.ToString(tempMousePositionInPlane.x, CultureInfo.CurrentCulture) + " Y= " + Convert.ToString(tempMousePositionInPlane.y, CultureInfo.CurrentCulture);
        }

        private void menuMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (myCurrentZoomRectangleOperation != ZoomingRectangleOperations.None)
            {
                myCurrentZoomRectangleOperation = ZoomingRectangleOperations.None;
                this.Cursor = Cursors.Default;
            }
        }

        private void sstripMainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (myCurrentZoomRectangleOperation != ZoomingRectangleOperations.None)
            {
                myCurrentZoomRectangleOperation = ZoomingRectangleOperations.None;
                this.Cursor = Cursors.Default;
            }
        }

        private void zoomToZoomRectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myFractalObserverConfiguration.PreviousRectangle = myFractalObserverConfiguration.CurrentRectangle.ShallowCopy();
            myFractalObserverConfiguration.CurrentRectangle = myFractalObserverConfiguration.ZoomRectangle.ShallowCopy();
            CheckZoomRectangleBoundary();

            RefreshAndShowUpdatedFractal();
        }

        private void zoomToPreviousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myFractalObserverConfiguration.CurrentRectangle = myFractalObserverConfiguration.PreviousRectangle.ShallowCopy();

            RefreshAndShowUpdatedFractal();
        }

        // during closing of application the current fractal configuration is written to xml
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (myConfigurationXmlIsOk)
            {
                try
                {
                    myFractalObserverConfiguration.WriteToFractalObserverConfigurationXml();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("Sorry, but it is not possible to write to the configuration file!\n" +
                                    "Your changes will not be saved!'\n" +
                                    "Exception message: " + ex.Message, "FractalObserver", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0);
                }
                finally
                {
                    if (FractalImage.Image != null)
                    {
                        FractalImage.Image.Dispose();
                        FractalImage.Image = null;
                    }

                    if (myHelpDialog != null)
                    {
                        myHelpDialog.Dispose();
                        myHelpDialog = null;
                    }
                }
            }
        }

        private void configureGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // showing dialog for grid configuration and setting the values
            using (ConfigureGridAndZoomRectangleDialog aConfigureGridAndZoomRectangleDialog = new ConfigureGridAndZoomRectangleDialog())
            {
                aConfigureGridAndZoomRectangleDialog.GridAlpha = myFractalObserverConfiguration.GridColor.alpha;
                aConfigureGridAndZoomRectangleDialog.GridColor = Color.FromArgb(myFractalObserverConfiguration.GridColor.red,
                                                                      myFractalObserverConfiguration.GridColor.green,
                                                                      myFractalObserverConfiguration.GridColor.blue);

                aConfigureGridAndZoomRectangleDialog.ZoomingRectangleAlpha = myFractalObserverConfiguration.ZoomRectangleColor.alpha;
                aConfigureGridAndZoomRectangleDialog.ZoomingRectangleColor = Color.FromArgb(myFractalObserverConfiguration.ZoomRectangleColor.red,
                                                                      myFractalObserverConfiguration.ZoomRectangleColor.green,
                                                                      myFractalObserverConfiguration.ZoomRectangleColor.blue);

                aConfigureGridAndZoomRectangleDialog.HorizontalSpacing = myFractalObserverConfiguration.HorizontalSpacing;
                aConfigureGridAndZoomRectangleDialog.VerticalSpacing = myFractalObserverConfiguration.VerticalSpacing;


                if (aConfigureGridAndZoomRectangleDialog.ShowDialog(this) == DialogResult.OK)
                {

                    myFractalObserverConfiguration.GridColor = new FractalColorValue(aConfigureGridAndZoomRectangleDialog.GridAlpha,
                                                                                     aConfigureGridAndZoomRectangleDialog.GridColor.R,
                                                                                     aConfigureGridAndZoomRectangleDialog.GridColor.G,
                                                                                     aConfigureGridAndZoomRectangleDialog.GridColor.B);

                    myFractalObserverConfiguration.ZoomRectangleColor = new FractalColorValue(aConfigureGridAndZoomRectangleDialog.ZoomingRectangleAlpha,
                                                                                                aConfigureGridAndZoomRectangleDialog.ZoomingRectangleColor.R,
                                                                                                aConfigureGridAndZoomRectangleDialog.ZoomingRectangleColor.G,
                                                                                                aConfigureGridAndZoomRectangleDialog.ZoomingRectangleColor.B);

                    myFractalObserverConfiguration.HorizontalSpacing = aConfigureGridAndZoomRectangleDialog.HorizontalSpacing;
                    myFractalObserverConfiguration.VerticalSpacing = aConfigureGridAndZoomRectangleDialog.VerticalSpacing;

                    FractalImage.Invalidate();
                    FractalImage.Update();

                    tsStatusLabelGridSpacing.Text = "GridSpacing : Horizontal = " + Convert.ToString(myFractalObserverConfiguration.HorizontalSpacing, CultureInfo.CurrentCulture)
                                                     + ", Vertical = " + Convert.ToString(myFractalObserverConfiguration.VerticalSpacing, CultureInfo.CurrentCulture);
                }
            }
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (myHelpDialog != null)
            {
                myHelpDialog.Dispose();
            }

            myHelpDialog = new HelpDialog();
            
            myHelpDialog.Show(this);
        }

        private void aboutFractalObserverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutFractalObserverDialog aAboutFractalObserverDialog = new AboutFractalObserverDialog())
            {
                aAboutFractalObserverDialog.ShowDialog(this);
            }
        }

        private void loadFractalObserverConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // loading program configuration from another xml file
            try
            {
                openFractalObserverConfiguration.Filter = "xml files (*.xml)|*.xml";
                openFractalObserverConfiguration.FilterIndex = 1;

                if (openFractalObserverConfiguration.ShowDialog(this) == DialogResult.OK)
                {
                    myFractalObserverConfiguration.ReadFromFractalObserverConfigurationXml(openFractalObserverConfiguration.FileName);
                }
            }
            catch(FileNotFoundException ex)
            {
                MessageBox.Show("File was not found!\n" + ex.Message, "FractalObserver", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0);
            }
            catch(XmlException ex)
            {
                MessageBox.Show("Problem ocurred during loading of configuration xml! Xml was not loaded!\n" + ex.Message, "FractalObserver", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0);
            }
        }

        private void loadBackgroundImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // loading background image
            try
            {
                openBackgroundImageDialog.Filter = "bmp files (*.bmp)|*.bmp|gif files (*.gif)|*.gif|jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|tiff files (*.tiff)|*.tiff";
                openBackgroundImageDialog.FilterIndex = 3;

                if (openBackgroundImageDialog.ShowDialog(this) == DialogResult.OK)
                {
                    FractalImage.BackgroundImage = Image.FromFile(openBackgroundImageDialog.FileName);
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Image was not found! It cannot be loaded!\n" + ex.Message, "FractalObserver", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0);
            }
        }

        private void configureFractalColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //showing dialog for configuration of colors for fractals
            using (ConfigureFractalColorsDialog aConfigureFractalColorsDialog = new ConfigureFractalColorsDialog())
            {
                aConfigureFractalColorsDialog.BackgroundAlpha = myFractalObserverConfiguration.BackgroundColor.alpha;
                aConfigureFractalColorsDialog.BackgroundColor = Color.FromArgb(myFractalObserverConfiguration.BackgroundColor.red,
                                                                      myFractalObserverConfiguration.BackgroundColor.green,
                                                                      myFractalObserverConfiguration.BackgroundColor.blue);

                aConfigureFractalColorsDialog.Alpha1 = myFractalObserverConfiguration.Color1.alpha;
                aConfigureFractalColorsDialog.Color1 = Color.FromArgb(myFractalObserverConfiguration.Color1.red,
                                                                      myFractalObserverConfiguration.Color1.green,
                                                                      myFractalObserverConfiguration.Color1.blue);
                aConfigureFractalColorsDialog.Alpha2 = myFractalObserverConfiguration.Color2.alpha;
                aConfigureFractalColorsDialog.Color2 = Color.FromArgb(myFractalObserverConfiguration.Color2.red,
                                                                      myFractalObserverConfiguration.Color2.green,
                                                                      myFractalObserverConfiguration.Color2.blue);
                aConfigureFractalColorsDialog.Alpha3 = myFractalObserverConfiguration.Color3.alpha;
                aConfigureFractalColorsDialog.Color3 = Color.FromArgb(myFractalObserverConfiguration.Color3.red,
                                                                      myFractalObserverConfiguration.Color3.green,
                                                                      myFractalObserverConfiguration.Color3.blue);


                if (aConfigureFractalColorsDialog.ShowDialog(this) == DialogResult.OK)
                {
                    myFractalObserverConfiguration.BackgroundColor = new FractalColorValue(aConfigureFractalColorsDialog.BackgroundAlpha,
                                                                                   aConfigureFractalColorsDialog.BackgroundColor.R,
                                                                                   aConfigureFractalColorsDialog.BackgroundColor.G,
                                                                                   aConfigureFractalColorsDialog.BackgroundColor.B);

                    myFractalObserverConfiguration.Color1 = new FractalColorValue(aConfigureFractalColorsDialog.Alpha1,
                                                                          aConfigureFractalColorsDialog.Color1.R,
                                                                          aConfigureFractalColorsDialog.Color1.G,
                                                                          aConfigureFractalColorsDialog.Color1.B);

                    myFractalObserverConfiguration.Color2 = new FractalColorValue(aConfigureFractalColorsDialog.Alpha2,
                                                                          aConfigureFractalColorsDialog.Color2.R,
                                                                          aConfigureFractalColorsDialog.Color2.G,
                                                                          aConfigureFractalColorsDialog.Color2.B);

                    myFractalObserverConfiguration.Color3 = new FractalColorValue(aConfigureFractalColorsDialog.Alpha3,
                                                                          aConfigureFractalColorsDialog.Color3.R,
                                                                          aConfigureFractalColorsDialog.Color3.G,
                                                                          aConfigureFractalColorsDialog.Color3.B);
                }
            }
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const double aMultiplyValue = 1.5 / 1.0;
            myFractalObserverConfiguration.PreviousRectangle = myFractalObserverConfiguration.CurrentRectangle.ShallowCopy();
            myFractalObserverConfiguration.CurrentRectangle.ResizeRectangle(aMultiplyValue);
            CheckZoomRectangleBoundary();

            RefreshAndShowUpdatedFractal();
        }

        private void zoomOut2xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const double aMultiplyValue = 2.0 / 1.0;
            myFractalObserverConfiguration.PreviousRectangle = myFractalObserverConfiguration.CurrentRectangle.ShallowCopy();
            myFractalObserverConfiguration.CurrentRectangle.ResizeRectangle(aMultiplyValue);
            CheckZoomRectangleBoundary();

            RefreshAndShowUpdatedFractal();
        }

        private void zoomOut5xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const double aMultiplyValue = 5.0 / 1.0;
            myFractalObserverConfiguration.PreviousRectangle = myFractalObserverConfiguration.CurrentRectangle.ShallowCopy();
            myFractalObserverConfiguration.CurrentRectangle.ResizeRectangle(aMultiplyValue);
            CheckZoomRectangleBoundary();

            RefreshAndShowUpdatedFractal();
        }

        private void zoomIn15xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const double aMultiplyValue = 1.0 / 1.5;
            myFractalObserverConfiguration.PreviousRectangle = myFractalObserverConfiguration.CurrentRectangle.ShallowCopy();
            myFractalObserverConfiguration.CurrentRectangle.ResizeRectangle(aMultiplyValue);
            CheckZoomRectangleBoundary();

            RefreshAndShowUpdatedFractal();
        }

        private void zoomIn2xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const double aMultiplyValue = 1.0 / 2.0;
            myFractalObserverConfiguration.PreviousRectangle = myFractalObserverConfiguration.CurrentRectangle.ShallowCopy();
            myFractalObserverConfiguration.CurrentRectangle.ResizeRectangle(aMultiplyValue);
            CheckZoomRectangleBoundary();

            RefreshAndShowUpdatedFractal();
        }

        private void zoomIn5xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const double aMultiplyValue = 1.0 / 5.0;
            myFractalObserverConfiguration.PreviousRectangle = myFractalObserverConfiguration.CurrentRectangle.ShallowCopy();
            myFractalObserverConfiguration.CurrentRectangle.ResizeRectangle(aMultiplyValue);
            CheckZoomRectangleBoundary();

            RefreshAndShowUpdatedFractal();
        }

        private void FractalImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                myMouseIsDown = true;
            }
        }

        private void FractalImage_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                myMouseIsDown = false;
                myIsPanNow = false;
                myCurrentZoomRectangleOperation = ZoomingRectangleOperations.None;
                this.Cursor = Cursors.Default;
            }
        }

        // checking the boundary of zoom rectangle - if it is two small then, it will be not visible
        private void CheckZoomRectangleBoundary()
        {
            // computing the screen coordinates
            ScreenPlaneCoordinatesTransfornation tempTransformation = new ScreenPlaneCoordinatesTransfornation(FractalImage.Width, FractalImage.Height, myFractalObserverConfiguration.CurrentRectangle);

            Point aStartPoint = tempTransformation.GetScreenCoordinates(myFractalObserverConfiguration.ZoomRectangle.MinX, myFractalObserverConfiguration.ZoomRectangle.MinY);
            Point aEndPoint = tempTransformation.GetScreenCoordinates(myFractalObserverConfiguration.ZoomRectangle.MaxX, myFractalObserverConfiguration.ZoomRectangle.MaxY);

            // not allowing to draw the zooming rectangle if it is outside of scope(outside of current rectangle), or if it is too small.
            if (myFractalObserverConfiguration.ZoomRectangle.MinX < myFractalObserverConfiguration.CurrentRectangle.MinX)
            {
                myShowZoomRectangleAndAllowModification = false;
            }
            else if (myFractalObserverConfiguration.ZoomRectangle.MinY < myFractalObserverConfiguration.CurrentRectangle.MinY)
            {
                myShowZoomRectangleAndAllowModification = false;
            }
            else if (myFractalObserverConfiguration.ZoomRectangle.MaxX > myFractalObserverConfiguration.CurrentRectangle.MaxX)
            {
                myShowZoomRectangleAndAllowModification = false;
            }
            else if (Math.Abs(aStartPoint.X - aEndPoint.X) < myLowerSizeLimitForZoomRectangle)
            {
                myShowZoomRectangleAndAllowModification = false;
            }
            else if (Math.Abs(aStartPoint.Y - aEndPoint.Y) < myLowerSizeLimitForZoomRectangle)
            {
                myShowZoomRectangleAndAllowModification = false;
            }
            else
            {
                myShowZoomRectangleAndAllowModification = true;
            }
        }

        #endregion

        #region Members

        private bool myMouseIsDown = false; //was mouse button pressed and was it hold pressed
        private IFractalObserverConfiguration myFractalObserverConfiguration = null; // current program configuration
        private const int myLimitForZoomRectangleChange = 10; // limit when the mouse pointer will change because zoomrectangle is near
        private const int myLowerSizeLimitForZoomRectangle = 20; // lowest zoomrectangle size
        private bool myIsPanNow = false; //is zoom rectangle being panned
        private PointInPlane myStartingDifferenceForPan; //when panning the zoom rectangle, the starting difference betwen upper left corner and mouse position
        private ZoomingRectangleOperations myCurrentZoomRectangleOperation = ZoomingRectangleOperations.None; //current zooming rectangle operation
        bool myShowZoomRectangleAndAllowModification = true; //shall Zoom rectangle be shown and shall the operations on zooming rectangle be allowed
        private FractalFactory myFractalFactory = null; //factory for creation of fractals
        private ComputedFractalValues myComputedFractalValues = null; //computed fractal output values
        private bool myConfigurationXmlIsOk = false; //indicates if the configuration xml was read properly

        HelpDialog myHelpDialog = null;

        #endregion
    }
}
