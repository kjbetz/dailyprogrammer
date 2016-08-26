using System;
using System.IO;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");

            foreach (string line in lines)
            {
                char[] test = line.ToCharArray();

                if (test.Length == 10)
                {
                    Fingers fingers = new Fingers(test);

                }
                else
                {
                    Console.WriteLine("{0} -> Invalid", line);
                }
            }
        }

        public class Fingers
        {
            public bool LeftThumb { get; private set; }
            public bool LeftIndex { get; private set; }
            public bool LeftMiddle { get; private set; }
            public bool LeftRing { get; private set; }
            public bool LeftPinky { get; private set; }
            public bool RightThumb { get; private set; }
            public bool RightIndex { get; private set; }
            public bool RightMiddle { get; private set; }
            public bool RightRing { get; private set; }
            public bool RightPinky { get; private set; }

            public Fingers (char[] fingers)
            {
                LeftPinky = Convert.ToBoolean(fingers[0]);
                LeftRing = Convert.ToBoolean(fingers[1]);
                LeftMiddle = Convert.ToBoolean(fingers[2]);
                LeftIndex = Convert.ToBoolean(fingers[3]);
                LeftThumb = Convert.ToBoolean(fingers[4]);
                RightThumb = Convert.ToBoolean(fingers[5]);
                RightIndex = Convert.ToBoolean(fingers[6]);
                RightMiddle = Convert.ToBoolean(fingers[7]);
                RightRing = Convert.ToBoolean(fingers[8]);
                RightPinky = Convert.ToBoolean(fingers[9]);                
            }
        }
    }
}
