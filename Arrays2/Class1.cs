using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
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

        public static void Sumaaftermin(double[] mas)
        {
            double x = mas[0], dob = 1;
            int ii = 0, i;
            for (i = 0; i < mas.Length; i++)
            {
                if (mas[i] <= x)
                {
                    x = mas[i];
                    ii = i;
                }
            }
            for (i = ii + 1; i < mas.Length; i++)
            {
                dob *= mas[i];
            }
            Console.WriteLine($"Добуток елементiв масиву, що розташованi пiсля мiнiмального елемента = {dob}");
            Console.WriteLine("////////////////////////////");
        }
        public static void Suma2(double[] mas)
        {
            double x = mas[0], dob = 0;
            int ii = 0,ii2=0,k=0, i;
            for (i = 0; i < mas.Length; i++)
            {
                if (mas[i] <0)
                {
                    ii = i;
                    break;
                }
            }
            for (i = 0; i < mas.Length; i++)
            {
                if (mas[i] > 0)
                {
                    k++;
                    if (k == 2)
                    {
                        ii2 = i;
                        break;
                    }
                }
            }
            if(ii>ii2)
            {
                i = ii;
                ii = ii2;
                ii2 = i;
            }
            for (i = ii + 1; i < ii2; i++)
            {
                dob += mas[i];
            }
            Console.WriteLine($"Cуму елементiв масиву, що розташованi мiж першим вiд'ємним та другим додатним елементами = {dob}");
            Console.WriteLine("////////////////////////////");
        }
        public static void Suma3(double[] mas)
        {
            double x = mas[0], dob = 0;
            int ii = 0, ii2 = 0, k = 0, i;
            for (i = 0; i < mas.Length; i++)
            {
                if (mas[i] ==0)
                {
                    k++;
                    if(k==1)
                    {
                        ii = i;
                    }
                        ii2 = i;
                  }
            }
            for (i = ii + 1; i < ii2; i++)
            {
                dob += mas[i];
            }
            Console.WriteLine($"Cумa елементiв масиву, якi розташованi мiж першим i останнiм нульовими елементами = {dob}");
            Console.WriteLine("////////////////////////////");
        }
        public static void Suma4(double[] mas)
        {
            double x = mas[0],x1=Math.Abs(mas[0]), dob = 1;
            int ii = 0, ii2 = 0,i;
            for (i = 0; i < mas.Length; i++)
            {
                if (Math.Abs(mas[i]) >= x)
                {
                    x = Math.Abs(mas[i]);
                    ii = i;
                }
            }
            for (i = 0; i < mas.Length; i++)
            {
                if (Math.Abs(mas[i]) <= x1)
                {
                    x1 = Math.Abs(mas[i]);
                    ii2 = i;
                }
            }
            if (ii > ii2)
            {
                i = ii;
                ii = ii2;
                ii2 = i;
            }
            for (i = ii + 1; i < ii2; i++)
            {
                dob *= mas[i];
            }
            Console.WriteLine($"Добуток елементiв масиву, що розташованi мiж максимальним за модулем i мiнiмальним за модулем елементами = {dob}");
            Console.WriteLine("////////////////////////////");
        }
    }
}
