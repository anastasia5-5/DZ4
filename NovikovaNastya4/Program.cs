using System;


namespace NovikovaNastya4
{
    internal class Program
    {
        static long Factorial(int n)
        {
            
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        private int[] numbers;

        public Program()
        {
            numbers = new int[20];
            Random random = new Random();

            
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 101); 
            }
        }

        public void PrintArray()
        {
            Console.WriteLine("Массив:");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        public void SwapNumbers(int num1, int num2)
        {
            int index1 = Array.IndexOf(numbers, num1);
            int index2 = Array.IndexOf(numbers, num2);

            if (index1 != -1 && index2 != -1)
            {
                
                int em = numbers[index1];
                numbers[index1] = numbers[index2];
                numbers[index2] = em;
            }
            else
            {
                Console.WriteLine("Одно или оба числа не найдены в массиве.");
            }
        }
        public class Calculator
        {
            public int CalculateSumAndProductAndAverage(out double average, ref int product, params int[] numbers)
            {
                int sum = 0;
                product = 1; 
                foreach (var number in numbers)
                {
                    sum += number;
                    product *= number;
                }

                average = (double)sum / numbers.Length; 
                return sum; 
            }
        }




        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2");
            Calculator calculator = new Calculator();

            int product = 1;
            double average;

            int sum = calculator.CalculateSumAndProductAndAverage(out average, ref product, 3, 8, 5, 1, 7);

            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Произведение: {product}");
            Console.WriteLine($"Среднее арифметическое: {average}");

            Console.ReadLine();

            Console.WriteLine("Задание 1");
            //Вывести на экран массив из 20 случайных чисел. Ввести два числа из этого массива,
            //которые нужно поменять местами. Вывести на экран получившийся массив.
            Program program = new Program();

            program.PrintArray();

            Console.WriteLine("Введите первое число для обмена:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число для обмена:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            program.SwapNumbers(firstNumber, secondNumber);

            program.PrintArray();

            Console.ReadLine();
        

        Console.WriteLine("Упражнение 5.4");
        //Написать рекурсивный метод вычисления факториала числа.


        Console.WriteLine("Введите неотрицательное целое число для вычисления его факториала:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number) && number >= 0)
        {
            long factorial = Factorial(number); 
            Console.WriteLine($"Факториал {number} равен {factorial}");
        }
        else
        {
            Console.WriteLine("Ошибка: введено некорректное число. Введите неотрицательное целое число.");
        }
        Console.ReadLine() ;













        Console.WriteLine("Упражнение 5.3");
        //Пользователь вводит числа. Если числа от 0 до 9, то необходимо в консоли нарисовать изображение цифры
        //в виде символа #.Если число больше 9 или меньше 0, то консоль должна окраситься в красный цвет на 3 секунды и вывести сообщение об ошибке.
        //Если пользователь ввёл не цифру, то программа должна выпасть в исключение. Программа завершает работу, если пользователь введёт слово: exit или закрыть (оба варианта должны сработать) - консоль закроется.

        while (true)
        {
            Console.WriteLine("Введите число от 0 до 9 или 'exit'/'закрыть' для выхода:");

            string input2 = Console.ReadLine();

            if (input2.Equals("exit", StringComparison.OrdinalIgnoreCase) ||input.Equals("закрыть", StringComparison.OrdinalIgnoreCase))
            {
                break; 
            }

            try
            {
                int number2 = int.Parse(input2);

                if (number2 >= 0 && number2 <= 9)
                {
                   DrawDigit(number);
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear(); 
                    Console.WriteLine("Ошибка: число должно быть от 0 до 9.");
                    System.Threading.Thread.Sleep(3000); 
                    Console.ResetColor(); 
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено не число.");
            }
        }
    }

        static void DrawDigit(int digit)
        {
            switch (digit)
            {
                case 0:
                    Console.WriteLine("###");
                    Console.WriteLine("# #");
                    Console.WriteLine("# #");
                    Console.WriteLine("# #");
                    Console.WriteLine("###");
                    break;
                case 1:
                    Console.WriteLine("  #");
                    Console.WriteLine("  #");
                    Console.WriteLine("  #");
                    Console.WriteLine("  #");
                    Console.WriteLine("###");
                    break;
                case 2:
                    Console.WriteLine("###");
                    Console.WriteLine("  #");
                    Console.WriteLine("###");
                    Console.WriteLine("#  ");
                    Console.WriteLine("###");
                    break;
                case 3:
                    Console.WriteLine("###");
                    Console.WriteLine("  #");
                    Console.WriteLine("###");
                    Console.WriteLine("  #");
                    Console.WriteLine("###");
                    break;
                case 4:
                    Console.WriteLine("# #");
                    Console.WriteLine("# #");
                    Console.WriteLine("###");
                    Console.WriteLine("  #");
                    Console.WriteLine("  #");
                    break;
                case 5:
                    Console.WriteLine("###");
                    Console.WriteLine("#  ");
                    Console.WriteLine("###");
                    Console.WriteLine("  #");
                    Console.WriteLine("###");
                    break;
                case 6:
                    Console.WriteLine("###");
                    Console.WriteLine("#  ");
                    Console.WriteLine("###");
                    Console.WriteLine("# #");
                    Console.WriteLine("###");
                    break;
                case 7:
                    Console.WriteLine("###");
                    Console.WriteLine("  #");
                    Console.WriteLine("  #");
                    Console.WriteLine("  #");
                    Console.WriteLine("  #");
                    break;
                case 8:
                    Console.WriteLine("###");
                    Console.WriteLine("# #");
                    Console.WriteLine("###");
                    Console.WriteLine("# #");
                    Console.WriteLine("###");
                    break;
                case 9:
                    Console.WriteLine("###");
                    Console.WriteLine("# #");
                    Console.WriteLine("###");
                    Console.WriteLine("  #");
                    Console.WriteLine("###");
                    break;
            
            }










        }

    }
}
