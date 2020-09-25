using System;

namespace formulario
{
    class Program
    {
        static void Main(string[] args)
        {
            String name, apellidopa, apellidoma, number, address, ocupation;
            int age;
            Console.WriteLine("\nFORMULARIO");
            Console.WriteLine("\nIngrese su Nombre: ");
            name = Console.ReadLine();
            Console.WriteLine("\nIngrese su apellido paterno: ");
            apellidopa = Console.ReadLine();
            Console.WriteLine("\nIngrese su apellido materno: ");
            apellidoma = Console.ReadLine();
            Console.WriteLine("\nIngrese su edad: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nIngrese su numero telefonico:");
            number = Console.ReadLine();
            Console.WriteLine("\nIngrese su correo electrónico");
            address = Console.ReadLine();
            Console.WriteLine("\nIngrese su ocupación (a que se dedica):");
            ocupation = Console.ReadLine();

            if (age <= 18)
            {
                Console.WriteLine("\nSu registro no ha sido procesado, usted es menor de edad");
            }
            else if (age > 18)
            {
                Console.WriteLine("\nEl registro fue un éxito, compruebe si sus datos son correctos: ");
                Console.WriteLine("\nNombre del usuario: " + name);
                Console.Write("\nApellido paterno: "+ apellidopa);
                Console.WriteLine("\nApellido materno: "+ apellidoma);
                Console.WriteLine("\nEdad de usuario: " + age);
                Console.WriteLine("\nNumero de telefono: " + number);
                Console.WriteLine("\nCorreo: " + address);
                Console.WriteLine("\nOcupacion: " + ocupation);
            }
        }
    }
}