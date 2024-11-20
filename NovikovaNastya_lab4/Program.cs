using System;


namespace NovikovaNastya_lab4
{
    internal class Program
    {
        static int GCD(int a, int b)
        {
            if (a <= 0 || b <= 0)
            {
                throw new ArgumentOutOfRangeException("Числа должны быть натуральными (больше нуля).");
            }

            while (b != 0)
            {
                int number = b;
                b = a % b;
                a = number;
            }

            return a;
        }

        // Метод для вычисления НОД трех натуральных чисел
        static int GCD(int a, int b, int c)
        {
            return GCD(GCD(a, b), c);
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static int Max(int a, int b)
        {
            return (a > b) ? a : b;
        }

        static void Main(string[] args)
        {
        Console.WriteLine("Упражнение 5.1");
            
        Console.WriteLine("Тестирование метода Max:");

           
        Console.WriteLine($"Max(5, 89) = {Max(5, 89)}"); 
        Console.WriteLine($"Max(-11, -1) = {Max(-11, -1)}"); 
        Console.WriteLine($"Max(0, 0) = {Max(0, 0)}"); 
        Console.WriteLine($"Max(101, 500) = {Max(101, 500)}"); 
        Console.WriteLine($"Max(5, 5) = {Max(5, 5)}");
        Console.ReadLine();
        
        Console.WriteLine("Упражнение 5.2");
        //метод который меняет местами значения двух передаваемых параметров

        Console.WriteLine("Тестирование метода Swap:");

        int x = 3;
        int y = 7;

        Console.WriteLine($"До обмена: x = {x}, y = {y}");

        Swap(ref x, ref y);

        Console.WriteLine($"После обмена: x = {x}, y = {y}"); 

        int a = -1;
        int b = 15;

        Console.WriteLine($"До обмена: a = {a}, b = {b}");

        Swap(ref a, ref b);

        Console.WriteLine($"После обмена: a = {a}, b = {b}"); 
        Console.ReadLine() ;

        Console.WriteLine("Домашнее задание 5.1");
            try
            {
                
                int num1 = 26;
                int num2 = 15;
                Console.WriteLine($"НОД {num1} и {num2} равен {GCD(num1, num2)}");

               
                int num3 = 39;
                Console.WriteLine($"НОД {num1}, {num2} и {num3} равен {GCD(num1, num2, num3)}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        Console.ReadLine();













        }
    }
}
