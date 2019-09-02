using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaOrdenada.Models
{
    public class Main
    {
        public static int[] ordenarNumeros(int[] numeros)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                for (int j = i + 1; j < numeros.Length; j++)
                {
                    var comp = comparar(numeros[i], numeros[j]);

                    if(comp == 1)
                    {
                        int temp = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = temp;
                    }
                }
            }
            return numeros;
        }

        // Retorna -1 se a < b, +1 se a > b e 0 se a = b
        public static int comparar(int a, int b)
        {
            if (a < b)
                return -1;

            if (a > b)
                return 1;

            return 0;
        }

        public static void mostrarNumeros(int[] numeros)
        {
            if (numeros == null)
                throw new ArgumentNullException("\"numeros\" nao pode ser nulo.");

            Console.WriteLine(string.Join(", ", numeros));
        }
    }
}
