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
            Auto miAuto = new Auto("",1,"",0);
            
            miAuto.SetPatente("AA456CV");
            miAuto.SetCantRuedas(4);
            miAuto.SetTipo("Sedan");
            miAuto.SetColor(Color.DarkGreen);
            Console.WriteLine(miAuto.MostrarInformacion());
        
        }
    }
}
