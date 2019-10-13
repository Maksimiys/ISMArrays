using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1
{
    class Massiv
    {

        public static int Size()
        {
            int n;
            Console.Write("Введить размiр масиву N=");
            var c = Console.ReadLine();
            while (!int.TryParse(c, out n) || int.Parse(c) < 1)
            {
                Console.WriteLine("Введіть коректне значення!");
                c = Console.ReadLine();
            }
            return n;
        }
        public static double Correct()
        {
            double number;
            var c = Console.ReadLine();
            while (!double.TryParse(c, out number))
            {
                Console.WriteLine("Введите коректное значение!");
                c = Console.ReadLine();
            }
            return number;
        }
        public static void SumaVid(double[] mas)
        {
            double suma = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < 0)
                    suma += mas[i];
            }
            Console.WriteLine($"Сума вiд’ємних елементiв масиву = {suma}");
            Console.WriteLine("////////////////////////////");
        }
        public static void Biger(double[] mas)
        {
            double max = mas[0];
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > max)
                    max = mas[i];
            }
            Console.WriteLine($"Mаксимальний елемент масиву = {max}");
            Console.WriteLine("////////////////////////////");
        }
        public static void IndexBiger(double[] mas)
        {
            double max = mas[0];
            int x = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > max)
                {
                    max = mas[i];
                    x = i;
                }
            }
            Console.WriteLine($"Hомер (iндекс) максимального елемента масиву = {x}");
            Console.WriteLine("////////////////////////////");
        }
        public static void BigerAbs(double[] mas)
        {
            double max = mas[0];
            for (int i = 0; i < mas.Length; i++)
            {
                if (Math.Abs(mas[i]) >= max)
                    max = Math.Abs(mas[i]);
            }
            Console.WriteLine($"Mаксимальний за модулем елемент масиву = {max}");
            Console.WriteLine("////////////////////////////");
        }
        public static void SumaIndex(double[] mas)
        {
            double suma = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > 0)
                    suma += i;
            }
            Console.WriteLine($"Сумa iндексiв додатних елементiв = {suma}");
            Console.WriteLine("////////////////////////////");
        }
        public static void NOI(double[] mas)
        {
            double suma = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] % 1 == 0)
                    suma++;
            }
            Console.WriteLine($"Kiлькiсть цiлих чисел у масивi = {suma}");
            Console.WriteLine("////////////////////////////");
        }
    }
}
