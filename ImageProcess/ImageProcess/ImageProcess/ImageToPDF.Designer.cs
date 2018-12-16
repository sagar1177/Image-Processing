namespace ImageProcess
{
    partial class ImageToPDF
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRotate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.trkWidth = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkImageQualityReduce = new System.Windows.Forms.CheckBox();
            this.lblHeightValue = new System.Windows.Forms.Label();
            this.lblWidthValue = new System.Windows.Forms.Label();
            this.chkEnableResize = new System.Windows.Forms.CheckBox();
            this.trkHeight = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenOutputFolder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trkWidth)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(12, 419);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(120, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Import Multiple Images";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 401);
            this.panel1.TabIndex = 1;
            // 
            // btnRotate
            // 
            this.btnRotate.Location = new System.Drawing.Point(138, 419);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(101, 23);
            this.btnRotate.TabIndex = 2;
            this.btnRotate.Text = "Rotate 90°";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(245, 419);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Export To PDF";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // trkWidth
            // 
            this.trkWidth.Location = new System.Drawing.Point(7, 37);
            this.trkWidth.Maximum = 1024;
            this.trkWidth.Minimum = 1;
            this.trkWidth.Name = "trkWidth";
            this.trkWidth.Size = new System.Drawing.Size(142, 45);
            this.trkWidth.TabIndex = 1;
            this.trkWidth.Value = 1;
            this.trkWidth.Scroll += new System.EventHandler(this.trkWidth_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Width:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkImageQualityReduce);
            this.groupBox2.Controls.Add(this.lblHeightValue);
            this.groupBox2.Controls.Add(this.lblWidthValue);
            this.groupBox2.Controls.Add(this.chkEnableResize);
            this.groupBox2.Controls.Add(this.trkHeight);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.trkWidth);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(554, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 401);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resize";
            // 
            // chkImageQualityReduce
            // 
            this.chkImageQualityReduce.AutoSize = true;
            this.chkImageQualityReduce.Location = new System.Drawing.Point(10, 187);
            this.chkImageQualityReduce.Name = "chkImageQualityReduce";
            this.chkImageQualityReduce.Size = new System.Drawing.Size(178, 17);
            this.chkImageQualityReduce.TabIndex = 7;
            this.chkImageQualityReduce.Text = "Want to Reduce Image Quality?";
            this.chkImageQualityReduce.UseVisualStyleBackColor = true;
            this.chkImageQualityReduce.Visible = false;
            this.chkImageQualityReduce.CheckedChanged += new System.EventHandler(this.chkImageQualityReduce_CheckedChanged);
            // 
            // lblHeightValue
            // 
            this.lblHeightValue.AutoSize = true;
            this.lblHeightValue.Location = new System.Drawing.Point(51, 85);
            this.lblHeightValue.Name = "lblHeightValue";
            this.lblHeightValue.Size = new System.Drawing.Size(13, 13);
            this.lblHeightValue.TabIndex = 6;
            this.lblHeightValue.Text = "0";
            // 
            // lblWidthValue
            // 
            this.lblWidthValue.AutoSize = true;
            this.lblWidthValue.Location = new System.Drawing.Point(51, 20);
            this.lblWidthValue.Name = "lblWidthValue";
            this.lblWidthValue.Size = new System.Drawing.Size(13, 13);
            this.lblWidthValue.TabIndex = 5;
            this.lblWidthValue.Text = "0";
            // 
            // chkEnableResize
            // 
            this.chkEnableResize.AutoSize = true;
            this.chkEnableResize.Location = new System.Drawing.Point(10, 153);
            this.chkEnableResize.Name = "chkEnableResize";
            this.chkEnableResize.Size = new System.Drawing.Size(105, 17);
            this.chkEnableResize.TabIndex = 4;
            this.chkEnableResize.Text = "Want to Resize?";
            this.chkEnableResize.UseVisualStyleBackColor = true;
            this.chkEnableResize.CheckedChanged += new System.EventHandler(this.chkEnableResize_CheckedChanged);
            // 
            // trkHeight
            // 
            this.trkHeight.Location = new System.Drawing.Point(7, 102);
            this.trkHeight.Maximum = 1024;
            this.trkHeight.Minimum = 1;
            this.trkHeight.Name = "trkHeight";
            this.trkHeight.Size = new System.Drawing.Size(142, 45);
            this.trkHeight.TabIndex = 3;
            this.trkHeight.Value = 1;
            this.trkHeight.Scroll += new System.EventHandler(this.trkHeight_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Height:";
            // 
            // btnOpenOutputFolder
            // 
            this.btnOpenOutputFolder.Location = new System.Drawing.Point(352, 420);
            this.btnOpenOutputFolder.Name = "btnOpenOutputFolder";
            this.btnOpenOutputFolder.Size = new System.Drawing.Size(108, 22);
            this.btnOpenOutputFolder.TabIndex = 6;
            this.btnOpenOutputFolder.Text = "Open Output Folder";
            this.btnOpenOutputFolder.UseVisualStyleBackColor = true;
            this.btnOpenOutputFolder.Click += new System.EventHandler(this.btnOpenOutputFolder_Click);
            // 
            // ImageToPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 452);
            this.Controls.Add(this.btnOpenOutputFolder);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRotate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBrowse);
            this.Name = "ImageToPDF";
            this.Text = "Image To PDF Tool";
            this.Load += new System.EventHandler(this.ImageToPDF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trkWidth)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TrackBar trkWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar trkHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkEnableResize;
        private System.Windows.Forms.Label lblHeightValue;
        private System.Windows.Forms.Label lblWidthValue;
        private System.Windows.Forms.CheckBox chkImageQualityReduce;
        private System.Windows.Forms.Button btnOpenOutputFolder;
    }
}

