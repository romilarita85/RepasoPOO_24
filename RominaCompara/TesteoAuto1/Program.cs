//-Crea un programa en C# que gestione un automóvil utilizando la clase Auto. El programa debe:

//Crear un Auto con los siguientes atributos:

//Patente: "AA456CV"
//Cantidad de Ruedas: 4
//Tipo: "Sedan"
//Cantidad de Combustible: 0
//Color: DarkGreen
//Mostrar la Información del automóvil usando el método MostrarInformacion.


using BibliotecaDeAutos1;
using System.Drawing;

namespace TesteoAuto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto miAuto = new Auto();
            Auto miAuto2 = new Auto();
            
            miAuto.Patente = "AA456CV";
            miAuto.CantidadRuedas = 3;
            miAuto.SetTipo("Sedan");
            miAuto.SetColor(Color.DarkGreen);

            Console.WriteLine(miAuto.MostrarInformacion());
            Console.WriteLine(miAuto.GetTipo());
            double cantidad = 30 ;
            if (miAuto2.SetCantCombustible(cantidad))
            {
                Console.WriteLine("Se pudo ingresar la cantidad de combustible");

            }
            else 
            {
                Console.WriteLine("No se pudo ingresar la cantidad de  combustible");

            }


        }
    }
}
