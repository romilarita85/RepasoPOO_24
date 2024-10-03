//Crear la clase de instancia Auto.
//La misma debe tener:

//A.Los atributos marca, cantCombustible, color.

//B. un constructor que inicialice todos los atributos.

//C. Solo metodos Get() para todos sus atributos.

//D. El metodo AutoToString(), este metodo debe retornar un string con toda su informacion.

//E. El metodo Avanzar(int km) que retornara un booleano para informar si pudo recorrer
//o no la cantidad de kilometros recibo por parametro, tener en cuenta que para poder
//avanzar se debe tener conbustible y por cada litro de combustible se pueden 10km.

//F. En un proyecto de consola crear un objeto del tipo Auto,mostrar todos su valores
// y dentro de un bucle repetitivo usar el metodo avanzar(),
//este debera repetirse hasta que el auto agote su combustible y se debera informar
//cuantas repeticiones logra realizar.
using System.Diagnostics;
using System.Drawing;

namespace BibliotecaDeAutos
{
    public class Auto
    {//A.Los atributos marca, cantCombustible, color.
        //*Todos los autos van a tener una misma nacionalidad(atributo static)
        private string marca;
        private double cantCombustible;
        private Color color;
        private static string nacionalidad; // es estatico-le pertenece a la clase
        //B. un constructor que inicialice todos los atributos.
        public Auto(string marca, double cantCombustible, Color color)
        {
            this.marca = marca;
            this.cantCombustible = cantCombustible;
            this.color = color;
        }
        static Auto() 
        {
            Auto.nacionalidad = "Argentina";
        }
        //C. Solo metodos Get() para todos sus atributos.
        public static string GetNacionalidad() 
        {
            return Auto.nacionalidad;
        }

        public static void SetNacionalidad(string nacionalidad) 
        {
            Auto.nacionalidad = nacionalidad;
        }
     

        public string GetMarca() 
        {
            return this.marca;
        }
        public void SetMarca(string marca) 
        {
            this.marca = marca;
            
        }
        public double GetCantCombustible()
        {
            return this.cantCombustible;
        }
        public void SerCantCombustible(double cantidad) 
        {
            this.cantCombustible = cantidad;
        }
        public Color GetColor()
        {
            return this.color;
        }
        public void SetColor(Color color)
        {
            this.color = color;
        }
        //D. El metodo AutoToString(), este metodo debe retornar un string con toda su informacion.
        public string AutoToString() 
        {
            return $"Marca: {this.marca} - Cantidad de combustible: {this.cantCombustible} - Color: {this.color.Name} - Nacionalidad: {Auto.nacionalidad}";
        }

        //E. El metodo Avanzar(int km) que retornara un booleano para informar si pudo recorrer
        //o no la cantidad de kilometros recibo por parametro, tener en cuenta que para poder
        //avanzar se debe tener conbustible y por cada litro de combustible se pueden 10km.
        public bool Avanzar(int km) 
        {
            bool pudoRecorrer = false;
            double combNecesario = (double)km / 10;

            if (cantCombustible > 0 && cantCombustible >= combNecesario)
            {// Si hay suficiente combustible, se resta la cantidad necesaria
                cantCombustible -= combNecesario;//cantCombustible = cantCombustible - combNecesario;
                pudoRecorrer = true;
            
            }

            return pudoRecorrer;
        }
        //Metodo publico de instancia que retorne un bool y que compare el auto actual con otro auto
        public bool CompararAuto(Auto autoComparar)
        {//bool me va a decir si es el auto o no
            bool sonIguales = false;

            if (autoComparar.marca == this.marca) 
            {
                sonIguales = true;
            }
            return sonIguales;
        }
        //Metodo publico estatico para comparar si mi auto1 es igual a mi auto2
        public static bool CompararAutos(Auto a1, Auto a2) 
        {
            bool sonIguales = false;
            if (a1.marca == a2.marca) 
            {
                sonIguales = true;  
            }
            return sonIguales;
        }
        //Metodo estatico usando comparaTo para compar auto1 y auto2: Forma larga**********************
        //public static int CompararAutosPorMarca(Auto a1, Auto a2) //le paso las dos instancias con las q vamos a trabajar
        //{//Comparo dos Strings
        //    int sonIguales = -1;//si estan desordenadas (dando por defecto valor)

        //    if (a1.marca == a2.marca)
        //    {
        //        sonIguales = 0;//si son iguales devuelve cero
        //    }
        //    else 
        //    {
        //        if (a1.marca.CompareTo(a2.marca) == 1)
        //        {//si la primera alfabeticamente es mayor q la segunda
        //            sonIguales = 1;//oredenadas alfabeticamente
        //        }
        //    }
        //    return sonIguales;

        //}

        //Metodo estatico usando comparaTo: Forma corta*********************
        public static int CompararAutosPorMarca(Auto a1, Auto a2) //le paso las dos instancias con las q vamos a trabajar
        {
            return a1.marca.CompareTo(a2.marca);
        }
    }
}
