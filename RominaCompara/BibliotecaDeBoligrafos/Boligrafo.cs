//Ejercitación programación orientada a objetos
//Una empresa de tecnología nos pide desarrollar un software para su más reciente
//invención: la “SmartPen”.

//Los requisitos planteados por parte de la empresa son los siguientes:
//● Crear una clase llamada Bolígrafo.
//● Los atributos serán los siguientes:
//-capacidadTintaMaxima
//- grosorPunta
//- color
//- cantidadTinta
//● Al crearse una nueva instancia de la clase Bolígrafo, la misma siempre se creará con
//una capacidad de tinta máxima de 100 (El constructor no recibirá este parámetro)
//● Al crearse una nueva instancia de la clase Bolígrafo la tinta siempre comenzará
//siendo de 80 (El constructor no recibirá este parámetro)
//● Al crearse una nueva instancia de la clase Bolígrafo se podrá elegir el color del
//mismo (El constructor recibirá un string indicando el color y lo guardará en el
//atributo)
//● Al crearse una nueva instancia de la clase Bolígrafo se podrá elegir el grosor de la
//punta del mismo (El constructor recibirá un string indicando el grosor y lo guardará
//en el atributo)

//● Los métodos de instancia serán los siguientes:
//● escribir(texto)
//- Deberá validar si el bolígrafo cuenta con la tinta suficiente para
//escribir el texto: la tinta a ser gastada corresponde a la cantidad de
//caracteres (Ej: el texto “hola” gasta 4 de tinta, si el trazo es fino. Si es
//grueso gasta el doble )
//- En caso de contar con la tinta suficiente, deberá restarse la cantidad
//del atributo cantidadTinta y devolver una cadena con el texto recibido
//por parámetro.
//- En caso de no contar con la tinta suficiente deberá retornar la cadena
//“No alcanza la tinta”.

//● recargar(cantidad)

//-Deberá sumarse la cantidad de tinta recibida por parámetro al
//atributo cantidadTinta.
//-Deberá validarse que la tinta recargada no supere el valor
//establecido por el atributo cantidadTintaMaxima. (Ej: Si el bolígrafo
//tiene 50 de tinta y el parámetro cantidad es 60 debe establecerse
//cantidadTinta en 100, no en 110, pues ese es el valor establecido
//como máximo en el atributo cantidadTintaMaxima.
//-Si la cantidad recargada no excede el máximo deberá retornarse la
//cadena “Lapicera recargada”.
//- Si la cantidad recargada excede el máximo deberá retornarse la
//cadena “Se recargó la lapicera y sobró __ cantidad de tinta. (Rellenar
//el espacio con el valor que se haya excedido)

//En el Main de la clase Program, crear un bolígrafo de tinta “Azul” y un grosor “Fino” y otro
//de tinta “Roja” y un grosor “Grueso”
//Utilizar todos los métodos y mostrar los resultados por consola.
using System.Drawing;
using System.Text;

namespace BibliotecaDeBoligrafos
{
    public class Boligrafo
    {
        #region Ejercicio Resuelto
        //private int capTintaMaxima;
        //private string grosorPunta;
        //private Color color;
        //private int cantidadTinta;

        //public Boligrafo( string grosorPunta, Color color)
        //{
        //    this.capTintaMaxima = 100;
        //    this.grosorPunta = grosorPunta;
        //    this.color = color;
        //    this.cantidadTinta = 80;
        //}
        //public int GetCapTintaMaxima() 
        //{
        //    return this.capTintaMaxima;
        //}
        //public void SetCapTinaMaxima(int tinta) 
        //{
        //    this.capTintaMaxima = tinta;
        //}
        //public string GetGrosorPunta() 
        //{
        //    return this.grosorPunta;    
        //}
        //public void SerGrosorPunta(string grosor) 
        //{
        //    this.grosorPunta = grosor;
        //}

