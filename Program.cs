using System;

namespace Syntacsys_var
{
    class Program
    {
        static void Main()
        {
            #region 1) Середнє арифметичне
            Console.WriteLine("Введи три дійсних числа:");
            double number1 = Convert.ToDouble(Console.ReadLine());
            double number2 = Convert.ToDouble(Console.ReadLine());
            double number3 = Convert.ToDouble(Console.ReadLine());
            double average = (number1 + number2 + number3) / 3;
            Console.WriteLine("Среднее арифметическое: " + average);
            #endregion
            #region 2) піднесення в степінь
            Console.WriteLine("Введи число і степінь, до якох треба піднести:");
            double num = Convert.ToDouble(Console.ReadLine());
            double pow = Convert.ToDouble(Console.ReadLine());
            double rez = Math.Pow(num, pow);
            Console.WriteLine($"{num}^{pow} = {rez}");
            #endregion
            #region 3) конвертор
            Console.WriteLine("Введи суму в гривнях:");
            double grn = Convert.ToDouble(Console.ReadLine());
            double dlr = 0.0271 * grn;
            double euro = 0.0248 * grn;
            Console.WriteLine($"Сума в доларах = {dlr}\nСума в євро = {euro}");
            #endregion
            #region 4) з кілометрів в милі
            Console.WriteLine("Введіть кількість кілометрів:");
            double km = Convert.ToDouble(Console.ReadLine());
            double land_ml = km / 1.609;
            double sea_ml = km / 1.852;
            Console.WriteLine("Сухопутні милі: " + land_ml + "\nМорські милі: " + sea_ml);
            #endregion
            #region 5) відсотки
            Console.WriteLine("Введіть число:");
            double N = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введить відсоток:");
            double P = Convert.ToDouble(Console.ReadLine());
            double result = (P / 100) * N;
            Console.WriteLine($"{P}% від числа {N} = {result}");
            #endregion
            #region 6) градуси з цельсія у фаренгейти і навпаки
            Console.WriteLine("Введіть градуси Цельсія:");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"Градуси Фаренгейта: {fahrenheit}\n");
            
            Console.WriteLine("Введіть градуси Фаренгейта:");
            fahrenheit = Convert.ToDouble(Console.ReadLine());
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Градуси Цельсія: " + celsius);
            #endregion
        }
    }
}
