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
        public compleks Sum(compleks x, compleks y)
        {
            return new compleks(re: x.a + y.a, im: x.b + y.b);
        }
        public compleks Min(compleks x, compleks y)
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
            compleks z3 = z1.Sum(z1, z2);//сложение
            Console.WriteLine(z3);
            compleks z4 = z1.Min(z1, z2);//вычитание
            Console.WriteLine(z4);

        }
    }
}
