namespace SVGSample
{
    partial class frmSVGWindow
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
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.btnSourceColor = new System.Windows.Forms.Button();
            this.lblSVG = new System.Windows.Forms.Label();
            this.btnDestinationColor = new System.Windows.Forms.Button();
            this.lblDestinationColor = new System.Windows.Forms.Label();
            this.pnlPictureContainer = new System.Windows.Forms.Panel();
            this.pictConvertedImage = new System.Windows.Forms.PictureBox();
            this.lblSourceColor = new System.Windows.Forms.Label();
            this.filePicker = new System.Windows.Forms.OpenFileDialog();
            this.txtSelectedFile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnReplaceColor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnScaleUp = new System.Windows.Forms.Button();
            this.btnScaleDown = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.togglePickColor = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlPictureContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictConvertedImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSourceColor
            // 
            this.btnSourceColor.BackColor = System.Drawing.Color.Red;
            this.btnSourceColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSourceColor.ForeColor = System.Drawing.Color.Transparent;
            this.btnSourceColor.Location = new System.Drawing.Point(96, 18);
            this.btnSourceColor.Name = "btnSourceColor";
            this.btnSourceColor.Size = new System.Drawing.Size(74, 31);
            this.btnSourceColor.TabIndex = 0;
            this.btnSourceColor.UseVisualStyleBackColor = false;
            this.btnSourceColor.Click += new System.EventHandler(this.btnSourceColor_Click);
            // 
            // lblSVG
            // 
            this.lblSVG.AutoSize = true;
            this.lblSVG.Location = new System.Drawing.Point(12, 23);
            this.lblSVG.Name = "lblSVG";
            this.lblSVG.Size = new System.Drawing.Size(56, 13);
            this.lblSVG.TabIndex = 1;
            this.lblSVG.Text = "Load SVG";
            // 
            // btnDestinationColor
            // 
            this.btnDestinationColor.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDestinationColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDestinationColor.ForeColor = System.Drawing.Color.Transparent;
            this.btnDestinationColor.Location = new System.Drawing.Point(96, 68);
            this.btnDestinationColor.Name = "btnDestinationColor";
            this.btnDestinationColor.Size = new System.Drawing.Size(74, 31);
            this.btnDestinationColor.TabIndex = 0;
            this.btnDestinationColor.UseVisualStyleBackColor = false;
            this.btnDestinationColor.Click += new System.EventHandler(this.btnDestination_Click);
            // 
            // lblDestinationColor
            // 
            this.lblDestinationColor.AutoSize = true;
            this.lblDestinationColor.Location = new System.Drawing.Point(6, 77);
            this.lblDestinationColor.Name = "lblDestinationColor";
            this.lblDestinationColor.Size = new System.Drawing.Size(87, 13);
            this.lblDestinationColor.TabIndex = 1;
            this.lblDestinationColor.Text = "Destination Color";
            // 
            // pnlPictureContainer
            // 
            this.pnlPictureContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlPictureContainer.Controls.Add(this.pictConvertedImage);
            this.pnlPictureContainer.Location = new System.Drawing.Point(15, 221);
            this.pnlPictureContainer.Name = "pnlPictureContainer";
            this.pnlPictureContainer.Size = new System.Drawing.Size(671, 417);
            this.pnlPictureContainer.TabIndex = 2;
            // 
            // pictConvertedImage
            // 
            this.pictConvertedImage.Location = new System.Drawing.Point(10, 13);
            this.pictConvertedImage.Name = "pictConvertedImage";
            this.pictConvertedImage.Size = new System.Drawing.Size(654, 396);
            this.pictConvertedImage.TabIndex = 0;
            this.pictConvertedImage.TabStop = false;
            this.pictConvertedImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictConvertedImage_MouseDown);
            // 
            // lblSourceColor
            // 
            this.lblSourceColor.AutoSize = true;
            this.lblSourceColor.Location = new System.Drawing.Point(6, 27);
            this.lblSourceColor.Name = "lblSourceColor";
            this.lblSourceColor.Size = new System.Drawing.Size(68, 13);
            this.lblSourceColor.TabIndex = 1;
            this.lblSourceColor.Text = "Source Color";
            // 
            // filePicker
            // 
            this.filePicker.Filter = "SVG Files | *.svg";
            // 
            // txtSelectedFile
            // 
            this.txtSelectedFile.Location = new System.Drawing.Point(102, 20);
            this.txtSelectedFile.Multiline = true;
            this.txtSelectedFile.Name = "txtSelectedFile";
            this.txtSelectedFile.Size = new System.Drawing.Size(503, 21);
            this.txtSelectedFile.TabIndex = 3;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(611, 20);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnReplaceColor
            // 
            this.btnReplaceColor.Location = new System.Drawing.Point(67, 116);
            this.btnReplaceColor.Name = "btnReplaceColor";
            this.btnReplaceColor.Size = new System.Drawing.Size(103, 36);
            this.btnReplaceColor.TabIndex = 6;
            this.btnReplaceColor.Text = "Replace Color";
            this.btnReplaceColor.UseVisualStyleBackColor = true;
            this.btnReplaceColor.Click += new System.EventHandler(this.btnReplaceColor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(15, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 168);
            this.panel1.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtHeight);
            this.groupBox2.Controls.Add(this.txtWidth);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnScaleUp);
            this.groupBox2.Controls.Add(this.btnScaleDown);
            this.groupBox2.Location = new System.Drawing.Point(345, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 158);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scaling";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(48, 65);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(188, 20);
            this.txtHeight.TabIndex = 7;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(48, 24);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(188, 20);
            this.txtWidth.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Width";
            // 
            // btnScaleUp
            // 
            this.btnScaleUp.Location = new System.Drawing.Point(133, 116);
            this.btnScaleUp.Name = "btnScaleUp";
            this.btnScaleUp.Size = new System.Drawing.Size(103, 36);
            this.btnScaleUp.TabIndex = 6;
            this.btnScaleUp.Text = "Scale Up";
            this.btnScaleUp.UseVisualStyleBackColor = true;
            this.btnScaleUp.Click += new System.EventHandler(this.btnScaleUp_Click);
            // 
            // btnScaleDown
            // 
            this.btnScaleDown.Location = new System.Drawing.Point(9, 116);
            this.btnScaleDown.Name = "btnScaleDown";
            this.btnScaleDown.Size = new System.Drawing.Size(103, 36);
            this.btnScaleDown.TabIndex = 6;
            this.btnScaleDown.Text = "Scale Down";
            this.btnScaleDown.UseVisualStyleBackColor = true;
            this.btnScaleDown.Click += new System.EventHandler(this.btnScaleDown_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.togglePickColor);
            this.groupBox1.Controls.Add(this.lblSourceColor);
            this.groupBox1.Controls.Add(this.btnDestinationColor);
            this.groupBox1.Controls.Add(this.btnReplaceColor);
            this.groupBox1.Controls.Add(this.lblDestinationColor);
            this.groupBox1.Controls.Add(this.btnSourceColor);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 158);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Replace Color";
            // 
            // togglePickColor
            // 
            this.togglePickColor.Appearance = System.Windows.Forms.Appearance.Button;
            this.togglePickColor.AutoSize = true;
            this.togglePickColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.togglePickColor.Location = new System.Drawing.Point(176, 22);
            this.togglePickColor.Name = "togglePickColor";
            this.togglePickColor.Size = new System.Drawing.Size(65, 23);
            this.togglePickColor.TabIndex = 7;
            this.togglePickColor.Text = "Pick Color";
            this.togglePickColor.UseVisualStyleBackColor = true;
            this.togglePickColor.CheckedChanged += new System.EventHandler(this.togglePickColor_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 647);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "- Lasitha Ishan Petthawadu - ";
            // 
            // frmSVGWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 669);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtSelectedFile);
            this.Controls.Add(this.pnlPictureContainer);
            this.Controls.Add(this.lblSVG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSVGWindow";
            this.Text = "Sample SVG Usage";
            this.pnlPictureContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictConvertedImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorPicker;
        private System.Windows.Forms.Button btnSourceColor;
        private System.Windows.Forms.Label lblSVG;
        private System.Windows.Forms.Button btnDestinationColor;
        private System.Windows.Forms.Label lblDestinationColor;
        private System.Windows.Forms.Panel pnlPictureContainer;
        private System.Windows.Forms.PictureBox pictConvertedImage;
        private System.Windows.Forms.Label lblSourceColor;
        private System.Windows.Forms.OpenFileDialog filePicker;
        private System.Windows.Forms.TextBox txtSelectedFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnReplaceColor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnScaleDown;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnScaleUp;
        private System.Windows.Forms.CheckBox togglePickColor;
        private System.Windows.Forms.Label label3;
    }
}

