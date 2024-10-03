namespace TesteoFunciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Testeo funcion Sumar
            //int numeroUno;
            //int numeroDos;
            //int resultado;

            //resultado = Sumar(4,5);
            //Console.WriteLine($"El resultado de la suma es : {resultado}");
            #endregion
            #region Testeo funcion PedirNumero
            //int numero;
            //numero = PedirNumero("Ingrese un numero");
            #endregion
            #region Testeo funcion PedirString
            //string nombre;
            //string apellido;
            //nombre = PedirString("Ingrese su nombre");
            //apellido = PedirString("Ingrese su apellido");
            //Console.WriteLine($"Su nombre completo es: {nombre} {apellido}");
            #endregion


        }
        #region Funcion para sumar dos numeros
        public static int Sumar(int numero1, int numero2)
        {
            int resultado = 0;
            resultado = numero1 + numero2;
            return resultado;
        }
        #endregion

        #region Funcion para pedir y retornar un numero
        public static int PedirNumero(string mensaje)
        {
           int numero;
           string lectura;
           
           Console.WriteLine(mensaje);
           lectura = Console.ReadLine();//lee mensaje
           numero = int.Parse(lectura);  
           return numero;
        }
        #endregion
        //Funcion para pedir y retornar una cadena
        public static string PedirString(string mensaje) 
        {
            string lectura;
            Console.WriteLine(mensaje);
            lectura = Console.ReadLine();
            return lectura;
        }
        //Funcion para evaluar una nota
        public static string EvaluarNota(int nota) 
        {
            string resultado = "promocionado";


            if (nota <= 3 && nota > 0)
            {
                resultado = "desaprobado";
            }
            else 
            {
                if (nota >= 4 && nota <= 5) 
                {
                    resultado = "regularizado";
                }
            }
            return resultado;
        }
        //Funcion para evaluar paridad
        public static bool EsPar(int numero) 
        {
            bool esPar = false;
            if (numero % 2 == 0 && numero != 0) 
            {
                esPar = true;
            }

            return esPar;
        }
        //Funcion para evaluar positividad
        public static int EvaluarPositividad(int numero) 
        {
            int positividad = 0;
            if (numero > 0)
            {
                positividad = 1;
            }
            else 
            {
                positividad = -1;
            
            }
            return numero;
        }
        //Funcion para calcular porcentaje
        public static double CalcularPorcentaje(int monto, int pje)
        {
            double resultado;
            resultado = 0;
            return resultado;
        }
        //Funcion para calcular Aumento
        public static double CalcularAumento(int monto, int ptje) 
        { 
            double resultado;
            resultado = monto + CalcularPorcentaje(monto, ptje);
            return resultado;
        }
        //Funcion para calcular Descuento
        public static double CalcularDescuento(int monto, int ptje)
        {
            double resultado;
            resultado = monto - CalcularPorcentaje(monto, ptje);
            return resultado;
        }
        //Funcion para promedios
        public static float CalcularPromedio(int acumulador, int contador) 
        {
            float resultado;
            resultado = (float)acumulador / contador;
            return resultado; 
        }
        //Metodo para generar un numero Aleatorio
        public static int Saltar() 
        {
            Random rnd = new Random();
            int altura = rnd.Next(10,70);
            Console.WriteLine("Estoy saltando");
            return altura;
        }
    }
}
