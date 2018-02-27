namespace RoadMap
{
    partial class GraphicEditor
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
            this.TopMenu = new System.Windows.Forms.ToolStrip();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.TopMenuButtonLine = new System.Windows.Forms.ToolStripButton();
            this.TopMenuButtonRectangle = new System.Windows.Forms.ToolStripButton();
            this.TopMenuButtonEllipse = new System.Windows.Forms.ToolStripButton();
            this.TopMenuLoadButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.DrawingContest = new System.Windows.Forms.PictureBox();
            this.TopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingContest)).BeginInit();
            this.SuspendLayout();
            // 
            // TopMenu
            // 
            this.TopMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopMenu.AutoSize = false;
            this.TopMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.TopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TopMenuButtonLine,
            this.TopMenuButtonRectangle,
            this.TopMenuButtonEllipse,
            this.TopMenuLoadButton,
            this.toolStripButton1});
            this.TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Size = new System.Drawing.Size(317, 72);
            this.TopMenu.TabIndex = 0;
            this.TopMenu.Text = "Главное меню";
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.CreatePrompt = true;
            this.SaveFileDialog.FileName = "Name";
            this.SaveFileDialog.Filter = "GraphicEditorFiles|*.ge|Image File|*.bmp";
            this.SaveFileDialog.FilterIndex = 2;
            // 
            // TopMenuButtonLine
            // 
            this.TopMenuButtonLine.AutoSize = false;
            this.TopMenuButtonLine.Image = global::RoadMap.Properties.Resources.Start;
            this.TopMenuButtonLine.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TopMenuButtonLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TopMenuButtonLine.Name = "TopMenuButtonLine";
            this.TopMenuButtonLine.Size = new System.Drawing.Size(59, 55);
            this.TopMenuButtonLine.Tag = "1";
            this.TopMenuButtonLine.Click += new System.EventHandler(this.TopMenuButton_Click);
            // 
            // TopMenuButtonRectangle
            // 
            this.TopMenuButtonRectangle.AutoSize = false;
            this.TopMenuButtonRectangle.Image = global::RoadMap.Properties.Resources.Stop;
            this.TopMenuButtonRectangle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TopMenuButtonRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TopMenuButtonRectangle.Name = "TopMenuButtonRectangle";
            this.TopMenuButtonRectangle.Size = new System.Drawing.Size(59, 55);
            this.TopMenuButtonRectangle.Tag = "2";
            this.TopMenuButtonRectangle.Click += new System.EventHandler(this.TopMenuButton_Click);
            // 
            // TopMenuButtonEllipse
            // 
            this.TopMenuButtonEllipse.AutoSize = false;
            this.TopMenuButtonEllipse.Image = global::RoadMap.Properties.Resources.Chechpoint;
            this.TopMenuButtonEllipse.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TopMenuButtonEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TopMenuButtonEllipse.Name = "TopMenuButtonEllipse";
            this.TopMenuButtonEllipse.Size = new System.Drawing.Size(59, 55);
            this.TopMenuButtonEllipse.Tag = "3";
            this.TopMenuButtonEllipse.Click += new System.EventHandler(this.TopMenuButton_Click);
            // 
            // TopMenuLoadButton
            // 
            this.TopMenuLoadButton.AutoSize = false;
            this.TopMenuLoadButton.Image = global::RoadMap.Properties.Resources.Wathcmen;
            this.TopMenuLoadButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TopMenuLoadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TopMenuLoadButton.Name = "TopMenuLoadButton";
            this.TopMenuLoadButton.Size = new System.Drawing.Size(59, 55);
            this.TopMenuLoadButton.Tag = "4";
            this.TopMenuLoadButton.Click += new System.EventHandler(this.TopMenuButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::RoadMap.Properties.Resources.SaveFile;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(59, 55);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.TopMenuSaveButton_Click);
            // 
            // DrawingContest
            // 
            this.DrawingContest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DrawingContest.BackColor = System.Drawing.SystemColors.Window;
            this.DrawingContest.BackgroundImage = global::RoadMap.Properties.Resources.Снимок;
            this.DrawingContest.ErrorImage = null;
            this.DrawingContest.Image = global::RoadMap.Properties.Resources.Снимок;
            this.DrawingContest.InitialImage = global::RoadMap.Properties.Resources.Снимок;
            this.DrawingContest.Location = new System.Drawing.Point(0, 0);
            this.DrawingContest.Name = "DrawingContest";
            this.DrawingContest.Size = new System.Drawing.Size(1008, 761);
            this.DrawingContest.TabIndex = 1;
            this.DrawingContest.TabStop = false;
            this.DrawingContest.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingContest_Paint);
            this.DrawingContest.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingContest_MouseDown);
            this.DrawingContest.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawingContest_MouseMove);
            this.DrawingContest.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawingContest_MouseUp);
            // 
            // GraphicEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 761);
            this.Controls.Add(this.TopMenu);
            this.Controls.Add(this.DrawingContest);
            this.Name = "GraphicEditor";
            this.Text = "GraphicEditor";
            this.TopMenu.ResumeLayout(false);
            this.TopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingContest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripButton TopMenuButtonLine;
        private System.Windows.Forms.ToolStripButton TopMenuButtonRectangle;
        private System.Windows.Forms.ToolStripButton TopMenuButtonEllipse;
        protected System.Windows.Forms.ToolStrip TopMenu;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.ToolStripButton TopMenuLoadButton;
        public System.Windows.Forms.PictureBox DrawingContest;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

