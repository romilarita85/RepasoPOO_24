using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Recargar Combustible:
//Utiliza la clase EstacionDeServicio para recargar combustible a los autos.
//Implementa tanto un método estático como uno de instancia para llevar a cabo esta acción.
//Interacción en Consola:

//El programa debe imprimir en la consola la información relevante sobre los autos antes y después de las modificaciones
//y recargas de combustible.
namespace BibliotecaDeAuto2
{
    //clase y metodo estatico
    public static class EstacionDeServicio1
    {
        public static void RecargarCombustible(Auto a1, double cantCombustible)
        {
            a1.SetCantCombustible(cantCombustible);
        }
    }
    //Clase y metodo de instancia
    //public class EstacionDeServicio1
    //{
    //    public void RecargarCombustible(Auto a1, double cantCombustible) 
    //    {
    //        a1.SetCantCombustible(cantCombustible);
    //    }
    //}
}
