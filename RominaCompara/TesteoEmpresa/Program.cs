//Desarrolla un programa en C# que utilice la clase Empresa para gestionar información sobre distintas empresas. El programa debe:

//-Crear una instancia de la clase Empresa con la razón social "XXX" y mostrar la fecha de inicio de actividades.
//-Establecer una nueva fecha de inicio de actividades a través del método estático EstablecerFechaInicio() y
//verificar que esta nueva fecha se aplique a todas las instancias.
//-Crear otra instancia de Empresa con la razón social "CFP 25" y mostrar ambas fechas de inicio de actividades para confirmar que son iguales.
//-Comparar diferentes empresas utilizando el método estático CompararPorRazonSocial() para determinar su orden alfabético y mostrar el resultado.
//Implementa el programa siguiendo estas especificaciones para comprobar la funcionalidad de la clase

using BibliotecaEmpresa;
using System.Net.Http.Headers;

namespace TesteoEmpresa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empresa e1 = new Empresa("Aviar");
            Empresa nuevaEmpresa = new Empresa("Coca-cola");

            Empresa.EstablecerFechaInicio();
           
            //-Crear una instancia de la clase Empresa con la razón social "XXX" y mostrar la fecha de inicio de actividades.
            Console.WriteLine(e1.GetFechaInicio());
           
            //-Establecer una nueva fecha de inicio de actividades a través del método estático EstablecerFechaInicio() y
            Empresa.EstablecerFechaInicio();
           
            //-Crear otra instancia de Empresa con la razón social "CFP 25" y mostrar ambas fechas de inicio de actividades
            //para confirmar que son iguales.
            Console.WriteLine($"Razon Social: {nuevaEmpresa.GetRazonSocial()}");
            Empresa.EstablecerFechaInicio();
            
            //-Comparar diferentes empresas utilizando el método estático CompararPorRazonSocial() para determinar
            //su orden alfabético y mostrar el resultado.
            int retorno;
            retorno = Empresa.CompararPorRazonSocial3(e1, nuevaEmpresa);    
            Console.WriteLine(retorno);
           
            //usando metodo 
            Empresa miEmpresa = new Empresa("Avianca");
            Empresa suEmpresa = new Empresa("Avianca");


            if (Empresa.CompararPorRazonSocial1(miEmpresa, suEmpresa))
            {
                Console.WriteLine("Las empresas son iguales");
            }
            else 
            {
                Console.WriteLine("Las empresas no son iguales");
            }
        }
    }
}
