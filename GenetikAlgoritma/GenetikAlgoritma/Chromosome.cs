namespace GenetikAlgoritma
{
    internal class Chromosome
    {
        public double[] Genes { get; set; }
        public double Fitness { get; set; }

        public Chromosome(int geneCount, double minValue, double maxValue)
        {
            Genes = new double[geneCount];
        }

        public Chromosome Clone()
        {
            var clone = new Chromosome(this.Genes.Length, 0, 0);
            clone.Genes = (double[])this.Genes.Clone();
            clone.Fitness = this.Fitness;
            return clone;
        }

        public void CalculateFitness(Func<double[], double> fitnessFunction)
        {
            Fitness = fitnessFunction(Genes);
        }
    }
}