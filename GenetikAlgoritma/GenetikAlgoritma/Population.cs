using System;
using System.Collections.Generic;
using System.Linq;

namespace GenetikAlgoritma
{
    internal class Population
    {
        public List<Chromosome> Chromosomes { get; set; }// popülasyon kromozomlarının listesi
        public int PopulationSize { get; set; }//popülasyon kromozom sayısı
        private Random _random;

        public Population(int populationSize, int geneCount, double minValue, double maxValue, Random random)
        {//popülasyonu başlatarak her bir kromozomu gen dğerleriyle dolduruyoruz. 
            PopulationSize = populationSize;
            Chromosomes = new List<Chromosome>();
            _random = random;

            for (int i = 0; i < populationSize; i++)
            {
                var chromosome = new Chromosome(geneCount, minValue, maxValue);
                for (int j = 0; j < geneCount; j++)
                {
                    chromosome.Genes[j] = minValue + (maxValue - minValue) * _random.NextDouble();
                }
                chromosome.CalculateFitness(Form1.FitnessFunction);
                Chromosomes.Add(chromosome);
            }
        }

        public void CalculateFitness(Func<double[], double> fitnessFunction)
        {    //popülasyondaki tüm kromozomların uygunluk değerlerini
        
            foreach (var chromosome in Chromosomes)
            {
                chromosome.CalculateFitness(fitnessFunction);
            }
        }

        public Chromosome GetBestChromosome()// kromozmları uygunluk değerleine göre sılara 
        {
            return Chromosomes.OrderBy(c => c.Fitness).First();
        }
    }
}
