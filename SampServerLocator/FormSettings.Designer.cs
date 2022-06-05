namespace SampServerLocator
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.buttonCustomName = new System.Windows.Forms.Button();
            this.labelTitle1 = new System.Windows.Forms.Label();
            this.buttonMinimzeONConnect = new System.Windows.Forms.Button();
            this.buttonCopyPlayerName = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox_InputCustomName = new MetroFramework.Controls.MetroTextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonShutdownGame = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonRefreshSrvQuery = new System.Windows.Forms.Button();
            this.buttonRefreshIPInfo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.metroTextBoxShutdownTimeInput = new MetroFramework.Controls.MetroTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonEraseShutdownBox = new System.Windows.Forms.Button();
            this.buttonEraseNameBox = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCustomName
            // 
            this.buttonCustomName.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonCustomName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCustomName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustomName.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCustomName.FlatAppearance.BorderSize = 0;
            this.buttonCustomName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonCustomName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustomName.ForeColor = System.Drawing.Color.White;
            this.buttonCustomName.Location = new System.Drawing.Point(158, 109);
            this.buttonCustomName.Name = "buttonCustomName";
            this.buttonCustomName.Size = new System.Drawing.Size(128, 33);
            this.buttonCustomName.TabIndex = 63;
            this.buttonCustomName.Text = "Use Custom Name";
            this.buttonCustomName.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.buttonCustomName, "Instead of using name from registry\r\nthis allows you to input your own custom nam" +
        "e\r\n");
            this.buttonCustomName.UseVisualStyleBackColor = false;
            this.buttonCustomName.Click += new System.EventHandler(this.buttonCustomName_Click);
            // 
            // labelTitle1
            // 
            this.labelTitle1.AutoSize = true;
            this.labelTitle1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle1.ForeColor = System.Drawing.Color.Transparent;
            this.labelTitle1.Location = new System.Drawing.Point(7, 9);
            this.labelTitle1.Name = "labelTitle1";
            this.labelTitle1.Size = new System.Drawing.Size(86, 22);
            this.labelTitle1.TabIndex = 64;
            this.labelTitle1.Text = "Settings";
            this.labelTitle1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseDown);
            this.labelTitle1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseMove);
            this.labelTitle1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseUp);
            // 
            // buttonMinimzeONConnect
            // 
            this.buttonMinimzeONConnect.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonMinimzeONConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMinimzeONConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimzeONConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonMinimzeONConnect.FlatAppearance.BorderSize = 0;
            this.buttonMinimzeONConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonMinimzeONConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimzeONConnect.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimzeONConnect.ForeColor = System.Drawing.Color.White;
            this.buttonMinimzeONConnect.Location = new System.Drawing.Point(158, 177);
            this.buttonMinimzeONConnect.Name = "buttonMinimzeONConnect";
            this.buttonMinimzeONConnect.Size = new System.Drawing.Size(128, 33);
            this.buttonMinimzeONConnect.TabIndex = 65;
            this.buttonMinimzeONConnect.Text = "Minimize on Connect";
            this.buttonMinimzeONConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.buttonMinimzeONConnect, "Minimize all windows when you connect to some server");
            this.buttonMinimzeONConnect.UseVisualStyleBackColor = false;
            this.buttonMinimzeONConnect.Click += new System.EventHandler(this.buttonMinimzeONConnect_Click);
            // 
            // buttonCopyPlayerName
            // 
            this.buttonCopyPlayerName.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonCopyPlayerName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCopyPlayerName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCopyPlayerName.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCopyPlayerName.FlatAppearance.BorderSize = 0;
            this.buttonCopyPlayerName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonCopyPlayerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCopyPlayerName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCopyPlayerName.ForeColor = System.Drawing.Color.White;
            this.buttonCopyPlayerName.Location = new System.Drawing.Point(60, 147);
            this.buttonCopyPlayerName.Name = "buttonCopyPlayerName";
            this.buttonCopyPlayerName.Size = new System.Drawing.Size(80, 24);
            this.buttonCopyPlayerName.TabIndex = 67;
            this.buttonCopyPlayerName.Text = "Copy Name";
            this.buttonCopyPlayerName.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.buttonCopyPlayerName, "Copy player name to clipboard");
            this.buttonCopyPlayerName.UseVisualStyleBackColor = false;
            this.buttonCopyPlayerName.Click += new System.EventHandler(this.buttonCopyPlayerName_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(415, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(28, 23);
            this.button5.TabIndex = 70;
            this.button5.Text = "X";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.button5, "Exit");
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(385, 10);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(28, 23);
            this.button6.TabIndex = 69;
            this.button6.Text = "_";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.button6, "Minimize");
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox_InputCustomName
            // 
            this.textBox_InputCustomName.Location = new System.Drawing.Point(141, 148);
            this.textBox_InputCustomName.MaxLength = 21;
            this.textBox_InputCustomName.Name = "textBox_InputCustomName";
            this.textBox_InputCustomName.Size = new System.Drawing.Size(184, 23);
            this.textBox_InputCustomName.TabIndex = 71;
            this.textBox_InputCustomName.Text = "Input new name";
            // 
            // panel12
            // 
            this.panel12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panel12.Controls.Add(this.labelTitle1);
            this.panel12.Controls.Add(this.button5);
            this.panel12.Controls.Add(this.button6);
            this.panel12.Location = new System.Drawing.Point(3, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(446, 45);
            this.panel12.TabIndex = 74;
            this.panel12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseDown);
            this.panel12.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseMove);
            this.panel12.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseUp);
            // 
            // buttonShutdownGame
            // 
            this.buttonShutdownGame.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonShutdownGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonShutdownGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShutdownGame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonShutdownGame.FlatAppearance.BorderSize = 0;
            this.buttonShutdownGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonShutdownGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShutdownGame.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShutdownGame.ForeColor = System.Drawing.Color.White;
            this.buttonShutdownGame.Location = new System.Drawing.Point(158, 237);
            this.buttonShutdownGame.Name = "buttonShutdownGame";
            this.buttonShutdownGame.Size = new System.Drawing.Size(128, 33);
            this.buttonShutdownGame.TabIndex = 75;
            this.buttonShutdownGame.Text = "Shutdown";
            this.buttonShutdownGame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.buttonShutdownGame, "Shutdown game on time");
            this.buttonShutdownGame.UseVisualStyleBackColor = false;
            this.buttonShutdownGame.Click += new System.EventHandler(this.buttonShutdownGame_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(158, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 33);
            this.button1.TabIndex = 78;
            this.button1.Text = "Exit Game";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.button1, "Close GTA window");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonExitGame_Click);
            // 
            // buttonRefreshSrvQuery
            // 
            this.buttonRefreshSrvQuery.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonRefreshSrvQuery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRefreshSrvQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefreshSrvQuery.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRefreshSrvQuery.FlatAppearance.BorderSize = 0;
            this.buttonRefreshSrvQuery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonRefreshSrvQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefreshSrvQuery.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefreshSrvQuery.ForeColor = System.Drawing.Color.White;
            this.buttonRefreshSrvQuery.Location = new System.Drawing.Point(93, 383);
            this.buttonRefreshSrvQuery.Name = "buttonRefreshSrvQuery";
            this.buttonRefreshSrvQuery.Size = new System.Drawing.Size(128, 33);
            this.buttonRefreshSrvQuery.TabIndex = 79;
            this.buttonRefreshSrvQuery.Text = "Refresh Server Query";
            this.buttonRefreshSrvQuery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.buttonRefreshSrvQuery, "Minimize all windows when you connect to some server");
            this.buttonRefreshSrvQuery.UseVisualStyleBackColor = false;
            this.buttonRefreshSrvQuery.Click += new System.EventHandler(this.buttonRefreshSrvQuery_Click);
            // 
            // buttonRefreshIPInfo
            // 
            this.buttonRefreshIPInfo.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonRefreshIPInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRefreshIPInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefreshIPInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRefreshIPInfo.FlatAppearance.BorderSize = 0;
            this.buttonRefreshIPInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonRefreshIPInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefreshIPInfo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefreshIPInfo.ForeColor = System.Drawing.Color.White;
            this.buttonRefreshIPInfo.Location = new System.Drawing.Point(227, 383);
            this.buttonRefreshIPInfo.Name = "buttonRefreshIPInfo";
            this.buttonRefreshIPInfo.Size = new System.Drawing.Size(128, 33);
            this.buttonRefreshIPInfo.TabIndex = 80;
            this.buttonRefreshIPInfo.Text = "Refresh IP Info";
            this.buttonRefreshIPInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.buttonRefreshIPInfo, "Minimize all windows when you connect to some server");
            this.buttonRefreshIPInfo.UseVisualStyleBackColor = false;
            this.buttonRefreshIPInfo.Click += new System.EventHandler(this.buttonRefreshIPInfo_Click);
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
            this.button2.Location = new System.Drawing.Point(93, 479);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 33);
            this.button2.TabIndex = 81;
            this.button2.Text = "https://ipapi.co/";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.button2, "Minimize all windows when you connect to some server");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(227, 479);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 33);
            this.button3.TabIndex = 82;
            this.button3.Text = "https://ipinfo.io/";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.button3, "Minimize all windows when you connect to some server");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // metroTextBoxShutdownTimeInput
            // 
            this.metroTextBoxShutdownTimeInput.Location = new System.Drawing.Point(126, 276);
            this.metroTextBoxShutdownTimeInput.MaxLength = 10;
            this.metroTextBoxShutdownTimeInput.Name = "metroTextBoxShutdownTimeInput";
            this.metroTextBoxShutdownTimeInput.Size = new System.Drawing.Size(184, 23);
            this.metroTextBoxShutdownTimeInput.TabIndex = 76;
            this.metroTextBoxShutdownTimeInput.Text = "Input Time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonEraseShutdownBox
            // 
            this.buttonEraseShutdownBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.buttonEraseShutdownBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEraseShutdownBox.BackgroundImage")));
            this.buttonEraseShutdownBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEraseShutdownBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEraseShutdownBox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonEraseShutdownBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonEraseShutdownBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEraseShutdownBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEraseShutdownBox.ForeColor = System.Drawing.Color.White;
            this.buttonEraseShutdownBox.Location = new System.Drawing.Point(311, 275);
            this.buttonEraseShutdownBox.Name = "buttonEraseShutdownBox";
            this.buttonEraseShutdownBox.Size = new System.Drawing.Size(31, 24);
            this.buttonEraseShutdownBox.TabIndex = 77;
            this.buttonEraseShutdownBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEraseShutdownBox.UseVisualStyleBackColor = false;
            this.buttonEraseShutdownBox.Click += new System.EventHandler(this.buttonEraseShutdownBox_Click);
            // 
            // buttonEraseNameBox
            // 
            this.buttonEraseNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.buttonEraseNameBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEraseNameBox.BackgroundImage")));
            this.buttonEraseNameBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEraseNameBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEraseNameBox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonEraseNameBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonEraseNameBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEraseNameBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEraseNameBox.ForeColor = System.Drawing.Color.White;
            this.buttonEraseNameBox.Location = new System.Drawing.Point(324, 148);
            this.buttonEraseNameBox.Name = "buttonEraseNameBox";
            this.buttonEraseNameBox.Size = new System.Drawing.Size(31, 24);
            this.buttonEraseNameBox.TabIndex = 73;
            this.buttonEraseNameBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEraseNameBox.UseVisualStyleBackColor = false;
            this.buttonEraseNameBox.Click += new System.EventHandler(this.buttonEraseNameBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(143, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 22);
            this.label1.TabIndex = 71;
            this.label1.Text = "IP Geo Providers";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(104, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 22);
            this.label2.TabIndex = 83;
            this.label2.Text = "Refresh Button Options";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseMove);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(154, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 22);
            this.label3.TabIndex = 84;
            this.label3.Text = "Game Options";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseMove);
            this.label3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseUp);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(451, 516);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRefreshIPInfo);
            this.Controls.Add(this.buttonRefreshSrvQuery);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonEraseShutdownBox);
            this.Controls.Add(this.metroTextBoxShutdownTimeInput);
            this.Controls.Add(this.buttonShutdownGame);
            this.Controls.Add(this.buttonEraseNameBox);
            this.Controls.Add(this.textBox_InputCustomName);
            this.Controls.Add(this.buttonCopyPlayerName);
            this.Controls.Add(this.buttonMinimzeONConnect);
            this.Controls.Add(this.buttonCustomName);
            this.Controls.Add(this.panel12);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.Opacity = 0.98D;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseUp);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCustomName;
        private System.Windows.Forms.Label labelTitle1;
        private System.Windows.Forms.Button buttonMinimzeONConnect;
        private System.Windows.Forms.Button buttonCopyPlayerName;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonEraseNameBox;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.ToolTip toolTip1;
        public MetroFramework.Controls.MetroTextBox textBox_InputCustomName;
        private System.Windows.Forms.Button buttonShutdownGame;
        private System.Windows.Forms.Button buttonEraseShutdownBox;
        public MetroFramework.Controls.MetroTextBox metroTextBoxShutdownTimeInput;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonRefreshSrvQuery;
        private System.Windows.Forms.Button buttonRefreshIPInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}