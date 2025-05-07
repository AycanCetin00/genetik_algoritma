using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GenetikAlgoritma
{
    public partial class Form1 : Form
    {
        private GeneticAlgorithm ga;

        public Form1()
        {
            InitializeComponent();
            // K�lt�r ayarlar�n� �ngilizce olarak ayarla (ondal�k ayra� nokta olacak)
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();

            // Sadece "En �yi Fitness" serisi
            chart1.Series.Add("En �yi Fitness");
            chart1.Series["En �yi Fitness"].ChartType = SeriesChartType.Line;
            chart1.Series["En �yi Fitness"].MarkerStyle = MarkerStyle.Diamond;
            chart1.Series["En �yi Fitness"].MarkerSize = 8;

            chart1.Series["En �yi Fitness"].MarkerStep = 15;  // Noktalar�n aral�klar�n� art�r�r






        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                // K�lt�r ayarlar�n� kontrol et
                CultureInfo culture = CultureInfo.InvariantCulture;
                
                int populationSize = int.Parse(txtPopulationSize.Text);
                double crossoverRate = double.Parse(txtCrossoverRate.Text, culture);
                double mutationRate = double.Parse(txtMutationRate.Text, culture);
                double elitismRate = double.Parse(txtElitismRate.Text, culture);
                int generationCount = int.Parse(txtGenerationCount.Text);
                
                // fonksiyon aral���n� belirledik
                ga = new GeneticAlgorithm(populationSize, 2, crossoverRate, mutationRate, elitismRate, -10, 10);
                ga.GenerationCount = generationCount;

                chart1.Series["En �yi Fitness"].Points.Clear();
                


                ga.Run(FitnessFunction);

                var bestChromosome = ga.Population.GetBestChromosome();
                // de�erleri labelin i�inde yazd�rd�k. 
                lblResult.Text = $"En �yi ��z�m: x = {bestChromosome.Genes[0]:F6}, y = {bestChromosome.Genes[1]:F6} - Fitness: {bestChromosome.Fitness:F6}";
                
                UpdateChart(ga.BestFitnessValues, bestChromosome);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static double FitnessFunction(double[] genes)//6. problem fonksiyonu
        {
            double x = genes[0];
            double y = genes[1];
            double value = Math.Pow(x + 2 * y - 7, 2) + Math.Pow(2 * x + y - 5, 2);
            return value;
        }

        private void UpdateChart(List<double> fitnessValues, Chromosome bestChromosome)
        {
            chart1.Series["En �yi Fitness"].Points.Clear();

            for (int i = 0; i < fitnessValues.Count; i++)
            {
                chart1.Series["En �yi Fitness"].Points.AddXY(i, fitnessValues[i]);
            }

            // En son jenerasyondaki en iyi fitness noktas�
        }
    }
}