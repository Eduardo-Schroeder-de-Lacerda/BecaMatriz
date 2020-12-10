using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecaMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cada Becario deverá criar um metódo para calcular a soma da diagonal principal de uma matriz quadrada 3 x 3 
            // O método deverá ter o nome do participante
            // exemplo: CalculaSomaDiagonalPrincipal_Ricardo();

            double[,] matrizEduardo = new double[3, 3];
            CalculaSomaDiagonalPrincipal_Edaurdo(matrizEduardo);
        }

        private static void CalculaSomaDiagonalPrincipal_Edaurdo(double[,] matrizEduardo)
        {
            double somaDiagonalPrincipal = 0.0;
            for (int i = 0; i < matrizEduardo.GetLength(0); i++)
            {
                for (int j = 0; j < matrizEduardo.GetLength(1); j++)
                {
                    Console.WriteLine("Coloque o valor da linha " +
                        i + " Coluna " + j);
                    matrizEduardo[i, j] = double.Parse(Console.ReadLine());

                    if (i == j)
                    {
                        somaDiagonalPrincipal += matrizEduardo[i, j];
                    }
                }
            }
            Console.WriteLine("----------Soma Diagonal Principal----------");
            Console.WriteLine(somaDiagonalPrincipal);
            Console.ReadLine();
        }
    }
}