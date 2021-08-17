using System;

namespace Homework_2
{
    class Program
    {
        static public int Minimum()
        {
            Console.WriteLine("Находим минимальное значение ");
            Random rnd = new Random();
            int a = rnd.Next(-100, 100);
            int b = rnd.Next(-100, 100);
            int c = rnd.Next(-100, 100);
            Console.WriteLine("Первое значение " + a);
            Console.WriteLine("Второе значение " + b);
            Console.WriteLine("Третье значение " + c);
            Console.WriteLine();
            int min;
            if (a < b && a < c)
            {
                min = a;
            }
            else if (b < c)
            {
                min = b;
            }
            else
            {
                min = c;
            }
            return min;
        } 
        static public int CountDigits()
        {
            Console.WriteLine();
            Random rnd = new Random();
            int a = rnd.Next(10, 20000);
            Console.WriteLine("Считаем количество чисел числа " + a);
            int b = 0;
            while (a > 0)
            {
                a = a / 10;
                b++;
            }
            return b;
        }
        static void Main(string[] args)
        {
            //Task 1 - Написать метод, возвращающий минимальное из трёх чисел.
            Console.WriteLine("Минимальное значение " + Minimum());

            //Task 2 - Написать метод подсчета количества цифр числа.
            Console.WriteLine("Количество цифр в числе " + CountDigits());

            //Task 3 - С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

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

            //Task 4 - Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
            //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
            //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
            //программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.

            string log;
            string password;
            int counter = 0;
            Console.WriteLine("Введите логин ");
            log = Console.ReadLine();
            Console.WriteLine("Введите пароль ");
            password = Console.ReadLine();
            //Console.Write("Логин - " + log + " Пароль - " + password);
            do
            {
                if (log != "root" || password != "GeekBrains")
                {
                    Console.WriteLine("Логин или пароль введен неверно!");
                    Console.WriteLine("Введите логин ");
                    log = Console.ReadLine();
                    Console.WriteLine("Введите пароль ");
                    password = Console.ReadLine();
                }
                else 
                {
                    Console.WriteLine("Добро пожаловать в систему! "); break;
                }
                counter++;
            }
            while (counter < 2);
            Console.WriteLine("Для выхода из приложение нажмите Enter");*/
        }
    }
}
