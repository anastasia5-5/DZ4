using System;


namespace NovikovaNastya4
{
    internal class Program
    {
        public void CalculateArrayStatistics(params int[] numbers)
        {
           
            int sum = 0;
            int product = 1;
            double average;

            
            foreach (int number in numbers)
            {
                sum += number;
                product *= number;
            }

            
            average = (numbers.Length > 0) ? (double)sum / numbers.Length : 0;

           
            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Произведение: {product}");
            Console.WriteLine($"Среднее арифметическое: {average}");
        }

        static void Main(string[] args)
        {
        Console.WriteLine("Задание 2");
        Program program = new Program();

        program.CalculateArrayStatistics(11, 4, 7, 9, 1);
        Console.ReadLine();







        }
    }
}
