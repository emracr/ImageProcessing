using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ImageProcessing
{
    public partial class frmHistogram : Form
    {
        Bitmap _image;
        public frmHistogram(Bitmap image)
        {
            InitializeComponent();
            _image = image;
        }

        private void frmHistogram_Load(object sender, EventArgs e)
        {
            Histogram();
        }

        public void Histogram()
        {
            Bitmap grayImage = frmMain.GrayFilter(_image);

            int[,] colorLevel = new int[256, 1];

            for (int i = 0; i < _image.Height; i++)
            {
                for (int j = 0; j < _image.Width; j++)
                {
                    int color = _image.GetPixel(j, i).R;
                    colorLevel[color, 0]++;
                }
            }

            for (int i = 0; i <= 255; i++)
            {
                if (i % 50 == 0)
                {
                    chrtHistogram.Series["ColorLevel"].Points.AddXY(i.ToString(), colorLevel[i, 0].ToString());
                }
                else
                {
                    chrtHistogram.Series["ColorLevel"].Points.AddXY("", colorLevel[i, 0].ToString());
                }
            }

            chrtHistogram.ChartAreas[0].RecalculateAxesScale();
            chrtHistogram.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chrtHistogram.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
        }
    }
}
