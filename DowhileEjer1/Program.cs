using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DowhileEjer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0,
            contador = 1,
            n = 1,
            suma = 0,
            i = 0;


            while (contador < 100)

            {
                suma = suma + num1;
                Console.WriteLine(suma);
                Console.WriteLine(contador);
                contador = contador + 1;
            }
            Console.ReadKey();
        }
       
        
    }
}