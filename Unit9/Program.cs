using System;

namespace Unit9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ArrFIO = { "Загоруйко", "Иванов", "Петров", "Деточкин", "Сидоров" };
            string EnterNumber;
            bool fokcheck = true;
            Sort SortDate = new Sort();
            CheckEnter chekent = new CheckEnter();

            chekent.onEnter += SortDate.SortArr;


            Console.WriteLine("Имеется списов фамилий людей:");
            for (int i = 0; i < ArrFIO.Length; i++)
                Console.WriteLine(ArrFIO[i]);
            do
            {
            Console.WriteLine("Для сортировки этих данных в алфавитном порядке нажмите цифру 1, " +
                               "\nдля сортировки данных в обратном порядке нажмите 2");
            EnterNumber = Console.ReadLine();
            
                fokcheck = true;
                try
                {
                    chekent.checkEnter(ref ArrFIO, EnterNumber);
                }
                catch (MyExeption ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Произошла ошибка: " + ex.sMessageRet);
                    fokcheck = false;
                    Console.ResetColor();
                }
            }
            while (fokcheck == false);

            if (fokcheck) 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Результат работы:");
                for (int i = 0; i < ArrFIO.Length; i++)
                    Console.WriteLine(ArrFIO[i]);
                Console.ResetColor();
            }
        }

    }
}
