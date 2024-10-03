//La clase Estudiante:

//⦁	Tendrá un constructor estático que inicializará el atributo estático random.
//⦁	Tendrá un constructor de instancia que inicializará los atributos nombre, apellido y legajo.
//⦁	El método setter SetNotaPrimerParcial permitirá cambiar el valor del atributo notaPrimerParcial.
//⦁	El método setter SetNotaSegundoParcial permitirá cambiar el valor del atributo notaSegundoParcial.
//⦁	El método privado CalcularPromedio retornará el promedio de las dos notas.
//⦁	El método CalcularNotaFinal deberá retornar la nota del final con un número aleatorio entre 6 y 10 incluidos siempre y cuando las notas del primer y segundo parcial sean mayores o iguales a 4, caso contrario la inicializará con el valor -1.
//⦁	El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos los datos de los alumnos:
//Nombre, apellido y legajo.
//Nota del primer y segundo parcial.
//Promedio.
//Nota final. Se mostrará sólo si el valor es distinto de -1, caso contrario se mostrará la leyenda "Alumno desaprobado".

//⦁	Crear tres instancias de la clase Estudiante (tres objetos) en el método Main.
//⦁	Cargar las notas del primer y segundo parcial a todos los alumnos. Dos deberán estar aprobados y uno desaprobado.
//⦁	Mostrar los datos de todos los alumnos.
using System.Text;

namespace BibliotecaDeEstudiantes
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial; 
        private int notaSegundoParcial;
        private static Random random; //ATRIBUTO ESTATICO
        
        //⦁	Tendrá un constructor estático que inicializará el atributo estático random.
        static Estudiante() //ok
        {
            Estudiante.random = new Random();
        }
        //⦁	Tendrá un constructor de instancia que inicializará los atributos nombre, apellido y legajo.
        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }
        //⦁	El método setter SetNotaPrimerParcial permitirá cambiar el valor del atributo notaPrimerParcial.
        public void SetNotaPrimerParcial(int nota) 
        {
            this.notaPrimerParcial = nota;

        }
        //⦁	El método setter SetNotaSegundoParcial permitirá cambiar el valor del atributo notaSegundoParcial.
        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;

        }
        //⦁	El método privado CalcularPromedio retornará el promedio de las dos notas.
        private float CalcularPromedio() 
        {
            float resultado;

            resultado = ((float)this.notaPrimerParcial + this.notaSegundoParcial) / 2;

            return resultado;
        }
        //⦁	El método CalcularNotaFinal deberá retornar la nota del final con un número aleatorio entre 6 y 10
        //incluidos siempre y cuando las notas del primer y segundo parcial sean mayores o iguales a 4,
        //caso contrario la inicializará con el valor -1.
        public double CalcularNotaFinal() 
        {
            double notaFinal = -1;
            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4) 
            {
                notaFinal = Estudiante.random.Next(6, 10);
            }
//Si un método necesita acceder a los campos de la clase(atributos) no es necesario recibir parámetros,
         //ya que puede acceder a esos campos directamente.
            return notaFinal;
        }

        //⦁	El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos los datos de los alumnos:
        //Nombre, apellido y legajo.
        //Nota del primer y segundo parcial.
        //Promedio.
        //Nota final. Se mostrará sólo si el valor es distinto de -1, caso contrario se mostrará la leyenda "Alumno desaprobado".
        public string MostrarInformacion() 
        {
            return $"Nombre: {this.nombre} - Apellido: {this.apellido} - Legajo: {this.legajo} - Nota 1°parcial: {this.notaPrimerParcial} - Nota 2°parcial: {notaSegundoParcial}";
        }
        public string Mostrar()
        {
            // Implementa la lógica para mostrar los datos del estudiante
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Alumno: {this.apellido},{this.nombre} - Legajo n°: {this.legajo}");
            sb.AppendLine($"Nota 1° parcial: {this.notaPrimerParcial}");
            sb.AppendLine($"Nota 2° parcial: {this.notaSegundoParcial}");
            sb.AppendLine($"Promedio: {this.CalcularPromedio()}");
            double notaFinal = this.CalcularNotaFinal();

            if (notaFinal != -1)
            {
                sb.AppendLine($"Nota final: {notaFinal}");
                sb.AppendLine("Alumno aprobado");
            }
            else
            {
                sb.AppendLine("Alumno desaprobado");
            }
            return sb.ToString();
        }
    }
}
