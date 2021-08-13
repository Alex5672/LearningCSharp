using System;

namespace Homework_4__Kondyukov
{
    class Program
    {
        /*int[][] rows;
        int rowCount;
        public Massive (int rowCount) {this.rowCount = rowCount;}
        public void Init()
        {
            rows = new int[rowCount][];
            for (int i = 0; i < rowCount; i++)
            {
                rows[i] = new int[i + 1];
                rows[i][i] = 1;
                rows[i][0] = 1;
            }
            for(int i = 2; i < rowCount; i++)
            {
                for (int u = 1; u < rows[i].Length-1; u++)
                {
                    rows[i][u] = rows[i - 1][u - 1] + rows[i - 1][u];
                }
            }
        }
        public void Print()
        {
            for (int i = 0; i < rows.Length; i++)
            {
                for (int u = 0; u < rows[i].Length; u++)
                {
                    Console.Write($"{rows[i][u],3} ");
                }
                Console.WriteLine();
            }
        }
    }*/
        public static void Main(string[] args)
        {
            //Task 1 - Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения
            //от –10 000 до 10 000 включительно. Заполнить случайными числами.
            //Написать программу, позволяющую найти и вывести количество пар элементов массива,
            //в которых только одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива.
            //Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.

            int[] Massive; //создал переменную типа массив
            Massive = new int[20]; //определили 20 элементов для массива
            Random rnd = new Random(); //создание объекта для генерации чисел
            for (int i = 0; i < Massive.Length; i++)
            {
                Massive[i] = rnd.Next(-10000, 10000); //ограничил генерацию рандомных чисел
                Console.Write($"{Massive[i],5} ");
            }
            /*Array.Sort(Massive); //вроде как все методы работают с отсортированными массивами, значит сортируем
            Console.WriteLine();
            for (int i = 0; i < Massive.Length; i++)
            {
                Console.Write($"{Massive[i],5} ");
            }*/
            Console.WriteLine();
            int pair = 0;
            for (int i = 0; i < Massive.Length-1; i++)
            {
                if (Massive[i] % 3 == 0 && Massive[i + 1] % 3 != 0 || Massive[i] % 3 != 0 && Massive[i + 1] % 3 == 0)
                {
                    pair++;
                }
                else {}
            }
            Console.WriteLine("Amount of searching objects is " + pair);


            //Massive pt = new Massive(11);
            //pt.Init();
            //pt.Print();



            /*//Ступенчатый массив, массив массивов
            int[][] triangle = new int[5][];
            //triangle[0] = new int [1] - определили на ппервой строчке 1 элемент массива
            for (int i = 0; i < triangle.Length; i++) //опредилили элементы массива автоматически
            {
                triangle[i] = new int [i + 1];
            }
            for (int i = 0; i < triangle.Length; i++)
            {
                for(int u = 0; u < triangle[i].Length; u++)
                {
                    Console.Write($"{triangle[i][u]} ");
                }
                Console.WriteLine();
            }*/

            //Многомерные массивы
            /*
            int[,] matrix;
            matrix = new int[10, 20];
            Console.WriteLine($"Rank = {matrix.Rank}");
            Console.WriteLine($"Getlength(0) = {matrix.GetLength(0)}");
            Console.WriteLine($"Getlength(1) = {matrix.GetLength(1)}");
            matrix[3, 4] = 99;
            matrix[2, 3] = 99;
            matrix[1, 2] = 99;
            matrix[4, 5] = 99;
            matrix[5, 6] = 99;
            matrix[0, 1] = 99;
            matrix[6, 7] = 99;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int u = 0; u < matrix.GetLength(1); u++)
                {
                    Console.Write($"{matrix[i, u],5}");
                }
                Console.WriteLine();
            }*/

            //Одномерные массивы
            /*int[] Massive;
            Massive = new int[10];
            Massive[1] = 10;
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                Massive[i] = r.Next(10);
                Console.Write($"{Massive[i]} ");
            }
            Array.Sort(Massive);
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{Massive[i]} ");
            }*/


        }
    }
    }


