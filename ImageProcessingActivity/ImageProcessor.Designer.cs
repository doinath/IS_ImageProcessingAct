namespace ImageProcessingActivity
{
    partial class ImageProcessor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageProcessingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greyscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorInversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianBlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smoothToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meanRemovalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embossFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageProcessing2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embossLaplacianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embossHVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embossAllFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embossLossyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embossVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embossHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webcamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startWebcamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopWebcamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pic_box1 = new System.Windows.Forms.PictureBox();
            this.pic_box2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_box3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoad_image = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.loadImage = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.imageProcessingToolStripMenuItem,
            this.imageProcessing2ToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.webcamToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1153, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 22);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // reseToolStripMenuItem
            // 
            this.reseToolStripMenuItem.Name = "reseToolStripMenuItem";
            this.reseToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.reseToolStripMenuItem.Text = "Reset";
            this.reseToolStripMenuItem.Click += new System.EventHandler(this.reseToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // imageProcessingToolStripMenuItem
            // 
            this.imageProcessingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.greyscaleToolStripMenuItem,
            this.colorInversionToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.sepiaToolStripMenuItem,
            this.gaussianBlurToolStripMenuItem,
            this.sharpenToolStripMenuItem,
            this.smoothToolStripMenuItem,
            this.meanRemovalToolStripMenuItem,
            this.embossFilterToolStripMenuItem});
            this.imageProcessingToolStripMenuItem.Name = "imageProcessingToolStripMenuItem";
            this.imageProcessingToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.imageProcessingToolStripMenuItem.Text = "Image Processing";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.copyToolStripMenuItem.Text = "Basic Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // greyscaleToolStripMenuItem
            // 
            this.greyscaleToolStripMenuItem.Name = "greyscaleToolStripMenuItem";
            this.greyscaleToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.greyscaleToolStripMenuItem.Text = "Greyscale";
            this.greyscaleToolStripMenuItem.Click += new System.EventHandler(this.greyscaleToolStripMenuItem_Click);
            // 
            // colorInversionToolStripMenuItem
            // 
            this.colorInversionToolStripMenuItem.Name = "colorInversionToolStripMenuItem";
            this.colorInversionToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.colorInversionToolStripMenuItem.Text = "Color Inversion";
            this.colorInversionToolStripMenuItem.Click += new System.EventHandler(this.colorInversionToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.sepiaToolStripMenuItem.Text = "Sepia";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);
            // 
            // gaussianBlurToolStripMenuItem
            // 
            this.gaussianBlurToolStripMenuItem.Name = "gaussianBlurToolStripMenuItem";
            this.gaussianBlurToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.gaussianBlurToolStripMenuItem.Text = "Gaussian Blur";
            this.gaussianBlurToolStripMenuItem.Click += new System.EventHandler(this.gaussianBlurFilter_Click);
            // 
            // sharpenToolStripMenuItem
            // 
            this.sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            this.sharpenToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.sharpenToolStripMenuItem.Text = "Sharpen";
            this.sharpenToolStripMenuItem.Click += new System.EventHandler(this.sharpenFilter_Click);
            // 
            // smoothToolStripMenuItem
            // 
            this.smoothToolStripMenuItem.Name = "smoothToolStripMenuItem";
            this.smoothToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.smoothToolStripMenuItem.Text = "Smooth";
            this.smoothToolStripMenuItem.Click += new System.EventHandler(this.smoothFilter_Click);
            // 
            // meanRemovalToolStripMenuItem
            // 
            this.meanRemovalToolStripMenuItem.Name = "meanRemovalToolStripMenuItem";
            this.meanRemovalToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.meanRemovalToolStripMenuItem.Text = "Mean Removal";
            this.meanRemovalToolStripMenuItem.Click += new System.EventHandler(this.meanRemovalFilter_Click);
            // 
            // embossFilterToolStripMenuItem
            // 
            this.embossFilterToolStripMenuItem.Name = "embossFilterToolStripMenuItem";
            this.embossFilterToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.embossFilterToolStripMenuItem.Text = "Emboss Filter";
            this.embossFilterToolStripMenuItem.Click += new System.EventHandler(this.embossFilter_Click);
            // 
            // imageProcessing2ToolStripMenuItem
            // 
            this.imageProcessing2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.embossLaplacianToolStripMenuItem,
            this.embossHVToolStripMenuItem,
            this.embossAllFilterToolStripMenuItem,
            this.embossLossyToolStripMenuItem,
            this.embossVerticalToolStripMenuItem,
            this.embossHorizontalToolStripMenuItem});
            this.imageProcessing2ToolStripMenuItem.Name = "imageProcessing2ToolStripMenuItem";
            this.imageProcessing2ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.imageProcessing2ToolStripMenuItem.Text = "Image Processing 2";
            // 
            // embossLaplacianToolStripMenuItem
            // 
            this.embossLaplacianToolStripMenuItem.Name = "embossLaplacianToolStripMenuItem";
            this.embossLaplacianToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.embossLaplacianToolStripMenuItem.Text = "Emboss Laplacian";
            this.embossLaplacianToolStripMenuItem.Click += new System.EventHandler(this.embossLaplacianFilter_Click);
            // 
            // embossHVToolStripMenuItem
            // 
            this.embossHVToolStripMenuItem.Name = "embossHVToolStripMenuItem";
            this.embossHVToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.embossHVToolStripMenuItem.Text = "Emboss HV";
            this.embossHVToolStripMenuItem.Click += new System.EventHandler(this.embossHVFilter_Click);
            // 
            // embossAllFilterToolStripMenuItem
            // 
            this.embossAllFilterToolStripMenuItem.Name = "embossAllFilterToolStripMenuItem";
            this.embossAllFilterToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.embossAllFilterToolStripMenuItem.Text = "Emboss All Filter";
            this.embossAllFilterToolStripMenuItem.Click += new System.EventHandler(this.embossAllFilter_Click);
            // 
            // embossLossyToolStripMenuItem
            // 
            this.embossLossyToolStripMenuItem.Name = "embossLossyToolStripMenuItem";
            this.embossLossyToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.embossLossyToolStripMenuItem.Text = "Emboss Lossy";
            this.embossLossyToolStripMenuItem.Click += new System.EventHandler(this.embossLossyFilter_Click);
            // 
            // embossVerticalToolStripMenuItem
            // 
            this.embossVerticalToolStripMenuItem.Name = "embossVerticalToolStripMenuItem";
            this.embossVerticalToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.embossVerticalToolStripMenuItem.Text = "Emboss Vertical";
            this.embossVerticalToolStripMenuItem.Click += new System.EventHandler(this.embossVerticalFilter_Click);
            // 
            // embossHorizontalToolStripMenuItem
            // 
            this.embossHorizontalToolStripMenuItem.Name = "embossHorizontalToolStripMenuItem";
            this.embossHorizontalToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.embossHorizontalToolStripMenuItem.Text = "Emboss Horizontal";
            this.embossHorizontalToolStripMenuItem.Click += new System.EventHandler(this.embossHorizontalFilter_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.save,
            this.loadImageToolStripMenuItem,
            this.clearImageToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.loadToolStripMenuItem.Text = "Image";
            // 
            // save
            // 
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(191, 22);
            this.save.Text = "Save Image";
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.loadImageToolStripMenuItem.Text = "Load Image";
            this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.loadImageToolStripMenuItem_Click);
            // 
            // clearImageToolStripMenuItem
            // 
            this.clearImageToolStripMenuItem.Name = "clearImageToolStripMenuItem";
            this.clearImageToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.clearImageToolStripMenuItem.Text = "Clear Image [ orginal ]";
            this.clearImageToolStripMenuItem.Click += new System.EventHandler(this.clearImageToolStripMenuItem_Click);
            // 
            // webcamToolStripMenuItem
            // 
            this.webcamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startWebcamToolStripMenuItem,
            this.stopWebcamToolStripMenuItem});
            this.webcamToolStripMenuItem.Name = "webcamToolStripMenuItem";
            this.webcamToolStripMenuItem.Size = new System.Drawing.Size(66, 22);
            this.webcamToolStripMenuItem.Text = "Webcam";
            // 
            // startWebcamToolStripMenuItem
            // 
            this.startWebcamToolStripMenuItem.Name = "startWebcamToolStripMenuItem";
            this.startWebcamToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.startWebcamToolStripMenuItem.Text = "Start Webcam";
            this.startWebcamToolStripMenuItem.Click += new System.EventHandler(this.startWebcamToolStripMenuItem_Click);
            // 
            // stopWebcamToolStripMenuItem
            // 
            this.stopWebcamToolStripMenuItem.Name = "stopWebcamToolStripMenuItem";
            this.stopWebcamToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.stopWebcamToolStripMenuItem.Text = "Stop Webcam";
            this.stopWebcamToolStripMenuItem.Click += new System.EventHandler(this.stopWebcamToolStripMenuItem_Click);
            // 
            // pic_box1
            // 
            this.pic_box1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_box1.Location = new System.Drawing.Point(57, 57);
            this.pic_box1.Name = "pic_box1";
            this.pic_box1.Size = new System.Drawing.Size(275, 275);
            this.pic_box1.TabIndex = 1;
            this.pic_box1.TabStop = false;
            // 
            // pic_box2
            // 
            this.pic_box2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_box2.Location = new System.Drawing.Point(467, 57);
            this.pic_box2.Name = "pic_box2";
            this.pic_box2.Size = new System.Drawing.Size(275, 275);
            this.pic_box2.TabIndex = 2;
            this.pic_box2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "ORIGINAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(565, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "RESULT";
            // 
            // pic_box3
            // 
            this.pic_box3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_box3.Location = new System.Drawing.Point(820, 57);
            this.pic_box3.Name = "pic_box3";
            this.pic_box3.Size = new System.Drawing.Size(275, 275);
            this.pic_box3.TabIndex = 5;
            this.pic_box3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(916, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "SUBTRACT";
            // 
            // btnLoad_image
            // 
            this.btnLoad_image.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLoad_image.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLoad_image.Location = new System.Drawing.Point(524, 359);
            this.btnLoad_image.Name = "btnLoad_image";
            this.btnLoad_image.Size = new System.Drawing.Size(168, 32);
            this.btnLoad_image.TabIndex = 7;
            this.btnLoad_image.Text = "Load Background Image Here";
            this.btnLoad_image.UseVisualStyleBackColor = true;
            this.btnLoad_image.Click += new System.EventHandler(this.btnLoad_image_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "only add here if you are doing the subtraction process";
            // 
            // loadImage
            // 
            this.loadImage.Location = new System.Drawing.Point(143, 359);
            this.loadImage.Name = "loadImage";
            this.loadImage.Size = new System.Drawing.Size(75, 32);
            this.loadImage.TabIndex = 9;
            this.loadImage.Text = "Load Image";
            this.loadImage.UseVisualStyleBackColor = true;
            this.loadImage.Click += new System.EventHandler(this.loadImage_Click);
            // 
            // subtract
            // 
            this.subtract.Location = new System.Drawing.Point(920, 359);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(75, 32);
            this.subtract.TabIndex = 10;
            this.subtract.Text = "Subtract";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.subtract_Click);
            // 
            // ImageProcessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 450);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.loadImage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLoad_image);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pic_box3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_box2);
            this.Controls.Add(this.pic_box1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ImageProcessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Processing ";
            this.Load += new System.EventHandler(this.Test_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.ToolStripMenuItem imageProcessingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greyscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorInversionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pic_box1;
        private System.Windows.Forms.PictureBox pic_box2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem clearImageToolStripMenuItem;
        private System.Windows.Forms.PictureBox pic_box3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLoad_image;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button loadImage;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.ToolStripMenuItem webcamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startWebcamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopWebcamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianBlurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smoothToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meanRemovalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem embossFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem imageProcessing2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem embossLaplacianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem embossHVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem embossAllFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem embossLossyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem embossVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem embossHorizontalToolStripMenuItem;
    }
}

