namespace SampServerLocator
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxInputAltitude = new MetroFramework.Controls.MetroTextBox();
            this.textBoxInputLongitude = new MetroFramework.Controls.MetroTextBox();
            this.textBox_InputCMD = new MetroFramework.Controls.MetroTextBox();
            this.textBox_Addr = new MetroFramework.Controls.MetroTextBox();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.buttonHelpMenu = new System.Windows.Forms.Button();
            this.buttonCreditsOpen = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonRotateImg = new System.Windows.Forms.Button();
            this.buttonWallpaperImg = new System.Windows.Forms.Button();
            this.buttonServersListOpen = new System.Windows.Forms.Button();
            this.buttonConnectToServer = new System.Windows.Forms.Button();
            this.buttonLocateCustom = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonClearLongitudeBox = new System.Windows.Forms.Button();
            this.buttonClearAltitudeBox = new System.Windows.Forms.Button();
            this.buttonIPInfo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCopyServerInfo = new System.Windows.Forms.Button();
            this.buttonAddMarker = new System.Windows.Forms.Button();
            this.buttonSaveGeoData = new System.Windows.Forms.Button();
            this.buttonTakePicture = new System.Windows.Forms.Button();
            this.buttonDelAllMarkers = new System.Windows.Forms.Button();
            this.buttonMarkerStyle = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonCheckUpdates = new System.Windows.Forms.Button();
            this.buttonYoutube = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.metroTrackBar_MapZoom = new MetroFramework.Controls.MetroTrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTimeZone = new System.Windows.Forms.Label();
            this.szWeburl = new System.Windows.Forms.Label();
            this.szLagcomp = new System.Windows.Forms.Label();
            this.szLabelWeather = new System.Windows.Forms.Label();
            this.szLabelSAMPVersion = new System.Windows.Forms.Label();
            this.szLabelMapName = new System.Windows.Forms.Label();
            this.szPing = new System.Windows.Forms.Label();
            this.szPassword = new System.Windows.Forms.Label();
            this.szLabelPlayers = new System.Windows.Forms.Label();
            this.szLabelLanguage = new System.Windows.Forms.Label();
            this.szLabelGameMode = new System.Windows.Forms.Label();
            this.szLabelHostName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelGetZoomLevel = new System.Windows.Forms.Label();
            this.panel2ForImageView = new System.Windows.Forms.Panel();
            this.buttonBigCameraImage = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelForImagesList = new System.Windows.Forms.Panel();
            this.labelImgResolution = new System.Windows.Forms.Label();
            this.labelImgName = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.szLabelGeoLongitude = new System.Windows.Forms.Label();
            this.szLabelGeoLatitude = new System.Windows.Forms.Label();
            this.szLabelGeoLocationName = new System.Windows.Forms.Label();
            this.labelinputCMD = new System.Windows.Forms.Label();
            this.buttonShowSettings = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2ForImageView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelForImagesList.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMap
            // 
            this.gMap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gMap.Bearing = 0F;
            this.gMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gMap.CanDragMap = true;
            this.gMap.EmptyTileColor = System.Drawing.Color.Transparent;
            this.gMap.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemory = 5;
            this.gMap.Location = new System.Drawing.Point(598, 34);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 2;
            this.gMap.MinZoom = 2;
            this.gMap.MouseWheelZoomEnabled = true;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap.ShowTileGridLines = false;
            this.gMap.Size = new System.Drawing.Size(549, 374);
            this.gMap.TabIndex = 11;
            this.gMap.Zoom = 0D;
            // 
            // textBoxInputAltitude
            // 
            this.textBoxInputAltitude.Location = new System.Drawing.Point(993, 485);
            this.textBoxInputAltitude.Name = "textBoxInputAltitude";
            this.textBoxInputAltitude.Size = new System.Drawing.Size(117, 23);
            this.textBoxInputAltitude.TabIndex = 49;
            this.textBoxInputAltitude.Text = "Latitude";
            this.toolTip1.SetToolTip(this.textBoxInputAltitude, "Input altitude");
            // 
            // textBoxInputLongitude
            // 
            this.textBoxInputLongitude.Location = new System.Drawing.Point(993, 514);
            this.textBoxInputLongitude.Name = "textBoxInputLongitude";
            this.textBoxInputLongitude.Size = new System.Drawing.Size(117, 23);
            this.textBoxInputLongitude.TabIndex = 50;
            this.textBoxInputLongitude.Text = "Longitude";
            this.toolTip1.SetToolTip(this.textBoxInputLongitude, "Input longitude");
            // 
            // textBox_InputCMD
            // 
            this.textBox_InputCMD.Location = new System.Drawing.Point(339, 392);
            this.textBox_InputCMD.Name = "textBox_InputCMD";
            this.textBox_InputCMD.Size = new System.Drawing.Size(123, 23);
            this.textBox_InputCMD.TabIndex = 55;
            this.textBox_InputCMD.Text = "Enter command";
            this.toolTip1.SetToolTip(this.textBox_InputCMD, "/cmds - view all commands");
            this.textBox_InputCMD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_SearchServer_KeyPress);
            // 
            // textBox_Addr
            // 
            this.textBox_Addr.Location = new System.Drawing.Point(71, 461);
            this.textBox_Addr.Name = "textBox_Addr";
            this.textBox_Addr.Size = new System.Drawing.Size(158, 23);
            this.textBox_Addr.TabIndex = 57;
            this.textBox_Addr.Text = "51.254.85.134:7776";
            this.toolTip1.SetToolTip(this.textBox_Addr, "Input altitude");
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonLoadImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLoadImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLoadImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonLoadImage.FlatAppearance.BorderSize = 0;
            this.buttonLoadImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonLoadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadImage.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadImage.ForeColor = System.Drawing.Color.White;
            this.buttonLoadImage.Location = new System.Drawing.Point(12, 393);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(91, 23);
            this.buttonLoadImage.TabIndex = 62;
            this.buttonLoadImage.Text = "Add Image";
            this.buttonLoadImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.buttonLoadImage, "Add Image");
            this.buttonLoadImage.UseVisualStyleBackColor = false;
            this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImageDialog_Click);
            // 
            // buttonHelpMenu
            // 
            this.buttonHelpMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonHelpMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonHelpMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelpMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonHelpMenu.FlatAppearance.BorderSize = 0;
            this.buttonHelpMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonHelpMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelpMenu.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelpMenu.ForeColor = System.Drawing.Color.White;
            this.buttonHelpMenu.Location = new System.Drawing.Point(104, 4);
            this.buttonHelpMenu.Name = "buttonHelpMenu";
            this.buttonHelpMenu.Size = new System.Drawing.Size(91, 28);
            this.buttonHelpMenu.TabIndex = 63;
            this.buttonHelpMenu.Text = "Help";
            this.buttonHelpMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.buttonHelpMenu, "Click here if you need help on how to use this software");
            this.buttonHelpMenu.UseVisualStyleBackColor = false;
            this.buttonHelpMenu.Click += new System.EventHandler(this.buttonHelpMenu_Click);
            // 
            // buttonCreditsOpen
            // 
            this.buttonCreditsOpen.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonCreditsOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCreditsOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreditsOpen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCreditsOpen.FlatAppearance.BorderSize = 0;
            this.buttonCreditsOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonCreditsOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreditsOpen.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreditsOpen.ForeColor = System.Drawing.Color.White;
            this.buttonCreditsOpen.Location = new System.Drawing.Point(194, 4);
            this.buttonCreditsOpen.Name = "buttonCreditsOpen";
            this.buttonCreditsOpen.Size = new System.Drawing.Size(91, 28);
            this.buttonCreditsOpen.TabIndex = 64;
            this.buttonCreditsOpen.Text = "Credits";
            this.buttonCreditsOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.buttonCreditsOpen, "Coding: _=Gigant=_");
            this.buttonCreditsOpen.UseVisualStyleBackColor = false;
            this.buttonCreditsOpen.Click += new System.EventHandler(this.buttonCreditsOpen_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(1089, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 28);
            this.button4.TabIndex = 66;
            this.button4.Text = "_";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.button4, "Minimize");
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(1119, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(28, 28);
            this.button5.TabIndex = 67;
            this.button5.Text = "X";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.button5, "Exit");
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonRotateImg
            // 
            this.buttonRotateImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.buttonRotateImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRotateImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRotateImg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRotateImg.FlatAppearance.BorderSize = 0;
            this.buttonRotateImg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonRotateImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRotateImg.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRotateImg.ForeColor = System.Drawing.Color.White;
            this.buttonRotateImg.Location = new System.Drawing.Point(-15, 113);
            this.buttonRotateImg.Name = "buttonRotateImg";
            this.buttonRotateImg.Size = new System.Drawing.Size(28, 83);
            this.buttonRotateImg.TabIndex = 70;
            this.buttonRotateImg.Text = "R";
            this.buttonRotateImg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.buttonRotateImg, "Rotate");
            this.buttonRotateImg.UseVisualStyleBackColor = false;
            this.buttonRotateImg.Click += new System.EventHandler(this.buttonImageRotate_Click);
            this.buttonRotateImg.MouseEnter += new System.EventHandler(this.buttonRotateImg_MouseEnter);
            this.buttonRotateImg.MouseLeave += new System.EventHandler(this.buttonRotateImg_MouseLeave);
            // 
            // buttonWallpaperImg
            // 
            this.buttonWallpaperImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.buttonWallpaperImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonWallpaperImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWallpaperImg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonWallpaperImg.FlatAppearance.BorderSize = 0;
            this.buttonWallpaperImg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonWallpaperImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWallpaperImg.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWallpaperImg.ForeColor = System.Drawing.Color.White;
            this.buttonWallpaperImg.Location = new System.Drawing.Point(-15, 196);
            this.buttonWallpaperImg.Name = "buttonWallpaperImg";
            this.buttonWallpaperImg.Size = new System.Drawing.Size(28, 83);
            this.buttonWallpaperImg.TabIndex = 71;
            this.buttonWallpaperImg.Text = "Wallpaper";
            this.buttonWallpaperImg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.buttonWallpaperImg, "Set as Wallpaper");
            this.buttonWallpaperImg.UseVisualStyleBackColor = false;
            this.buttonWallpaperImg.Click += new System.EventHandler(this.buttonImageDelete_Click);
            this.buttonWallpaperImg.MouseEnter += new System.EventHandler(this.buttonDeleteImg_MouseEnter);
            this.buttonWallpaperImg.MouseLeave += new System.EventHandler(this.buttonDeleteImg_MouseLeave);
            // 
            // buttonServersListOpen
            // 
            this.buttonServersListOpen.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonServersListOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonServersListOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonServersListOpen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonServersListOpen.FlatAppearance.BorderSize = 0;
            this.buttonServersListOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonServersListOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonServersListOpen.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonServersListOpen.ForeColor = System.Drawing.Color.White;
            this.buttonServersListOpen.Location = new System.Drawing.Point(284, 4);
            this.buttonServersListOpen.Name = "buttonServersListOpen";
            this.buttonServersListOpen.Size = new System.Drawing.Size(91, 28);
            this.buttonServersListOpen.TabIndex = 65;
            this.buttonServersListOpen.Text = "Servers";
            this.buttonServersListOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.buttonServersListOpen, "Show ip addresses of 0.3.7 servers");
            this.buttonServersListOpen.UseVisualStyleBackColor = false;
            this.buttonServersListOpen.Click += new System.EventHandler(this.buttonServersListOpen_Click);
            // 
            // buttonConnectToServer
            // 
            this.buttonConnectToServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.buttonConnectToServer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonConnectToServer.BackgroundImage")));
            this.buttonConnectToServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonConnectToServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConnectToServer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonConnectToServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonConnectToServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnectToServer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnectToServer.ForeColor = System.Drawing.Color.White;
            this.buttonConnectToServer.Location = new System.Drawing.Point(0, 485);
            this.buttonConnectToServer.Name = "buttonConnectToServer";
            this.buttonConnectToServer.Size = new System.Drawing.Size(36, 38);
            this.buttonConnectToServer.TabIndex = 69;
            this.buttonConnectToServer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.buttonConnectToServer, "Click to connect to server");
            this.buttonConnectToServer.UseVisualStyleBackColor = false;
            this.buttonConnectToServer.Click += new System.EventHandler(this.buttonConnectToServer_Click);
            // 
            // buttonLocateCustom
            // 
            this.buttonLocateCustom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.buttonLocateCustom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLocateCustom.BackgroundImage")));
            this.buttonLocateCustom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLocateCustom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLocateCustom.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonLocateCustom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonLocateCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLocateCustom.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLocateCustom.ForeColor = System.Drawing.Color.White;
            this.buttonLocateCustom.Location = new System.Drawing.Point(567, 325);
            this.buttonLocateCustom.Name = "buttonLocateCustom";
            this.buttonLocateCustom.Size = new System.Drawing.Size(31, 59);
            this.buttonLocateCustom.TabIndex = 60;
            this.buttonLocateCustom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.buttonLocateCustom, "Search for a location");
            this.buttonLocateCustom.UseVisualStyleBackColor = false;
            this.buttonLocateCustom.Click += new System.EventHandler(this.buttonLocateCustom_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(39, 460);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 24);
            this.button3.TabIndex = 59;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.button3, "Clear Address Input");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttonClearAddress_Click);
            // 
            // buttonClearLongitudeBox
            // 
            this.buttonClearLongitudeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.buttonClearLongitudeBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClearLongitudeBox.BackgroundImage")));
            this.buttonClearLongitudeBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClearLongitudeBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearLongitudeBox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonClearLongitudeBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonClearLongitudeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearLongitudeBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearLongitudeBox.ForeColor = System.Drawing.Color.White;
            this.buttonClearLongitudeBox.Location = new System.Drawing.Point(1116, 514);
            this.buttonClearLongitudeBox.Name = "buttonClearLongitudeBox";
            this.buttonClearLongitudeBox.Size = new System.Drawing.Size(31, 23);
            this.buttonClearLongitudeBox.TabIndex = 52;
            this.buttonClearLongitudeBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.buttonClearLongitudeBox, "Take a picture of the map");
            this.buttonClearLongitudeBox.UseVisualStyleBackColor = false;
            this.buttonClearLongitudeBox.Click += new System.EventHandler(this.buttonClearLongitudeBox_Click);
            // 
            // buttonClearAltitudeBox
            // 
            this.buttonClearAltitudeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.buttonClearAltitudeBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClearAltitudeBox.BackgroundImage")));
            this.buttonClearAltitudeBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClearAltitudeBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearAltitudeBox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonClearAltitudeBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonClearAltitudeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearAltitudeBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearAltitudeBox.ForeColor = System.Drawing.Color.White;
            this.buttonClearAltitudeBox.Location = new System.Drawing.Point(1116, 485);
            this.buttonClearAltitudeBox.Name = "buttonClearAltitudeBox";
            this.buttonClearAltitudeBox.Size = new System.Drawing.Size(31, 23);
            this.buttonClearAltitudeBox.TabIndex = 51;
            this.buttonClearAltitudeBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.buttonClearAltitudeBox, "Take a picture of the map");
            this.buttonClearAltitudeBox.UseVisualStyleBackColor = false;
            this.buttonClearAltitudeBox.Click += new System.EventHandler(this.buttonClearAltitudeBox_Click);
            // 
            // buttonIPInfo
            // 
            this.buttonIPInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.buttonIPInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonIPInfo.BackgroundImage")));
            this.buttonIPInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonIPInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIPInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonIPInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonIPInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIPInfo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIPInfo.ForeColor = System.Drawing.Color.White;
            this.buttonIPInfo.Location = new System.Drawing.Point(0, 610);
            this.buttonIPInfo.Name = "buttonIPInfo";
            this.buttonIPInfo.Size = new System.Drawing.Size(36, 40);
            this.buttonIPInfo.TabIndex = 48;
            this.buttonIPInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.buttonIPInfo, "Check Your IP Info");
            this.buttonIPInfo.UseVisualStyleBackColor = false;
            this.buttonIPInfo.Click += new System.EventHandler(this.buttonIPInfo_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 40);
            this.button1.TabIndex = 47;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.button1, "Click to locate server");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonLocateServer_Click);
            // 
            // buttonCopyServerInfo
            // 
            this.buttonCopyServerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.buttonCopyServerInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCopyServerInfo.BackgroundImage")));
            this.buttonCopyServerInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCopyServerInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCopyServerInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCopyServerInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonCopyServerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCopyServerInfo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCopyServerInfo.ForeColor = System.Drawing.Color.White;
            this.buttonCopyServerInfo.Location = new System.Drawing.Point(0, 567);
            this.buttonCopyServerInfo.Name = "buttonCopyServerInfo";
            this.buttonCopyServerInfo.Size = new System.Drawing.Size(36, 40);
            this.buttonCopyServerInfo.TabIndex = 46;
            this.buttonCopyServerInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.buttonCopyServerInfo, "Copy server info");
            this.buttonCopyServerInfo.UseVisualStyleBackColor = false;
            this.buttonCopyServerInfo.Click += new System.EventHandler(this.buttonCopyServerInfo_Click);
            // 
            // buttonAddMarker
            // 
            this.buttonAddMarker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.buttonAddMarker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddMarker.BackgroundImage")));
            this.buttonAddMarker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddMarker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddMarker.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonAddMarker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonAddMarker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddMarker.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddMarker.ForeColor = System.Drawing.Color.White;
            this.buttonAddMarker.Location = new System.Drawing.Point(567, 47);
            this.buttonAddMarker.Name = "buttonAddMarker";
            this.buttonAddMarker.Size = new System.Drawing.Size(31, 59);
            this.buttonAddMarker.TabIndex = 42;
            this.buttonAddMarker.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.buttonAddMarker, "Add new marker at current position by camera");
            this.buttonAddMarker.UseVisualStyleBackColor = false;
            this.buttonAddMarker.Click += new System.EventHandler(this.buttonAddMarker_Click);
            // 
            // buttonSaveGeoData
            // 
            this.buttonSaveGeoData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.buttonSaveGeoData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSaveGeoData.BackgroundImage")));
            this.buttonSaveGeoData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSaveGeoData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveGeoData.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSaveGeoData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonSaveGeoData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveGeoData.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveGeoData.ForeColor = System.Drawing.Color.White;
            this.buttonSaveGeoData.Location = new System.Drawing.Point(567, 102);
            this.buttonSaveGeoData.Name = "buttonSaveGeoData";
            this.buttonSaveGeoData.Size = new System.Drawing.Size(31, 59);
            this.buttonSaveGeoData.TabIndex = 41;
            this.buttonSaveGeoData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.buttonSaveGeoData, "Save server geo data to txt file");
            this.buttonSaveGeoData.UseVisualStyleBackColor = false;
            this.buttonSaveGeoData.Click += new System.EventHandler(this.buttonSaveGeoData_Click);
            // 
            // buttonTakePicture
            // 
            this.buttonTakePicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.buttonTakePicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTakePicture.BackgroundImage")));
            this.buttonTakePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTakePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTakePicture.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonTakePicture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonTakePicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTakePicture.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTakePicture.ForeColor = System.Drawing.Color.White;
            this.buttonTakePicture.Location = new System.Drawing.Point(567, 267);
            this.buttonTakePicture.Name = "buttonTakePicture";
            this.buttonTakePicture.Size = new System.Drawing.Size(31, 59);
            this.buttonTakePicture.TabIndex = 38;
            this.buttonTakePicture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.buttonTakePicture, "Take a picture of the map");
            this.buttonTakePicture.UseVisualStyleBackColor = false;
            this.buttonTakePicture.Click += new System.EventHandler(this.buttonTakePicture_Click);
            // 
            // buttonDelAllMarkers
            // 
            this.buttonDelAllMarkers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.buttonDelAllMarkers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDelAllMarkers.BackgroundImage")));
            this.buttonDelAllMarkers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDelAllMarkers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelAllMarkers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDelAllMarkers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(130)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.buttonDelAllMarkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelAllMarkers.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelAllMarkers.ForeColor = System.Drawing.Color.White;
            this.buttonDelAllMarkers.Location = new System.Drawing.Point(567, 156);
            this.buttonDelAllMarkers.Name = "buttonDelAllMarkers";
            this.buttonDelAllMarkers.Size = new System.Drawing.Size(31, 59);
            this.buttonDelAllMarkers.TabIndex = 40;
            this.buttonDelAllMarkers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.buttonDelAllMarkers, "Remove all markers on map");
            this.buttonDelAllMarkers.UseVisualStyleBackColor = false;
            this.buttonDelAllMarkers.Click += new System.EventHandler(this.buttonDelAllMarkers_Click);
            // 
            // buttonMarkerStyle
            // 
            this.buttonMarkerStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.buttonMarkerStyle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMarkerStyle.BackgroundImage")));
            this.buttonMarkerStyle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMarkerStyle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMarkerStyle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonMarkerStyle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonMarkerStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMarkerStyle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMarkerStyle.ForeColor = System.Drawing.Color.White;
            this.buttonMarkerStyle.Location = new System.Drawing.Point(567, 212);
            this.buttonMarkerStyle.Name = "buttonMarkerStyle";
            this.buttonMarkerStyle.Size = new System.Drawing.Size(31, 59);
            this.buttonMarkerStyle.TabIndex = 39;
            this.buttonMarkerStyle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.buttonMarkerStyle, "Change map style");
            this.buttonMarkerStyle.UseVisualStyleBackColor = false;
            this.buttonMarkerStyle.Click += new System.EventHandler(this.buttonNextMapStyle_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.Color.White;
            this.buttonRefresh.Location = new System.Drawing.Point(230, 461);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(91, 23);
            this.buttonRefresh.TabIndex = 72;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.buttonRefresh, "Refresh\\Update server info");
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonCheckUpdates
            // 
            this.buttonCheckUpdates.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonCheckUpdates.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCheckUpdates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCheckUpdates.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCheckUpdates.FlatAppearance.BorderSize = 0;
            this.buttonCheckUpdates.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonCheckUpdates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckUpdates.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckUpdates.ForeColor = System.Drawing.Color.White;
            this.buttonCheckUpdates.Location = new System.Drawing.Point(375, 4);
            this.buttonCheckUpdates.Name = "buttonCheckUpdates";
            this.buttonCheckUpdates.Size = new System.Drawing.Size(91, 28);
            this.buttonCheckUpdates.TabIndex = 73;
            this.buttonCheckUpdates.Text = "Update";
            this.buttonCheckUpdates.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.buttonCheckUpdates, "Show ip addresses of 0.3.7 servers");
            this.buttonCheckUpdates.UseVisualStyleBackColor = false;
            this.buttonCheckUpdates.Click += new System.EventHandler(this.buttonCheckUpdates_Click);
            // 
            // buttonYoutube
            // 
            this.buttonYoutube.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonYoutube.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonYoutube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonYoutube.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonYoutube.FlatAppearance.BorderSize = 0;
            this.buttonYoutube.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonYoutube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonYoutube.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYoutube.ForeColor = System.Drawing.Color.White;
            this.buttonYoutube.Location = new System.Drawing.Point(466, 4);
            this.buttonYoutube.Name = "buttonYoutube";
            this.buttonYoutube.Size = new System.Drawing.Size(95, 28);
            this.buttonYoutube.TabIndex = 74;
            this.buttonYoutube.Text = "YouTube";
            this.buttonYoutube.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolTip1.SetToolTip(this.buttonYoutube, "Download thumbnail from video link");
            this.buttonYoutube.UseVisualStyleBackColor = false;
            this.buttonYoutube.Click += new System.EventHandler(this.buttonYoutube_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(104, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 75;
            this.button2.Text = "Open Location";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.button2, "Add Image");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // metroTrackBar_MapZoom
            // 
            this.metroTrackBar_MapZoom.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar_MapZoom.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.metroTrackBar_MapZoom.Location = new System.Drawing.Point(669, 409);
            this.metroTrackBar_MapZoom.Maximum = 20;
            this.metroTrackBar_MapZoom.MouseWheelBarPartitions = 1;
            this.metroTrackBar_MapZoom.Name = "metroTrackBar_MapZoom";
            this.metroTrackBar_MapZoom.Size = new System.Drawing.Size(478, 18);
            this.metroTrackBar_MapZoom.TabIndex = 43;
            this.metroTrackBar_MapZoom.Value = 1;
            this.metroTrackBar_MapZoom.ValueChanged += new System.EventHandler(this.metroTrackBar_MapZoom_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.labelTimeZone);
            this.panel1.Controls.Add(this.szWeburl);
            this.panel1.Controls.Add(this.szLagcomp);
            this.panel1.Controls.Add(this.szLabelWeather);
            this.panel1.Controls.Add(this.szLabelSAMPVersion);
            this.panel1.Controls.Add(this.szLabelMapName);
            this.panel1.Controls.Add(this.szPing);
            this.panel1.Controls.Add(this.szPassword);
            this.panel1.Controls.Add(this.szLabelPlayers);
            this.panel1.Controls.Add(this.szLabelLanguage);
            this.panel1.Controls.Add(this.szLabelGameMode);
            this.panel1.Controls.Add(this.szLabelHostName);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Location = new System.Drawing.Point(39, 485);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 169);
            this.panel1.TabIndex = 44;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseDown);
            this.panel1.MouseHover += new System.EventHandler(this.panel_info_MouseHover);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseUp);
            // 
            // labelTimeZone
            // 
            this.labelTimeZone.AutoSize = true;
            this.labelTimeZone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTimeZone.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeZone.ForeColor = System.Drawing.Color.White;
            this.labelTimeZone.Location = new System.Drawing.Point(405, 7);
            this.labelTimeZone.Name = "labelTimeZone";
            this.labelTimeZone.Size = new System.Drawing.Size(64, 15);
            this.labelTimeZone.TabIndex = 61;
            this.labelTimeZone.Text = "Timezone:";
            // 
            // szWeburl
            // 
            this.szWeburl.AutoSize = true;
            this.szWeburl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.szWeburl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.szWeburl.ForeColor = System.Drawing.Color.White;
            this.szWeburl.Location = new System.Drawing.Point(686, 138);
            this.szWeburl.Name = "szWeburl";
            this.szWeburl.Size = new System.Drawing.Size(52, 15);
            this.szWeburl.TabIndex = 60;
            this.szWeburl.Text = "Weburl:";
            // 
            // szLagcomp
            // 
            this.szLagcomp.AutoSize = true;
            this.szLagcomp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.szLagcomp.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.szLagcomp.ForeColor = System.Drawing.Color.White;
            this.szLagcomp.Location = new System.Drawing.Point(686, 92);
            this.szLagcomp.Name = "szLagcomp";
            this.szLagcomp.Size = new System.Drawing.Size(59, 15);
            this.szLagcomp.TabIndex = 59;
            this.szLagcomp.Text = "Lagcomp:";
            // 
            // szLabelWeather
            // 
            this.szLabelWeather.AutoSize = true;
            this.szLabelWeather.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.szLabelWeather.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.szLabelWeather.ForeColor = System.Drawing.Color.White;
            this.szLabelWeather.Location = new System.Drawing.Point(405, 92);
            this.szLabelWeather.Name = "szLabelWeather";
            this.szLabelWeather.Size = new System.Drawing.Size(60, 15);
            this.szLabelWeather.TabIndex = 57;
            this.szLabelWeather.Text = "Weather:";
            // 
            // szLabelSAMPVersion
            // 
            this.szLabelSAMPVersion.AutoSize = true;
            this.szLabelSAMPVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.szLabelSAMPVersion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.szLabelSAMPVersion.ForeColor = System.Drawing.Color.White;
            this.szLabelSAMPVersion.Location = new System.Drawing.Point(686, 6);
            this.szLabelSAMPVersion.Name = "szLabelSAMPVersion";
            this.szLabelSAMPVersion.Size = new System.Drawing.Size(52, 15);
            this.szLabelSAMPVersion.TabIndex = 56;
            this.szLabelSAMPVersion.Text = "Version:";
            // 
            // szLabelMapName
            // 
            this.szLabelMapName.AutoSize = true;
            this.szLabelMapName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.szLabelMapName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.szLabelMapName.ForeColor = System.Drawing.Color.White;
            this.szLabelMapName.Location = new System.Drawing.Point(686, 46);
            this.szLabelMapName.Name = "szLabelMapName";
            this.szLabelMapName.Size = new System.Drawing.Size(71, 15);
            this.szLabelMapName.TabIndex = 55;
            this.szLabelMapName.Text = "Map Name:";
            // 
            // szPing
            // 
            this.szPing.AutoSize = true;
            this.szPing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.szPing.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.szPing.ForeColor = System.Drawing.Color.White;
            this.szPing.Location = new System.Drawing.Point(405, 138);
            this.szPing.Name = "szPing";
            this.szPing.Size = new System.Drawing.Size(34, 15);
            this.szPing.TabIndex = 54;
            this.szPing.Text = "Ping:";
            // 
            // szPassword
            // 
            this.szPassword.AutoSize = true;
            this.szPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.szPassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.szPassword.ForeColor = System.Drawing.Color.White;
            this.szPassword.Location = new System.Drawing.Point(405, 46);
            this.szPassword.Name = "szPassword";
            this.szPassword.Size = new System.Drawing.Size(45, 15);
            this.szPassword.TabIndex = 53;
            this.szPassword.Text = "Status:";
            // 
            // szLabelPlayers
            // 
            this.szLabelPlayers.AutoSize = true;
            this.szLabelPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.szLabelPlayers.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.szLabelPlayers.ForeColor = System.Drawing.Color.White;
            this.szLabelPlayers.Location = new System.Drawing.Point(4, 139);
            this.szLabelPlayers.Name = "szLabelPlayers";
            this.szLabelPlayers.Size = new System.Drawing.Size(50, 15);
            this.szLabelPlayers.TabIndex = 52;
            this.szLabelPlayers.Text = "Players:";
            // 
            // szLabelLanguage
            // 
            this.szLabelLanguage.AutoSize = true;
            this.szLabelLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.szLabelLanguage.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.szLabelLanguage.ForeColor = System.Drawing.Color.White;
            this.szLabelLanguage.Location = new System.Drawing.Point(4, 92);
            this.szLabelLanguage.Name = "szLabelLanguage";
            this.szLabelLanguage.Size = new System.Drawing.Size(62, 15);
            this.szLabelLanguage.TabIndex = 51;
            this.szLabelLanguage.Text = "Language:";
            // 
            // szLabelGameMode
            // 
            this.szLabelGameMode.AutoSize = true;
            this.szLabelGameMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.szLabelGameMode.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.szLabelGameMode.ForeColor = System.Drawing.Color.White;
            this.szLabelGameMode.Location = new System.Drawing.Point(4, 46);
            this.szLabelGameMode.Name = "szLabelGameMode";
            this.szLabelGameMode.Size = new System.Drawing.Size(75, 15);
            this.szLabelGameMode.TabIndex = 50;
            this.szLabelGameMode.Text = "GameMode:";
            // 
            // szLabelHostName
            // 
            this.szLabelHostName.AutoSize = true;
            this.szLabelHostName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.szLabelHostName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.szLabelHostName.ForeColor = System.Drawing.Color.White;
            this.szLabelHostName.Location = new System.Drawing.Point(5, 6);
            this.szLabelHostName.Name = "szLabelHostName";
            this.szLabelHostName.Size = new System.Drawing.Size(69, 15);
            this.szLabelHostName.TabIndex = 49;
            this.szLabelHostName.Text = "HostName:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(-1, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(947, 10);
            this.panel4.TabIndex = 47;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseDown);
            this.panel4.MouseHover += new System.EventHandler(this.panel_info_MouseHover);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseMove);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseUp);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(-1, 72);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(947, 10);
            this.panel5.TabIndex = 48;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseDown);
            this.panel5.MouseHover += new System.EventHandler(this.panel_info_MouseHover);
            this.panel5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseMove);
            this.panel5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseUp);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(-1, 117);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(947, 10);
            this.panel6.TabIndex = 48;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseDown);
            this.panel6.MouseHover += new System.EventHandler(this.panel_info_MouseHover);
            this.panel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseMove);
            this.panel6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseUp);
            // 
            // labelGetZoomLevel
            // 
            this.labelGetZoomLevel.AutoSize = true;
            this.labelGetZoomLevel.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGetZoomLevel.ForeColor = System.Drawing.Color.Transparent;
            this.labelGetZoomLevel.Location = new System.Drawing.Point(595, 411);
            this.labelGetZoomLevel.Name = "labelGetZoomLevel";
            this.labelGetZoomLevel.Size = new System.Drawing.Size(41, 16);
            this.labelGetZoomLevel.TabIndex = 45;
            this.labelGetZoomLevel.Text = "Zoom:";
            // 
            // panel2ForImageView
            // 
            this.panel2ForImageView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.panel2ForImageView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2ForImageView.Controls.Add(this.buttonBigCameraImage);
            this.panel2ForImageView.Controls.Add(this.dataGridView1);
            this.panel2ForImageView.Controls.Add(this.pictureBox1);
            this.panel2ForImageView.Location = new System.Drawing.Point(12, 34);
            this.panel2ForImageView.Name = "panel2ForImageView";
            this.panel2ForImageView.Size = new System.Drawing.Size(549, 323);
            this.panel2ForImageView.TabIndex = 45;
            // 
            // buttonBigCameraImage
            // 
            this.buttonBigCameraImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.buttonBigCameraImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBigCameraImage.BackgroundImage")));
            this.buttonBigCameraImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBigCameraImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonBigCameraImage.FlatAppearance.BorderSize = 0;
            this.buttonBigCameraImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.buttonBigCameraImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.buttonBigCameraImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBigCameraImage.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBigCameraImage.ForeColor = System.Drawing.Color.White;
            this.buttonBigCameraImage.Location = new System.Drawing.Point(203, 96);
            this.buttonBigCameraImage.Name = "buttonBigCameraImage";
            this.buttonBigCameraImage.Size = new System.Drawing.Size(132, 107);
            this.buttonBigCameraImage.TabIndex = 73;
            this.buttonBigCameraImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBigCameraImage.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = "<no data>";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Cyan;
            this.dataGridView1.Location = new System.Drawing.Point(535, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(10, 319);
            this.dataGridView1.TabIndex = 78;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.MouseLeave += new System.EventHandler(this.dataGridView1_MouseLeave);
            this.dataGridView1.MouseHover += new System.EventHandler(this.dataGridView1_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(545, 319);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelForImagesList
            // 
            this.panelForImagesList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.panelForImagesList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelForImagesList.Controls.Add(this.labelImgResolution);
            this.panelForImagesList.Controls.Add(this.labelImgName);
            this.panelForImagesList.Location = new System.Drawing.Point(12, 356);
            this.panelForImagesList.Name = "panelForImagesList";
            this.panelForImagesList.Size = new System.Drawing.Size(549, 34);
            this.panelForImagesList.TabIndex = 46;
            // 
            // labelImgResolution
            // 
            this.labelImgResolution.AutoSize = true;
            this.labelImgResolution.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImgResolution.ForeColor = System.Drawing.Color.Transparent;
            this.labelImgResolution.Location = new System.Drawing.Point(3, 7);
            this.labelImgResolution.Name = "labelImgResolution";
            this.labelImgResolution.Size = new System.Drawing.Size(69, 16);
            this.labelImgResolution.TabIndex = 73;
            this.labelImgResolution.Text = "Resolution:";
            // 
            // labelImgName
            // 
            this.labelImgName.AutoSize = true;
            this.labelImgName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImgName.ForeColor = System.Drawing.Color.Transparent;
            this.labelImgName.Location = new System.Drawing.Point(267, 7);
            this.labelImgName.Name = "labelImgName";
            this.labelImgName.Size = new System.Drawing.Size(40, 16);
            this.labelImgName.TabIndex = 74;
            this.labelImgName.Text = "Name:";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel12.Controls.Add(this.szLabelGeoLongitude);
            this.panel12.Controls.Add(this.szLabelGeoLatitude);
            this.panel12.Controls.Add(this.szLabelGeoLocationName);
            this.panel12.Location = new System.Drawing.Point(986, 543);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(167, 111);
            this.panel12.TabIndex = 45;
            this.panel12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseDown);
            this.panel12.MouseHover += new System.EventHandler(this.panel_info_MouseHover);
            this.panel12.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseMove);
            this.panel12.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseUp);
            // 
            // szLabelGeoLongitude
            // 
            this.szLabelGeoLongitude.AutoSize = true;
            this.szLabelGeoLongitude.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.szLabelGeoLongitude.ForeColor = System.Drawing.Color.Transparent;
            this.szLabelGeoLongitude.Location = new System.Drawing.Point(3, 80);
            this.szLabelGeoLongitude.Name = "szLabelGeoLongitude";
            this.szLabelGeoLongitude.Size = new System.Drawing.Size(66, 16);
            this.szLabelGeoLongitude.TabIndex = 53;
            this.szLabelGeoLongitude.Text = "Longitude:";
            this.szLabelGeoLongitude.Click += new System.EventHandler(this.szLabelGeoLongitude_Click);
            // 
            // szLabelGeoLatitude
            // 
            this.szLabelGeoLatitude.AutoSize = true;
            this.szLabelGeoLatitude.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.szLabelGeoLatitude.ForeColor = System.Drawing.Color.Transparent;
            this.szLabelGeoLatitude.Location = new System.Drawing.Point(3, 46);
            this.szLabelGeoLatitude.Name = "szLabelGeoLatitude";
            this.szLabelGeoLatitude.Size = new System.Drawing.Size(55, 16);
            this.szLabelGeoLatitude.TabIndex = 52;
            this.szLabelGeoLatitude.Text = "Latitude:";
            this.szLabelGeoLatitude.Click += new System.EventHandler(this.szLabelGeoAltitude_Click);
            // 
            // szLabelGeoLocationName
            // 
            this.szLabelGeoLocationName.AutoSize = true;
            this.szLabelGeoLocationName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.szLabelGeoLocationName.ForeColor = System.Drawing.Color.Transparent;
            this.szLabelGeoLocationName.Location = new System.Drawing.Point(2, 14);
            this.szLabelGeoLocationName.Name = "szLabelGeoLocationName";
            this.szLabelGeoLocationName.Size = new System.Drawing.Size(32, 16);
            this.szLabelGeoLocationName.TabIndex = 51;
            this.szLabelGeoLocationName.Text = "City:";
            // 
            // labelinputCMD
            // 
            this.labelinputCMD.AutoSize = true;
            this.labelinputCMD.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelinputCMD.ForeColor = System.Drawing.Color.Transparent;
            this.labelinputCMD.Location = new System.Drawing.Point(464, 395);
            this.labelinputCMD.Name = "labelinputCMD";
            this.labelinputCMD.Size = new System.Drawing.Size(96, 16);
            this.labelinputCMD.TabIndex = 56;
            this.labelinputCMD.Text = ":Input Command";
            // 
            // buttonShowSettings
            // 
            this.buttonShowSettings.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonShowSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonShowSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonShowSettings.FlatAppearance.BorderSize = 0;
            this.buttonShowSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonShowSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowSettings.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowSettings.ForeColor = System.Drawing.Color.White;
            this.buttonShowSettings.Location = new System.Drawing.Point(12, 4);
            this.buttonShowSettings.Name = "buttonShowSettings";
            this.buttonShowSettings.Size = new System.Drawing.Size(91, 28);
            this.buttonShowSettings.TabIndex = 68;
            this.buttonShowSettings.Text = "Settings";
            this.buttonShowSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonShowSettings.UseVisualStyleBackColor = false;
            this.buttonShowSettings.Click += new System.EventHandler(this.buttonShowSettings_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1150, 650);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonYoutube);
            this.Controls.Add(this.buttonCheckUpdates);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonWallpaperImg);
            this.Controls.Add(this.buttonRotateImg);
            this.Controls.Add(this.buttonConnectToServer);
            this.Controls.Add(this.buttonShowSettings);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonServersListOpen);
            this.Controls.Add(this.buttonCreditsOpen);
            this.Controls.Add(this.buttonHelpMenu);
            this.Controls.Add(this.buttonLoadImage);
            this.Controls.Add(this.buttonLocateCustom);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox_Addr);
            this.Controls.Add(this.labelinputCMD);
            this.Controls.Add(this.textBox_InputCMD);
            this.Controls.Add(this.buttonClearLongitudeBox);
            this.Controls.Add(this.buttonClearAltitudeBox);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.textBoxInputLongitude);
            this.Controls.Add(this.textBoxInputAltitude);
            this.Controls.Add(this.panelForImagesList);
            this.Controls.Add(this.panel2ForImageView);
            this.Controls.Add(this.buttonIPInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCopyServerInfo);
            this.Controls.Add(this.labelGetZoomLevel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroTrackBar_MapZoom);
            this.Controls.Add(this.buttonAddMarker);
            this.Controls.Add(this.buttonSaveGeoData);
            this.Controls.Add(this.buttonTakePicture);
            this.Controls.Add(this.buttonDelAllMarkers);
            this.Controls.Add(this.buttonMarkerStyle);
            this.Controls.Add(this.gMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SA:MP Server Locator";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2ForImageView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelForImagesList.ResumeLayout(false);
            this.panelForImagesList.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.Windows.Forms.Button buttonAddMarker;
        private System.Windows.Forms.Button buttonSaveGeoData;
        private System.Windows.Forms.Button buttonTakePicture;
        private System.Windows.Forms.Button buttonDelAllMarkers;
        private System.Windows.Forms.Button buttonMarkerStyle;
        private System.Windows.Forms.ToolTip toolTip1;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar_MapZoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelGetZoomLevel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCopyServerInfo;
        private System.Windows.Forms.Button buttonIPInfo;
        private System.Windows.Forms.Panel panel2ForImageView;
        private System.Windows.Forms.Panel panelForImagesList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private MetroFramework.Controls.MetroTextBox textBoxInputAltitude;
        private MetroFramework.Controls.MetroTextBox textBoxInputLongitude;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button buttonClearAltitudeBox;
        private System.Windows.Forms.Button buttonClearLongitudeBox;
        private System.Windows.Forms.Label szWeburl;
        private System.Windows.Forms.Label szLagcomp;
        private System.Windows.Forms.Label szLabelWeather;
        private System.Windows.Forms.Label szLabelSAMPVersion;
        private System.Windows.Forms.Label szLabelMapName;
        private System.Windows.Forms.Label szPing;
        private System.Windows.Forms.Label szPassword;
        private System.Windows.Forms.Label szLabelPlayers;
        private System.Windows.Forms.Label szLabelLanguage;
        private System.Windows.Forms.Label szLabelGameMode;
        private System.Windows.Forms.Label szLabelHostName;
        private System.Windows.Forms.Label labelinputCMD;
        private MetroFramework.Controls.MetroTextBox textBox_InputCMD;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonLocateCustom;
        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.Button buttonHelpMenu;
        private System.Windows.Forms.Button buttonCreditsOpen;
        private System.Windows.Forms.Button buttonServersListOpen;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonShowSettings;
        private System.Windows.Forms.Button buttonConnectToServer;
        private System.Windows.Forms.Button buttonWallpaperImg;
        private System.Windows.Forms.Button buttonRotateImg;
        private System.Windows.Forms.Label labelImgName;
        private System.Windows.Forms.Label labelImgResolution;
        public System.Windows.Forms.Label szLabelGeoLongitude;
        public System.Windows.Forms.Label szLabelGeoLatitude;
        public System.Windows.Forms.Label szLabelGeoLocationName;
        public MetroFramework.Controls.MetroTextBox textBox_Addr;
        private System.Windows.Forms.Label labelTimeZone;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonBigCameraImage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonCheckUpdates;
        private System.Windows.Forms.Button buttonYoutube;
        private System.Windows.Forms.Button button2;
    }
}