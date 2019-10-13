using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            n = Massiv.Size();
            double[] mas = new double[n];
            for (i = 0; i < mas.Length; i++)
            {
                mas[i] = Massiv.Correct();
            }
            Massiv.Sumaaftermin(mas);
            Massiv.Suma2(mas);
            Massiv.Suma3(mas);
            Massiv.Suma4(mas);
        }
    }
    
}

