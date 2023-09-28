namespace Task3
{
    using System;
    internal class Program
    {
        /*
        Дана целочисленная квадратная матрица. 
        Найти в каждой строке наибольший элемент и поменять его местами с элементом главной диагонали.
         */
        static void Task993()
        {
            Console.WriteLine("Task993");
            Random r = new Random();
            int arraySize = 5;
            int[,] array = new int[arraySize, arraySize];
            int maxElement;
            int maxElementIndex;
            int diagonalMemory;
            Console.WriteLine("Array:");
            for (int i = 0; i < arraySize; i++)
            {
                for (int j = 0; j < arraySize; j++)
                {
                    array[i, j] = r.Next(0, 100);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine("\n");
            }

            for (int i = 0; i < arraySize; i++)
            {
                maxElement = array[i, 0];
                maxElementIndex = 0;
                diagonalMemory = array[i, i];
                for (int j = 1; j < arraySize; j++)
                {
                    if (array[i, j] > maxElement)
                    {
                        maxElement = array[i, j];
                        maxElementIndex = j;
                    }
                }
                array[i, i] = maxElement;
                array[i, maxElementIndex] = diagonalMemory;
            }

            Console.WriteLine("Array edit:");
            for (int i = 0; i < arraySize; i++)
            {
                for (int j = 0; j < arraySize; j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine("\n");
            }
        }

        /*
        Дана вещественная квадратная матрица порядка n (n — нечетное), все элементы которой различны. 
        Найти наибольший элемент среди стоящих на главной и побочной диагоналях и поменять его местами с элементом, стоящим на пересечении этих диагоналей. 
         */
        static void Task1000()
        {
            Console.WriteLine("Task1000");
            Random r = new Random();
            int arraySize = 5;
            int centerIndex = arraySize / 2;
            double[,] array = new double[arraySize, arraySize];
            double maxElement;
            double centralElement;
            int maxElementColumn = 0, maxElementRow = 0;
            Console.WriteLine("Array:");
            for (int i = 0; i < arraySize; i++)
            {
                for (int j = 0; j < arraySize; j++)
                {
                    array[i, j] = r.NextDouble() * 100;
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine("\n");
            }

            maxElement = array[0, 0];
            centralElement = array[centerIndex, centerIndex];

            for (int i = 0; i < arraySize; i++)
            {
                if (array[i, i] > maxElement)
                {
                    maxElement = array[i, i];
                    maxElementColumn = i;
                    maxElementRow = i;
                }
                if (array[i, arraySize - 1 - i] > maxElement)
                {
                    maxElement = array[i, arraySize - 1 - i];
                    maxElementColumn = i;
                    maxElementRow = arraySize - 1 - i;
                }
            }

            array[centerIndex, centerIndex] = array[maxElementColumn, maxElementRow];
            array[maxElementColumn, maxElementRow] = centralElement;

            Console.WriteLine("Array edit:");
            for (int i = 0; i < arraySize; i++)
            {
                for (int j = 0; j < arraySize; j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine("\n");
            }
        }

        /*
         Найти сумму всех четных элементов Двумерного массива целых чисел A[10, 10].
         */
        static void Task903()
        {
            Console.WriteLine("Task903");
            Random r = new Random();
            int arraySize = 10;
            int[,] array = new int[arraySize, arraySize];
            int summary = 0;
            Console.WriteLine("Array:");
            for (int i = 0; i < arraySize; i++)
            {
                for (int j = 0; j < arraySize; j++)
                {
                    array[i, j] = r.Next(0, 100);
                    if (array[i, j] % 2 == 0)
                    {
                        summary += array[i, j];
                    }
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine($"Сумма всех четных элементов = {summary}");
        }

        /*
         Известен номер столбца, на котором расположен элемент побочной диагонали массива. 
        Вывести на экран значение этого элемента.
         */
        static void Task939()
        {
            Console.WriteLine("Task939");
            Random r = new Random();
            string input;
            int arraySize = 5;
            int[,] array = new int[arraySize, arraySize];
            bool continueInput = true;
            Console.WriteLine("Array:");
            for (int i = 0; i < arraySize; i++)
            {
                for (int j = 0; j < arraySize; j++)
                {
                    array[i, j] = r.Next(0, 100);
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine($"Введите номер столбца от 1 до {arraySize} чтобы получить \nэлемент находящийся на побочной диагонали, введите 0 чтобы завершить:");
            while (continueInput)
            {
                input = Console.ReadLine();

                if (int.TryParse(input, out int number) && number >= 0 && number < arraySize + 1)
                {
                    if (number == 0)
                    {
                        continueInput = false;
                    }
                    else
                    {
                        Console.WriteLine($"Элемент находящийся на побочной диагонали номера столбца {number} - {array[arraySize - number, number - 1]}");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect value");
                }
            }

        }

        static void Main(string[] args)
        {
            Task993();
            Task1000();
            Task903();
            Task939();
        }
    }
}
