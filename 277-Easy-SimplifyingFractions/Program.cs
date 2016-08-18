using System;
using System.IO;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input-file.txt");

            foreach (string line in lines)
            {
                string[] numbers = line.Split();
                
                if(numbers.Length == 2)
                {
                    Fraction fraction = new Fraction(Convert.ToInt32(numbers[0]), Convert.ToInt32(numbers[1]));

                    Fraction reducedFraction = fraction.ReduceFraction();

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
                for (int i = this.Denominator; i > 0; i--)
                {
                    if (this.Denominator % i == 0 && this.Numerator % i == 0)
                    {
                        return i;
                    }
                }

                return 1;
            }

            public Fraction ReduceFraction()
            {
                int divisor = this.GreatestCommonDivisor();
                return new Fraction(this.Numerator / divisor, this.Denominator / divisor);
            }
        }
    }
}
