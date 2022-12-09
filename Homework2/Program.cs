using System;

namespace HomeWork2

{
    internal class Program
    {
        static void Main(string[] args)
        {   

            /// Option 1
            
            ///Создайте переменную под сумму баллов по всем предметам.

            byte element1 = 120;
            int element2 = 320;

            ///Посчитайте сумму баллов.

            int result1 = element1 + element2;

            ///Рассчитайте среднее арифметическое баллов.

            int result2 = result1 / 2;

            Console.WriteLine("среднее арифметическое баллов :" + result2);
            Console.ReadKey(true);


            /// Option 2

            ///float element1 = 2.6F;
            ///double element2 = 245.765;

            ///double result = (element1 + element2) / 2;
            ///Console.WriteLine("среднее арифметическое баллов:" + result);

            ///Console.ReadKey(true);

            /// Option 3

            ///double firstValue, secondValue;

            ///Console.WriteLine("Введите Число");
            ///firstValue = double.Parse(Console.ReadLine());

            ///Console.WriteLine("Введите Следующее Число");
            ///secondValue= double.Parse(Console.ReadLine());

            ///double result = (firstValue + secondValue) / 2;
            ///Console.WriteLine("среднее арифметическое баллов:" + result);

            ///Console.ReadKey(true);





        }
    }
}
