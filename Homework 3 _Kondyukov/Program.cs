using System;

namespace Homework_3__Kondyukov
{
    struct compleks
    {
        public int a, b;
        public compleks(int re, int im)
        {
            a = re;
            b = im;
        }
        public static compleks Sum(compleks x, compleks y)
        {
            return new compleks(re: x.a + y.a, im: x.b + y.b);
        }
        public static compleks Min(compleks x, compleks y)
        {
            return new compleks(re: x.a - y.a, im: x.b - y.b);
        }
        public override string ToString ()
        {
            return b < 0? $"{a} - {-b}i": $"{a} + {b}i";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры
            compleks z1 = new compleks(re: 1, im: 20);
            Console.WriteLine(z1);
            compleks z2 = new compleks(re: 20, im: 15);
            Console.WriteLine(z2);
            compleks z3 = compleks.Sum(z1, z2);//сложение
            Console.WriteLine(z3);
            compleks z4 = compleks.Min(z1, z2);//вычитание
            Console.WriteLine(z4);

            //Task 2 - С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
            //Требуется подсчитать сумму всех нечётных положительных чисел.
            //Сами числа и сумму вывести на экран, используя tryParse

            int a;
            int k = 0;
            Console.WriteLine("Введите число");
            a = Convert.ToInt32(Console.ReadLine());
            while (a != 0)
            {
                if (a > 0 && a % 2 != 0)
                {
                    k += a;
                }
                a = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(k);
        }
    }
}
