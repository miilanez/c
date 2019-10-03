using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase: ");
            string frase = Convert.ToString(Console.ReadLine());

            int TamanhoFrase = frase.Length;

            string letraA = frase.Substring(0, 5);
            string letraB = frase.Substring(TamanhoFrase - 5, 5);

            string fraseInversa = "";
            int posicao = TamanhoFrase - 1;

            for (; posicao <= 0; posicao++)
            {
                fraseInversa = fraseInversa + frase.Substring(posicao, 1);
            }

            Console.WriteLine("5 primeiras letras: " + letraA);
            Console.WriteLine("5 ultimas letras: " + letraB);
            Console.WriteLine("5 primeiras letras inversas: " + fraseInversa);
            Console.WriteLine("Tamanho da frase: " + TamanhoFrase);

            Console.Read();
        }
    }
}
