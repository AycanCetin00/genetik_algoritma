using System;
using System.Collections.Generic;
using System.Linq;

namespace GenetikAlgoritma
{
    internal class GeneticAlgorithm
    {
        private Random _random = new Random();
        public Population Population { get; set; }
        public double CrossoverRate { get; set; }
        public double MutationRate { get; set; }
        public double ElitismRate { get; set; }
        public int GenerationCount { get; set; }
        public List<double> BestFitnessValues { get; private set; } = new List<double>();

        public GeneticAlgorithm(int populationSize, int geneCount, double crossoverRate, double mutationRate, double elitismRate, double minValue, double maxValue)
        {
            Population = new Population(populationSize, geneCount, minValue, maxValue, _random);
            CrossoverRate = crossoverRate;
            MutationRate = mutationRate;
            ElitismRate = elitismRate;
        }

        // Run metodunda değişiklik yapıldı
        public void Run(Func<double[], double> fitnessFunction)
        {
            BestFitnessValues.Clear(); // Her çalıştırmada temizle

            for (int i = 0; i < GenerationCount; i++)
            {
                Population.CalculateFitness(fitnessFunction);

                var bestChromosome = Population.GetBestChromosome();
                BestFitnessValues.Add(bestChromosome.Fitness);

                Console.WriteLine($"Generation {i}: Best Fitness = {bestChromosome.Fitness}, Genes = [{bestChromosome.Genes[0]}, {bestChromosome.Genes[1]}]");

                var eliteCount = (int)(Population.PopulationSize * ElitismRate);
                var elite = Population.Chromosomes.OrderBy(c => c.Fitness).Take(eliteCount).ToList();

                var newPopulation = new List<Chromosome>();

                while (newPopulation.Count < Population.PopulationSize - eliteCount)
                {
                    var parent1 = TournamentSelection();
                    var parent2 = TournamentSelection();

                    if (_random.NextDouble() < CrossoverRate)
                    {
                        var (child1, child2) = Crossover(parent1, parent2);
                        Mutate(child1);
                        Mutate(child2);
                        newPopulation.Add(child1);
                        newPopulation.Add(child2);
                    }
                    else
                    {
                        // Çaprazlama olmazsa ebeveynleri doğrudan ekle
                        var child1 = new Chromosome(parent1.Genes.Length, 0, 0) { Genes = (double[])parent1.Genes.Clone() };
                        var child2 = new Chromosome(parent2.Genes.Length, 0, 0) { Genes = (double[])parent2.Genes.Clone() };
                        Mutate(child1);
                        Mutate(child2);
                        newPopulation.Add(child1);
                        newPopulation.Add(child2);
                    }
                }

                newPopulation.AddRange(elite);
                Population.Chromosomes = newPopulation;
            }

            // Son bir fitness hesaplama yap
            Population.CalculateFitness(fitnessFunction);
            var finalBest = Population.GetBestChromosome();
            BestFitnessValues.Add(finalBest.Fitness);
        }

        private Chromosome TournamentSelection()
        {
            var tournamentSize = 10;
            var tournament = new List<Chromosome>();

            for (int i = 0; i < tournamentSize; i++)
            {
                tournament.Add(Population.Chromosomes[_random.Next(Population.PopulationSize)]);
            }

            return tournament.OrderBy(c => c.Fitness).First();
        }

        private (Chromosome, Chromosome) Crossover(Chromosome parent1, Chromosome parent2)
        {
            var child1 = new Chromosome(parent1.Genes.Length, 0, 0);
            var child2 = new Chromosome(parent1.Genes.Length, 0, 0);

            for (int i = 0; i < parent1.Genes.Length; i++)
            {
                double alpha = _random.NextDouble();
                child1.Genes[i] = alpha * parent1.Genes[i] + (1 - alpha) * parent2.Genes[i];
                child2.Genes[i] = alpha * parent2.Genes[i] + (1 - alpha) * parent1.Genes[i];
            }

            return (child1, child2);
        }

        private void Mutate(Chromosome chromosome)
        {
            for (int i = 0; i < chromosome.Genes.Length; i++)
            {
                if (_random.NextDouble() < MutationRate)
                {
                    chromosome.Genes[i] += (_random.NextDouble() - 0.5) * 5;// mutasyonun büyüklüğü rastegle atandı
                }
            }
        }
    }
}
