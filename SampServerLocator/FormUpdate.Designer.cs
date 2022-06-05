namespace SampServerLocator
{
    partial class FormUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdate));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel12 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonDownloadUpdate = new System.Windows.Forms.Button();
            this.szLabelProgress = new System.Windows.Forms.Label();
            this.szLabelUpdateChecker = new System.Windows.Forms.Label();
            this.szLabelVersion = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonPathChoose = new System.Windows.Forms.Button();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.progressBar1.Location = new System.Drawing.Point(52, 69);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(371, 23);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Visible = false;
            this.progressBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseDown);
            this.progressBar1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseMove);
            this.progressBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseUp);
            // 
            // panel12
            // 
            this.panel12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panel12.Controls.Add(this.labelTitle);
            this.panel12.Controls.Add(this.button5);
            this.panel12.Controls.Add(this.button6);
            this.panel12.Location = new System.Drawing.Point(-1, -3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(499, 43);
            this.panel12.TabIndex = 75;
            this.panel12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseDown);
            this.panel12.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseMove);
            this.panel12.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseUp);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Transparent;
            this.labelTitle.Location = new System.Drawing.Point(7, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(86, 22);
            this.labelTitle.TabIndex = 64;
            this.labelTitle.Text = "Updates";
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseDown);
            this.labelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseMove);
            this.labelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseUp);
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
            this.button5.Location = new System.Drawing.Point(468, 8);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(28, 23);
            this.button5.TabIndex = 70;
            this.button5.Text = "X";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            this.button6.Location = new System.Drawing.Point(438, 8);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(28, 23);
            this.button6.TabIndex = 69;
            this.button6.Text = "_";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonDownloadUpdate
            // 
            this.buttonDownloadUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDownloadUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonDownloadUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDownloadUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDownloadUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDownloadUpdate.FlatAppearance.BorderSize = 0;
            this.buttonDownloadUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonDownloadUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDownloadUpdate.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownloadUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonDownloadUpdate.Location = new System.Drawing.Point(165, 129);
            this.buttonDownloadUpdate.Name = "buttonDownloadUpdate";
            this.buttonDownloadUpdate.Size = new System.Drawing.Size(150, 32);
            this.buttonDownloadUpdate.TabIndex = 76;
            this.buttonDownloadUpdate.Text = "Download latest Version";
            this.buttonDownloadUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDownloadUpdate.UseVisualStyleBackColor = false;
            this.buttonDownloadUpdate.Click += new System.EventHandler(this.buttonDownloadUpdate_Click);
            // 
            // szLabelProgress
            // 
            this.szLabelProgress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.szLabelProgress.AutoSize = true;
            this.szLabelProgress.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.szLabelProgress.ForeColor = System.Drawing.Color.Transparent;
            this.szLabelProgress.Location = new System.Drawing.Point(426, 72);
            this.szLabelProgress.Name = "szLabelProgress";
            this.szLabelProgress.Size = new System.Drawing.Size(39, 16);
            this.szLabelProgress.TabIndex = 71;
            this.szLabelProgress.Text = "100%";
            this.szLabelProgress.Visible = false;
            this.szLabelProgress.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseDown);
            this.szLabelProgress.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseMove);
            this.szLabelProgress.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseUp);
            // 
            // szLabelUpdateChecker
            // 
            this.szLabelUpdateChecker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.szLabelUpdateChecker.AutoSize = true;
            this.szLabelUpdateChecker.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.szLabelUpdateChecker.ForeColor = System.Drawing.Color.Transparent;
            this.szLabelUpdateChecker.Location = new System.Drawing.Point(51, 47);
            this.szLabelUpdateChecker.Name = "szLabelUpdateChecker";
            this.szLabelUpdateChecker.Size = new System.Drawing.Size(134, 14);
            this.szLabelUpdateChecker.TabIndex = 71;
            this.szLabelUpdateChecker.Text = "No new updates found.";
            this.szLabelUpdateChecker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseDown);
            this.szLabelUpdateChecker.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseMove);
            this.szLabelUpdateChecker.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseUp);
            // 
            // szLabelVersion
            // 
            this.szLabelVersion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.szLabelVersion.AutoSize = true;
            this.szLabelVersion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.szLabelVersion.ForeColor = System.Drawing.Color.Transparent;
            this.szLabelVersion.Location = new System.Drawing.Point(424, 147);
            this.szLabelVersion.Name = "szLabelVersion";
            this.szLabelVersion.Size = new System.Drawing.Size(71, 14);
            this.szLabelVersion.TabIndex = 77;
            this.szLabelVersion.Text = "Version: 1.3";
            this.szLabelVersion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseDown);
            this.szLabelVersion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseMove);
            this.szLabelVersion.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseUp);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.textBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(52, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(371, 22);
            this.textBox1.TabIndex = 78;
            this.textBox1.Text = "https://download938.mediafire.com/7a4b7lf41icg/6evini6nalc5ys2/SampServerLocator." +
    "rar";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.textBoxPath.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPath.ForeColor = System.Drawing.Color.White;
            this.textBoxPath.Location = new System.Drawing.Point(52, 70);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(263, 22);
            this.textBoxPath.TabIndex = 79;
            // 
            // buttonPathChoose
            // 
            this.buttonPathChoose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonPathChoose.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonPathChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPathChoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPathChoose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonPathChoose.FlatAppearance.BorderSize = 0;
            this.buttonPathChoose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonPathChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPathChoose.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPathChoose.ForeColor = System.Drawing.Color.White;
            this.buttonPathChoose.Location = new System.Drawing.Point(321, 70);
            this.buttonPathChoose.Name = "buttonPathChoose";
            this.buttonPathChoose.Size = new System.Drawing.Size(102, 22);
            this.buttonPathChoose.TabIndex = 80;
            this.buttonPathChoose.Text = "Select Save Path";
            this.buttonPathChoose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonPathChoose.UseVisualStyleBackColor = false;
            this.buttonPathChoose.Click += new System.EventHandler(this.buttonPathChoose_Click);
            // 
            // FormUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(495, 167);
            this.Controls.Add(this.buttonPathChoose);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.szLabelVersion);
            this.Controls.Add(this.szLabelUpdateChecker);
            this.Controls.Add(this.szLabelProgress);
            this.Controls.Add(this.buttonDownloadUpdate);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.progressBar1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
            this.Load += new System.EventHandler(this.FormUpdate_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ThisForm_MouseUp);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonDownloadUpdate;
        private System.Windows.Forms.Label szLabelProgress;
        private System.Windows.Forms.Label szLabelUpdateChecker;
        private System.Windows.Forms.Label szLabelVersion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonPathChoose;
    }
}