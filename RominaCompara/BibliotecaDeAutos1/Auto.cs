﻿//Crea una clase en C# llamada Auto que represente un automóvil. La clase debe incluir:

//Atributos:

//patente: string que almacena la patente del auto.
//cantidadRuedas: entero que indica el número de ruedas.
//tipo: string que describe el tipo de auto.
//cantidadCombustible: double que representa la cantidad de combustible en litros.
//color: objeto Color que representa el color del auto (inicializado como blanco por defecto).
//Constructor:

//Un constructor que reciba patente, cantidadRuedas, tipo y cantidadCombustible (con un valor por defecto para el color).
//Métodos Setters y Getters:

//SetTipo(string tipo): establece el tipo de auto, con validación para evitar strings vacíos.
//SetCantCombustible(double cant): establece la cantidad de combustible, asegurándose de que esté entre 0 y 150 litros.
//SetColor(Color color): establece el color del auto.
//GetPatente(): devuelve la patente.
//GetCantCombustible(): devuelve la cantidad de combustible.
//Métodos:

//Conducir(double distancia): permite al auto conducir una cierta distancia, descontando el combustible correspondiente. Retorna un booleano indicando si se pudo realizar la acción.
//MostrarInformacion(): devuelve un string con la información del auto (patente, tipo, color, cantidad de ruedas y cantidad de combustible).

using System.Drawing;

namespace BibliotecaDeAutos1
{
    public class Auto
    {
        private string patente;
        private int cantRuedas;
        private string tipo;
        private double cantCombustible;
        private Color color;

        public Auto(string patente, int cantRuedas, string tipo, double cantCombustible)
        {
            this.patente = patente;
            this.cantRuedas = cantRuedas;
            this.tipo = tipo;
            this.cantCombustible = cantCombustible;
            this.color = Color.White;
        }

        public void SetPatente(string valor)
        {
            this.patente = valor;
        }
        public string GetPatente()
        {
            return this.patente;
        }
        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            {
                patente = value;
            }
        }
        public void SetCantRuedas(int cantidad)
        {
            this.cantRuedas = cantidad;
        }
        public int GetCantRuedas() 
        {
            return this.cantRuedas;
        }
        public void SetTipo(string tipo) 
        { 
            this.tipo = tipo;   
        }
        public string GetTipo() 
        {
            return this.tipo;
        }
        public void SetCantCombustible(double cantidad) 
        {
            this.cantCombustible = cantidad;
        
        }
        public double GetCantCombustible()
        {
            return this.cantCombustible;
        }
        public void SetColor(Color color)
        {
            this.color = color;

        }
        public Color GetColor()
        {
            return this.color;
        }

        //Métodos:
        //Conducir(double distancia): permite al auto conducir una cierta distancia, descontando el combustible correspondiente.
        //Retorna un booleano indicando si se pudo realizar la acción.Por cada litro pudo hacer 4 kilometros
        public bool Conducir(double distancia) 
        {
            bool pudo = false;
            double consumo;
            consumo = distancia / 4;
            if (cantCombustible > consumo) 
            {
                cantCombustible -= consumo;
                pudo = true;
            }
            return pudo;
        }
        //MostrarInformacion(): devuelve un string con la información del auto (patente, tipo, color, cantidad de ruedas y cantidad de combustible).
        public string MostrarInformacion() 
        {
            string mensaje;
            mensaje = $"Patente: {this.patente}\n Tipo: {this.tipo}\n Color: {this.color}\n Cantidad de ruedas: {this.cantRuedas} \n Cantidad de combustible: {this.cantCombustible}\n";
            return mensaje;
        }
    }
}
