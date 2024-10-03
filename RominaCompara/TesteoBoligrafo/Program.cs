//En el Main de la clase Program, crear un bolígrafo de tinta “Azul” y un grosor “Fino” y otro
//de tinta “Roja” y un grosor “Grueso”
//Utilizar todos los métodos y mostrar los resultados por consola.
using BibliotecaDeBoligrafos;
using System.Drawing;

namespace TesteoBoligrafo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boligrafo b1 = new Boligrafo("Fino",Color.Blue);
            Boligrafo b2 = new Boligrafo("Grueso",Color.Red);

            Console.WriteLine(b1.MostrarInformacion());
            Console.WriteLine(b2.MostrarInformacion());

            Console.WriteLine($"Consuntando cantidad de tinta b1:{b1.GetCantidadTinta()}");
            Console.WriteLine($"Consultando capacidad de tinta maxima de b1 {b1.GetCapTintaMaxima()}");

            b2.SetColor(Color.White);
            b2.SetCapTinaMaxima(30);
            b2.SetCantidadTinta(50);

            Console.WriteLine(b2.MostrarInformacion());

            string texto = b1.Escribir("Hola");
            Console.WriteLine(texto);

            string texto1 = b2.Escribir("Utilizar todos los métodos y mostrar los resultados por consola.");
            Console.WriteLine(texto1);

            Console.WriteLine(b1.Recargar(30));
            Console.WriteLine(b2.Recargar(70));

        }
    }
}
