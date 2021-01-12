namespace WSR_Tool
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.maketransparentBtn = new FlatUI.FlatButton();
            this.defaultTaskbarBtn = new FlatUI.FlatButton();
            this.removeBtn = new FlatUI.FlatButton();
            this.restoreBtn = new FlatUI.FlatButton();
            this.topPanel = new System.Windows.Forms.Panel();
            this.minusBtn = new System.Windows.Forms.Button();
            this.titleLbl = new System.Windows.Forms.Label();
            this.xBtn = new System.Windows.Forms.Button();
            this.flatTabControl1 = new FlatUI.FlatTabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.discordLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.versionLbl = new System.Windows.Forms.Label();
            this.activateWin = new FlatUI.FlatButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.topPanel.SuspendLayout();
            this.flatTabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discordLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // maketransparentBtn
            // 
            this.maketransparentBtn.BackColor = System.Drawing.Color.Transparent;
            this.maketransparentBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.maketransparentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maketransparentBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.maketransparentBtn.Location = new System.Drawing.Point(34, 33);
            this.maketransparentBtn.Name = "maketransparentBtn";
            this.maketransparentBtn.Rounded = true;
            this.maketransparentBtn.Size = new System.Drawing.Size(268, 43);
            this.maketransparentBtn.TabIndex = 6;
            this.maketransparentBtn.Text = "Make Taskbar Transparent";
            this.maketransparentBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.maketransparentBtn.UseCustomColor = false;
            this.maketransparentBtn.Click += new System.EventHandler(this.maketransparentBtn_Click);
            // 
            // defaultTaskbarBtn
            // 
            this.defaultTaskbarBtn.BackColor = System.Drawing.Color.Transparent;
            this.defaultTaskbarBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.defaultTaskbarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.defaultTaskbarBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.defaultTaskbarBtn.Location = new System.Drawing.Point(34, 82);
            this.defaultTaskbarBtn.Name = "defaultTaskbarBtn";
            this.defaultTaskbarBtn.Rounded = true;
            this.defaultTaskbarBtn.Size = new System.Drawing.Size(268, 43);
            this.defaultTaskbarBtn.TabIndex = 7;
            this.defaultTaskbarBtn.Text = "Default Taskbar";
            this.defaultTaskbarBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.defaultTaskbarBtn.UseCustomColor = false;
            this.defaultTaskbarBtn.Click += new System.EventHandler(this.defaultTaskbarBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.Transparent;
            this.removeBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.removeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.removeBtn.Location = new System.Drawing.Point(34, 170);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Rounded = true;
            this.removeBtn.Size = new System.Drawing.Size(268, 43);
            this.removeBtn.TabIndex = 8;
            this.removeBtn.Text = "Remove Shortcut Arrows";
            this.removeBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.removeBtn.UseCustomColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // restoreBtn
            // 
            this.restoreBtn.BackColor = System.Drawing.Color.Transparent;
            this.restoreBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.restoreBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restoreBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.restoreBtn.Location = new System.Drawing.Point(34, 219);
            this.restoreBtn.Name = "restoreBtn";
            this.restoreBtn.Rounded = true;
            this.restoreBtn.Size = new System.Drawing.Size(268, 43);
            this.restoreBtn.TabIndex = 9;
            this.restoreBtn.Text = "Restore Default Shortcut Arrows";
            this.restoreBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.restoreBtn.UseCustomColor = false;
            this.restoreBtn.Click += new System.EventHandler(this.restoreBtn_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.topPanel.Controls.Add(this.minusBtn);
            this.topPanel.Controls.Add(this.titleLbl);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(345, 35);
            this.topPanel.TabIndex = 0;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // minusBtn
            // 
            this.minusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.minusBtn.FlatAppearance.BorderSize = 0;
            this.minusBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.minusBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.minusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.minusBtn.Location = new System.Drawing.Point(274, 0);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(35, 35);
            this.minusBtn.TabIndex = 9;
            this.minusBtn.TabStop = false;
            this.minusBtn.Text = "—";
            this.minusBtn.UseVisualStyleBackColor = false;
            this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.titleLbl.Location = new System.Drawing.Point(12, 5);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(97, 24);
            this.titleLbl.TabIndex = 10;
            this.titleLbl.Text = "WSR-Tool";
            // 
            // xBtn
            // 
            this.xBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.xBtn.FlatAppearance.BorderSize = 0;
            this.xBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.xBtn.Location = new System.Drawing.Point(310, 0);
            this.xBtn.Name = "xBtn";
            this.xBtn.Size = new System.Drawing.Size(35, 35);
            this.xBtn.TabIndex = 8;
            this.xBtn.TabStop = false;
            this.xBtn.Text = "X";
            this.xBtn.UseVisualStyleBackColor = false;
            this.xBtn.Click += new System.EventHandler(this.xBtn_Click);
            // 
            // flatTabControl1
            // 
            this.flatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatTabControl1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatTabControl1.Controls.Add(this.tabPage3);
            this.flatTabControl1.Controls.Add(this.tabPage2);
            this.flatTabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatTabControl1.ItemSize = new System.Drawing.Size(120, 40);
            this.flatTabControl1.Location = new System.Drawing.Point(0, 32);
            this.flatTabControl1.Name = "flatTabControl1";
            this.flatTabControl1.SelectedIndex = 0;
            this.flatTabControl1.Size = new System.Drawing.Size(342, 343);
            this.flatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.flatTabControl1.TabIndex = 10;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage3.Controls.Add(this.discordLogo);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Controls.Add(this.versionLbl);
            this.tabPage3.Controls.Add(this.activateWin);
            this.tabPage3.Location = new System.Drawing.Point(4, 44);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(334, 295);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Home";
            // 
            // discordLogo
            // 
            this.discordLogo.Image = ((System.Drawing.Image)(resources.GetObject("discordLogo.Image")));
            this.discordLogo.Location = new System.Drawing.Point(298, 258);
            this.discordLogo.Name = "discordLogo";
            this.discordLogo.Size = new System.Drawing.Size(30, 30);
            this.discordLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.discordLogo.TabIndex = 13;
            this.discordLogo.TabStop = false;
            this.discordLogo.Click += new System.EventHandler(this.discordLogo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(90, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // versionLbl
            // 
            this.versionLbl.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.versionLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.versionLbl.Location = new System.Drawing.Point(8, 258);
            this.versionLbl.Name = "versionLbl";
            this.versionLbl.Size = new System.Drawing.Size(167, 25);
            this.versionLbl.TabIndex = 11;
            this.versionLbl.Text = "N/A";
            // 
            // activateWin
            // 
            this.activateWin.BackColor = System.Drawing.Color.Transparent;
            this.activateWin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.activateWin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.activateWin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.activateWin.Location = new System.Drawing.Point(34, 191);
            this.activateWin.Name = "activateWin";
            this.activateWin.Rounded = true;
            this.activateWin.Size = new System.Drawing.Size(268, 43);
            this.activateWin.TabIndex = 10;
            this.activateWin.Text = "Hide Windows Activation";
            this.activateWin.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.activateWin.UseCustomColor = false;
            this.activateWin.Click += new System.EventHandler(this.blankNames_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage2.Controls.Add(this.maketransparentBtn);
            this.tabPage2.Controls.Add(this.defaultTaskbarBtn);
            this.tabPage2.Controls.Add(this.restoreBtn);
            this.tabPage2.Controls.Add(this.removeBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(334, 295);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "More";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(344, 376);
            this.Controls.Add(this.xBtn);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.flatTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WSR-Tool";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.main_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.flatTabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.discordLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FlatUI.FlatButton maketransparentBtn;
        private FlatUI.FlatButton defaultTaskbarBtn;
        private FlatUI.FlatButton removeBtn;
        private FlatUI.FlatButton restoreBtn;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button xBtn;
        private System.Windows.Forms.Label titleLbl;
        private FlatUI.FlatTabControl flatTabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private FlatUI.FlatButton activateWin;
        private System.Windows.Forms.Label versionLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox discordLogo;
    }
}

