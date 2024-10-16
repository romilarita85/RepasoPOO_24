using System.Numerics;
//1.Cargar un vector de enteros de 5 elementos y mostrarlo.
namespace Vectores01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vectorNumeros = new int[5];

            CargarVector(vectorNumeros);
            Console.WriteLine("************************");
            MostrarVector(vectorNumeros);
        }
        static void CargarVector(int[] vector) 
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"Ingrese un numero {i} en {i+1}: ");
                int numero = int.Parse(Console.ReadLine());
                vector[i] = numero;
            }
        }
        static void MostrarVector(int[] vector) 
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }
        }
       
    }
}
