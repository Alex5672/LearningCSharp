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

            int y;
            int count = 0;
            Console.WriteLine("Введите число");
            y = Convert.ToInt32(Console.ReadLine());
            while(y > 0)
            {
                y = y / 10;
                Console.WriteLine(y);
                count++;
            }
            Console.WriteLine("Число содержит " + count + " цифр");
            Console.WriteLine("Для выхода из приложение нажмите Enter");

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
            Console.WriteLine("Для выхода из приложение нажмите Enter");
        }
    }
}
