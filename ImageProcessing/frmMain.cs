using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class frmMain : Form
    {
        static Bitmap filteredImage;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SetBrightnessTrackOptions();
            SetContrastTrackOptions();
            cbFilters.SelectedIndex = 25;

        }

        private void pbUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resimler|*.bmp;*.png;*.jpeg;*.jpg|All Files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbImageSource.ImageLocation = openFileDialog.FileName;
                pnlFilterChoose.Visible = true;
                pbHistogram.Visible = true;
            }
        }

        private async void btnApplyFilter_Click(object sender, EventArgs e)
        {
            pbImageOutput.Visible = false;
            pnlBrightness.Visible = false;
            lblImageProcessingWait.Visible = true;

            btnApplyFilter.Enabled = false;

            await Task.Run(() => Thread.Sleep(100));

            if (cbFilters.SelectedIndex == 0)
            {
                Bitmap image = new Bitmap(pbImageSource.Image);
                Bitmap grayFilter = GrayFilter(image);
                filteredImage = grayFilter;
            }
            else if (cbFilters.SelectedIndex == 1)
            {
                Bitmap image = new Bitmap(pbImageSource.Image);
                Bitmap negativeFilter = NegativeFilter(image);
                filteredImage = negativeFilter;
            }
            else if (cbFilters.SelectedIndex == 2)
            {
                Bitmap image = new Bitmap(pbImageSource.Image);
                Bitmap negativeGrayFilter = NegativeGrayFilter(image);
                filteredImage = negativeGrayFilter;
            }
            else if (cbFilters.SelectedIndex == 3)
            {
                Bitmap image = new Bitmap(pbImageSource.Image);
                Bitmap binaryFilter = BinaryFilter(image);
                filteredImage = binaryFilter;
            }
            else if (cbFilters.SelectedIndex == 4)
            {
                Bitmap image = new Bitmap(pbImageSource.Image);
                Bitmap sepiaFilter = SepiaTone(image);
                filteredImage = sepiaFilter;
            }
            else if (cbFilters.SelectedIndex == 5)
            {
                Bitmap image = new Bitmap(pbImageSource.Image);
                Bitmap sobelEdgeFilter = SobelEdgeFilter(image);
                filteredImage = sobelEdgeFilter;
            }
            else if (cbFilters.SelectedIndex == 6)
            {
                Bitmap image = new Bitmap(pbImageSource.Image);
                Bitmap histogramEqualization = HistogramEqualization(image);
                filteredImage = histogramEqualization;
            }
            else if (cbFilters.SelectedIndex == 7)
            {
                Bitmap image = new Bitmap(pbImageSource.Image);
                int mask = 0;

                if (cbGaussianMask.SelectedIndex == 0)
                    mask = 3;
                else if (cbGaussianMask.SelectedIndex == 1)
                    mask = 5;
                else
                    mask = 10;

                Bitmap gaussianFilter = GaussianFilter(image, GaussianBlur(mask, mask));
                filteredImage = gaussianFilter;
            }
            else if (cbFilters.SelectedIndex == 8)
            {
                Bitmap image = new Bitmap(pbImageSource.Image);
                Bitmap meanFilter = MeanFilter(image);
                filteredImage = meanFilter;
            }
            else if (cbFilters.SelectedIndex == 9)
            {
                Bitmap image = new Bitmap(pbImageSource.Image);
                Bitmap medianFilter = MedianFilter(image);
                filteredImage = medianFilter;
            }
            else if (cbFilters.SelectedIndex == 10)
            {
                Bitmap image = new Bitmap(pbImageSource.Image);
                Bitmap laplacianFilter = LaplacianFilter(image);
                filteredImage = laplacianFilter;
            }
            else if (cbFilters.SelectedIndex == 11)
            {
                Bitmap image = new Bitmap(pbImageSource.Image);
                Bitmap prewittFilter = PrewittFilter(image);
                filteredImage = prewittFilter;
            }
            else if (cbFilters.SelectedIndex == 12)
            {
                Bitmap image = new Bitmap(pbImageSource.Image);
                Bitmap imageMirroring = ImageMirroring(image);
                filteredImage = imageMirroring;
            }
            else if (cbFilters.SelectedIndex == 13)
            {
                Bitmap image = new Bitmap(pbImageSource.Image);
                Bitmap imageInversion = ImageInversion(image);
                filteredImage = imageInversion;
            }
            else if (cbFilters.SelectedIndex == 14)
            {
                Bitmap image = new Bitmap(pbImageSource.Image);
                Bitmap dilation = Dilation(image);
                filteredImage = dilation;
            }
            else if (cbFilters.SelectedIndex == 15)
            {
                Bitmap image = new Bitmap(pbImageSource.Image);
                Bitmap erosion = Erosion(image);
                filteredImage = erosion;
            }
            else if (cbFilters.SelectedIndex == 16)
            {
                Bitmap image = new Bitmap(pbImageSource.Image);
                Bitmap opening = OpeningMorphological(image);
                filteredImage = opening;
            }
            else if (cbFilters.SelectedIndex == 17)
            {
                Bitmap image = new Bitmap(pbImageSource.Image);
                Bitmap closing = ClosingMorphological(image);
                filteredImage = closing;
            }
            else if (cbFilters.SelectedIndex == 18)
            {
                Bitmap image = new Bitmap(pbImageSource.Image);
                Bitmap imageSharpening = ImageSharpening(image);
                filteredImage = imageSharpening;
            }
            else if (cbFilters.SelectedIndex == 19)
            {
                if (fontForWriteToImage != null)
                {
                    Bitmap image = new Bitmap(pbImageSource.Image);
                    Bitmap writeToImage = WriteToImage(image, tbWriteToImage.Text);
                    filteredImage = writeToImage;
                }
                else
                {
                    MessageBox.Show("Lütfen font ayarlarınızı seçininz", "Font ayarı seçilmedi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (cbFilters.SelectedIndex == 20)
            {
                if (clipping != null)
                {
                }
                else
                {
                    MessageBox.Show("Lütfen kırpılacak alanı seçin", "Kırpılacak alan seçilmedi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (cbFilters.SelectedIndex == 21)
            {
                Bitmap image = new Bitmap(pbImageSource.Image);
                Bitmap konvolusyon = Konvolusyon(image);
                filteredImage = konvolusyon;
            }
            else if (cbFilters.SelectedIndex == 22)
            {
                Bitmap image = new Bitmap(pbImageSource.Image);
                Bitmap drawWithPencil = DrawWithPencil(image);
                filteredImage = drawWithPencil;
            }
            else if (cbFilters.SelectedIndex == 22)
            {
                filteredImage = new Bitmap(pbImageSource.Image);
            }
            else if (cbFilters.SelectedIndex == 23)
            {
                Bitmap image = new Bitmap(pbImageSource.Image);
                Bitmap tasima = MoveOperation(image);
                filteredImage = tasima;
            }
            else if (cbFilters.SelectedIndex == 24)
            {
                Bitmap image = new Bitmap(pbImageSource.Image);
                Bitmap resim = Reduction(image);
                filteredImage = resim;
            }
            else
            {
                filteredImage = new Bitmap(pbImageSource.Image);
            }

            pbImageOutput.Image = filteredImage;

            btnApplyFilter.Enabled = true;
            pbImageSaveAs.Visible = true;
            pbImageOutput.Visible = true;
            pnlBrightness.Visible = true;
            lblImageProcessingWait.Visible = false;

            ResetBrightnessAndContrast();
        }

        //public Bitmap GrayFilter(Bitmap bitmap)
        //{
        //    for (int i = 0; i < bitmap.Height; i++)
        //    {
        //        for (int j = 0; j < bitmap.Width; j++)
        //        {
        //            int value = (bitmap.GetPixel(j, i).R + bitmap.GetPixel(j, i).G + bitmap.GetPixel(j, i).B) / 3;
        //            Color color = Color.FromArgb(value, value, value);
        //            bitmap.SetPixel(j, i, color);
        //        }
        //    }

        //    return bitmap;
        //}

        public static Bitmap GrayFilter(Bitmap image)
        {
            Color color;
            int value;

            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    value = Convert.ToInt32((0.299 * image.GetPixel(j, i).R) + (0.587 * image.GetPixel(j, i).G) + (0.114 * image.GetPixel(j, i).B));

                    color = Color.FromArgb(value, value, value);
                    image.SetPixel(j, i, color);
                }
            }

            return image;
        }

        public Bitmap NegativeFilter(Bitmap image)
        {
            Color color;
            int red, green, blue;

            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    red = 255 - image.GetPixel(j, i).R;
                    green = 255 - image.GetPixel(j, i).G;
                    blue = 255 - image.GetPixel(j, i).B;

                    color = Color.FromArgb(red, green, blue);
                    image.SetPixel(j, i, color);
                }
            }

            return image;
        }

        public Bitmap NegativeGrayFilter(Bitmap image)
        {
            Color color;
            int value;

            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    value = ((255 - image.GetPixel(j, i).R) + (255 - image.GetPixel(j, i).G) + (255 - image.GetPixel(j, i).B)) / 3;

                    color = Color.FromArgb(value, value, value);
                    image.SetPixel(j, i, color);
                }
            }

            return image;
        }

        public Bitmap BinaryFilter(Bitmap image) // Thresholding(Eşikleme)
        {
            Bitmap grayFilter = GrayFilter(image);
            int thresholdValue = 130;
            Color color;

            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    if (grayFilter.GetPixel(j, i).R < thresholdValue)
                    {
                        color = Color.FromArgb(0, 0, 0);
                    }
                    else
                    {
                        color = Color.FromArgb(255, 255, 255);
                    }
                    image.SetPixel(j, i, color);
                }
            }

            return image;
        }

        public Bitmap SepiaTone(Bitmap image)
        {
            Color color;
            int red, green, blue;

            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    red = Convert.ToInt32((image.GetPixel(j, i).R * 0.393) + (image.GetPixel(j, i).G * 0.769) + (image.GetPixel(j, i).B * 0.189));
                    green = Convert.ToInt32((image.GetPixel(j, i).R * 0.349) + (image.GetPixel(j, i).G * 0.686) + (image.GetPixel(j, i).B * 0.168));
                    blue = Convert.ToInt32((image.GetPixel(j, i).R * 0.272) + (image.GetPixel(j, i).G * 0.534) + (image.GetPixel(j, i).B * 0.131));

                    if (red > 255)
                    {
                        red = 255;
                    }
                    if (green > 255)
                    {
                        green = 255;
                    }
                    if (blue > 255)
                    {
                        blue = 255;
                    }

                    color = Color.FromArgb(red, green, blue);
                    image.SetPixel(j, i, color);
                }
            }
            return image;
        }
        public Bitmap Brightness(Bitmap image, int brightnessValue)
        {
            Bitmap buffer = new Bitmap(image.Width, image.Height);
            Color color;
            int red, green, blue;

            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    red = image.GetPixel(j, i).R + brightnessValue;
                    green = image.GetPixel(j, i).G + brightnessValue;
                    blue = image.GetPixel(j, i).B + brightnessValue;

                    if (red > 255)
                        red = 255;
                    else if (red < 0)
                        red = 0;

                    if (green > 255)
                        green = 255;
                    else if (green < 0)
                        green = 0;

                    if (blue > 255)
                        blue = 255;
                    else if (blue < 0)
                        blue = 0;

                    color = Color.FromArgb(red, green, blue);
                    buffer.SetPixel(j, i, color);
                }
            }

            return buffer;
        }

        public Bitmap Contrast(Bitmap image, double contrastLevel)
        {
            Bitmap buffer = new Bitmap(image.Width, image.Height);
            Color color;
            int red, green, blue;

            double factor = (259 * (contrastLevel + 255)) / (255 * (259 - contrastLevel));

            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {

                    red = (int)((factor * (image.GetPixel(j, i).R - 128)) + 128);
                    green = (int)((factor * (image.GetPixel(j, i).G - 128)) + 128);
                    blue = (int)((factor * (image.GetPixel(j, i).B - 128)) + 128);

                    if (red > 255)
                        red = 255;
                    else if (red < 0)
                        red = 0;

                    if (green > 255)
                        green = 255;
                    else if (green < 0)
                        green = 0;

                    if (blue > 255)
                        blue = 255;
                    else if (blue < 0)
                        blue = 0;

                    color = Color.FromArgb(red, green, blue);
                    buffer.SetPixel(j, i, color);
                }
            }

            return buffer;
        }

        public Bitmap SobelEdgeFilter(Bitmap image)
        {
            Bitmap grayImage = GrayFilter(image);
            Bitmap buffer = new Bitmap(grayImage.Width, grayImage.Height);
            Color color;

            int sumX, sumY, total;

            int[,] maskX = new int[3, 3];
            int[,] maskY = new int[3, 3];

            maskX[0, 0] = -1; maskX[0, 1] = 0; maskX[0, 2] = 1;
            maskX[1, 0] = -2; maskX[1, 1] = 0; maskX[1, 2] = 2;
            maskX[2, 0] = -1; maskX[2, 1] = 0; maskX[2, 2] = 1;

            maskY[0, 0] = 1; maskY[0, 1] = 2; maskY[0, 2] = 1;
            maskY[1, 0] = 0; maskY[1, 1] = 0; maskY[1, 2] = 0;
            maskY[2, 0] = -1; maskY[2, 1] = -2; maskY[2, 2] = -1;

            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    if (i == 0 || i == grayImage.Height - 1 || j == 0 || j == grayImage.Width - 1)
                    {
                        color = Color.FromArgb(255, 255, 255);
                        buffer.SetPixel(j, i, color);
                    }
                    else
                    {
                        sumX = grayImage.GetPixel(j - 1, i - 1).R * maskX[0, 0] +
                            grayImage.GetPixel(j, i - 1).R * maskX[0, 1] +
                            grayImage.GetPixel(j + 1, i - 1).R * maskX[0, 2] +

                            grayImage.GetPixel(j - 1, i).R * maskX[1, 0] +
                            grayImage.GetPixel(j, i).R * maskX[1, 1] +
                            grayImage.GetPixel(j + 1, i).R * maskX[1, 2] +

                            grayImage.GetPixel(j - 1, i + 1).R * maskX[2, 0] +
                            grayImage.GetPixel(j, i + 1).R * maskX[2, 1] +
                            grayImage.GetPixel(j + 1, i + 1).R * maskX[2, 2];

                        sumY = grayImage.GetPixel(j - 1, i - 1).R * maskY[0, 0] +
                            grayImage.GetPixel(j, i - 1).R * maskY[0, 1] +
                            grayImage.GetPixel(j + 1, i - 1).R * maskY[0, 2] +

                            grayImage.GetPixel(j - 1, i).R * maskY[1, 0] +
                            grayImage.GetPixel(j, i).R * maskY[1, 1] +
                            grayImage.GetPixel(j + 1, i).R * maskY[1, 2] +

                            grayImage.GetPixel(j - 1, i + 1).R * maskY[2, 0] +
                            grayImage.GetPixel(j, i + 1).R * maskY[2, 1] +
                            grayImage.GetPixel(j + 1, i + 1).R * maskY[2, 2];

                        total = Math.Abs(sumX) + Math.Abs(sumY);

                        if (total > 255)
                        {
                            total = 255;
                        }
                        else if (total < 0)
                        {
                            total = 0;
                        }

                        color = Color.FromArgb(total, total, total);
                        buffer.SetPixel(j, i, color);
                    }
                }
            }

            return buffer;
        }

        public Bitmap HistogramEqualization(Bitmap image)
        {
            int w = image.Width;
            int h = image.Height;
            BitmapData sd = image.LockBits(new Rectangle(0, 0, w, h), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            int bytes = sd.Stride * sd.Height;
            byte[] buffer = new byte[bytes];
            byte[] result = new byte[bytes];
            Marshal.Copy(sd.Scan0, buffer, 0, bytes);
            image.UnlockBits(sd);
            int current = 0;
            double[] pn = new double[256];
            for (int p = 0; p < bytes; p += 4)
            {
                pn[buffer[p]]++;
            }
            for (int prob = 0; prob < pn.Length; prob++)
            {
                pn[prob] /= (w * h);
            }
            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    current = y * sd.Stride + x * 4;
                    double sum = 0;
                    for (int i = 0; i < buffer[current]; i++)
                    {
                        sum += pn[i];
                    }
                    for (int c = 0; c < 3; c++)
                    {
                        result[current + c] = (byte)Math.Floor(255 * sum);
                    }
                    result[current + 3] = 255;
                }
            }
            Bitmap res = new Bitmap(w, h);
            BitmapData rd = res.LockBits(new Rectangle(0, 0, w, h), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            Marshal.Copy(result, 0, rd.Scan0, bytes);
            res.UnlockBits(rd);
            return res;
        }

        private void pbImageSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog.Title = "Save an Image File";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                FileStream fileStream = (System.IO.FileStream)saveFileDialog.OpenFile();

                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        pbImageOutput.Image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        pbImageOutput.Image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        pbImageOutput.Image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fileStream.Close();
                MessageBox.Show("Resim dosyası kaydedildi", "Kaydedildi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        public static double[,] GaussianBlur(int lenght, double weight)
        {
            double[,] kernel = new double[lenght, lenght];
            double kernelSum = 0;
            int foff = (lenght - 1) / 2;
            double distance = 0;
            double constant = 1d / (2 * Math.PI * weight * weight);
            for (int y = -foff; y <= foff; y++)
            {
                for (int x = -foff; x <= foff; x++)
                {
                    distance = ((y * y) + (x * x)) / (2 * weight * weight);
                    kernel[y + foff, x + foff] = constant * Math.Exp(-distance);
                    kernelSum += kernel[y + foff, x + foff];
                }
            }
            for (int y = 0; y < lenght; y++)
            {
                for (int x = 0; x < lenght; x++)
                {
                    kernel[y, x] = kernel[y, x] * 1d / kernelSum;
                }
            }
            return kernel;
        }

        public static Bitmap GaussianFilter(Bitmap srcImage, double[,] kernel)
        {
            int width = srcImage.Width;
            int height = srcImage.Height;
            BitmapData srcData = srcImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            int bytes = srcData.Stride * srcData.Height;
            byte[] buffer = new byte[bytes];
            byte[] result = new byte[bytes];
            Marshal.Copy(srcData.Scan0, buffer, 0, bytes);
            srcImage.UnlockBits(srcData);
            int colorChannels = 3;
            double[] rgb = new double[colorChannels];
            int foff = (kernel.GetLength(0) - 1) / 2;
            int kcenter = 0;
            int kpixel = 0;
            for (int y = foff; y < height - foff; y++)
            {
                for (int x = foff; x < width - foff; x++)
                {
                    for (int c = 0; c < colorChannels; c++)
                    {
                        rgb[c] = 0.0;
                    }
                    kcenter = y * srcData.Stride + x * 4;
                    for (int fy = -foff; fy <= foff; fy++)
                    {
                        for (int fx = -foff; fx <= foff; fx++)
                        {
                            kpixel = kcenter + fy * srcData.Stride + fx * 4;
                            for (int c = 0; c < colorChannels; c++)
                            {
                                rgb[c] += (double)(buffer[kpixel + c]) * kernel[fy + foff, fx + foff];
                            }
                        }
                    }
                    for (int c = 0; c < colorChannels; c++)
                    {
                        if (rgb[c] > 255)
                        {
                            rgb[c] = 255;
                        }
                        else if (rgb[c] < 0)
                        {
                            rgb[c] = 0;
                        }
                    }
                    for (int c = 0; c < colorChannels; c++)
                    {
                        result[kcenter + c] = (byte)rgb[c];
                    }
                    result[kcenter + 3] = 255;
                }
            }
            Bitmap resultImage = new Bitmap(width, height);
            BitmapData resultData = resultImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            Marshal.Copy(result, 0, resultData.Scan0, bytes);
            resultImage.UnlockBits(resultData);
            return resultImage;
        }

        public Bitmap MeanFilter(Bitmap image)
        {
            Bitmap buffer = new Bitmap(image.Width, image.Height);
            Color color;
            int red, green, blue;

            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    if (i == 0 || i == image.Height - 1 || j == 0 || j == image.Width - 1)
                    {
                        color = Color.FromArgb(image.GetPixel(j, i).R, image.GetPixel(j, i).G, image.GetPixel(j, i).B);
                        buffer.SetPixel(j, i, color);
                    }
                    else
                    {
                        red = image.GetPixel(j - 1, i - 1).R + image.GetPixel(j, i - 1).R + image.GetPixel(j + 1, i - 1).R +
                                  image.GetPixel(j - 1, i).R + image.GetPixel(j, i).R + image.GetPixel(j + 1, i).R +
                                   image.GetPixel(j - 1, i + 1).R + image.GetPixel(j, i + 1).R + image.GetPixel(j + 1, i + 1).R;

                        green = image.GetPixel(j - 1, i - 1).G + image.GetPixel(j, i - 1).G + image.GetPixel(j + 1, i - 1).G +
                                  image.GetPixel(j - 1, i).G + image.GetPixel(j, i).G + image.GetPixel(j + 1, i).G +
                                   image.GetPixel(j - 1, i + 1).G + image.GetPixel(j, i + 1).G + image.GetPixel(j + 1, i + 1).G;

                        blue = image.GetPixel(j - 1, i - 1).B + image.GetPixel(j, i - 1).B + image.GetPixel(j + 1, i - 1).B +
                                  image.GetPixel(j - 1, i).B + image.GetPixel(j, i).B + image.GetPixel(j + 1, i).B +
                                   image.GetPixel(j - 1, i + 1).B + image.GetPixel(j, i + 1).B + image.GetPixel(j + 1, i + 1).B;


                        color = Color.FromArgb(red / 9, green / 9, blue / 9);
                        buffer.SetPixel(j, i, color);
                    }

                }
            }

            return buffer;
        }

        public Bitmap MedianFilter(Bitmap image)
        {
            Bitmap buffer = new Bitmap(image.Width, image.Height);
            Bitmap grayImage = GrayFilter(image);
            Color color;

            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    if (i == 0 || i == image.Height - 1 || j == 0 || j == image.Width - 1)
                    {
                        color = Color.FromArgb(grayImage.GetPixel(j, i).R, grayImage.GetPixel(j, i).G, grayImage.GetPixel(j, i).B);
                        buffer.SetPixel(j, i, color);
                    }
                    else
                    {
                        int[] values = new int[9];

                        values[0] = grayImage.GetPixel(j - 1, i - 1).R; values[1] = grayImage.GetPixel(j, i - 1).R; values[2] = grayImage.GetPixel(j + 1, i - 1).R;
                        values[3] = grayImage.GetPixel(j - 1, i).R; values[4] = grayImage.GetPixel(j, i).R; values[5] = grayImage.GetPixel(j + 1, i).R;
                        values[6] = grayImage.GetPixel(j - 1, i + 1).R; values[7] = grayImage.GetPixel(j, i + 1).R; values[8] = grayImage.GetPixel(j + 1, i + 1).R;

                        // Sorting
                        int smallestNumberIndex;
                        for (int k = 0; k < values.Length; k++)
                        {
                            smallestNumberIndex = k;
                            for (int z = k + 1; z < values.Length; z++)
                            {
                                if (values[smallestNumberIndex] > values[z])
                                {
                                    smallestNumberIndex = z;
                                }
                            }

                            int temp = values[k];
                            values[k] = values[smallestNumberIndex];
                            values[smallestNumberIndex] = temp;
                        }

                        color = Color.FromArgb(values[4], values[4], values[4]); // Dizideki ortanca değer 4 indexli değerdir
                        buffer.SetPixel(j, i, color);
                    }

                }
            }

            return buffer;
        }

        public Bitmap LaplacianFilter(Bitmap image)
        {
            Bitmap buffer = new Bitmap(image.Width, image.Height);
            Color color;
            int red, green, blue;

            //int[,] mask = new int[3, 3];

            //mask[0, 0] = 0; mask[0, 1] = 1; mask[0, 2] = 0;
            //mask[1, 0] = 1; mask[1, 1] = -4; mask[1, 2] = 1;
            //mask[2, 0] = 0; mask[2, 1] = 1; mask[2, 2] = 0;

            int[,] mask = new int[3, 3];

            mask[0, 0] = 1; mask[0, 1] = 1; mask[0, 2] = 1;
            mask[1, 0] = 1; mask[1, 1] = -8; mask[1, 2] = 1;
            mask[2, 0] = 1; mask[2, 1] = 1; mask[2, 2] = 1;

            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    if (i == 0 || i == image.Height - 1 || j == 0 || j == image.Width - 1)
                    {
                        color = Color.FromArgb(image.GetPixel(j, i).R, image.GetPixel(j, i).G, image.GetPixel(j, i).B);
                        buffer.SetPixel(j, i, color);
                    }
                    else
                    {
                        red = (image.GetPixel(j - 1, i - 1).R * mask[0, 0]) + (image.GetPixel(j, i - 1).R * mask[0, 1]) + (image.GetPixel(j + 1, i - 1).R * mask[0, 2]) +
                        (image.GetPixel(j - 1, i).R * mask[1, 0]) + (image.GetPixel(j, i).R * mask[1, 1]) + (image.GetPixel(j + 1, i).R * mask[1, 2]) +
                        (image.GetPixel(j - 1, i + 1).R * mask[2, 0]) + (image.GetPixel(j, i + 1).R * mask[2, 1]) + (image.GetPixel(j + 1, i + 1).R * mask[2, 2]);

                        green = (image.GetPixel(j - 1, i - 1).G * mask[0, 0]) + (image.GetPixel(j, i - 1).G * mask[0, 1]) + (image.GetPixel(j + 1, i - 1).G * mask[0, 2]) +
                        (image.GetPixel(j - 1, i).G * mask[1, 0]) + (image.GetPixel(j, i).G * mask[1, 1]) + (image.GetPixel(j + 1, i).G * mask[1, 2]) +
                        (image.GetPixel(j - 1, i + 1).G * mask[2, 0]) + (image.GetPixel(j, i + 1).G * mask[2, 1]) + (image.GetPixel(j + 1, i + 1).G * mask[2, 2]);

                        blue = (image.GetPixel(j - 1, i - 1).B * mask[0, 0]) + (image.GetPixel(j, i - 1).B * mask[0, 1]) + (image.GetPixel(j + 1, i - 1).B * mask[0, 2]) +
                        (image.GetPixel(j - 1, i).B * mask[1, 0]) + (image.GetPixel(j, i).B * mask[1, 1]) + (image.GetPixel(j + 1, i).B * mask[1, 2]) +
                        (image.GetPixel(j - 1, i + 1).B * mask[2, 0]) + (image.GetPixel(j, i + 1).B * mask[2, 1]) + (image.GetPixel(j + 1, i + 1).B * mask[2, 2]);

                        red = image.GetPixel(j, i).R - red;
                        green = image.GetPixel(j, i).G - green;
                        blue = image.GetPixel(j, i).B - blue;

                        red = (red + image.GetPixel(j, i).R) / 2;
                        green = (green + image.GetPixel(j, i).G) / 2;
                        blue = (blue + image.GetPixel(j, i).B) / 2;

                        if (red > 255)
                            red = 255;
                        else if (red < 0)
                            red = 0;

                        if (green > 255)
                            green = 255;
                        else if (green < 0)
                            green = 0;

                        if (blue > 255)
                            blue = 255;
                        else if (blue < 0)
                            blue = 0;

                        color = Color.FromArgb(red, green, blue);
                        buffer.SetPixel(j, i, color);
                    }

                }
            }

            return buffer;
        }

        public Bitmap PrewittFilter(Bitmap image)
        {
            Bitmap buffer = new Bitmap(image.Width, image.Height);
            Color color;
            int sumX, sumY, sum;
            int[,] maskX = new int[3, 3];
            int[,] maskY = new int[3, 3];

            maskX[0, 0] = -1; maskX[0, 1] = -1; maskX[0, 2] = -1;
            maskX[1, 0] = 0; maskX[1, 1] = 0; maskX[1, 2] = 0;
            maskX[2, 0] = 1; maskX[2, 1] = 1; maskX[2, 2] = 1;

            maskY[0, 0] = -1; maskY[0, 1] = 0; maskY[0, 2] = 1;
            maskY[1, 0] = -1; maskY[1, 1] = 0; maskY[1, 2] = 1;
            maskY[2, 0] = -1; maskY[2, 1] = 0; maskY[2, 2] = 1;

            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    if (i == 0 || i == image.Height - 1 || j == 0 || j == image.Width - 1)
                    {
                        color = Color.FromArgb(0, 0, 0);
                        buffer.SetPixel(j, i, color);
                    }
                    else
                    {
                        sumX = image.GetPixel(j - 1, i - 1).R * maskX[0, 0] +
                            image.GetPixel(j, i - 1).R * maskX[0, 1] +
                            image.GetPixel(j + 1, i - 1).R * maskX[0, 2] +

                            image.GetPixel(j - 1, i).R * maskX[1, 0] +
                            image.GetPixel(j, i).R * maskX[1, 1] +
                            image.GetPixel(j + 1, i).R * maskX[1, 2] +

                            image.GetPixel(j - 1, i + 1).R * maskX[2, 0] +
                            image.GetPixel(j, i + 1).R * maskX[2, 1] +
                            image.GetPixel(j + 1, i + 1).R * maskX[2, 2];

                        sumY = image.GetPixel(j - 1, i - 1).R * maskY[0, 0] +
                            image.GetPixel(j, i - 1).R * maskY[0, 1] +
                            image.GetPixel(j + 1, i - 1).R * maskY[0, 2] +

                            image.GetPixel(j - 1, i).R * maskY[1, 0] +
                            image.GetPixel(j, i).R * maskY[1, 1] +
                            image.GetPixel(j + 1, i).R * maskY[1, 2] +

                            image.GetPixel(j - 1, i + 1).R * maskY[2, 0] +
                            image.GetPixel(j, i + 1).R * maskY[2, 1] +
                            image.GetPixel(j + 1, i + 1).R * maskY[2, 2];

                        sum = Math.Abs(sumX) + Math.Abs(sumY);

                        if (sum > 255)
                        {
                            sum = 255;
                        }
                        else if (sum < 0)
                        {
                            sum = 0;
                        }

                        color = Color.FromArgb(sum, sum, sum);
                        buffer.SetPixel(j, i, color);
                    }
                }
            }

            return buffer;
        }

        public Bitmap RotateImage(Bitmap image, int angle)
        {
            Bitmap buffer = new Bitmap(image.Width, image.Height);

            double radian = angle * 2 * Math.PI / 360;
            double x = 0, y = 0;

            //Resim merkezini buluyor. Resim merkezi etrafında döndürecek.
            int midX = image.Width / 2;
            int midY = image.Height / 2;

            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {

                    x = ((j - midX) * Math.Cos(radian)) + ((i - midY) * Math.Sin(radian));
                    y = -((j - midX) * Math.Sin(radian)) + ((i - midY) * Math.Cos(radian));

                    x += midX;
                    y += midY;

                    if (x >= 0 && y >= 0 && x < image.Width && y < image.Height)
                    {
                        buffer.SetPixel(j, i, image.GetPixel((int)x, (int)y));
                    }
                }
            }

            return buffer;
        }

        private void btnImageRotate_Click(object sender, EventArgs e)
        {
            int angle = Convert.ToInt32(nudRotateDegree.Value);
            pbImageOutput.Image = RotateImage(filteredImage, angle);
        }

        public Bitmap ImageMirroring(Bitmap image)
        {
            Bitmap buffer = new Bitmap(image.Width, image.Height);
            Color colorLeft, colorRight;

            int[] leftPixelRGB = new int[3];
            int[] rightPixelRGB = new int[3];

            int width = 0;
            if (image.Width % 2 == 0)
            {
                width = (image.Width / 2);
            }
            else
            {
                width = (image.Width / 2) + 1;
            }

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    leftPixelRGB[0] = image.GetPixel(i, j).R;
                    leftPixelRGB[1] = image.GetPixel(i, j).G;
                    leftPixelRGB[2] = image.GetPixel(i, j).B;

                    rightPixelRGB[0] = image.GetPixel(image.Width - 1 - i, j).R;
                    rightPixelRGB[1] = image.GetPixel(image.Width - 1 - i, j).G;
                    rightPixelRGB[2] = image.GetPixel(image.Width - 1 - i, j).B;

                    colorLeft = Color.FromArgb(leftPixelRGB[0], leftPixelRGB[1], leftPixelRGB[2]);
                    colorRight = Color.FromArgb(rightPixelRGB[0], rightPixelRGB[1], rightPixelRGB[2]);

                    buffer.SetPixel(i, j, colorRight);
                    buffer.SetPixel(image.Width - 1 - i, j, colorLeft);
                }
            }

            return buffer;
        }

        public Bitmap ImageInversion(Bitmap image)
        {
            Bitmap buffer = new Bitmap(image.Width, image.Height);
            Color colorLeft, colorRight;

            int[] topPixelRGB = new int[3];
            int[] bottomPixelRGB = new int[3];

            int height = 0;
            if (image.Height % 2 == 0)
            {
                height = (image.Height / 2);
            }
            else
            {
                height = (image.Height / 2) + 1;
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    topPixelRGB[0] = image.GetPixel(j, i).R;
                    topPixelRGB[1] = image.GetPixel(j, i).G;
                    topPixelRGB[2] = image.GetPixel(j, i).B;

                    bottomPixelRGB[0] = image.GetPixel(j, image.Height - 1 - i).R;
                    bottomPixelRGB[1] = image.GetPixel(j, image.Height - 1 - i).G;
                    bottomPixelRGB[2] = image.GetPixel(j, image.Height - 1 - i).B;

                    colorLeft = Color.FromArgb(topPixelRGB[0], topPixelRGB[1], topPixelRGB[2]);
                    colorRight = Color.FromArgb(bottomPixelRGB[0], bottomPixelRGB[1], bottomPixelRGB[2]);

                    buffer.SetPixel(j, i, colorRight);
                    buffer.SetPixel(j, image.Height - 1 - i, colorLeft);
                }
            }

            return buffer;
        }

        public Bitmap Dilation(Bitmap image)
        {
            Bitmap dilation = new Bitmap(image.Width, image.Height);
            if (cbMorphologyMaskSize.SelectedIndex == 0)
            {
                dilation = DilationMask(image, 3);
            }
            else if (cbMorphologyMaskSize.SelectedIndex == 1)
            {
                dilation = DilationMask(image, 5);
            }
            else if (cbMorphologyMaskSize.SelectedIndex == 2)
            {
                dilation = DilationMask(image, 9);
            }
            return dilation;
        }

        public Bitmap DilationMask(Bitmap image, int length)
        {
            Bitmap buffer = new Bitmap(image.Width, image.Height);
            Bitmap binaryImage = BinaryFilter(image);
            Color color;

            int gridCount = length / 2;

            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    if (i < gridCount || i >= image.Height - gridCount || j < gridCount || j >= image.Width - gridCount)
                    {
                        color = Color.FromArgb(0, 0, 0);
                        buffer.SetPixel(j, i, color);
                    }
                    else
                    {
                        int[,] values = new int[length, length];

                        for (int k = 0; k < length; k++)
                        {
                            for (int z = 0; z < length; z++)
                            {
                                values[k, z] = binaryImage.GetPixel(j - (gridCount - z), i - (gridCount - k)).R;
                            }
                        }

                        int counter = 0;
                        for (int k = 0; k < length; k++)
                        {
                            for (int z = 0; z < length; z++)
                            {
                                if (values[k, z] == 255)
                                {
                                    counter++;
                                    break;
                                }
                            }
                        }

                        if (counter > 0)
                        {
                            color = Color.FromArgb(255, 255, 255);
                            buffer.SetPixel(j, i, color);
                        }
                        else
                        {
                            color = Color.FromArgb(0, 0, 0);
                            buffer.SetPixel(j, i, color);
                        }

                    }
                }
            }

            return buffer;
        }

        public Bitmap Erosion(Bitmap image)
        {
            Bitmap erosion = new Bitmap(image.Width, image.Height);
            if (cbMorphologyMaskSize.SelectedIndex == 0)
            {
                erosion = ErosionMask(image, 3);
            }
            else if (cbMorphologyMaskSize.SelectedIndex == 1)
            {
                erosion = ErosionMask(image, 5);
            }
            else if (cbMorphologyMaskSize.SelectedIndex == 2)
            {
                erosion = ErosionMask(image, 10);
            }
            return erosion;
        }

        public Bitmap ErosionMask(Bitmap image, int length)
        {
            Bitmap buffer = new Bitmap(image.Width, image.Height);
            Bitmap binaryImage = BinaryFilter(image);
            Color color;

            int gridCount = length / 2;

            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    if (i < gridCount || i >= image.Height - gridCount || j < gridCount || j >= image.Width - gridCount)
                    {
                        color = Color.FromArgb(0, 0, 0);
                        buffer.SetPixel(j, i, color);
                    }
                    else
                    {
                        int[,] values = new int[length, length];

                        for (int k = 0; k < length; k++)
                        {
                            for (int z = 0; z < length; z++)
                            {
                                values[k, z] = binaryImage.GetPixel(j - (gridCount - z), i - (gridCount - k)).R;
                            }
                        }

                        int counter = 0;
                        for (int k = 0; k < length; k++)
                        {
                            for (int z = 0; z < length; z++)
                            {
                                if (values[k, z] == 0)
                                {
                                    counter++;
                                    break;
                                }
                            }
                        }

                        if (counter > 0)
                        {
                            color = Color.FromArgb(0, 0, 0);
                            buffer.SetPixel(j, i, color);
                        }
                        else
                        {
                            color = Color.FromArgb(255, 255, 255);
                            buffer.SetPixel(j, i, color);
                        }

                    }
                }
            }

            return buffer;
        }

        public Bitmap OpeningMorphological(Bitmap image)
        {
            Bitmap buffer = new Bitmap(image.Width, image.Height);

            // Önce aşındırma
            buffer = Erosion(image);

            // Sonra yayma
            buffer = Dilation(buffer);

            return buffer;
        }

        public Bitmap ClosingMorphological(Bitmap image)
        {
            Bitmap buffer = new Bitmap(image.Width, image.Height);

            // Önce yayma
            buffer = Dilation(image);

            // Sonra aşındırma
            buffer = Erosion(buffer);

            return buffer;
        }

        public Bitmap ImageSharpening(Bitmap image)
        {
            Bitmap buffer = new Bitmap(image.Width, image.Height);
            Color color;

            int red, green, blue;

            int[,] mask = {
                { 0, -2, 0 },
                { -2, 11, -2 },
                { 0, -2, 0 }
            };

            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    if (i == 0 || i == image.Height - 1 || j == 0 || j == image.Width - 1)
                    {
                        color = Color.FromArgb(image.GetPixel(j, i).R, image.GetPixel(j, i).G, image.GetPixel(j, i).B);
                        buffer.SetPixel(j, i, color);
                    }
                    else
                    {
                        red = (image.GetPixel(j - 1, i - 1).R * mask[0, 0]) + (image.GetPixel(j, i - 1).R * mask[0, 1]) + (image.GetPixel(j + 1, i - 1).R * mask[0, 2]) +
                              (image.GetPixel(j - 1, i).R * mask[1, 0]) + (image.GetPixel(j, i).R * mask[1, 1]) + (image.GetPixel(j + 1, i).R * mask[1, 2]) +
                              (image.GetPixel(j - 1, i + 1).R * mask[2, 0]) + (image.GetPixel(j, i + 1).R * mask[2, 1]) + (image.GetPixel(j + 1, i + 1).R * mask[2, 2]);

                        green = (image.GetPixel(j - 1, i - 1).G * mask[0, 0]) + (image.GetPixel(j, i - 1).G * mask[0, 1]) + (image.GetPixel(j + 1, i - 1).G * mask[0, 2]) +
                              (image.GetPixel(j - 1, i).G * mask[1, 0]) + (image.GetPixel(j, i).G * mask[1, 1]) + (image.GetPixel(j + 1, i).G * mask[1, 2]) +
                              (image.GetPixel(j - 1, i + 1).G * mask[2, 0]) + (image.GetPixel(j, i + 1).G * mask[2, 1]) + (image.GetPixel(j + 1, i + 1).G * mask[2, 2]);

                        blue = (image.GetPixel(j - 1, i - 1).B * mask[0, 0]) + (image.GetPixel(j, i - 1).B * mask[0, 1]) + (image.GetPixel(j + 1, i - 1).B * mask[0, 2]) +
                              (image.GetPixel(j - 1, i).B * mask[1, 0]) + (image.GetPixel(j, i).B * mask[1, 1]) + (image.GetPixel(j + 1, i).B * mask[1, 2]) +
                              (image.GetPixel(j - 1, i + 1).B * mask[2, 0]) + (image.GetPixel(j, i + 1).B * mask[2, 1]) + (image.GetPixel(j + 1, i + 1).B * mask[2, 2]);

                        red /= 3;
                        green /= 3;
                        blue /= 3;

                        if (red > 255)
                            red = 255;
                        else if (red < 0)
                            red = 0;

                        if (green > 255)
                            green = 255;
                        else if (green < 0)
                            green = 0;

                        if (blue > 255)
                            blue = 255;
                        else if (blue < 0)
                            blue = 0;

                        color = Color.FromArgb(red, green, blue);
                        buffer.SetPixel(j, i, color);
                    }
                }
            }

            return buffer;
        }

        int xPointForWriteToImage, yPointForWriteToImage;
        private void pbImageSource_Click(object sender, EventArgs e)
        {
            if (cbFilters.SelectedIndex == 19)
            {
                MouseEventArgs me = (MouseEventArgs)e;
                Point coordinates = me.Location;
                xPointForWriteToImage = coordinates.X;
                yPointForWriteToImage = coordinates.Y;
            }
        }

        public Bitmap WriteToImage(Bitmap image, string text)
        {

            Bitmap buffer = new Bitmap(image);

            Point point = new Point(xPointForWriteToImage, yPointForWriteToImage);

            Graphics graphics = Graphics.FromImage(buffer);
            Font fontType = fontForWriteToImage;

            if (cbSelectColor.SelectedIndex == 0)
            {
                graphics.DrawString(text, fontType, Brushes.Red, point);
            }
            else if (cbSelectColor.SelectedIndex == 1)
            {
                graphics.DrawString(text, fontType, Brushes.Green, point);
            }
            else if (cbSelectColor.SelectedIndex == 2)
            {
                graphics.DrawString(text, fontType, Brushes.Blue, point);
            }
            else if (cbSelectColor.SelectedIndex == 3)
            {
                graphics.DrawString(text, fontType, Brushes.Black, point);
            }
            else if (cbSelectColor.SelectedIndex == 4)
            {
                graphics.DrawString(text, fontType, Brushes.White, point);
            }
            else if (cbSelectColor.SelectedIndex == 5)
            {
                graphics.DrawString(text, fontType, Brushes.Yellow, point);
            }
            else if (cbSelectColor.SelectedIndex == 6)
            {
                graphics.DrawString(text, fontType, Brushes.Pink, point);
            }
            else if (cbSelectColor.SelectedIndex == 7)
            {
                graphics.DrawString(text, fontType, Brushes.Orange, point);
            }
            else
            {
                graphics.DrawString(text, fontType, Brushes.Black, point);
            }

            return buffer;

        }

        private void SetBrightnessTrackOptions()
        {
            trcbBrightness.Minimum = -100;
            trcbBrightness.Maximum = 100;
            trcbBrightness.Value = 0;
        }

        private void SetContrastTrackOptions()
        {
            trcbContrast.Minimum = -128;
            trcbContrast.Maximum = 128;
            trcbContrast.Value = 0;
        }

        private void trcbBrightness_Scroll(object sender, EventArgs e)
        {
            lblBrightnessValue.Text = trcbBrightness.Value.ToString();
            pbImageOutput.Image = Brightness(filteredImage, trcbBrightness.Value);
        }

        private void trcbContrast_Scroll(object sender, EventArgs e)
        {
            lblContrast.Text = trcbContrast.Value.ToString();
            pbImageOutput.Image = Contrast(filteredImage, Convert.ToDouble(trcbContrast.Value));
        }

        private void pbResetBrightnessAndContrast_Click(object sender, EventArgs e)
        {
            ResetBrightnessAndContrast();
        }

        private void ResetBrightnessAndContrast()
        {
            lblBrightnessValue.Text = lblContrast.Text = "0";
            trcbBrightness.Value = trcbContrast.Value = 0;
            nudRotateDegree.Value = 0;
            pbImageOutput.Image = filteredImage;
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilters.SelectedIndex == 7)
            {
                pnlGaussianMaskSize.Visible = true;
                cbGaussianMask.SelectedIndex = 0;
            }
            else
            {
                pnlGaussianMaskSize.Visible = false;
            }

            if (cbFilters.SelectedIndex == 14 || cbFilters.SelectedIndex == 15 || cbFilters.SelectedIndex == 16 || cbFilters.SelectedIndex == 17)
            {
                pnlMorphologyMaskSize.Visible = true;
                cbMorphologyMaskSize.SelectedIndex = 0;
            }
            else
            {
                pnlMorphologyMaskSize.Visible = false;
            }

            if (cbFilters.SelectedIndex == 19)
            {
                pnlWriteToImage.Visible = true;
                cbSelectColor.SelectedIndex = 0;
                MessageBox.Show("Lütfen resim üzerinde kordinat seçin", "Kordinat seçin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                pnlWriteToImage.Visible = false;
            }

            if (cbFilters.SelectedIndex == 23)
            {
                pnlMove.Visible = true;
            }
            else
            {
                pnlMove.Visible = false;
            }
        }

        private void pbHistogram_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pbImageSource.Image);
            frmHistogram frmHistogram = new frmHistogram(image);
            frmHistogram.Show();
        }


        Point pDown = Point.Empty;
        Rectangle rect = Rectangle.Empty;
        private void pbImageSource_MouseDown(object sender, MouseEventArgs e)
        {
            if (cbFilters.SelectedIndex == 20)
            {
                pDown = e.Location;
                pbImageSource.Refresh();
            }
        }

        private void pbImageSource_MouseMove(object sender, MouseEventArgs e)
        {
            if (cbFilters.SelectedIndex == 20)
            {
                if (!e.Button.HasFlag(MouseButtons.Left)) return;

                rect = new Rectangle(pDown, new Size(e.X - pDown.X, e.Y - pDown.Y));
                using (Graphics g = pbImageSource.CreateGraphics())
                {
                    pbImageSource.Refresh();
                    g.DrawRectangle(Pens.Red, rect);
                }
            }
        }

        Bitmap clipping;
        private void pbImageSource_MouseUp(object sender, MouseEventArgs e)
        {
            if (cbFilters.SelectedIndex == 20)
            {
                pbImageOutput.Image = pbImageSource.Image;
                pbImageOutput.Visible = true;
                pnlBrightness.Visible = true;
                pbImageSaveAs.Visible = true;
                Rectangle iR = ImageArea(pbImageOutput);
                rect = new Rectangle(pDown.X - iR.X, pDown.Y - iR.Y,
                                     e.X - pDown.X, e.Y - pDown.Y);
                Rectangle rectSrc = Scaled(rect, pbImageOutput, true);
                Rectangle rectDest = new Rectangle(Point.Empty, rectSrc.Size);

                Bitmap bmp = new Bitmap(rectDest.Width, rectDest.Height);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.DrawImage(pbImageOutput.Image, rectDest, rectSrc, GraphicsUnit.Pixel);
                }
                pbImageOutput.Image = bmp;
                filteredImage = (Bitmap)pbImageOutput.Image;
                clipping = bmp;
            }
        }

        Rectangle ImageArea(PictureBox pbox)
        {
            Size si = pbox.Image.Size;
            Size sp = pbox.ClientSize;

            if (pbox.SizeMode == PictureBoxSizeMode.StretchImage)
                return pbox.ClientRectangle;
            if (pbox.SizeMode == PictureBoxSizeMode.Normal ||
                pbox.SizeMode == PictureBoxSizeMode.AutoSize)
                return new Rectangle(Point.Empty, si);
            if (pbox.SizeMode == PictureBoxSizeMode.CenterImage)
                return new Rectangle(new Point((sp.Width - si.Width) / 2,
                                    (sp.Height - si.Height) / 2), si);

            //  PictureBoxSizeMode.Zoom
            float ri = 1f * si.Width / si.Height;
            float rp = 1f * sp.Width / sp.Height;
            if (rp > ri)
            {
                int width = si.Width * sp.Height / si.Height;
                int left = (sp.Width - width) / 2;
                return new Rectangle(left, 0, width, sp.Height);
            }
            else
            {
                int height = si.Height * sp.Width / si.Width;
                int top = (sp.Height - height) / 2;
                return new Rectangle(0, top, sp.Width, height);
            }
        }

        Rectangle Scaled(Rectangle rect, PictureBox pbox, bool scale)
        {
            float factor = GetFactor(pbox);
            if (!scale) factor = 1f / factor;
            return Rectangle.Round(new RectangleF(rect.X * factor, rect.Y * factor,
                                       rect.Width * factor, rect.Height * factor));
        }
        float GetFactor(PictureBox pBox)
        {
            if (pBox.Image == null) return 0;
            Size si = pBox.Image.Size;
            Size sp = pBox.ClientSize;
            float ri = 1f * si.Width / si.Height;
            float rp = 1f * sp.Width / sp.Height;
            float factor = 1f * pBox.Image.Width / pBox.ClientSize.Width;
            if (rp > ri) factor = 1f * pBox.Image.Height / pBox.ClientSize.Height;
            return factor;
        }

        public Bitmap Konvolusyon(Bitmap image)
        {
            Bitmap buffer = new Bitmap(image.Width, image.Height);
            Color color;

            int[,] mask = new int[3, 3] {
                { -1, -1, -1 },
                { -2, 10, -2 },
                { -1, -1, -1 }
            };

            int red, green, blue;

            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    if (i == 0 || i == image.Height - 1 || j == 0 || j == image.Width - 1)
                    {
                        color = Color.FromArgb(image.GetPixel(j, i).R, image.GetPixel(j, i).G, image.GetPixel(j, i).B);
                        buffer.SetPixel(j, i, color);
                    }
                    else
                    {
                        red = (mask[0, 0] * image.GetPixel(j + 1, i + 1).R) + (mask[0, 1] * image.GetPixel(j, i + 1).R) + (mask[0, 2] * image.GetPixel(j - 1, i + 1).R) +
                              (mask[1, 0] * image.GetPixel(j + 1, i).R) + (mask[1, 1] * image.GetPixel(j, i).R) + (mask[1, 2] * image.GetPixel(j - 1, i).R) +
                              (mask[2, 0] * image.GetPixel(j + 1, i - 1).R) + (mask[2, 1] * image.GetPixel(j, i - 1).R) + (mask[2, 2] * image.GetPixel(j - 1, i - 1).R);

                        green = (mask[0, 0] * image.GetPixel(j + 1, i + 1).G) + (mask[0, 1] * image.GetPixel(j, i + 1).G) + (mask[0, 2] * image.GetPixel(j - 1, i + 1).G) +
                              (mask[1, 0] * image.GetPixel(j + 1, i).G) + (mask[1, 1] * image.GetPixel(j, i).G) + (mask[1, 2] * image.GetPixel(j - 1, i).G) +
                              (mask[2, 0] * image.GetPixel(j + 1, i - 1).G) + (mask[2, 1] * image.GetPixel(j, i - 1).G) + (mask[2, 2] * image.GetPixel(j - 1, i - 1).G);

                        blue = (mask[0, 0] * image.GetPixel(j + 1, i + 1).B) + (mask[0, 1] * image.GetPixel(j, i + 1).B) + (mask[0, 2] * image.GetPixel(j - 1, i + 1).B) +
                              (mask[1, 0] * image.GetPixel(j + 1, i).B) + (mask[1, 1] * image.GetPixel(j, i).B) + (mask[1, 2] * image.GetPixel(j - 1, i).B) +
                              (mask[2, 0] * image.GetPixel(j + 1, i - 1).B) + (mask[2, 1] * image.GetPixel(j, i - 1).B) + (mask[2, 2] * image.GetPixel(j - 1, i - 1).B);

                        if (red > 255)
                            red = 255;
                        else if (red < 0)
                            red = 0;

                        if (green > 255)
                            green = 255;
                        else if (green < 0)
                            green = 0;

                        if (blue > 255)
                            blue = 255;
                        else if (blue < 0)
                            blue = 0;

                        color = Color.FromArgb(red, green, blue);
                        buffer.SetPixel(j, i, color);

                    }
                }
            }

            return buffer;
        }

        Font fontForWriteToImage;
        private void btnSelectFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                fontForWriteToImage = fontDialog.Font;
            }
        }

        private void tbWriteToImage_TextChanged(object sender, EventArgs e)
        {

        }

        public Bitmap DrawWithPencil(Bitmap image)
        {
            Bitmap pencilDraw = new Bitmap(image.Width, image.Height);
            pencilDraw = SobelEdgeFilter(image);
            pencilDraw = NegativeFilter(pencilDraw);
            return pencilDraw;
        }

        public Bitmap MoveOperation(Bitmap image)
        {
            Color color;
            Bitmap buffer = new Bitmap(image.Width, image.Height);

            double x2 = 0, y2 = 0;

            int Tx = Convert.ToInt32(tbMoveX.Text);
            int Ty = Convert.ToInt32(tbMoveY.Text);

            for (int x1 = 0; x1 < image.Width; x1++)
            {
                for (int y1 = 0; y1 < image.Height; y1++)
                {
                    color = image.GetPixel(x1, y1);
                    x2 = x1 + Tx;
                    y2 = y1 + Ty;
                    if (x2 > 0 && x2 < image.Width && y2 > 0 && y2 < image.Width)
                        buffer.SetPixel((int)x2, (int)y2, color);
                }
            }
            return buffer;
        }

        public Bitmap Reduction(Bitmap image)
        {
            Bitmap buffer = new Bitmap(image.Width, image.Height);

            int R = 0, G = 0, B = 0;

            int x = 0, y = 0; //Çıkış resminin x ve y si olacak.

            int reductionCoefficient = 2;

            for (int x1 = 0; x1 < image.Width; x1 = x1 + reductionCoefficient)
            {
                y = 0;
                for (int y1 = 0; y1 < image.Height; y1 = y1 + reductionCoefficient)
                {
                    //x ve y de ilerlerken her atlanan pikselleri okuyacak ve ortalama değerini alacak.
                    R = 0; G = 0; B = 0;
                    try //resim sınırının dışına çıkaldığında hata vermesin diye
                    {
                        for (int i = 0; i < reductionCoefficient; i++)
                        {
                            for (int j = 0; j < reductionCoefficient; j++)
                            {
                                Color color = image.GetPixel(x1 + i, y1 + j);
                                R = R + color.R;
                                G = G + color.G;
                                B = B + color.B;

                            }
                        }
                    }
                    catch { }
                    //Renk kanallarının ortalamasını alıyor
                    R = R / (reductionCoefficient * reductionCoefficient);
                    G = G / (reductionCoefficient * reductionCoefficient);
                    B = B / (reductionCoefficient * reductionCoefficient);
                    Color color2 = Color.FromArgb(R, G, B);
                    buffer.SetPixel(x, y, color2);
                    y++;
                }
                x++;
            }
            return buffer;
        }
    }
}
