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
            #region Ejercicio resuelto
            //Boligrafo b1 = new Boligrafo("Fino",Color.Blue);
            //Boligrafo b2 = new Boligrafo("Grueso",Color.Red);

            //Console.WriteLine(b1.MostrarInformacion());
            //Console.WriteLine(b2.MostrarInformacion());

            //Console.WriteLine($"Consuntando cantidad de tinta b1:{b1.GetCantidadTinta()}");
            //Console.WriteLine($"Consultando capacidad de tinta maxima de b1 {b1.GetCapTintaMaxima()}");

            //b2.SetColor(Color.White);
            //b2.SetCapTinaMaxima(30);
            //b2.SetCantidadTinta(50);

            //Console.WriteLine(b2.MostrarInformacion());


            //string texto = b1.Escribir("Hola");
            //Console.WriteLine(texto);

            //string texto1 = b2.Escribir("Utilizar todos los métodos y mostrar los resultados por consola.");
            //Console.WriteLine(texto1);

            //Console.WriteLine(b1.Recargar(30));
            //Console.WriteLine(b2.Recargar(70));
            #endregion

            Boligrafo b1 = new Boligrafo("fino", Color.Blue);
            Boligrafo b2 = new Boligrafo("grueso", Color.Red);

            Console.WriteLine(b1.MostrarBoligrafo());
            Console.WriteLine(b2.MostrarBoligrafo());

            b1.GrosorPunta = "grueso";
            b2.GrosorPunta = "fino";
            Console.WriteLine(b1.GrosorPunta);
            Console.WriteLine(b2.GrosorPunta);
//*****************************************+
            string texto;
            Console.WriteLine("Ingrese el texto para el boligrafo 1");
            texto = Console.ReadLine();
            Console.WriteLine(b1.Escribir(texto));
           
            Console.WriteLine("Ingrese el texto para el boligrafo 2");
            texto = Console.ReadLine();
            Console.WriteLine(b2.Escribir(texto));
            //************************************
            int cantidad;
            Console.WriteLine("Ingrese la cantidad de tinta que va a recargar al boligrafo 1: ");
            cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine(b1.Recargar(cantidad));
            
            Console.WriteLine("Ingrese la cantidad de tinta que va a recargar al boligrafo 2: ");
            cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine(b2.Recargar(cantidad));
            
            //****************************************************
            Console.WriteLine($"Valores de boligrafo 1: {b1.MostrarBoligrafo()}");
            Console.WriteLine($"Valores de boligrafo 2: {b2.MostrarBoligrafo()}");

        }
    }
}
