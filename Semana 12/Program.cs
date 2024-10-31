using Semana_12;

byte opcion;
string regresar;
Estudiantes e = new Estudiantes();
do
{
    Console.WriteLine("BIENVENIDOS AL SISTEMA DE REGISTRO DE EDADES\n");
    Console.WriteLine("*******MENÚ*******");
    Console.WriteLine("* 1. Insertar    *");
    Console.WriteLine("* 2. Mostrar     *");
    Console.WriteLine("* 3. Eliminar    *");
    Console.WriteLine("* 4. Ordenar     *");
    Console.WriteLine("* 0. Salir       *");
    Console.WriteLine("******************\n");

    Console.WriteLine("Ingrese opcion");

    while (!byte.TryParse(Console.ReadLine(), out opcion) || opcion > 4)
    {
        Console.Write("Error: Ingrese opción: ");
    }

    switch (opcion)
    {
        case 0:Environment.Exit(0); break;
        case 1: e.insertar(); break;
        case 2: e.mostrar(); break;
        case 3:
            Console.Write("\nIngrese edad a eliminar: ");
            byte ed = byte.Parse(Console.ReadLine());
            e.eliminar(ed);
            break;
        case 4: break;
    }
    Console.WriteLine("\n\nDesea regresar al menú [si]: ");
    regresar = Console.ReadLine();
    Console.Clear();
} while (regresar == "si");



