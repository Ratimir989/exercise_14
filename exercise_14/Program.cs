using System;

namespace exercise_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("подбираем  5 случайных целых чисел ");
            Random rnd1 = new Random();
            int value1 = rnd1.Next();
            Console.WriteLine(value1);
            Random rnd2 = new Random();
            int value2 = rnd2.Next();
            Console.WriteLine(value2);
            Random rnd3 = new Random();
            int value3 = rnd3.Next();
            Console.WriteLine(value3);
            Random rnd4 = new Random();
            int value4 = rnd4.Next();
            Console.WriteLine(value4);
            Random rnd5 = new Random();
            int value5 = rnd5.Next();
            Console.WriteLine(value5);
            int average = (value1 + value2 + value3 + value4 + value5) / 5;
            Console.WriteLine($"Среднее арифметическое {average} ");
            Console.ReadLine();
        }
    }
}
