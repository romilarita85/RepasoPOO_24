namespace RepasoBucles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1)-WHILE(mientras)
             int control = 0;
            while (control<5) 
            {
                Console.WriteLine(control);
                control = control + 1;
            }
            //**********************************
            int control1 = 0;
            int repeticiones = 1;
            while (control1 < repeticiones) 
            {
                Console.WriteLine(control1);
                control1 = control1 + 1;
            }

            //2)-DO WHILE (repetir)
            int control2 = 0;
            int repeticiones2 = 0;

            do
            {
                Console.WriteLine(control2);
                control2 = control2 + 1;
            }
            while (control2 < repeticiones2);

            

            //3)-FOR(para)-> Cuando se la cantidad de repeticiones que tengo
            int control3 = 0;
            int repeticiones3 = 5;
            int i;

            for (i = 0; i > repeticiones3; i = i + 1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"valor del control despues del bucle {i}");
            //-------------------------------
            //Numeros pares y contadores:
            int control03 = 0;
            int repeticiones03 = 5;
            int contadorPares03 = 0;
     
            for (i = 0; i < repeticiones03; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} es un numero par");
                }
            }
            Console.WriteLine($"La cantidad de pares es: {contadorPares03}");
        }
    }
}
