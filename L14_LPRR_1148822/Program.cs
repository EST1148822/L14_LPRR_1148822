using System;

string opcion; 
int numero1, numero2;
int añ;

Console.WriteLine("Bienvenido al menú, seleccione una de las siguientes opciones por favor");
Console.WriteLine("Presione 1: -----> edad de empleado");
Console.WriteLine("Presione 2: -----> 5 puestos y salarios"); 
Console.WriteLine("Presione 3: -----> salir de programa");

opcion = Console.ReadLine();

switch (opcion)
{
    case "1":
      string[] nombres = new string[5];
        int[] año = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Introducir nombres de empleados: ");
            nombres[i] = Console.ReadLine();
            Console.WriteLine("Introducir año: ");
            año[i] = Convert.ToInt32(Console.ReadLine());  
        }
        for (int i = 0; i < 5; i++)
        {
            int edad;
            edad = 2022 - año[i];
            Console.WriteLine(nombres[i]);
            Console.WriteLine("edad: " + edad);
        }
        break;

        case "2":
        string[] puesto = new string[5];
        int[] salario = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("introducir puesto de empleado: ");
            puesto[i] = Console.ReadLine();
            Console.WriteLine("Introducir Salario: ");
            salario[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(puesto[i]);
            Console.WriteLine(salario[i]);
        }
        break;

        case "3":
        Console.WriteLine("Gracias por utilizar nuestros servicios, vuelva pronto :)");
        Environment.Exit(0);
        break;

        default:
        Console.WriteLine("Error :/");
        break;



}