using System;
using System.Linq;

namespace Frequencia_De_Numeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantos números serão digitados: ");
            int qntNumeros = int.Parse(Console.ReadLine()); 

            int[] numeros = new int[qntNumeros];
            string[] quantasVezesAparece = new string[qntNumeros];
            int contVezes = 0;

            Console.WriteLine("Digite os números.");
            Console.WriteLine();

            for (int i = 0; i < qntNumeros; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < qntNumeros; i++)
            {
                for (int j = 0; j < qntNumeros; j++)
                {
                    if (numeros[i] == numeros[j])
                    {
                        contVezes++;
                    }
                }

                quantasVezesAparece[i] = "O número " + numeros[i] + " aparece " + contVezes+ " vez(es).";
                contVezes = 0;

            }

            string[] retiraDuplicados = quantasVezesAparece.Distinct().ToArray();

            Console.WriteLine();
            for(int i = 0;i < retiraDuplicados.Length; i++)
            {
                Console.WriteLine(retiraDuplicados[i]);
            }

        }
    }
}
