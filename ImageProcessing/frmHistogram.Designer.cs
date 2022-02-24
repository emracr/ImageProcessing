
namespace ImageProcessing
{
    partial class frmHistogram
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chrtHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chrtHistogram)).BeginInit();
            this.SuspendLayout();
            // 
            // chrtHistogram
            // 
            chartArea4.Name = "ChartArea1";
            this.chrtHistogram.ChartAreas.Add(chartArea4);
            this.chrtHistogram.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chrtHistogram.Legends.Add(legend4);
            this.chrtHistogram.Location = new System.Drawing.Point(0, 0);
            this.chrtHistogram.Name = "chrtHistogram";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "ColorLevel";
            this.chrtHistogram.Series.Add(series4);
            this.chrtHistogram.Size = new System.Drawing.Size(964, 726);
            this.chrtHistogram.TabIndex = 0;
            this.chrtHistogram.Text = "chart1";
            // 
            // frmHistogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 726);
            this.Controls.Add(this.chrtHistogram);
            this.Name = "frmHistogram";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histogram";
            this.Load += new System.EventHandler(this.frmHistogram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrtHistogram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrtHistogram;
    }
}