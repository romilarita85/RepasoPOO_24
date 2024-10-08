//4)-Ejercicio Auto: clase(26 / 09)

//- Desarrolla una clase en C# llamada Auto que represente un automóvil y que incluya las siguientes características:

//Atributos:
//patente: un string que almacena la patente del auto.
//marca: un string que representa la marca del auto.
//cantCombustible: un double que indica la cantidad de combustible en el tanque.
//nacionalidad: un string estático que representa la nacionalidad del auto, inicializado en "Argentina".

//Constructores:
//Un constructor de instancia que permite inicializar patente, marca y cantCombustible.
//Un constructor estático que inicializa el atributo estático nacionalidad.

//Métodos Setters:
//SetCantCombustible(double cantidad): permite modificar la cantidad de combustible.
//SetNacionalidad(string nacionalidad): permite modificar la nacionalidad (este método es estático).
//SetMarca(string marca): permite modificar la marca del auto.
//Métodos Getters:

//GetCantCombustible(): devuelve la cantidad de combustible.
//GetMarca(): devuelve la marca del auto.
//GetPatente(): devuelve la patente del auto.
//GetNacionalidad(): devuelve la nacionalidad del auto (a través de un método de instancia).
//Métodos:

//MostrarInfo(): devuelve una cadena con la información del auto, incluyendo marca, patente, cantidad de combustible y nacionalidad.
//CompararAuto(Auto a1, Auto a2): un método estático que compara dos objetos Auto y devuelve true si son iguales (mismo marca y patente).

//-Crea una clase en C# llamada EstacionDeServicio en el espacio de nombres Biblioteca_Auto. Esta clase debe tener:

//Método de Instancia:
//RecargarCombustible(Auto a, double cantCombustible): recibe un objeto Auto y una cantidad de combustible, y utiliza el método setter del auto para actualizar su cantidad de combustible.
//Desarrolla una aplicación de consola en C# que utilice las clases Auto y EstacionDeServicio de la biblioteca Biblioteca_Auto. El programa debe realizar las siguientes acciones:

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
//Utiliza la clase EstacionDeServicio para recargar combustible a los autos. Implementa tanto un método estático como uno de instancia para llevar a cabo esta acción.
//Interacción en Consola:

//El programa debe imprimir en la consola la información relevante sobre los autos antes y después de las modificaciones y recargas de combustible.

using System.Runtime.CompilerServices;

namespace BibliotecaDeAuto2
{
    public class Auto
    {
        private string patente;
        private string marca;
        private double cantCombustible;
        private static string nacionalidad;

        //Constructores:
        //Un constructor de instancia que permite inicializar patente, marca y cantCombustible.
        //Un constructor estático que inicializa el atributo estático nacionalidad.
        public Auto(string patente, string marca, double cantCombustible)
        {
            this.patente = patente;
            this.marca = marca;
            this.cantCombustible = cantCombustible;
        }
        static Auto() 
        {
            Auto.nacionalidad = "Argentina";
        }

        //Métodos Setters:
        //SetCantCombustible(double cantidad): permite modificar la cantidad de combustible.
        //SetNacionalidad(string nacionalidad): permite modificar la nacionalidad (este método es estático).
        //SetMarca(string marca): permite modificar la marca del auto.

        //Métodos Getters:
        //GetCantCombustible(): devuelve la cantidad de combustible.
        //GetMarca(): devuelve la marca del auto.
        //GetPatente(): devuelve la patente del auto.
        //GetNacionalidad(): devuelve la nacionalidad del auto (a través de un método de instancia).

        public double CantCombustible 
        {
            get 
            { 
                return this.cantCombustible; 
            }
            set 
            { 
                this.cantCombustible = value; 
            } 
        }
        public void SetCantCombustible(double cantidad) 
        {
            this.cantCombustible = cantidad;
        }
        public static void SetNacionalidad(string nacionalidad) 
        {
            Auto.nacionalidad = nacionalidad;
        }
        public string Marca 
        {
            get
            {
                return this.marca; 
            }

            set
            {
                this.marca = value;
            }
        }

        public string GetPatente() 
        {
            return this.patente;
        }
        public string GetNacionalidad() 
        {
            return Auto.nacionalidad;
        }
        //MostrarInfo(): devuelve una cadena con la información del auto, incluyendo marca, patente, cantidad de combustible y nacionalidad.
        public string MostrarInfo() 
        {
            return $"Marca: {this.marca}- Patente: {this.patente} - Cantidad de combustible: {this.cantCombustible} - Nacionalidad: {Auto.nacionalidad}.";
        }
        //CompararAuto(Auto a1, Auto a2): un método estático que compara dos objetos Auto y devuelve true si son iguales (mismo marca y patente).
        public static bool CompararAuto(Auto a1, Auto a2) 
        {
            bool iguales = false;
            if (a1.marca == a2.marca && a1.patente == a2.patente) 
            {
                iguales = true;
            }
            return iguales;
        }
        public bool CompararAuto2(Auto autoComparar)
        {
            bool sonIguales;
            if (autoComparar.marca == this.marca && autoComparar.patente == this.patente)
            {
                sonIguales = true;  
            }
            else 
            {
                sonIguales = false;
            }
            return sonIguales;
        }
    }
}
