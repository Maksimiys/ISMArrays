using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i;
            n = Massiv.Size();
            double[] mas = new double[n];
            for (i=0;i<mas.Length ;i++ )
            {
                mas[i] = Massiv.Correct();
            }
            Massiv.SumaVid(mas);
            Massiv.Biger(mas);
            Massiv.IndexBiger(mas);
            Massiv.BigerAbs(mas);
            Massiv.SumaIndex(mas);
            Massiv.NOI(mas);
        }
        
    }
    }

