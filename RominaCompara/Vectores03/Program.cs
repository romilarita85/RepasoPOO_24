// 3. Idem punto 2, pero calcular el promedio.
namespace Vectores03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[5];
            float promedio;
            int contador = 0;

            CargarVector(vector);
            Console.WriteLine("***************************");
            MostrarValores(vector);
            Console.WriteLine($"La suma de los elementos es {SumarValores(vector)}");
            //Calcular promedio
          
            while (contador < 5)
            {
                Console.WriteLine(contador);
                contador++;
            }

            foreach (int elemento in vector)
            {
                promedio = (float)SumarValores(vector) / contador;
                
            }
           
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
            foreach (int elemento in vector)
            {
                suma += elemento;
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
