using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string NameValue = "EUR";
            double EurCost = 12.23;
            string Pay = Console.ReadLine();
            double parsedSum = double.Parse(Pay);
            double resultEuro = parsedSum / EurCost;
            Console.WriteLine("You pay: " + Pay + " And u get: " + resultEuro + NameValue);


        }
    }
}
