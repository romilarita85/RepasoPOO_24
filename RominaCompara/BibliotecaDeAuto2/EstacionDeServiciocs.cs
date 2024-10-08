using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Recargar Combustible:
//Utiliza la clase EstacionDeServicio para recargar combustible a los autos.
//Implementa tanto un método estático como uno de instancia para llevar a cabo esta acción.
//Interacción en Consola:
//RecargarCombustible(Auto a, double cantCombustible )
//El programa debe imprimir en la consola la información relevante sobre los autos antes y después de las modificaciones
//y recargas de combustible.
namespace BibliotecaDeAuto2
{
    public class EstacionDeServiciocs
    {
        public void RecargarCombustible(Auto a, double cantComb) 
        {

            a.SetCantCombustible(cantComb);
        }
    }
}
