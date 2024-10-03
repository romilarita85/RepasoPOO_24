//⦁	Crear tres instancias de la clase Estudiante (tres objetos) en el método Main.
//⦁	Cargar las notas del primer y segundo parcial a todos los alumnos. Dos deberán estar aprobados y uno desaprobado.
//⦁	Mostrar los datos de todos los alumnos.

using BibliotecaDeEstudiantes;

namespace TesteEstudiante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante e1 = new Estudiante("Gomez", "243435", "Clara");
            Estudiante e2 = new Estudiante("Adrian", "45466456", "Roco");
            Estudiante e3 = new Estudiante("Sanchez", "78989", "Cesar");

            e1.SetNotaPrimerParcial(4);
            e2.SetNotaPrimerParcial(8);
            e3.SetNotaPrimerParcial(2);
            e1.SetNotaSegundoParcial(6);
            e2.SetNotaSegundoParcial(4);
            e3.SetNotaSegundoParcial(2);

            Console.WriteLine(e1.Mostrar());
            Console.WriteLine(e2.Mostrar());
            Console.WriteLine(e3.Mostrar());

            Console.ReadLine();
        }
    }
}
