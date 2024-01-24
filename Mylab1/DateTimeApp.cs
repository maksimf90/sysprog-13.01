using Mylib;
using Mylib.DateTimeLib;
using System.ComponentModel.Design;

namespace DateTimeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите функционал:");
            Console.WriteLine("1. Нахождение разницы между двумя датами");
            Console.WriteLine("2. Определить, является ли год високосным");
            Console.WriteLine("3. Нахождение времени суток по заданному времени");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                DateTimeFunctions dateTimeFunctions = new DateTimeFunctions();
                DateTime dateTime1, dateTime2;

                switch (choice)
                {
                    case 1: //разница в датах
                        Console.WriteLine("Введите первую дату (формат: dd.MM.yyyy):");
                        DateTime.TryParse(Console.ReadLine(), out dateTime1);

                        Console.WriteLine("Введите вторую дату (формат: dd.MM.yyyy):");
                        DateTime.TryParse(Console.ReadLine(), out dateTime2);

                        TimeSpan difference = DateTimeFunctions.FindDateDifference(dateTime1, dateTime2);
                        Console.WriteLine($"Разница между датами: {difference.TotalDays} дней");
                        break;

                    case 2: //определение високосного года
                        Console.WriteLine("Введите год:");
                        int year;
                        if (int.TryParse(Console.ReadLine(), out year))
                        {
                            bool isLeapYear = DateTimeFunctions.IsLeapYear(year);
                            Console.WriteLine($"Год {(isLeapYear ? "високосный" : "не високосный")}");
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод года.");
                        }
                        break;

                    case 3: //определение времени суток
                        Console.WriteLine("Введите время (формат: HH:mm:ss):");
                        DateTime.TryParse(Console.ReadLine(), out dateTime1);

                        string timeOfDay = DateTimeFunctions.FindTimeOfDay(dateTime1);
                        Console.WriteLine($"Время суток: {timeOfDay}");
                        break;

                }
            }
        }
    }
}