        //public Color GetColor() 
        //{
        //    return this.color;  
        //}
        //public void SetColor(Color color) 
        //{
        //    this.color = color;
        //}
        //public int GetCantidadTinta() 
        //{
        //    return this.cantidadTinta;
        //}
        //public void SetCantidadTinta(int tinta) 
        //{
        //    this.cantidadTinta = tinta;
        //}

        ////● escribir(texto)
        ////- Deberá validar si el bolígrafo cuenta con la tinta suficiente para
        ////escribir el texto: la tinta a ser gastada corresponde a la cantidad de
        ////caracteres (Ej: el texto “hola” gasta 4 de tinta, si el trazo es fino. Si es
        ////grueso gasta el doble )
        ////- En caso de contar con la tinta suficiente, deberá restarse la cantidad
        ////del atributo cantidadTinta y devolver una cadena con el texto recibido
        ////por parámetro.
        ////- En caso de no contar con la tinta suficiente deberá retornar la cadena
        ////“No alcanza la tinta”.
        //public string Escribir(string texto) 
        //{
        //    string cadena = "No alcanza la tinta";
        //    int tintaSuficiente = texto.Length; // si el trazo es fino

        //    if (grosorPunta == "Grueso") 
        //    {
        //        tintaSuficiente = texto.Length * 2;
        //    }
        //    if (cantidadTinta > tintaSuficiente)
        //    {
        //        cantidadTinta-=tintaSuficiente; // cantidadTinta = cantidadTinta - tintaSuficiente;

        //        cadena = "Alcanzo la tinta";
        //    }

        //    return cadena;

        //}
        ////● recargar(cantidad)

        ////-Deberá sumarse la cantidad de tinta recibida por parámetro al
        ////atributo cantidadTinta.
        ////-Deberá validarse que la tinta recargada no supere el valor
        ////establecido por el atributo cantidadTintaMaxima. (Ej: Si el bolígrafo
        ////tiene 50 de tinta y el parámetro cantidad es 60 debe establecerse
        ////cantidadTinta en 100, no en 110, pues ese es el valor establecido
        ////como máximo en el atributo cantidadTintaMaxima.
        ////-Si la cantidad recargada no excede el máximo deberá retornarse la
        ////cadena “Lapicera recargada”.
        ////- Si la cantidad recargada excede el máximo deberá retornarse la
        ////cadena “Se recargó la lapicera y sobró __ cantidad de tinta. (Rellenar
        ////el espacio con el valor que se haya excedido)
        //public string Recargar(int cantidad) 
        //{
        //    string cadena = string.Empty;

        //    int tintaRecargada = cantidad + this.cantidadTinta;

        //    if (capTintaMaxima > tintaRecargada && capTintaMaxima < 100)
        //    {
        //        this.cantidadTinta = tintaRecargada; //cantidad de tinta pasa a tener un nuevo valor
        //        cadena = "Lapicera recargada";
        //    }
        //    else 
        //    {
        //        int excedente;
        //        excedente = tintaRecargada - capTintaMaxima;
        //        cadena = $"Se cargo la lapicera y sobro {excedente} de cantidad de tinta";
        //    }
        //    return cadena;

        //}
        //public string MostrarInformacion()
        //{
        //    return $" Cap tinta maxima: {capTintaMaxima} - Grosor punta: {grosorPunta} - Color: {color.Name} - Cantidad de tinta: {cantidadTinta}";
        //}
        #endregion

        private int capacidadTintaMaxima;
        private string grosorPunta;
        private Color color;
        private int cantidadTinta;

        public Boligrafo(string grosorPunta, Color color)
        {
            this.capacidadTintaMaxima = 100;
            this.grosorPunta = grosorPunta;
            this.color = color;
            this.cantidadTinta = 80;
        }

