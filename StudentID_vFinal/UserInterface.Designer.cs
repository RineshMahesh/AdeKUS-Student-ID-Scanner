namespace Id_scanner
{
    partial class UserInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GivesFuncOfPicBox = new System.Windows.Forms.Label();
            this.StudentInfo = new System.Windows.Forms.Label();
            this.StudentStatus = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.DeniedOrAcceptedBox = new System.Windows.Forms.RichTextBox();
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip8 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip9 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFotoDisplayen = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.BtnMoodleLijst = new System.Windows.Forms.Button();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoDisplayen)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // GivesFuncOfPicBox
            // 
            this.GivesFuncOfPicBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GivesFuncOfPicBox.AutoSize = true;
            this.GivesFuncOfPicBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GivesFuncOfPicBox.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GivesFuncOfPicBox.ForeColor = System.Drawing.Color.Black;
            this.GivesFuncOfPicBox.Location = new System.Drawing.Point(259, 56);
            this.GivesFuncOfPicBox.Name = "GivesFuncOfPicBox";
            this.GivesFuncOfPicBox.Size = new System.Drawing.Size(311, 34);
            this.GivesFuncOfPicBox.TabIndex = 6;
            this.GivesFuncOfPicBox.Text = "Current Image Being Scanned";
            this.GivesFuncOfPicBox.Click += new System.EventHandler(this.GivesFuncOfPicBox_Click);
            // 
            // StudentInfo
            // 
            this.StudentInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.StudentInfo.AutoSize = true;
            this.StudentInfo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.StudentInfo.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentInfo.Location = new System.Drawing.Point(695, 56);
            this.StudentInfo.Name = "StudentInfo";
            this.StudentInfo.Size = new System.Drawing.Size(212, 34);
            this.StudentInfo.TabIndex = 7;
            this.StudentInfo.Text = "Student Information";
            this.StudentInfo.Click += new System.EventHandler(this.label2_Click);
            // 
            // StudentStatus
            // 
            this.StudentStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.StudentStatus.AutoSize = true;
            this.StudentStatus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.StudentStatus.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentStatus.Location = new System.Drawing.Point(695, 359);
            this.StudentStatus.Name = "StudentStatus";
            this.StudentStatus.Size = new System.Drawing.Size(159, 34);
            this.StudentStatus.TabIndex = 8;
            this.StudentStatus.Text = "Student Status";
            this.StudentStatus.Click += new System.EventHandler(this.StudentStatus_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.richTextBox2.BackColor = System.Drawing.Color.White;
            this.richTextBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(701, 93);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(223, 228);
            this.richTextBox2.TabIndex = 9;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // DeniedOrAcceptedBox
            // 
            this.DeniedOrAcceptedBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DeniedOrAcceptedBox.BackColor = System.Drawing.Color.White;
            this.DeniedOrAcceptedBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DeniedOrAcceptedBox.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeniedOrAcceptedBox.Location = new System.Drawing.Point(701, 396);
            this.DeniedOrAcceptedBox.Name = "DeniedOrAcceptedBox";
            this.DeniedOrAcceptedBox.ReadOnly = true;
            this.DeniedOrAcceptedBox.Size = new System.Drawing.Size(223, 31);
            this.DeniedOrAcceptedBox.TabIndex = 10;
            this.DeniedOrAcceptedBox.Text = "";
            this.DeniedOrAcceptedBox.TextChanged += new System.EventHandler(this.DeniedOrAcceptedBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(211, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.toolTip4.SetToolTip(this.pictureBox1, "Save Exam Attendance");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(211, 132);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.toolTip6.SetToolTip(this.pictureBox3, "Select Moodle List");
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(211, 171);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(36, 33);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            this.toolTip9.SetToolTip(this.pictureBox6, "Exit Application");
            // 
            // pictureBoxFotoDisplayen
            // 
            this.pictureBoxFotoDisplayen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxFotoDisplayen.BackColor = System.Drawing.Color.White;
            this.pictureBoxFotoDisplayen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxFotoDisplayen.Location = new System.Drawing.Point(265, 93);
            this.pictureBoxFotoDisplayen.Name = "pictureBoxFotoDisplayen";
            this.pictureBoxFotoDisplayen.Size = new System.Drawing.Size(396, 228);
            this.pictureBoxFotoDisplayen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFotoDisplayen.TabIndex = 2;
            this.pictureBoxFotoDisplayen.TabStop = false;
            this.pictureBoxFotoDisplayen.Click += new System.EventHandler(this.pictureBoxFotoDisplayen_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::Id_scanner.Properties.Resources.Untitled_1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.BtnMoodleLijst);
            this.panel1.Controls.Add(this.btnCreateFile);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.btnLeave);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 490);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.Location = new System.Drawing.Point(3, 5);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(39, 76);
            this.pictureBox7.TabIndex = 17;
            this.pictureBox7.TabStop = false;
            // 
            // BtnMoodleLijst
            // 
            this.BtnMoodleLijst.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnMoodleLijst.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMoodleLijst.Location = new System.Drawing.Point(3, 132);
            this.BtnMoodleLijst.Name = "BtnMoodleLijst";
            this.BtnMoodleLijst.Size = new System.Drawing.Size(202, 33);
            this.BtnMoodleLijst.TabIndex = 6;
            this.BtnMoodleLijst.Text = "Select Registration List";
            this.BtnMoodleLijst.UseVisualStyleBackColor = true;
            this.BtnMoodleLijst.Click += new System.EventHandler(this.BtnMoodleLijst_Click);
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCreateFile.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateFile.Location = new System.Drawing.Point(3, 93);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(202, 33);
            this.btnCreateFile.TabIndex = 3;
            this.btnCreateFile.Text = "Create Attendance List";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.AllowDrop = true;
            this.btnLeave.BackColor = System.Drawing.Color.White;
            this.btnLeave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLeave.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeave.ForeColor = System.Drawing.Color.Red;
            this.btnLeave.Location = new System.Drawing.Point(3, 171);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(202, 33);
            this.btnLeave.TabIndex = 0;
            this.btnLeave.Text = "Quit Menu";
            this.btnLeave.UseVisualStyleBackColor = false;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 62);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(241, -10);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(734, 521);
            this.pictureBox8.TabIndex = 11;
            this.pictureBox8.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(265, 396);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(396, 31);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 34);
            this.label2.TabIndex = 13;
            this.label2.Text = "Phone Status";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 490);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.StudentInfo);
            this.Controls.Add(this.DeniedOrAcceptedBox);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.StudentStatus);
            this.Controls.Add(this.GivesFuncOfPicBox);
            this.Controls.Add(this.pictureBoxFotoDisplayen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox8);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student ID-Scanner ";
            this.Load += new System.EventHandler(this.UserInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoDisplayen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Button BtnMoodleLijst;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
   
        private System.Windows.Forms.Label GivesFuncOfPicBox;
        private System.Windows.Forms.Label StudentInfo;
        private System.Windows.Forms.Label StudentStatus;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox DeniedOrAcceptedBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.ToolTip toolTip7;
        private System.Windows.Forms.ToolTip toolTip8;
        private System.Windows.Forms.ToolTip toolTip9;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox pictureBoxFotoDisplayen;
    }
}