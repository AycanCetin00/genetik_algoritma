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
            // Kültür ayarlarýný Ýngilizce olarak ayarla (ondalýk ayraç nokta olacak)
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();

            // Sadece "En Ýyi Fitness" serisi
            chart1.Series.Add("En Ýyi Fitness");
            chart1.Series["En Ýyi Fitness"].ChartType = SeriesChartType.Line;
            chart1.Series["En Ýyi Fitness"].MarkerStyle = MarkerStyle.Diamond;
            chart1.Series["En Ýyi Fitness"].MarkerSize = 8;

            chart1.Series["En Ýyi Fitness"].MarkerStep = 15;  // Noktalarýn aralýklarýný artýrýr






        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                // Kültür ayarlarýný kontrol et
                CultureInfo culture = CultureInfo.InvariantCulture;
                
                int populationSize = int.Parse(txtPopulationSize.Text);
                double crossoverRate = double.Parse(txtCrossoverRate.Text, culture);
                double mutationRate = double.Parse(txtMutationRate.Text, culture);
                double elitismRate = double.Parse(txtElitismRate.Text, culture);
                int generationCount = int.Parse(txtGenerationCount.Text);
                
                // fonksiyon aralýðýný belirledik
                ga = new GeneticAlgorithm(populationSize, 2, crossoverRate, mutationRate, elitismRate, -10, 10);
                ga.GenerationCount = generationCount;

                chart1.Series["En Ýyi Fitness"].Points.Clear();
                


                ga.Run(FitnessFunction);

                var bestChromosome = ga.Population.GetBestChromosome();
                // deðerleri labelin içinde yazdýrdýk. 
                lblResult.Text = $"En Ýyi Çözüm: x = {bestChromosome.Genes[0]:F6}, y = {bestChromosome.Genes[1]:F6} - Fitness: {bestChromosome.Fitness:F6}";
                
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
            chart1.Series["En Ýyi Fitness"].Points.Clear();

            for (int i = 0; i < fitnessValues.Count; i++)
            {
                chart1.Series["En Ýyi Fitness"].Points.AddXY(i, fitnessValues[i]);
            }

            // En son jenerasyondaki en iyi fitness noktasý
        }
    }
}