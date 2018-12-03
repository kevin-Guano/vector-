using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appVectores
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("control de versiones");
            Console.WriteLine("control de versiones1");
            Console.WriteLine("control de versiones2");
            Console.WriteLine("control de versiones3");
            vectorInicializador();
            Console.ReadKey();

        }
        public static void vectorInicializador()
        {
            int[] x = new int[8];
            x[0] = 10;
            x[1] = 2;
            x[2] = 20;
            x[3] = 8;
            x[4] = 15;
            x[5] = 1;
            x[6] = -9;
            x[7] = 14;
            //IMPRIMIR EL VECTOR 
            Console.WriteLine("\nELEMENTOS DEL VECTOR\nxxxxxxxxxxxx\n");
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("elemento indice {0} -->{1} ", (i + 1), x[i]);

            }
            //sumatoria de los elemntos del vector 
            int suma = 0;
            for (int i = 0; i < x.Length; i++)
            {
                suma = suma + x[i];
            }
            Console.WriteLine("la sumatoria es {0}", suma);
            Console.WriteLine("el promedio es {0}", (double)suma / x.Length);




        }
    }
}

