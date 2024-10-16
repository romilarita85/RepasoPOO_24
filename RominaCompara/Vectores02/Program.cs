// 2. Cargar un vector de enteros de 5 elementos, sumar los valores y mostrarlo.
namespace Vectores02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[5];
            
            CargarVector(vector);
            Console.WriteLine("***************************");
            MostrarValores(vector);
            Console.WriteLine($"La suma de los elementos es {SumarValores(vector)}");
           
        }
        public static void CargarVector(int[] vector) 
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"Ingrese un numero {i + 1} de {vector.Length}");
                int numero = int.Parse(Console.ReadLine());
                vector[i] = numero; 
            }
        }
        public static int SumarValores(int[] vector) 
        {
            int suma = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                suma += vector[i];
            }
            return suma;
        }
        public static void MostrarValores(int[] vector) 
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);

            }
            
        }
    }
}
