// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using ImplementacionClases.Utils;

// Ejemplo de Clase estatica:
// Console.WriteLine(ConsoleUtils.Saludar("Cecil"));

//Ejemplo de escritura por linea y por parte
//Console.Write("Hola");
//Console.WriteLine(" Mundo");

/* Ejemplo de cambios de colores en consola
Console.BackgroundColor = ConsoleColor.DarkGray;
Console.ForegroundColor = ConsoleColor.Green;
*/

/*Ejemplo Entrada / salida de consola
Console.Write("Escribe un nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine($"Ha escrito {nombre}");
*/

while (Menu()) 
{
    Console.ReadLine(); //Pausa, solicitar entradas de una tecla
}

static bool Menu() 
{
    Boolean continuar = true;

    Console.Clear();   //Limpia la pantalla 
    Console.Title = "Ejercicio Menu + Clases";

    Console.WriteLine(" ================");
    Console.WriteLine("=Menu de opciones=");
    Console.WriteLine(" ================");
    Console.WriteLine("1) Listar datos");
    Console.WriteLine("2) Agregar datos");
    Console.WriteLine("");
    Console.WriteLine("0) Salir ");

    String opcion = Console.ReadLine().Trim();//" 1 " => "1!

    switch (opcion)
    {
        case "1":
            Console.WriteLine("Escogio la opcion 1");
            break;
        case "2":
            Console.WriteLine("Escogio la opcion 2");
            OpcionInsertar();
            break;
        case "0":
            Console.WriteLine("Saliendo del progerama......");
            continuar = false;
            break ;
        default:
            Console.WriteLine("Opcion no valida");
            break;
    }

    return continuar;
}

static void OpcionInsertar()
{
    /*
     int id
     float nivel
     float temperatura
     float voltaje
    */
    try
    {
        Console.WriteLine("Ingrese el id");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese temperatura");
        float temperatura = float.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese valor del flujo");
        float flujo = float.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese valor del nivel ");
        float nivel = float.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese valor del voltaje ");
        float voltaje = float.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Ingrese correctamente los datos e intente otra vez");
        
    }




    /*
    //Ejemplos de Conversion
    int i = 5;
    i.ToString();//Cualquier cosa a String
    
    //Utilizando la clase Convert(Sirve a varios tipos)
    int convertido = Convert.ToInt32("-100");

    //Conversión explicita
    int test = 12345;
    float conDecimales = (float)test;

    //Conversión implicita
    int otroTest = 123456;
    float otroDecimal = otroTest;

    //A través de clases de tipo de dato
    string unEnteroSinConvertir = "98";
    */



}