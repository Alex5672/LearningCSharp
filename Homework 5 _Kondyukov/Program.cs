using System;
using System.Text;

namespace Homework_5__Kondyukov
{
    //Task 2 - Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
    static class Message
    {
        static public string text;
        static Message()
        {
            text = "Job vacancies in the U.K.have spiked to their highest recorded level, official figures showed Tuesday";
        }
        //a) Вывести только те слова сообщения, которые содержат не более n букв
        static public void GetWords(int leng)
        {
            string [] words = text.Split(new char[] {' ', ',', '.', '-', '\n', '\t'});
            foreach(string word in words)
            {
                if (word.Length <= leng)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Создать программу, которая будет проверять корректность ввода логина.
            // Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры,
            // при этом цифра не может быть первой: а) без использования регулярных выражений;

            
            Console.WriteLine("Type your login");
            string log = Convert.ToString(Console.ReadLine());
            Console.WriteLine(log);
            if (log.Length < 2 || log.Length > 10)
            {
                Console.WriteLine("Login is not correct ");
            }
            if (char.IsDigit(log[0]))
            {
                Console.WriteLine("Login is not correct ");
            }
            for (int i = 0; i < log.Length; i++)
            {
                if (char.IsLetterOrDigit(log[i])) { }
                else
                {
                    Console.WriteLine("Login is not correct");
                }
                
                //в) Найти самое длинное слово сообщения.
                //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.



                /*string poems = "белеет парус одинокий в тумане моря голубом";
                char[] div = { ' ' }; // создаем массив разделителей
                                      // разбиваем строку на части,
                string[] parts = poems.Split(div);
                Console.WriteLine("Результат разбиения строки на части: ");
                for (int i = 0; i < parts.Length; i++)
                    Console.WriteLine(parts[i]);
                // собираем эти части в одну строку, в качестве разделителя используем символ |
                string str = String.Join("|", parts);
                Console.WriteLine("Результат сборки: ");
                Console.WriteLine(str);*/


            }
            #region Help from Lesson
            //TryParse выводит заданный формат числа(int), в случае несоответствия формата, выводит значение "а"-0
            //int.TryParse(Console.ReadLine(), out int a);
            //Console.WriteLine(a);
            #endregion
        }
    }
}