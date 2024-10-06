using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Text;
using System.Reflection.Metadata.Ecma335;

namespace BibliotecaTelevisor
{
    public class Televisor
    {
        private string marca;
        private int pulgadas;
        private int volumen;
        private bool estaEncendido;

        public string Marca { get => marca; set => marca = value; }
        public int Pulgadas { get => pulgadas; set => pulgadas = value; }
        public int Volumen { get => volumen; set => volumen = value; }
        public bool EstaEncendido { get => estaEncendido; set => estaEncendido = value; }

        public Televisor() 
        { 
        }

        public Televisor(string marca, int pulgadas, int volumen, bool estaEncendido)
        {
            this.marca = marca;
            this.pulgadas = pulgadas;
            this.volumen = volumen;
            this.estaEncendido = estaEncendido;
        }

        public string GetMarca() 
        {
            return this.marca;
        }

        public void SetMarca(string marca) 
        {
            this.marca = marca;
        }
        public int GetPulgadas() 
        {
            return this.pulgadas;
        }
        public void SetPulgadas(int pulgad) 
        {
            this.pulgadas = pulgad;  
        }
        public int GetVolumen() 
        {
            return this.volumen;
        }
        public void SetVolumen(int volumen) 
        {
            this.volumen = volumen;
        }
        public bool GetEstaEncendido() 
        {
            return this.estaEncendido;
        }
        public void SetEstaEncendido(bool estaEncendido) 
        {
            this.estaEncendido = estaEncendido;
        }
        //Un método Encender que alterna el estado del televisor entre encendido y apagado.
        public void Encender() 
        { 
           
            this.estaEncendido = !this.estaEncendido;
        }

        //Métodos SubirVolumen y BajarVolumen que incrementan y decrementan el nivel de volumen, respectivamente.
        public void SubirVolumen() 
        {
            this.volumen ++;
        }
        public void BajarVolumen() 
        {
            this.volumen --; //volumen = volumen - 1;
        }

        //Un método MostrarTelevisor que devuelve una cadena con la información del televisor(marca, pulgadas, volumen y estado).
        public string MostrarTelevisor() 
        {
            string cadena;

            cadena = $"Marca: {this.marca}\n - Pulgadas: {this.pulgadas}\n - Volumen:  {this.volumen}\n - Estado: {this.estaEncendido}\n"; 
            
            return cadena;
        }
    }
}
