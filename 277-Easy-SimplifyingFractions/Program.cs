using System;
using System.IO;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input-file.txt");
/*
            foreach (string line in lines)
            {
                string[] numbers = line.Split();
                if(numbers.Length == 2)
                {
                    int nominator = Convert.ToInt32(numbers[0]);
                    int denominator = Convert.ToInt32(numbers[1]);
                    int divisor = denominator;

                    for(int i = divisor; i > 0; i--)
                    {
                        if (denominator % i == 0 && nominator % i == 0)
                        {
                            divisor = i;
                            break;
                        }
                    }

                    int reducedNominator = nominator / divisor;
                    int reducedDenominator = denominator / divisor;

                    Console.WriteLine("{0} {1}", reducedNominator, reducedDenominator);
                } 
            }
*/
            foreach (string line in lines)
            {
                string[] numbers = line.Split();
                if(numbers.Length == 2)
                {
                    Fraction fraction = new Fraction(Convert.ToInt32(numbers[0]), Convert.ToInt32(numbers[1]));
                    Console.WriteLine(fraction.GreatestCommonDivisor());
                    Fraction reducedFraction = new Fraction(fraction.Numerator / fraction.GreatestCommonDivisor(), fraction.Denominator / fraction.GreatestCommonDivisor());

                    Console.WriteLine("{0} {1}", reducedFraction.Numerator, reducedFraction.Denominator);
                }
            }

            Console.WriteLine("Press any key to continue.");
            Console.ReadLine(); 
        }

        public class Fraction
        {
            public int Numerator { get; private set; }
            public int Denominator { get; private set; }

            public Fraction(int numerator, int denominator)
            {
                Numerator = numerator;
                Denominator = denominator;
            }

            public int GreatestCommonDivisor()
            {
                int divisor = this.Denominator;
                Console.WriteLine(divisor);
                for (int i = divisor; i > 0; i--)
                {
                    if (this.Denominator % i == 0 && this.Numerator == 0)
                    {
                        divisor = i;
                        break;
                    }
                }
                return divisor;
            }
        }
    }
}
