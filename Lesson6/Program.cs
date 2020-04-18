using System;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Task8();
        }

        /// <summary>
        /// Найти минимальный элемент массива
        /// </summary>
        public static void Task1()
        {
            int[] a = new int[] { 100, 12, 13, 2, 3, 9, 15, 19, 6 };
            int min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
            }

            Console.WriteLine(min);
        }

        /// <summary>
        /// Найти два наибольших элемента массива
        /// </summary>
        public static void Task2()
        {
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            
            int max = a[0];
            int max2 = a[1];
            if (max2 > max)
            {
                max = max2;
                max2 = a[0];
            }
            for (int i = 2; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max2 = max;
                    max = a[i];
                }
                
                if(max2 < a[i] && a[i]!=max)
                {
                    max2 = a[i];
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(max2);
        }

        public static void Task2v2()
        {
            int[] a = new int[] { 50, 120, 13, 2, 1000, 9, 15, 19, 6 };

            int max = a[0];
            int max2 = a[1];
            if (max2 > max)
            {
                max = max2;
                max2 = a[0];
            }

            for (int i = 1; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            Console.WriteLine(max);

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] == max)
                    continue;

                if (max2 < a[i])
                {
                    max2 = a[i];
                }
            }

            
            Console.WriteLine(max2);
        }

        /// <summary>
        /// Посчитать сумму элементов массива
        /// </summary>
        public static void Task3()
        {
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6, 7};
            long sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];//sum+=a[i];
            }
            Console.WriteLine(sum);
        }

        /// <summary>
        /// Заполнить массив по возрастанию от 1 до 100
        /// </summary>
        public static void Task4()
        {
            int[] a = new int[100];
            for (int i = 1; i <= 100; i++)
            {
                a[i-1] = i;
            }
            
        }

        /// <summary>
        /// Создать и заполнить массив случайными целыми числами
        /// </summary>
        public static void Task5()
        {
            //пример вызова генератора случайных чисел, он понадобится в данной задаче
            Random rnd = new Random();
            
            int[] a = new int[100];
            for (int i = 0; i < 100; i++)
            {
                int r = rnd.Next(1, 10);//случайное число от 1 до 10

                a[i] = r;
            }
        }

        /// <summary>
        /// Проверить, что в массиве нет одинаковых чисел
        /// </summary>
        public static void Task6()
        {
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 111, 19, 6};
            bool result = false;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i+1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        result = true;
                        break;
                    }
                }
                
                if (result)
                {
                    break;
                }
            }

            Console.WriteLine(result);
        }

        /// <summary>
        /// Переставить элементы массива в обратном порядке используя вспомогательный массив
        /// </summary>
        public static void Task7()
        {
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[b.Length - i - 1] = a[i];
            }

        }

        /// <summary>
        /// Переставить элементы массива в обратном порядке НЕ используя вспомогательный массив
        /// </summary>
        public static void Task8()
        {
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };

            for (int i = 0; i < a.Length / 2; i++)
            {
                int t = a[i];
                a[i] = a[a.Length-1-i];
                a[a.Length-1-i] = t;
            }
        }

        /// <summary>
        /// Подсчитать сумму чисел в двухмерном массиве
        /// </summary>
        public static void Task9()
        {
            int[,] m = new int[,] { { 11, 22, 31 }, { 4, 53, 6 }, { 7, 81, 90 } };
        }

        /// <summary>
        /// Заполнить двумерный массив 10 на 10 случайными числами от 1 до 9 и вывести на экран консоли
        /// </summary>
        public static void Task10()
        {
        }

        /// <summary>
        /// Двумерный массив скопировать в одномерный
        /// </summary>
        public static void Task11()
        {
            int[,] m = new int[,] { { 11, 22, 31 }, { 4, 53, 6 }, { 7, 81, 90 } };
        }


        /// <summary>
        /// Заполнить двумерный массив 10 на 10 случайными числами от 1 до 99 и определить количество четных чисел в массиве
        /// </summary>
        public static void Task12()
        {
            //подсказка: для определения остка от деления используется оператор %
            int ostatok = 4 % 2; //будет равен нулю
        }

        /// <summary>
        /// Одномерный массив скопировать в двумерный 4 на 4
        /// </summary>
        public static void Task13()
        {
            int[] m = new int[] { 11, 22, 31, 4, 53, 6, 7, 81, 90, 11, 22, 31, 4, 53, 12, 7};
        }
    }
}
