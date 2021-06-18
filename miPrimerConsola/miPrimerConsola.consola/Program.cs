using System;

namespace miPrimerConsola.consola
{  
    class Program
    {
        static void Main(string[] args)
        {
            //pedir datos de una persona: string, bool, datatime , int, float, dauble  10 datos 
            Console.WriteLine("Bienvenido");

            Console.Write("Escribe el nombre: ");
            var nombre = Console.ReadLine();
            Console.Write("Ingrese su edad: ");
            var edad = Console.ReadLine();
            int edad1 = int.Parse(edad);
            Console.Write("cual es su peso: ");
            float peso = float.Parse(Console.ReadLine());
            Console.Write("Eres programador ? true / false ");
            var respuesta = bool.Parse(Console.ReadLine());
            
            DateTime fecha = new DateTime(2021, 06, 17);

            Console.WriteLine("valores para una divicion");
            Console.Write("ingrese un numero entero: ");
            var x = Console.ReadLine();
            int x1 = int.Parse(x);
            Console.Write("ingrese un numero decimal: ");
            var y = Console.ReadLine();
            double y1 = double.Parse(y);
            double resultado = x1 / y1;
            Console.Write("ingrese salario minimo: ");
            var salario = Console.ReadLine();
            long salario1 = long.Parse(salario); 







            var persona = new Persona();
            persona.nombre = nombre;
            persona.edad = edad1;
            persona.peso = peso;

            Console.WriteLine("usted ingreso lo siguiente: ");
            Console.Write("\nnombre: \n" + persona.nombre);
            Console.Write("\nedad: \n" + persona.edad);
            Console.Write("\npeso: \n" + persona.peso);
            if (respuesta == true)
            {
                Console.Write("\neres programador eres fiel");
            }
            else
            {
                Console.Write("\nno eres programador no eres fiel");
            }
            Console.WriteLine("\nla fecha es: " + fecha);
            Console.WriteLine("\nEl resultado de la división es: {0} ", resultado);
            Console.WriteLine("Tu salario es de " + salario1);
            Console.Write(" \n muchas gracias digite cualquier tecla para terminar. ");
            Console.ReadKey();


        }





    }

}

/*
static void SaludoInicial(string[] args)
{
    if (args.Length > 0)
    {
        Console.WriteLine("Hola {0} {2} {1} ", args[0], args[1], args[2]);
    }
    else
    {
        Console.WriteLine("Hola Desconocido");
    }
    Console.WriteLine("como estas?");
    var estado = Console.ReadLine();
    Console.WriteLine("mmmmm, entiendo");
    Console.ReadLine();
    Console.WriteLine();
}
}
*/
