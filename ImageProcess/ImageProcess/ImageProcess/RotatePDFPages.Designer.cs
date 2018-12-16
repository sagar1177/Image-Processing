namespace ImageProcess
{
    partial class RotatePDFPages
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtn0 = new System.Windows.Forms.RadioButton();
            this.rbtn270 = new System.Windows.Forms.RadioButton();
            this.rbtn180 = new System.Windows.Forms.RadioButton();
            this.rbtn90 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.btnOpenOutputFolder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(11, 189);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Rotate and Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(12, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(120, 23);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Import PDF";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtn0);
            this.panel1.Controls.Add(this.rbtn270);
            this.panel1.Controls.Add(this.rbtn180);
            this.panel1.Controls.Add(this.rbtn90);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 27);
            this.panel1.TabIndex = 9;
            // 
            // rbtn0
            // 
            this.rbtn0.AutoSize = true;
            this.rbtn0.Location = new System.Drawing.Point(3, 5);
            this.rbtn0.Name = "rbtn0";
            this.rbtn0.Size = new System.Drawing.Size(51, 17);
            this.rbtn0.TabIndex = 4;
            this.rbtn0.TabStop = true;
            this.rbtn0.Text = "None";
            this.rbtn0.UseVisualStyleBackColor = true;
            // 
            // rbtn270
            // 
            this.rbtn270.AutoSize = true;
            this.rbtn270.Location = new System.Drawing.Point(149, 5);
            this.rbtn270.Name = "rbtn270";
            this.rbtn270.Size = new System.Drawing.Size(43, 17);
            this.rbtn270.TabIndex = 2;
            this.rbtn270.TabStop = true;
            this.rbtn270.Text = "270";
            this.rbtn270.UseVisualStyleBackColor = true;
            // 
            // rbtn180
            // 
            this.rbtn180.AutoSize = true;
            this.rbtn180.Location = new System.Drawing.Point(100, 5);
            this.rbtn180.Name = "rbtn180";
            this.rbtn180.Size = new System.Drawing.Size(43, 17);
            this.rbtn180.TabIndex = 1;
            this.rbtn180.TabStop = true;
            this.rbtn180.Text = "180";
            this.rbtn180.UseVisualStyleBackColor = true;
            // 
            // rbtn90
            // 
            this.rbtn90.AutoSize = true;
            this.rbtn90.Location = new System.Drawing.Point(57, 5);
            this.rbtn90.Name = "rbtn90";
            this.rbtn90.Size = new System.Drawing.Size(37, 17);
            this.rbtn90.TabIndex = 0;
            this.rbtn90.TabStop = true;
            this.rbtn90.Text = "90";
            this.rbtn90.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 56);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rotate Page";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOutputPath);
            this.groupBox2.Location = new System.Drawing.Point(12, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 56);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output Path";
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Location = new System.Drawing.Point(7, 22);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.ReadOnly = true;
            this.txtOutputPath.Size = new System.Drawing.Size(208, 20);
            this.txtOutputPath.TabIndex = 0;
            // 
            // btnOpenOutputFolder
            // 
            this.btnOpenOutputFolder.Location = new System.Drawing.Point(118, 189);
            this.btnOpenOutputFolder.Name = "btnOpenOutputFolder";
            this.btnOpenOutputFolder.Size = new System.Drawing.Size(111, 23);
            this.btnOpenOutputFolder.TabIndex = 12;
            this.btnOpenOutputFolder.Text = "Open Output Folder";
            this.btnOpenOutputFolder.UseVisualStyleBackColor = true;
            this.btnOpenOutputFolder.Click += new System.EventHandler(this.btnOpenOutputFolder_Click);
            // 
            // RotatePDFPages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 219);
            this.Controls.Add(this.btnOpenOutputFolder);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBrowse);
            this.Name = "RotatePDFPages";
            this.Text = "Rotate PDF Pages";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtn90;
        private System.Windows.Forms.RadioButton rbtn180;
        private System.Windows.Forms.RadioButton rbtn270;
        private System.Windows.Forms.RadioButton rbtn0;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.Button btnOpenOutputFolder;
    }
}