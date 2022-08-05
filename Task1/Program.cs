using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool beGradus;
            bool beMin;
            bool beSec;
            int gradus;
            int min;
            int sec;
            Console.WriteLine("Введите целочисленное значение угла в градусах, минутах, секундах");
            do
            {
                Console.Write("Градусы: ");
                beGradus = int.TryParse(Console.ReadLine(), out gradus);
                if (!beGradus)
                {
                    Console.WriteLine("Ошибка! Неверный формат данных. Попробуйте ещё раз.");
                }
            } while (!beGradus);
            do
            {
                Console.Write("Минуты: ");
                beMin = int.TryParse(Console.ReadLine(), out min);
                if (!beMin)
                {
                    Console.WriteLine("Ошибка! Неверный формат данных. Попробуйте ещё раз.");
                }
            } while (!beMin);
            do
            {
                Console.Write("Секунды: ");
                beSec = int.TryParse(Console.ReadLine(), out sec);
                if (!beSec)
                {
                    Console.WriteLine("Ошибка! Неверный формат данных. Попробуйте ещё раз.");
                }
            } while (!beSec);

            Angle angle = new Angle(gradus, min, sec);
            Console.WriteLine();
            Console.WriteLine("Перевод градусов в радианы:");
            Console.WriteLine("{0}°{1}'{2}\" = {3} рад.", gradus, min, sec, Math.Round(angle.ToRadians(),4, MidpointRounding.AwayFromZero));
            Console.ReadKey();
        }
    }
}