        public int CapacidadTintaMaxima 
        { 
            get 
            {
                return this.capacidadTintaMaxima; 
            } 
            set 
            { 
                this.capacidadTintaMaxima = value; 
            } 
        }
        public string GrosorPunta 
        {
            get 
            { 
                return this.grosorPunta; 
            }
            set 
            { grosorPunta = value; } 
        }
        public Color Color 
        {
            get 
            { 
                return this.color; 
            } 
            set 
            {
                this.color = value; 
            }
        }
        public int CantidadTinta
        {
            get
            {
                return cantidadTinta;
            }
            set
            {
                this.cantidadTinta = value;

            }
        }
        //● Los métodos de instancia serán los siguientes:
        //● escribir(texto)
        //- Deberá validar si el bolígrafo cuenta con la tinta suficiente para
        //escribir el texto: la tinta a ser gastada corresponde a la cantidad de
        //caracteres (Ej: el texto “hola” gasta 4 de tinta, si el trazo es fino. Si es
        //grueso gasta el doble )
        //- En caso de contar con la tinta suficiente, deberá restarse la cantidad
        //del atributo cantidadTinta y devolver una cadena con el texto recibido
        //por parámetro.
        //- En caso de no contar con la tinta suficiente deberá retornar la cadena
        //“No alcanza la tinta”.

        public string Escribir(string texto) 
        {
            string cadena = string.Empty;
            int tintaSuficiente = texto.Length;
          
            if (grosorPunta == "grueso") 
            {
                tintaSuficiente = texto.Length * 2;
            }
            if (cantidadTinta > tintaSuficiente)
            {
                cantidadTinta -= tintaSuficiente;       
            }
            else 
            {
                cadena = "No alcanza la tinta";
            }
            return cadena;
        }
        //public string Escribir(string texto) 
        //{
        //    string cadena = "No alcanza la tinta";
        //    int tintaSuficiente = texto.Length; // si el trazo es fino

        //    if (grosorPunta == "Grueso") 
        //    {
        //        tintaSuficiente = texto.Length * 2;
        //    }
        //    if (cantidadTinta > tintaSuficiente)
        //    {
        //        cantidadTinta-=tintaSuficiente; // cantidadTinta = cantidadTinta - tintaSuficiente;

        //        cadena = "Alcanzo la tinta";
        //    }

        //    return cadena;

        //}
        //● recargar(cantidad)

        //-Deberá sumarse la cantidad de tinta recibida por parámetro al
        //atributo cantidadTinta.
        //-Deberá validarse que la tinta recargada no supere el valor
        //establecido por el atributo cantidadTintaMaxima. (Ej: Si el bolígrafo
        //tiene 50 de tinta y el parámetro cantidad es 60 debe establecerse
        //cantidadTinta en 100, no en 110, pues ese es el valor establecido
        //como máximo en el atributo cantidadTintaMaxima.
        //-Si la cantidad recargada no excede el máximo deberá retornarse la
        //cadena “Lapicera recargada”.
        //-Si la cantidad recargada excede el máximo deberá retornarse la
        //cadena “Se recargó la lapicera y sobró __ cantidad de tinta. (Rellenar
        //el espacio con el valor que se haya excedido)
        public string Recargar(int cantidad) 
        {
            string cadena = string.Empty;
            int tintaRecargada = 0;
            if (tintaRecargada < capacidadTintaMaxima)
            {
                capacidadTintaMaxima += tintaRecargada;
                cadena = "Lapicera recargada";
            }
            else 
            {
                int sobrante;
                sobrante = tintaRecargada - capacidadTintaMaxima;
                cadena = $"Se recargó la lapicera y sobró {sobrante} cantidad de tinta.";
            }
            return cadena;
        }
        public string MostrarBoligrafo() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Capacidad de tinta maxima : {this.capacidadTintaMaxima}");
            sb.AppendLine($"Grosor punta: {this.GrosorPunta}");
            sb.AppendLine($"Color:{color.Name}");
            sb.AppendLine($"Cantidad de tinta: {this.capacidadTintaMaxima}");
            
            return sb.ToString();

  
        }
    }
}
