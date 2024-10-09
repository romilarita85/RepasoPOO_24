using Microsoft.VisualBasic;
using System.Net;

namespace BibliotecaEmpresa
{
    public class Empresa
    {
        private string razonSocial;
        private static DateTime fechaInicioActividades;

        public Empresa(string razonSocial) 
        { 
            this.razonSocial = razonSocial;
        }
        static Empresa() 
        {
            Empresa.fechaInicioActividades = DateTime.Now;
        }
        
        public string GetRazonSocial() 
        {
            return this.razonSocial;
        }

        //-GetInicioActividades() : método de instancia que retorna la fecha de inicio de actividades.
        public DateTime GetFechaInicio() 
        {
            return Empresa.fechaInicioActividades;
        }

        public static void EstablecerFechaInicio()//Metodo Estatico
        {
            fechaInicioActividades = DateTime.Now;
        }
        //-CompararPorRazonSocial(Empresa e1, Empresa e2) : método public estático que compara dos empresas por su razón social y
        //devuelve un valor que indica su orden alfabético.
        public static bool CompararPorRazonSocial1(Empresa e1, Empresa e2) 
        {
            bool sonIguales = false;
            if (e1.razonSocial == e2.razonSocial) 
            {
                sonIguales = true;
            }
            return sonIguales;
        }

        public static int CompararPorRazonSocial2(Empresa e1, Empresa e2)
        {
            int sonIguales = -1;//no son iguales
            if (e1.razonSocial == e2.razonSocial)
            {
                sonIguales = 1;
            }
            else 
            {
                sonIguales = 0;
            }
            return sonIguales;
        }
        public static int CompararPorRazonSocial3(Empresa e1, Empresa e2)
        {
            return e1.razonSocial.CompareTo(e2.razonSocial);
        }
        public static int ComparaPorRazonSocial4(Empresa e1, Empresa e2) 
        {
            int comparacion = -1;
            if (e1.razonSocial == e2.razonSocial)
            {
                comparacion = 0;
            }
            else 
            {
                if (e1.razonSocial.CompareTo(e2.razonSocial) == 1) 
                {
                    comparacion = 1;
                }
            }
            return comparacion;
        }

    }
}
