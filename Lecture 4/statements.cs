using System;

namespace Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            double Percentage;
            Console.WriteLine("Please Enetr Your Percentage: ");
            Percentage = Convert.TOInt32(Console.Readline());
           
           if (Percentage >= 60)
           {
               Console.WriteLine("A Grade!");
           }
           else
           {
             Console.WriteLine("B Grade!");  
           }
           Console.Readkey();
        }
    }
}
            