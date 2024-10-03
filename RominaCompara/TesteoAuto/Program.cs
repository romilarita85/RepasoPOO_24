//F. En un proyecto de consola crear un objeto del tipo Auto,mostrar todos su valores
// y dentro de un bucle repetitivo usar el metodo avanzar(),
//este debera repetirse hasta que el auto agote su combustible y se debera informar
//cuantas repeticiones logra realizar.
using BibliotecaDeAutos;
using System.Drawing;

namespace TesteoAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto("Ford", 234.4, Color.Aqua);
            Auto auto2 = new Auto("Wolsbagen", 150, Color.Black);
            Console.WriteLine($"Los valores del auto son: {auto1.AutoToString()}");

            Console.WriteLine(auto1.GetCantCombustible());

            int repeticiones = 0; //contador para saber cuantas repeticiones hizo
            while (auto1.Avanzar(80))
            {
                repeticiones++; // repeticiones = repeticiones + 1;
            }
            Console.WriteLine("El auto agoto su combustible");
            Console.WriteLine($"Logro hacer {repeticiones} repeticiones");
            
            // Usando metodo de instancia
            if (auto1.CompararAuto(auto2)) 
            {
                Console.WriteLine("Son iguales");
            }
            else 
            {
                Console.WriteLine("Son distintos");
            }

            //Usando metodo estatico
            if (Auto.CompararAutos(auto1,auto2))
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son distintos");
            }

            Console.WriteLine(Auto.GetNacionalidad());

            //Usando metodo estatico con CompararAuto con compareTo
            int retorno = Auto.CompararAutosPorMarca(auto1,auto2);
            Console.WriteLine(retorno);

            //Usando metodo estatico SetNacionalidad

            Console.WriteLine(Auto.GetNacionalidad());
            Console.WriteLine("******Modificando el atributo static (nacionalidad) ******");
            Auto.SetNacionalidad("Alemana");

            Console.WriteLine($"La nueva nacionalidad es: {Auto.GetNacionalidad()}");
           
        }
    }
}
