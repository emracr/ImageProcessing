
namespace ImageProcessing
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pbImageSource = new System.Windows.Forms.PictureBox();
            this.pbImageOutput = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlFilterChoose = new System.Windows.Forms.Panel();
            this.pnlWriteToImage = new System.Windows.Forms.Panel();
            this.cbSelectColor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSelectFont = new System.Windows.Forms.Button();
            this.tbWriteToImage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlMorphologyMaskSize = new System.Windows.Forms.Panel();
            this.cbMorphologyMaskSize = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlGaussianMaskSize = new System.Windows.Forms.Panel();
            this.cbGaussianMask = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.pnlTools = new System.Windows.Forms.Panel();
            this.pbHistogram = new System.Windows.Forms.PictureBox();
            this.pbImageSaveAs = new System.Windows.Forms.PictureBox();
            this.pbUploadImage = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pnlBrightness = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnImageRotate = new System.Windows.Forms.Button();
            this.nudRotateDegree = new System.Windows.Forms.NumericUpDown();
            this.pbResetBrightnessAndContrast = new System.Windows.Forms.PictureBox();
            this.lblContrast = new System.Windows.Forms.Label();
            this.trcbContrast = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBrightnessValue = new System.Windows.Forms.Label();
            this.trcbBrightness = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.lblImageProcessingWait = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.pnlMove = new System.Windows.Forms.Panel();
            this.tbMoveY = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbMoveX = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageOutput)).BeginInit();
            this.pnlFilterChoose.SuspendLayout();
            this.pnlWriteToImage.SuspendLayout();
            this.pnlMorphologyMaskSize.SuspendLayout();
            this.pnlGaussianMaskSize.SuspendLayout();
            this.pnlTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageSaveAs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUploadImage)).BeginInit();
            this.pnlBrightness.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRotateDegree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResetBrightnessAndContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcbContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcbBrightness)).BeginInit();
            this.pnlMove.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImageSource
            // 
            this.pbImageSource.Location = new System.Drawing.Point(21, 67);
            this.pbImageSource.Name = "pbImageSource";
            this.pbImageSource.Size = new System.Drawing.Size(450, 450);
            this.pbImageSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImageSource.TabIndex = 0;
            this.pbImageSource.TabStop = false;
            this.pbImageSource.Click += new System.EventHandler(this.pbImageSource_Click);
            this.pbImageSource.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbImageSource_MouseDown);
            this.pbImageSource.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbImageSource_MouseMove);
            this.pbImageSource.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbImageSource_MouseUp);
            // 
            // pbImageOutput
            // 
            this.pbImageOutput.Location = new System.Drawing.Point(489, 67);
            this.pbImageOutput.Name = "pbImageOutput";
            this.pbImageOutput.Size = new System.Drawing.Size(450, 450);
            this.pbImageOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImageOutput.TabIndex = 1;
            this.pbImageOutput.TabStop = false;
            this.pbImageOutput.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pnlFilterChoose
            // 
            this.pnlFilterChoose.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlFilterChoose.Controls.Add(this.pnlWriteToImage);
            this.pnlFilterChoose.Controls.Add(this.pnlMorphologyMaskSize);
            this.pnlFilterChoose.Controls.Add(this.pnlGaussianMaskSize);
            this.pnlFilterChoose.Controls.Add(this.btnApplyFilter);
            this.pnlFilterChoose.Controls.Add(this.label1);
            this.pnlFilterChoose.Controls.Add(this.cbFilters);
            this.pnlFilterChoose.Location = new System.Drawing.Point(21, 537);
            this.pnlFilterChoose.Name = "pnlFilterChoose";
            this.pnlFilterChoose.Size = new System.Drawing.Size(450, 180);
            this.pnlFilterChoose.TabIndex = 3;
            this.pnlFilterChoose.Visible = false;
            // 
            // pnlWriteToImage
            // 
            this.pnlWriteToImage.Controls.Add(this.cbSelectColor);
            this.pnlWriteToImage.Controls.Add(this.label8);
            this.pnlWriteToImage.Controls.Add(this.btnSelectFont);
            this.pnlWriteToImage.Controls.Add(this.tbWriteToImage);
            this.pnlWriteToImage.Controls.Add(this.label7);
            this.pnlWriteToImage.Location = new System.Drawing.Point(9, 65);
            this.pnlWriteToImage.Name = "pnlWriteToImage";
            this.pnlWriteToImage.Size = new System.Drawing.Size(434, 65);
            this.pnlWriteToImage.TabIndex = 14;
            this.pnlWriteToImage.Visible = false;
            // 
            // cbSelectColor
            // 
            this.cbSelectColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSelectColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectColor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSelectColor.FormattingEnabled = true;
            this.cbSelectColor.Items.AddRange(new object[] {
            "Kırmızı",
            "Yeşil",
            "Mavi",
            "Siyah",
            "Beyaz",
            "Sarı",
            "Pembe",
            "Turuncu"});
            this.cbSelectColor.Location = new System.Drawing.Point(68, 37);
            this.cbSelectColor.Name = "cbSelectColor";
            this.cbSelectColor.Size = new System.Drawing.Size(122, 21);
            this.cbSelectColor.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label8.Location = new System.Drawing.Point(5, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Renk seç :";
            // 
            // btnSelectFont
            // 
            this.btnSelectFont.Location = new System.Drawing.Point(356, 35);
            this.btnSelectFont.Name = "btnSelectFont";
            this.btnSelectFont.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFont.TabIndex = 20;
            this.btnSelectFont.Text = "Yazı tipi seç";
            this.btnSelectFont.UseVisualStyleBackColor = true;
            this.btnSelectFont.Click += new System.EventHandler(this.btnSelectFont_Click);
            // 
            // tbWriteToImage
            // 
            this.tbWriteToImage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbWriteToImage.Location = new System.Drawing.Point(68, 5);
            this.tbWriteToImage.Name = "tbWriteToImage";
            this.tbWriteToImage.Size = new System.Drawing.Size(362, 22);
            this.tbWriteToImage.TabIndex = 16;
            this.tbWriteToImage.TextChanged += new System.EventHandler(this.tbWriteToImage_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label7.Location = new System.Drawing.Point(20, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Metin :";
            // 
            // pnlMorphologyMaskSize
            // 
            this.pnlMorphologyMaskSize.Controls.Add(this.cbMorphologyMaskSize);
            this.pnlMorphologyMaskSize.Controls.Add(this.label6);
            this.pnlMorphologyMaskSize.Location = new System.Drawing.Point(9, 65);
            this.pnlMorphologyMaskSize.Name = "pnlMorphologyMaskSize";
            this.pnlMorphologyMaskSize.Size = new System.Drawing.Size(434, 65);
            this.pnlMorphologyMaskSize.TabIndex = 13;
            this.pnlMorphologyMaskSize.Visible = false;
            // 
            // cbMorphologyMaskSize
            // 
            this.cbMorphologyMaskSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMorphologyMaskSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMorphologyMaskSize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbMorphologyMaskSize.FormattingEnabled = true;
            this.cbMorphologyMaskSize.Items.AddRange(new object[] {
            "3 X 3",
            "5 X 5",
            "10 X 10"});
            this.cbMorphologyMaskSize.Location = new System.Drawing.Point(4, 31);
            this.cbMorphologyMaskSize.Name = "cbMorphologyMaskSize";
            this.cbMorphologyMaskSize.Size = new System.Drawing.Size(151, 25);
            this.cbMorphologyMaskSize.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label6.Location = new System.Drawing.Point(1, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Maske (Disk) Boyutu";
            // 
            // pnlGaussianMaskSize
            // 
            this.pnlGaussianMaskSize.Controls.Add(this.cbGaussianMask);
            this.pnlGaussianMaskSize.Controls.Add(this.label3);
            this.pnlGaussianMaskSize.Location = new System.Drawing.Point(9, 65);
            this.pnlGaussianMaskSize.Name = "pnlGaussianMaskSize";
            this.pnlGaussianMaskSize.Size = new System.Drawing.Size(434, 65);
            this.pnlGaussianMaskSize.TabIndex = 12;
            this.pnlGaussianMaskSize.Visible = false;
            // 
            // cbGaussianMask
            // 
            this.cbGaussianMask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbGaussianMask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGaussianMask.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbGaussianMask.FormattingEnabled = true;
            this.cbGaussianMask.Items.AddRange(new object[] {
            "3 X 3",
            "5 X 5",
            "10 X 10"});
            this.cbGaussianMask.Location = new System.Drawing.Point(4, 31);
            this.cbGaussianMask.Name = "cbGaussianMask";
            this.cbGaussianMask.Size = new System.Drawing.Size(151, 25);
            this.cbGaussianMask.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label3.Location = new System.Drawing.Point(1, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Maske Boyutu";
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.BackColor = System.Drawing.Color.OliveDrab;
            this.btnApplyFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplyFilter.FlatAppearance.BorderSize = 0;
            this.btnApplyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnApplyFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnApplyFilter.Location = new System.Drawing.Point(9, 139);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(430, 33);
            this.btnApplyFilter.TabIndex = 9;
            this.btnApplyFilter.Text = "Filtreyi uygula";
            this.btnApplyFilter.UseVisualStyleBackColor = false;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Filtre Seçin";
            // 
            // cbFilters
            // 
            this.cbFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilters.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Items.AddRange(new object[] {
            "Gri Filtre",
            "Negatif Filtre",
            "Negatif (Gri) Filtre",
            "Binary (Eşikleme) Filtre",
            "Sepia Tonu",
            "Sobel Kenar Filtresi",
            "Histogram Eşitleme",
            "Gaussian Alçak Geçiren Filtre",
            "Mean (Ortalama) Filtre",
            "Medyan (Ortanca) Filtre",
            "Laplacian Filtresi",
            "Prewitt Filtresi",
            "Görüntü Aynalama",
            "Görüntü Ters Çevirme",
            "Yayma (Dilation)",
            "Aşındırma (Erosion)",
            "Açma (Opening)",
            "Kapama (Close)",
            "Görüntü Netleştirme (Keskinleştirme)",
            "Yazı yaz",
            "Kırpma",
            "Konvolüsyon",
            "Kurşun Kalem Baskısı",
            "Taşıma",
            "Küçültme",
            "-- Filtre yok --"});
            this.cbFilters.Location = new System.Drawing.Point(9, 33);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(434, 25);
            this.cbFilters.TabIndex = 7;
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // pnlTools
            // 
            this.pnlTools.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlTools.Controls.Add(this.pbHistogram);
            this.pnlTools.Controls.Add(this.pbImageSaveAs);
            this.pnlTools.Controls.Add(this.pbUploadImage);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTools.Location = new System.Drawing.Point(0, 0);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(963, 45);
            this.pnlTools.TabIndex = 4;
            // 
            // pbHistogram
            // 
            this.pbHistogram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHistogram.Image = ((System.Drawing.Image)(resources.GetObject("pbHistogram.Image")));
            this.pbHistogram.Location = new System.Drawing.Point(913, 9);
            this.pbHistogram.Name = "pbHistogram";
            this.pbHistogram.Size = new System.Drawing.Size(32, 32);
            this.pbHistogram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbHistogram.TabIndex = 7;
            this.pbHistogram.TabStop = false;
            this.pbHistogram.Visible = false;
            this.pbHistogram.Click += new System.EventHandler(this.pbHistogram_Click);
            // 
            // pbImageSaveAs
            // 
            this.pbImageSaveAs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbImageSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("pbImageSaveAs.Image")));
            this.pbImageSaveAs.Location = new System.Drawing.Point(82, 14);
            this.pbImageSaveAs.Name = "pbImageSaveAs";
            this.pbImageSaveAs.Size = new System.Drawing.Size(21, 21);
            this.pbImageSaveAs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImageSaveAs.TabIndex = 6;
            this.pbImageSaveAs.TabStop = false;
            this.pbImageSaveAs.Visible = false;
            this.pbImageSaveAs.Click += new System.EventHandler(this.pbImageSaveAs_Click);
            // 
            // pbUploadImage
            // 
            this.pbUploadImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUploadImage.Image = ((System.Drawing.Image)(resources.GetObject("pbUploadImage.Image")));
            this.pbUploadImage.Location = new System.Drawing.Point(24, 11);
            this.pbUploadImage.Name = "pbUploadImage";
            this.pbUploadImage.Size = new System.Drawing.Size(24, 24);
            this.pbUploadImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbUploadImage.TabIndex = 5;
            this.pbUploadImage.TabStop = false;
            this.pbUploadImage.Click += new System.EventHandler(this.pbUploadImage_Click);
            // 
            // pnlBrightness
            // 
            this.pnlBrightness.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlBrightness.Controls.Add(this.label5);
            this.pnlBrightness.Controls.Add(this.btnImageRotate);
            this.pnlBrightness.Controls.Add(this.nudRotateDegree);
            this.pnlBrightness.Controls.Add(this.pbResetBrightnessAndContrast);
            this.pnlBrightness.Controls.Add(this.lblContrast);
            this.pnlBrightness.Controls.Add(this.trcbContrast);
            this.pnlBrightness.Controls.Add(this.label4);
            this.pnlBrightness.Controls.Add(this.lblBrightnessValue);
            this.pnlBrightness.Controls.Add(this.trcbBrightness);
            this.pnlBrightness.Controls.Add(this.label2);
            this.pnlBrightness.Location = new System.Drawing.Point(489, 537);
            this.pnlBrightness.Name = "pnlBrightness";
            this.pnlBrightness.Size = new System.Drawing.Size(450, 180);
            this.pnlBrightness.TabIndex = 5;
            this.pnlBrightness.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label5.Location = new System.Drawing.Point(94, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Derece";
            // 
            // btnImageRotate
            // 
            this.btnImageRotate.BackColor = System.Drawing.Color.OrangeRed;
            this.btnImageRotate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImageRotate.FlatAppearance.BorderSize = 0;
            this.btnImageRotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImageRotate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnImageRotate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnImageRotate.Location = new System.Drawing.Point(252, 145);
            this.btnImageRotate.Name = "btnImageRotate";
            this.btnImageRotate.Size = new System.Drawing.Size(186, 29);
            this.btnImageRotate.TabIndex = 13;
            this.btnImageRotate.Text = "Döndür";
            this.btnImageRotate.UseVisualStyleBackColor = false;
            this.btnImageRotate.Click += new System.EventHandler(this.btnImageRotate_Click);
            // 
            // nudRotateDegree
            // 
            this.nudRotateDegree.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudRotateDegree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nudRotateDegree.Location = new System.Drawing.Point(12, 145);
            this.nudRotateDegree.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudRotateDegree.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.nudRotateDegree.Name = "nudRotateDegree";
            this.nudRotateDegree.Size = new System.Drawing.Size(234, 29);
            this.nudRotateDegree.TabIndex = 16;
            this.nudRotateDegree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbResetBrightnessAndContrast
            // 
            this.pbResetBrightnessAndContrast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbResetBrightnessAndContrast.Image = ((System.Drawing.Image)(resources.GetObject("pbResetBrightnessAndContrast.Image")));
            this.pbResetBrightnessAndContrast.Location = new System.Drawing.Point(403, 61);
            this.pbResetBrightnessAndContrast.Name = "pbResetBrightnessAndContrast";
            this.pbResetBrightnessAndContrast.Size = new System.Drawing.Size(24, 24);
            this.pbResetBrightnessAndContrast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbResetBrightnessAndContrast.TabIndex = 7;
            this.pbResetBrightnessAndContrast.TabStop = false;
            this.pbResetBrightnessAndContrast.Click += new System.EventHandler(this.pbResetBrightnessAndContrast_Click);
            // 
            // lblContrast
            // 
            this.lblContrast.AutoEllipsis = true;
            this.lblContrast.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblContrast.Location = new System.Drawing.Point(102, 68);
            this.lblContrast.Name = "lblContrast";
            this.lblContrast.Size = new System.Drawing.Size(238, 21);
            this.lblContrast.TabIndex = 15;
            this.lblContrast.Text = "0";
            this.lblContrast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trcbContrast
            // 
            this.trcbContrast.Location = new System.Drawing.Point(3, 91);
            this.trcbContrast.Name = "trcbContrast";
            this.trcbContrast.Size = new System.Drawing.Size(435, 45);
            this.trcbContrast.TabIndex = 14;
            this.trcbContrast.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trcbContrast.Scroll += new System.EventHandler(this.trcbContrast_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label4.Location = new System.Drawing.Point(9, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Kontrast";
            // 
            // lblBrightnessValue
            // 
            this.lblBrightnessValue.AutoEllipsis = true;
            this.lblBrightnessValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBrightnessValue.Location = new System.Drawing.Point(109, 12);
            this.lblBrightnessValue.Name = "lblBrightnessValue";
            this.lblBrightnessValue.Size = new System.Drawing.Size(223, 21);
            this.lblBrightnessValue.TabIndex = 12;
            this.lblBrightnessValue.Text = "0";
            this.lblBrightnessValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trcbBrightness
            // 
            this.trcbBrightness.Location = new System.Drawing.Point(3, 36);
            this.trcbBrightness.Name = "trcbBrightness";
            this.trcbBrightness.Size = new System.Drawing.Size(435, 45);
            this.trcbBrightness.TabIndex = 11;
            this.trcbBrightness.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trcbBrightness.Scroll += new System.EventHandler(this.trcbBrightness_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Parlaklık";
            // 
            // lblImageProcessingWait
            // 
            this.lblImageProcessingWait.AutoSize = true;
            this.lblImageProcessingWait.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblImageProcessingWait.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblImageProcessingWait.Location = new System.Drawing.Point(623, 286);
            this.lblImageProcessingWait.Name = "lblImageProcessingWait";
            this.lblImageProcessingWait.Size = new System.Drawing.Size(185, 60);
            this.lblImageProcessingWait.TabIndex = 6;
            this.lblImageProcessingWait.Text = "Görüntü işleniyor\r\n lütfen bekleyin...";
            this.lblImageProcessingWait.Visible = false;
            // 
            // pnlMove
            // 
            this.pnlMove.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlMove.Controls.Add(this.tbMoveY);
            this.pnlMove.Controls.Add(this.label9);
            this.pnlMove.Controls.Add(this.tbMoveX);
            this.pnlMove.Controls.Add(this.label10);
            this.pnlMove.Location = new System.Drawing.Point(30, 602);
            this.pnlMove.Name = "pnlMove";
            this.pnlMove.Size = new System.Drawing.Size(434, 65);
            this.pnlMove.TabIndex = 22;
            this.pnlMove.Visible = false;
            // 
            // tbMoveY
            // 
            this.tbMoveY.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMoveY.Location = new System.Drawing.Point(227, 24);
            this.tbMoveY.Name = "tbMoveY";
            this.tbMoveY.Size = new System.Drawing.Size(70, 22);
            this.tbMoveY.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label9.Location = new System.Drawing.Point(201, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "y :";
            // 
            // tbMoveX
            // 
            this.tbMoveX.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMoveX.Location = new System.Drawing.Point(121, 24);
            this.tbMoveX.Name = "tbMoveX";
            this.tbMoveX.Size = new System.Drawing.Size(70, 22);
            this.tbMoveX.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label10.Location = new System.Drawing.Point(94, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 21);
            this.label10.TabIndex = 15;
            this.label10.Text = "x :";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 724);
            this.Controls.Add(this.pnlMove);
            this.Controls.Add(this.pnlBrightness);
            this.Controls.Add(this.pnlTools);
            this.Controls.Add(this.pnlFilterChoose);
            this.Controls.Add(this.pbImageOutput);
            this.Controls.Add(this.pbImageSource);
            this.Controls.Add(this.lblImageProcessingWait);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Görüntü İşleme";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageOutput)).EndInit();
            this.pnlFilterChoose.ResumeLayout(false);
            this.pnlFilterChoose.PerformLayout();
            this.pnlWriteToImage.ResumeLayout(false);
            this.pnlWriteToImage.PerformLayout();
            this.pnlMorphologyMaskSize.ResumeLayout(false);
            this.pnlMorphologyMaskSize.PerformLayout();
            this.pnlGaussianMaskSize.ResumeLayout(false);
            this.pnlGaussianMaskSize.PerformLayout();
            this.pnlTools.ResumeLayout(false);
            this.pnlTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHistogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageSaveAs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUploadImage)).EndInit();
            this.pnlBrightness.ResumeLayout(false);
            this.pnlBrightness.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRotateDegree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResetBrightnessAndContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcbContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcbBrightness)).EndInit();
            this.pnlMove.ResumeLayout(false);
            this.pnlMove.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImageSource;
        private System.Windows.Forms.PictureBox pbImageOutput;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel pnlFilterChoose;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.PictureBox pbUploadImage;
        private System.Windows.Forms.PictureBox pbImageSaveAs;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel pnlBrightness;
        private System.Windows.Forms.TrackBar trcbBrightness;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBrightnessValue;
        private System.Windows.Forms.Label lblContrast;
        private System.Windows.Forms.TrackBar trcbContrast;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbResetBrightnessAndContrast;
        private System.Windows.Forms.Panel pnlGaussianMaskSize;
        private System.Windows.Forms.ComboBox cbGaussianMask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnImageRotate;
        private System.Windows.Forms.NumericUpDown nudRotateDegree;
        private System.Windows.Forms.Panel pnlMorphologyMaskSize;
        private System.Windows.Forms.ComboBox cbMorphologyMaskSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblImageProcessingWait;
        private System.Windows.Forms.PictureBox pbHistogram;
        private System.Windows.Forms.Panel pnlWriteToImage;
        private System.Windows.Forms.TextBox tbWriteToImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSelectFont;
        private System.Windows.Forms.ComboBox cbSelectColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Panel pnlMove;
        private System.Windows.Forms.TextBox tbMoveX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbMoveY;
        private System.Windows.Forms.Label label9;
    }
}

