using System;

namespace LearningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Task 1 Kondyukov - Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст,
            рост, вес). В результате вся информация выводится в одну строчку*/

            Console.WriteLine("Привет! Заполни анкету ");
            Console.Write("Введите ваше имя ");
            string name = Console.ReadLine();
            Console.Write("Введите вашу фамилию ");
            string surname = Console.ReadLine();
            Console.Write("Введите ваш возраст ");
            string age = Console.ReadLine();
            Console.Write("Введите ваш рост в метрах ");
            double hight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ваш вес в киллограммах ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write(name + " " + surname + " - возраст " + age + " лет, рост " + hight + " метров, вес "
                + weight + " киллограммов ");
            Console.ReadLine();

            /*Task 2 Kondyukov - Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле
            I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах*/

            double index = weight / (hight * hight);
            Console.WriteLine("Ваш индекс массы тела " + "= " + index);
            Console.ReadLine();

            /*Task 3 Kondyukov - а) Написать программу, которая подсчитывает расстояние между точками с координатами x1,
            y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат,
            используя спецификатор формата .2f (с двумя знаками после запятой);*/

            Console.WriteLine("Type number x1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Type number x2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Type number y1");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Type number y2");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("{0:F2}", r);
            Console.ReadLine();

            /*Task 4 Kondyukov - Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов
            с использованием третьей переменной.*/

            int a = 2; //присвоил переменной а значение
            int b = 3; //присвоил переменной b значение
            int c = a; //присвоил переменной с значение а
            a = b; // поменял значение а в значение b
            b = c; // поменял значение b в значение c
            Console.WriteLine(a + " + " + b + " + " + c); //проверка
            Console.ReadLine();

        }
    }

}