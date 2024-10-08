//Crear Objetos de Auto:

//Crea al menos dos instancias de la clase Auto con diferentes atributos (patente, marca y cantidad de combustible).

//Comparar Autos:
//Implementa la comparación de los autos utilizando un método de instancia y un método estático para verificar
//si son iguales (mismo marca y patente).

//Mostrar Nacionalidad:
//Utiliza los métodos para obtener y mostrar la nacionalidad de los autos. Asegúrate de que sea un atributo compartido entre todas las instancias.

//Modificar Atributos:
//Modifica la nacionalidad de los autos y muestra cómo afecta a todas las instancias. También, cambia la marca de uno de los autos y verifica que la otra instancia no se vea afectada.

//Recargar Combustible:
//Utiliza la clase EstacionDeServicio para recargar combustible a los autos.
//Implementa tanto un método estático como uno de instancia para llevar a cabo esta acción.
//Interacción en Consola:

//El programa debe imprimir en la consola la información relevante sobre los autos antes y después de las modificaciones
//y recargas de combustible.
using BibliotecaDeAuto2;

namespace TesteoAuto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto("AD123", "Ford", 120);
            Auto auto2 = new Auto("AD124", "Ford", 220);

            //Comparar Autos:
            //Implementa la comparación de los autos utilizando un método de instancia y un método estático para verificar
            //si son iguales (mismo marca y patente).
            if (Auto.CompararAuto(auto1, auto2))
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son distintos");

            }
            Auto auto3 = new Auto("AD123", "Ford", 120);
            Auto auto4 = new Auto("AD123", "Ford", 220);
            
            if (auto3.CompararAuto2(auto4))
            {
                Console.WriteLine("Son iguales");
            }
            else 
            {
                Console.WriteLine("Son distintos");
            }

            //Mostrar Nacionalidad:
            //Utiliza los métodos para obtener y mostrar la nacionalidad de los autos.
            //Asegúrate de que sea un atributo compartido entre todas las instancias.
            Console.WriteLine($"Auto 1: {auto1.GetNacionalidad()} - Auto 2:{auto1.GetNacionalidad()} - Auto 3: {auto3.GetNacionalidad()} ");
           
            string lectura;
            lectura = auto4.GetNacionalidad();
            Console.WriteLine(lectura);


            //Modificar Atributos:
            //Modifica la nacionalidad de los autos y muestra cómo afecta a todas las instancias.
            Auto.SetNacionalidad("Alemana");
            Console.WriteLine($"Auto 1: {auto1.GetNacionalidad()} - Auto 2:{auto2.GetNacionalidad()} - Auto 3: {auto3.GetNacionalidad()} - Auto 4: {auto4.GetNacionalidad()} ");

            //modificar cantidad de combustible para auto 1 y auto 2 con propertie:
            auto1.CantCombustible = 230;
            auto2.CantCombustible = 180;

            Console.WriteLine($"Auto 1: {auto1.CantCombustible} - Auto 2:{auto2.CantCombustible} - Auto 3: {auto3.CantCombustible} - Auto 4: {auto4.CantCombustible} ");
            //También, cambia la marca de uno de los autos y verifica que la otra instancia no se vea afectada.
            auto1.Marca = "Wolf";
           
            auto1.MostrarInfo();
            auto2.MostrarInfo();
            auto3.MostrarInfo();
            auto4.MostrarInfo();
        }
    }
}
