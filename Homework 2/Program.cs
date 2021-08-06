using System;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Написать метод, возвращающий минимальное из трёх чисел.

            int x;
            Console.WriteLine("Введите первое число");
            x = Convert.ToInt32(Console.ReadLine());
            int b;
            Console.WriteLine("Введите второе число");
            b = Convert.ToInt32(Console.ReadLine());
            int c;
            Console.WriteLine("Введите третье число");
            c = Convert.ToInt32(Console.ReadLine());
            if (x < b && x < c)
            {
                Console.WriteLine("Минимальное число " + x);
            }
            else if (b < c)
            {
                Console.WriteLine("Минимальное число " + b);
            }
            else
            {
                Console.WriteLine("Минимальное число " + c);
            }
            Console.WriteLine("Для выхода из приложение нажмите Enter");

            //Task 2 - Написать метод подсчета количества цифр числа.

            int a;
            int counter = 0;
            Console.WriteLine("Введите число");
            a = Convert.ToInt32(Console.ReadLine());
            while(a > 0)
            {
                a = a / 10;
                Console.WriteLine(a);
                counter++;
            }
            Console.WriteLine("Число содержит " + counter + " цифр");
            Console.WriteLine("Для выхода из приложение нажмите Enter");
        }
    }
}
