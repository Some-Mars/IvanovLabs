using System;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = int.Parse(Console.ReadLine());
            number *= 3;
            number += 4;
            number /= 2;
            int[] massiv = new int[number];
            for (int i = 0; i < number; i++)
            {
                massiv[i] = rnd.Next(-20,20);
            }
            Console.WriteLine("{0}", string.Join(" ", massiv));
        }
    }
}