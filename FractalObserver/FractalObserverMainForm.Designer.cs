namespace FractalObserverApplication
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawFractalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.loadFractalObserverConfigurationFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBackgroundImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showZoomRectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToZoomRectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomIn15xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomIn2xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomIn5xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOut2xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOut5xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.zoomToPreviousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureFractalObserverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureFractalColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureZoomRectangleAndGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutFractalObserverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FractalImage = new System.Windows.Forms.PictureBox();
            this.contextMenuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.drawFractalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.loadBackgroundImageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FractalProgress = new System.Windows.Forms.ProgressBar();
            this.sstripMainForm = new System.Windows.Forms.StatusStrip();
            this.tsStatusLabelFractalType = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsStatusLabelGridSpacing = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsStatusLabelMousePosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveDrawnFractalDialog = new System.Windows.Forms.SaveFileDialog();
            this.openBackgroundImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFractalObserverConfiguration = new System.Windows.Forms.OpenFileDialog();
            this.menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FractalImage)).BeginInit();
            this.contextMenuMain.SuspendLayout();
            this.sstripMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.zoomToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuMain.Size = new System.Drawing.Size(1183, 28);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            this.menuMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuMain_MouseMove);
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawFractalToolStripMenuItem,
            this.toolStripSeparator2,
            this.loadFractalObserverConfigurationFromFileToolStripMenuItem,
            this.loadBackgroundImageToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.mainMenuToolStripMenuItem.Text = "File";
            // 
            // drawFractalToolStripMenuItem
            // 
            this.drawFractalToolStripMenuItem.Name = "drawFractalToolStripMenuItem";
            this.drawFractalToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.drawFractalToolStripMenuItem.Text = "Draw Fractal";
            this.drawFractalToolStripMenuItem.Click += new System.EventHandler(this.drawFractalToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(322, 6);
            // 
            // loadFractalObserverConfigurationFromFileToolStripMenuItem
            // 
            this.loadFractalObserverConfigurationFromFileToolStripMenuItem.Name = "loadFractalObserverConfigurationFromFileToolStripMenuItem";
            this.loadFractalObserverConfigurationFromFileToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.loadFractalObserverConfigurationFromFileToolStripMenuItem.Text = "Load Fractal Configuration From File";
            this.loadFractalObserverConfigurationFromFileToolStripMenuItem.Click += new System.EventHandler(this.loadFractalObserverConfigurationToolStripMenuItem_Click);
            // 
            // loadBackgroundImageToolStripMenuItem
            // 
            this.loadBackgroundImageToolStripMenuItem.Name = "loadBackgroundImageToolStripMenuItem";
            this.loadBackgroundImageToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.loadBackgroundImageToolStripMenuItem.Text = "Load Background Image";
            this.loadBackgroundImageToolStripMenuItem.Click += new System.EventHandler(this.loadBackgroundImageToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(322, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showZoomRectangleToolStripMenuItem,
            this.showGridToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // showZoomRectangleToolStripMenuItem
            // 
            this.showZoomRectangleToolStripMenuItem.Checked = true;
            this.showZoomRectangleToolStripMenuItem.CheckOnClick = true;
            this.showZoomRectangleToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showZoomRectangleToolStripMenuItem.Name = "showZoomRectangleToolStripMenuItem";
            this.showZoomRectangleToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.showZoomRectangleToolStripMenuItem.Text = "Show Zoom Rectangle";
            this.showZoomRectangleToolStripMenuItem.Click += new System.EventHandler(this.showZoomRectangleToolStripMenuItem_Click);
            // 
            // showGridToolStripMenuItem
            // 
            this.showGridToolStripMenuItem.CheckOnClick = true;
            this.showGridToolStripMenuItem.Name = "showGridToolStripMenuItem";
            this.showGridToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.showGridToolStripMenuItem.Text = "Show Grid";
            this.showGridToolStripMenuItem.Click += new System.EventHandler(this.showGridToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToZoomRectangleToolStripMenuItem,
            this.zoomIn15xToolStripMenuItem,
            this.zoomIn2xToolStripMenuItem,
            this.zoomIn5xToolStripMenuItem,
            this.toolStripSeparator1,
            this.zoomOutToolStripMenuItem,
            this.zoomOut2xToolStripMenuItem,
            this.zoomOut5xToolStripMenuItem,
            this.toolStripSeparator5,
            this.zoomToPreviousToolStripMenuItem});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // zoomInToZoomRectangleToolStripMenuItem
            // 
            this.zoomInToZoomRectangleToolStripMenuItem.Name = "zoomInToZoomRectangleToolStripMenuItem";
            this.zoomInToZoomRectangleToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.zoomInToZoomRectangleToolStripMenuItem.Text = "Zoom In To Zoom Rectangle";
            this.zoomInToZoomRectangleToolStripMenuItem.Click += new System.EventHandler(this.zoomToZoomRectangleToolStripMenuItem_Click);
            // 
            // zoomIn15xToolStripMenuItem
            // 
            this.zoomIn15xToolStripMenuItem.Name = "zoomIn15xToolStripMenuItem";
            this.zoomIn15xToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.zoomIn15xToolStripMenuItem.Text = "Zoom In 1.5x";
            this.zoomIn15xToolStripMenuItem.Click += new System.EventHandler(this.zoomIn15xToolStripMenuItem_Click);
            // 
            // zoomIn2xToolStripMenuItem
            // 
            this.zoomIn2xToolStripMenuItem.Name = "zoomIn2xToolStripMenuItem";
            this.zoomIn2xToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.zoomIn2xToolStripMenuItem.Text = "Zoom In 2x";
            this.zoomIn2xToolStripMenuItem.Click += new System.EventHandler(this.zoomIn2xToolStripMenuItem_Click);
            // 
            // zoomIn5xToolStripMenuItem
            // 
            this.zoomIn5xToolStripMenuItem.Name = "zoomIn5xToolStripMenuItem";
            this.zoomIn5xToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.zoomIn5xToolStripMenuItem.Text = "Zoom In 5x";
            this.zoomIn5xToolStripMenuItem.Click += new System.EventHandler(this.zoomIn5xToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(271, 6);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out 1.5x";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // zoomOut2xToolStripMenuItem
            // 
            this.zoomOut2xToolStripMenuItem.Name = "zoomOut2xToolStripMenuItem";
            this.zoomOut2xToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.zoomOut2xToolStripMenuItem.Text = "Zoom Out 2x";
            this.zoomOut2xToolStripMenuItem.Click += new System.EventHandler(this.zoomOut2xToolStripMenuItem_Click);
            // 
            // zoomOut5xToolStripMenuItem
            // 
            this.zoomOut5xToolStripMenuItem.Name = "zoomOut5xToolStripMenuItem";
            this.zoomOut5xToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.zoomOut5xToolStripMenuItem.Text = "Zoom Out 5x";
            this.zoomOut5xToolStripMenuItem.Click += new System.EventHandler(this.zoomOut5xToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(271, 6);
            // 
            // zoomToPreviousToolStripMenuItem
            // 
            this.zoomToPreviousToolStripMenuItem.Name = "zoomToPreviousToolStripMenuItem";
            this.zoomToPreviousToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.zoomToPreviousToolStripMenuItem.Text = "Zoom To Previous";
            this.zoomToPreviousToolStripMenuItem.Click += new System.EventHandler(this.zoomToPreviousToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureFractalObserverToolStripMenuItem,
            this.configureFractalColorsToolStripMenuItem,
            this.configureZoomRectangleAndGridToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.optionsToolStripMenuItem.Text = "Configuration";
            // 
            // configureFractalObserverToolStripMenuItem
            // 
            this.configureFractalObserverToolStripMenuItem.Name = "configureFractalObserverToolStripMenuItem";
            this.configureFractalObserverToolStripMenuItem.Size = new System.Drawing.Size(326, 26);
            this.configureFractalObserverToolStripMenuItem.Text = "Configure Fractal Values";
            this.configureFractalObserverToolStripMenuItem.Click += new System.EventHandler(this.configureFractalToolStripMenuItem_Click);
            // 
            // configureFractalColorsToolStripMenuItem
            // 
            this.configureFractalColorsToolStripMenuItem.Name = "configureFractalColorsToolStripMenuItem";
            this.configureFractalColorsToolStripMenuItem.Size = new System.Drawing.Size(326, 26);
            this.configureFractalColorsToolStripMenuItem.Text = "Configure Fractal Colors";
            this.configureFractalColorsToolStripMenuItem.Click += new System.EventHandler(this.configureFractalColorsToolStripMenuItem_Click);
            // 
            // configureZoomRectangleAndGridToolStripMenuItem
            // 
            this.configureZoomRectangleAndGridToolStripMenuItem.Name = "configureZoomRectangleAndGridToolStripMenuItem";
            this.configureZoomRectangleAndGridToolStripMenuItem.Size = new System.Drawing.Size(326, 26);
            this.configureZoomRectangleAndGridToolStripMenuItem.Text = "Configure Zoom Rectangle And Grid";
            this.configureZoomRectangleAndGridToolStripMenuItem.Click += new System.EventHandler(this.configureGridToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutFractalObserverToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(232, 26);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // aboutFractalObserverToolStripMenuItem
            // 
            this.aboutFractalObserverToolStripMenuItem.Name = "aboutFractalObserverToolStripMenuItem";
            this.aboutFractalObserverToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.aboutFractalObserverToolStripMenuItem.Text = "About FractalObserver";
            this.aboutFractalObserverToolStripMenuItem.Click += new System.EventHandler(this.aboutFractalObserverToolStripMenuItem_Click);
            // 
            // FractalImage
            // 
            this.FractalImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FractalImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FractalImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FractalImage.ContextMenuStrip = this.contextMenuMain;
            this.FractalImage.Location = new System.Drawing.Point(0, 33);
            this.FractalImage.Margin = new System.Windows.Forms.Padding(4);
            this.FractalImage.Name = "FractalImage";
            this.FractalImage.Size = new System.Drawing.Size(1181, 664);
            this.FractalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FractalImage.TabIndex = 1;
            this.FractalImage.TabStop = false;
            this.FractalImage.Paint += new System.Windows.Forms.PaintEventHandler(this.FractalImage_Paint);
            this.FractalImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FractalImage_MouseDown);
            this.FractalImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FractalImage_MouseMove);
            this.FractalImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FractalImage_MouseUp);
            this.FractalImage.Resize += new System.EventHandler(this.FractalImage_Resize);
            // 
            // contextMenuMain
            // 
            this.contextMenuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawFractalToolStripMenuItem1,
            this.toolStripSeparator8,
            this.toolStripMenuItem2,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripSeparator6,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem1,
            this.toolStripSeparator7,
            this.loadBackgroundImageToolStripMenuItem1});
            this.contextMenuMain.Name = "contextMenuMain";
            this.contextMenuMain.Size = new System.Drawing.Size(269, 262);
            // 
            // drawFractalToolStripMenuItem1
            // 
            this.drawFractalToolStripMenuItem1.Name = "drawFractalToolStripMenuItem1";
            this.drawFractalToolStripMenuItem1.Size = new System.Drawing.Size(268, 24);
            this.drawFractalToolStripMenuItem1.Text = "Draw Fractal";
            this.drawFractalToolStripMenuItem1.Click += new System.EventHandler(this.drawFractalToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(265, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(268, 24);
            this.toolStripMenuItem2.Text = "Zoom In To Zoom Rectangle";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.zoomToZoomRectangleToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(268, 24);
            this.toolStripMenuItem6.Text = "Zoom In 1.5x";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.zoomIn15xToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(268, 24);
            this.toolStripMenuItem7.Text = "Zoom In 2x";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.zoomIn2xToolStripMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(268, 24);
            this.toolStripMenuItem8.Text = "Zoom In 5x";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.zoomIn5xToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(265, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(268, 24);
            this.toolStripMenuItem3.Text = "Zoom Out 1.5x";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(268, 24);
            this.toolStripMenuItem4.Text = "Zoom Out 2x";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.zoomOut2xToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(268, 24);
            this.toolStripMenuItem5.Text = "Zoom Out 5x";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.zoomOut5xToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(268, 24);
            this.toolStripMenuItem1.Text = "Zoom To Previous";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.zoomToPreviousToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(265, 6);
            // 
            // loadBackgroundImageToolStripMenuItem1
            // 
            this.loadBackgroundImageToolStripMenuItem1.Name = "loadBackgroundImageToolStripMenuItem1";
            this.loadBackgroundImageToolStripMenuItem1.Size = new System.Drawing.Size(268, 24);
            this.loadBackgroundImageToolStripMenuItem1.Text = "Load Background Image";
            this.loadBackgroundImageToolStripMenuItem1.Click += new System.EventHandler(this.loadBackgroundImageToolStripMenuItem_Click);
            // 
            // FractalProgress
            // 
            this.FractalProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FractalProgress.Location = new System.Drawing.Point(16, 351);
            this.FractalProgress.Margin = new System.Windows.Forms.Padding(4);
            this.FractalProgress.Name = "FractalProgress";
            this.FractalProgress.Size = new System.Drawing.Size(1151, 28);
            this.FractalProgress.TabIndex = 2;
            this.FractalProgress.Visible = false;
            // 
            // sstripMainForm
            // 
            this.sstripMainForm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sstripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatusLabelFractalType,
            this.tsStatusLabelGridSpacing,
            this.tsStatusLabelMousePosition});
            this.sstripMainForm.Location = new System.Drawing.Point(0, 705);
            this.sstripMainForm.Name = "sstripMainForm";
            this.sstripMainForm.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.sstripMainForm.Size = new System.Drawing.Size(1183, 24);
            this.sstripMainForm.TabIndex = 3;
            this.sstripMainForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sstripMainForm_MouseMove);
            // 
            // tsStatusLabelFractalType
            // 
            this.tsStatusLabelFractalType.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsStatusLabelFractalType.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.tsStatusLabelFractalType.Name = "tsStatusLabelFractalType";
            this.tsStatusLabelFractalType.Size = new System.Drawing.Size(4, 19);
            // 
            // tsStatusLabelGridSpacing
            // 
            this.tsStatusLabelGridSpacing.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsStatusLabelGridSpacing.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.tsStatusLabelGridSpacing.Name = "tsStatusLabelGridSpacing";
            this.tsStatusLabelGridSpacing.Size = new System.Drawing.Size(4, 19);
            // 
            // tsStatusLabelMousePosition
            // 
            this.tsStatusLabelMousePosition.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsStatusLabelMousePosition.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.tsStatusLabelMousePosition.Name = "tsStatusLabelMousePosition";
            this.tsStatusLabelMousePosition.Size = new System.Drawing.Size(4, 19);
            // 
            // saveDrawnFractalDialog
            // 
            this.saveDrawnFractalDialog.RestoreDirectory = true;
            // 
            // openBackgroundImageDialog
            // 
            this.openBackgroundImageDialog.RestoreDirectory = true;
            // 
            // openFractalObserverConfiguration
            // 
            this.openFractalObserverConfiguration.RestoreDirectory = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 729);
            this.Controls.Add(this.sstripMainForm);
            this.Controls.Add(this.FractalProgress);
            this.Controls.Add(this.menuMain);
            this.Controls.Add(this.FractalImage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Fractal Observer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FractalImage)).EndInit();
            this.contextMenuMain.ResumeLayout(false);
            this.sstripMainForm.ResumeLayout(false);
            this.sstripMainForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawFractalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox FractalImage;
        private System.Windows.Forms.ProgressBar FractalProgress;
        private System.Windows.Forms.StatusStrip sstripMainForm;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusLabelFractalType;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showZoomRectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureFractalObserverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFractalObserverConfigurationFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureZoomRectangleAndGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutFractalObserverToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuMain;
        private System.Windows.Forms.ToolStripMenuItem drawFractalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToPreviousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToZoomRectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadBackgroundImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadBackgroundImageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem configureFractalColorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zoomOut2xToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOut5xToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveDrawnFractalDialog;
        private System.Windows.Forms.OpenFileDialog openBackgroundImageDialog;
        private System.Windows.Forms.OpenFileDialog openFractalObserverConfiguration;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem zoomIn15xToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomIn2xToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomIn5xToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusLabelGridSpacing;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusLabelMousePosition;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

    }
}

