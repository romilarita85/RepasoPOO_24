//Crea una aplicación de consola en C# que interactúe con la clase Televisor del espacio de nombres Biblioteca_Televisor. El programa debe:
//-Crear Dos Televisores:
//Uno con el constructor por defecto y otro con el constructor parametrizado.

//-Mostrar Información:
//Utiliza el método MostrarTelevisor() para imprimir la información de ambos televisores.

//-Modificar Atributos:
//Cambia la marca del televisor parametrizado usando el setter y asigna valores al televisor por defecto.

//-Encender y Apagar:
//Usa el método Encender() para alternar el estado y muestra el resultado.

//-Controlar Volumen:
//Incrementa y decrementa el volumen con los métodos SubirVolumen() y BajarVolumen(), mostrando el volumen después de cada cambio.

using BibliotecaTelevisor;
using System.Text;

namespace TesteroTelevisor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Televisor tele1 = new Televisor();
            Televisor tele2 = new Televisor("Lg",32,50,true);

           
            Console.WriteLine(tele1.MostrarTelevisor());
            Console.WriteLine(tele2.MostrarTelevisor());

             tele1.Marca = "Sony";
             tele1.Pulgadas = 40;
             tele1.Volumen = 30;
             tele1.EstaEncendido = false;

            
            tele2.SetMarca("Bageo");
            Console.WriteLine(tele1.MostrarTelevisor());
            Console.WriteLine(tele2.MostrarTelevisor());
            // -Encender y Apagar:
            //Usa el método Encender() para alternar el estado y muestra el resultado.
            tele1.Encender();
            Console.WriteLine(tele1.MostrarTelevisor());
            tele2.Encender();
            Console.WriteLine(tele2.MostrarTelevisor());

            //Usar metodos subir y bajar volumen
            for (int i = 0; i < 10; i++)
            {
                tele1.SubirVolumen();//30+10 = 40
            }
            Console.WriteLine($"Subio el volumen en unos: {tele1.GetVolumen()}");//40
            
            for (int i = 0; i < 5; i++)
            {
                tele1.BajarVolumen();//40 - 5 = 36
            }
          
            Console.WriteLine($"Bajo el volumen en : {tele1.GetVolumen()}");
        }
    }
}
