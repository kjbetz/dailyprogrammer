﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");
            string[] lines2 = File.ReadAllLines("input2.txt");

            foreach (string line in lines)
            {
                Console.WriteLine("largest_digit({0}) -> {1}", line, line.Max());
            }

            Console.WriteLine("\n");

            foreach (string line in lines)
            {
                Console.WriteLine("desc_digits({0}) -> {1}", line, String.Concat(line.OrderByDescending(d => (int)d)));
            }

            Console.WriteLine("\n");

            foreach (string line in lines2)
            {
                Console.WriteLine("kaprekar({0}) -> {1}", line, Kaprekar(line));
            }
        }

        public static int Kaprekar(string line)
        {
            int kaprekar = 0;
            int initialValue = int.Parse(line);
            
            do
            {
                string workingValue = initialValue.ToString();
                
                for (int i = workingValue.Length; i < 4; i++)
                {
                    workingValue = "0" + workingValue;
                }
                
                int highValue = int.Parse(String.Concat(workingValue.OrderByDescending(d => (int)d)));
                int lowValue = int.Parse(String.Concat(workingValue.OrderBy(d => (int)d)));
                initialValue = highValue - lowValue; 
                kaprekar++;               
            }while (initialValue != 6174);

            return kaprekar;
        }
    }
}
