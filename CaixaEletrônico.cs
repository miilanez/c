using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("QUANTIDADE QUE DESEJA RETIRAR: ");
                int VALOR = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(VALOR % 1000);
                Console.WriteLine("Quantidades de notas de 100: " + VALOR / 100);
                VALOR = VALOR - (VALOR / 100 * 100);
                Console.WriteLine("Quantidades de notas de 50: " + (VALOR / 50));
                VALOR = VALOR - (VALOR / 50 * 50);
                Console.WriteLine("Quantidades de notas de 20: " + (VALOR / 20));
                VALOR = VALOR - ((VALOR / 20) * 20);
                Console.WriteLine("Quantidades de notas de 10: " + (VALOR / 10));
                VALOR = VALOR - ((VALOR / 10) * 10);
                Console.WriteLine("Quantidades de notas de 5: " + (VALOR / 5));
                VALOR = VALOR - ((VALOR / 5) * 5);
                Console.WriteLine("Quantidades de notas de 2: " + (VALOR / 2));
                VALOR = VALOR - ((VALOR / 2) * 2);
                Console.WriteLine("Quantidades notas de 1: " + (VALOR));

                Console.ReadLine();

            }
        }
    }
}
