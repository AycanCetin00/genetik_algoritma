namespace GenetikAlgoritma
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            label1 = new Label();
            txtPopulationSize = new TextBox();
            txtCrossoverRate = new TextBox();
            label2 = new Label();
            txtMutationRate = new TextBox();
            label3 = new Label();
            txtGenerationCount = new TextBox();
            label4 = new Label();
            btnStart = new Button();
            lblResult = new Label();
            label6 = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            txtElitismRate = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(15, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(167, 23);
            label1.TabIndex = 0;
            label1.Text = "Popülasyon Boyutu: ";
            // 
            // txtPopulationSize
            // 
            txtPopulationSize.Location = new Point(199, 23);
            txtPopulationSize.Margin = new Padding(4, 3, 4, 3);
            txtPopulationSize.Name = "txtPopulationSize";
            txtPopulationSize.Size = new Size(155, 30);
            txtPopulationSize.TabIndex = 1;
            // 
            // txtCrossoverRate
            // 
            txtCrossoverRate.Location = new Point(199, 71);
            txtCrossoverRate.Margin = new Padding(4, 3, 4, 3);
            txtCrossoverRate.Name = "txtCrossoverRate";
            txtCrossoverRate.Size = new Size(155, 30);
            txtCrossoverRate.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(15, 75);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(156, 23);
            label2.TabIndex = 2;
            label2.Text = "Çaprazlama Oranı: ";
            // 
            // txtMutationRate
            // 
            txtMutationRate.Location = new Point(199, 120);
            txtMutationRate.Margin = new Padding(4, 3, 4, 3);
            txtMutationRate.Name = "txtMutationRate";
            txtMutationRate.Size = new Size(155, 30);
            txtMutationRate.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(34, 120);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(143, 23);
            label3.TabIndex = 4;
            label3.Text = "Mutasyon Oranı: ";
            // 
            // txtGenerationCount
            // 
            txtGenerationCount.Location = new Point(199, 217);
            txtGenerationCount.Margin = new Padding(4, 3, 4, 3);
            txtGenerationCount.Name = "txtGenerationCount";
            txtGenerationCount.Size = new Size(155, 30);
            txtGenerationCount.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(15, 217);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(152, 23);
            label4.TabIndex = 6;
            label4.Text = "Jenerasyon Sayısı: ";
            // 
            // btnStart
            // 
            btnStart.BackColor = SystemColors.ActiveCaption;
            btnStart.Location = new Point(116, 402);
            btnStart.Margin = new Padding(4, 3, 4, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(161, 61);
            btnStart.TabIndex = 8;
            btnStart.Text = "Başla";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(496, 31);
            lblResult.Margin = new Padding(4, 0, 4, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(15, 23);
            lblResult.TabIndex = 9;
            lblResult.Text = " ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.Location = new Point(404, 31);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(61, 23);
            label6.TabIndex = 10;
            label6.Text = "Sonuç:";
            // 
            // chart1
            // 
            chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(439, 225);
            chart1.Margin = new Padding(4, 3, 4, 3);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.MarkerSize = 8;
            series1.MarkerStep = 10;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(469, 431);
            chart1.TabIndex = 11;
            // 
            // txtElitismRate
            // 
            txtElitismRate.Location = new Point(199, 167);
            txtElitismRate.Margin = new Padding(4, 3, 4, 3);
            txtElitismRate.Name = "txtElitismRate";
            txtElitismRate.Size = new Size(155, 30);
            txtElitismRate.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.Location = new Point(26, 167);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(132, 23);
            label5.TabIndex = 12;
            label5.Text = "Seçkinlik Oranı: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1000, 966);
            Controls.Add(txtElitismRate);
            Controls.Add(label5);
            Controls.Add(chart1);
            Controls.Add(label6);
            Controls.Add(lblResult);
            Controls.Add(btnStart);
            Controls.Add(txtGenerationCount);
            Controls.Add(label4);
            Controls.Add(txtMutationRate);
            Controls.Add(label3);
            Controls.Add(txtCrossoverRate);
            Controls.Add(label2);
            Controls.Add(txtPopulationSize);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPopulationSize;
        private TextBox txtCrossoverRate;
        private Label label2;
        private TextBox txtMutationRate;
        private Label label3;
        private TextBox txtGenerationCount;
        private Label label4;
        private Button btnStart;
        private Label lblResult;
        private Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private TextBox txtElitismRate;
        private Label label5;
    }
}
