using System;
using System.Collections;
using System.Collections.Generic;

namespace suma_de_multiplos_generalizada_gtesistemas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Hola, introduce el número tope para para suma de múltiplos de N números:");
            int tope = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la cantidad de números:");
            int cantidadNumeros = int.Parse(Console.ReadLine());
            Console.WriteLine("Ahora, los números:");
            List<int> listaNumeros = new List<int>();
            List<int> listaSumandos = new List<int>();
            int numeroIngresado;
            int total=0;

            for (int i=0;i<cantidadNumeros;i++)
            {
                numeroIngresado = int.Parse(Console.ReadLine());
                if (listaNumeros.IndexOf(numeroIngresado)  == -1)
                    {
                    listaNumeros.Add(numeroIngresado);
                    }
                    else
                    {
                    Console.WriteLine("Número repetido, intente de nuevo.");
                    i--;
                    }
            }

            Console.WriteLine("El número tope es es: {0} ",tope);
            Console.Write("La lista de números es: ");
            foreach (int numero in listaNumeros)
                {
                    for (int i=0;i<=tope;i++)
                    {
                    if ((i % numero == 0) && (listaSumandos.IndexOf(i)  == -1))
                    {
                        listaSumandos.Add(i);
                    }
                    }
                Console.Write(" {0}",numero);
                }
            Console.WriteLine("");

            Console.Write("La lista de números a sumar es: ");
            foreach (int sumando in listaSumandos)
            {
                Console.Write(" {0} ", sumando);
                total = total+sumando;
            }
            Console.WriteLine("");
            Console.Write("El total de la suma es: {0} ", total);

        }
    }
        
}

