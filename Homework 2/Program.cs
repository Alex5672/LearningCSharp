using System;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            int x;
            Console.WriteLine("Введите целое число.");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x + " - " + ((x % 2 == 0) ? "четное число" : "нечетное число"));
            Console.WriteLine("Для выхода из приложение нажмите Enter");
            Console.ReadLine();*/

            /*Task 1 - Написать метод, возвращающий минимальное из трёх чисел.
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
        }
    }
}
