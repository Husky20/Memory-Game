namespace Memo {
    partial class Menu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.labelTitleChildForm = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButtonStart = new FontAwesome.Sharp.IconButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButtonContact = new FontAwesome.Sharp.IconButton();
            this.iconButtonHardLevel = new FontAwesome.Sharp.IconButton();
            this.iconButtonEasyLevel = new FontAwesome.Sharp.IconButton();
            this.iconButtonZasady = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNHome = new FontAwesome.Sharp.IconButton();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.exitBtn = new FontAwesome.Sharp.IconButton();
            this.maximizeBtn = new FontAwesome.Sharp.IconButton();
            this.minimizeBtn = new FontAwesome.Sharp.IconButton();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelDesktop.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitleChildForm
            // 
            this.labelTitleChildForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitleChildForm.AutoSize = true;
            this.labelTitleChildForm.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleChildForm.Location = new System.Drawing.Point(383, 13);
            this.labelTitleChildForm.Name = "labelTitleChildForm";
            this.labelTitleChildForm.Size = new System.Drawing.Size(374, 52);
            this.labelTitleChildForm.TabIndex = 0;
            this.labelTitleChildForm.Text = "Witaj w grze memo!!!";
            this.labelTitleChildForm.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(459, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(680, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zdecyduj który poziom rozgrywki wybierasz";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(438, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(715, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "wciśnij start wciśnij start i ćwicz swoją pamięć";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(216)))), ((int)(((byte)(217)))));
            this.panelDesktop.Controls.Add(this.iconButton1);
            this.panelDesktop.Controls.Add(this.iconButtonStart);
            this.panelDesktop.Controls.Add(this.label3);
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1332, 653);
            this.panelDesktop.TabIndex = 5;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(216)))), ((int)(((byte)(217)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.BookDead;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 95;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.Location = new System.Drawing.Point(818, 359);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(274, 169);
            this.iconButton1.TabIndex = 7;
            this.iconButton1.Text = "Zabójczo trudna rozgrywka";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // iconButtonStart
            // 
            this.iconButtonStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(216)))), ((int)(((byte)(217)))));
            this.iconButtonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonStart.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.iconButtonStart.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.iconButtonStart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonStart.IconSize = 90;
            this.iconButtonStart.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonStart.Location = new System.Drawing.Point(486, 358);
            this.iconButtonStart.Name = "iconButtonStart";
            this.iconButtonStart.Size = new System.Drawing.Size(274, 169);
            this.iconButtonStart.TabIndex = 6;
            this.iconButtonStart.Text = "Łatwa gra";
            this.iconButtonStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButtonStart.UseVisualStyleBackColor = true;
            this.iconButtonStart.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.CadetBlue;
            this.panelMenu.Controls.Add(this.iconButtonContact);
            this.panelMenu.Controls.Add(this.iconButtonHardLevel);
            this.panelMenu.Controls.Add(this.iconButtonEasyLevel);
            this.panelMenu.Controls.Add(this.iconButtonZasady);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 653);
            this.panelMenu.TabIndex = 6;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // iconButtonContact
            // 
            this.iconButtonContact.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonContact.FlatAppearance.BorderSize = 0;
            this.iconButtonContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonContact.IconChar = FontAwesome.Sharp.IconChar.Headset;
            this.iconButtonContact.IconColor = System.Drawing.Color.Black;
            this.iconButtonContact.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonContact.IconSize = 32;
            this.iconButtonContact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonContact.Location = new System.Drawing.Point(0, 288);
            this.iconButtonContact.Name = "iconButtonContact";
            this.iconButtonContact.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonContact.Size = new System.Drawing.Size(230, 67);
            this.iconButtonContact.TabIndex = 4;
            this.iconButtonContact.Text = "Kontakt";
            this.iconButtonContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonContact.UseVisualStyleBackColor = true;
            this.iconButtonContact.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconButtonHardLevel
            // 
            this.iconButtonHardLevel.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonHardLevel.FlatAppearance.BorderSize = 0;
            this.iconButtonHardLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonHardLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonHardLevel.IconChar = FontAwesome.Sharp.IconChar.BookDead;
            this.iconButtonHardLevel.IconColor = System.Drawing.Color.Black;
            this.iconButtonHardLevel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonHardLevel.IconSize = 32;
            this.iconButtonHardLevel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonHardLevel.Location = new System.Drawing.Point(0, 221);
            this.iconButtonHardLevel.Name = "iconButtonHardLevel";
            this.iconButtonHardLevel.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonHardLevel.Size = new System.Drawing.Size(230, 67);
            this.iconButtonHardLevel.TabIndex = 3;
            this.iconButtonHardLevel.Text = "Poziom trudny";
            this.iconButtonHardLevel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonHardLevel.UseVisualStyleBackColor = true;
            this.iconButtonHardLevel.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButtonEasyLevel
            // 
            this.iconButtonEasyLevel.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonEasyLevel.FlatAppearance.BorderSize = 0;
            this.iconButtonEasyLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonEasyLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonEasyLevel.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.iconButtonEasyLevel.IconColor = System.Drawing.Color.Black;
            this.iconButtonEasyLevel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonEasyLevel.IconSize = 32;
            this.iconButtonEasyLevel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonEasyLevel.Location = new System.Drawing.Point(0, 154);
            this.iconButtonEasyLevel.Name = "iconButtonEasyLevel";
            this.iconButtonEasyLevel.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonEasyLevel.Size = new System.Drawing.Size(230, 67);
            this.iconButtonEasyLevel.TabIndex = 2;
            this.iconButtonEasyLevel.Text = "Poziom łatwy";
            this.iconButtonEasyLevel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonEasyLevel.UseVisualStyleBackColor = true;
            this.iconButtonEasyLevel.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButtonZasady
            // 
            this.iconButtonZasady.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonZasady.FlatAppearance.BorderSize = 0;
            this.iconButtonZasady.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonZasady.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonZasady.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.iconButtonZasady.IconColor = System.Drawing.Color.Black;
            this.iconButtonZasady.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonZasady.IconSize = 32;
            this.iconButtonZasady.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonZasady.Location = new System.Drawing.Point(0, 87);
            this.iconButtonZasady.Name = "iconButtonZasady";
            this.iconButtonZasady.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonZasady.Size = new System.Drawing.Size(230, 67);
            this.iconButtonZasady.TabIndex = 1;
            this.iconButtonZasady.Text = "Zasady gry";
            this.iconButtonZasady.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonZasady.UseVisualStyleBackColor = true;
            this.iconButtonZasady.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.BTNHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 87);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // BTNHome
            // 
            this.BTNHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(127)))), ((int)(((byte)(129)))));
            this.BTNHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.BTNHome.FlatAppearance.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.BTNHome.FlatAppearance.BorderSize = 0;
            this.BTNHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNHome.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.BTNHome.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BTNHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(18)))));
            this.BTNHome.IconChar = FontAwesome.Sharp.IconChar.Dice;
            this.BTNHome.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(18)))));
            this.BTNHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTNHome.Location = new System.Drawing.Point(0, 0);
            this.BTNHome.Name = "BTNHome";
            this.BTNHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BTNHome.Size = new System.Drawing.Size(230, 87);
            this.BTNHome.TabIndex = 1;
            this.BTNHome.Text = "MEMO GAME";
            this.BTNHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BTNHome.UseVisualStyleBackColor = false;
            this.BTNHome.Click += new System.EventHandler(this.BTNHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.panelTitleBar.Controls.Add(this.exitBtn);
            this.panelTitleBar.Controls.Add(this.maximizeBtn);
            this.panelTitleBar.Controls.Add(this.minimizeBtn);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Controls.Add(this.labelTitleChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(230, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1102, 87);
            this.panelTitleBar.TabIndex = 7;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.exitBtn.IconColor = System.Drawing.Color.Black;
            this.exitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitBtn.IconSize = 30;
            this.exitBtn.Location = new System.Drawing.Point(1049, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Rotation = 45D;
            this.exitBtn.Size = new System.Drawing.Size(50, 35);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // maximizeBtn
            // 
            this.maximizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeBtn.FlatAppearance.BorderSize = 0;
            this.maximizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeBtn.IconChar = FontAwesome.Sharp.IconChar.Clone;
            this.maximizeBtn.IconColor = System.Drawing.Color.Black;
            this.maximizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.maximizeBtn.IconSize = 25;
            this.maximizeBtn.Location = new System.Drawing.Point(997, 0);
            this.maximizeBtn.Name = "maximizeBtn";
            this.maximizeBtn.Size = new System.Drawing.Size(53, 35);
            this.maximizeBtn.TabIndex = 3;
            this.maximizeBtn.UseVisualStyleBackColor = true;
            this.maximizeBtn.Click += new System.EventHandler(this.maximizeBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.minimizeBtn.IconColor = System.Drawing.Color.Black;
            this.minimizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimizeBtn.IconSize = 30;
            this.minimizeBtn.Location = new System.Drawing.Point(941, 0);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(50, 35);
            this.minimizeBtn.TabIndex = 2;
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Dice;
            this.iconCurrentChildForm.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 52;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(49, 21);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(53, 52);
            this.iconCurrentChildForm.TabIndex = 1;
            this.iconCurrentChildForm.TabStop = false;
            this.iconCurrentChildForm.Click += new System.EventHandler(this.iconCurrentChildForm_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(216)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1332, 653);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelDesktop);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinimumSize = new System.Drawing.Size(1350, 700);
            this.Name = "Menu";
            this.Text = "Memo";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitleChildForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonZasady;
        private FontAwesome.Sharp.IconButton iconButtonContact;
        private FontAwesome.Sharp.IconButton iconButtonHardLevel;
        private FontAwesome.Sharp.IconButton iconButtonEasyLevel;
        private FontAwesome.Sharp.IconButton BTNHome;
        private FontAwesome.Sharp.IconButton iconButtonStart;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private FontAwesome.Sharp.IconButton exitBtn;
        private FontAwesome.Sharp.IconButton maximizeBtn;
        private FontAwesome.Sharp.IconButton minimizeBtn;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

