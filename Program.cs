using System.Data;
using System.Numerics;

class Program
{

    static void Main(string[] args)
    {
        Menu();
    }

    static void Menuprincipal()
    {
        Console.Clear();
        Console.WriteLine("1. Comprar ropa");
        Console.WriteLine("2. Comprar armas");
        Console.WriteLine("9. Carrito");
    }


    static void Menu()
    {
        int opcion = 1;
        while (opcion != 0)
        {
            Console.Clear();
            Menuprincipal();
            Console.Write("Escoge una opcion: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Comprarropa();
                    break;
                case 2:
                    Compraarmas();
                    break;
                case 9:
                    vercarrito();
                    break;

            }
        }

    }
    static void Comprarropa()
    {
        int total = 0;
        int respuesta = 1;
        while (respuesta != 0)
        {
            Console.Clear();
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|        Elige tu ropa:        |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|    1. Camiseta basica        |");
            Console.WriteLine("|Precio: 39$                   |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|    2. pantalon tactico       |");
            Console.WriteLine("|Precio: 299$                  |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|    3. Chaqueta multicam 150$ |");
            Console.WriteLine("|Precio: 150$                  |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|    4. Polar USAF MIL-TEC     |");
            Console.WriteLine("|Precio: 49$                   |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|    9. Ver total de compra    |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|    0. salir sin comprar nada |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("Eliga una opcion: ");
            respuesta = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (respuesta)
            {

                case 1:
                    total += 40;
                    carrito += "Camiseta basica (40$)";
                    totalcarrito += 40;
                    Console.WriteLine("Has añadido una camiseta basica (40$)");
                    break;
                case 2:
                    total += 299;
                    Console.WriteLine("Has añadido una camiseta basica (299$)");
                    break;
                case 3:
                    total += 150;
                    Console.WriteLine("Has añadido una camiseta basica (150$)");
                    break;
                case 4:
                    total += 49;
                    Console.WriteLine("Has añadido un Polar USAF MIL-TEC (49$) ");
                    break;
                case 9:
                    Console.WriteLine($"\ntotal de tu compra: {total}$");
                    Console.WriteLine("Gracias por comprar!");
                    break;
                case 0:
                    Console.WriteLine("Gracias po su compra.");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Opcion no valida, introduzca otra vez:");
                    break;
            }
            Console.Clear();
            if (respuesta != 0 && respuesta != 9)
            {
                Console.WriteLine("¿Quiere seguir comprando?");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Total actual: {total}$");
                Console.WriteLine("Presiona ENTER para continuar...");
                Console.ReadKey();
            }

        }
    }
    static void Compraarmas()
    {

        int total = 0;
        int respuesta = 1;
        while (respuesta != 0)
        {
            Console.Clear();
            Console.WriteLine("|-----------------------------|");
            Console.WriteLine("|     Elige tu compar         |");
            Console.WriteLine("|-----------------------------|");
            Console.WriteLine("| 1.  Rifle de precisión      |");
            Console.WriteLine("| Precio: 568$                |");
            Console.WriteLine("|-----------------------------|");
            Console.WriteLine("| 2. Escopeta de calibre 12   |");
            Console.WriteLine("| Precio: 749$                |");
            Console.WriteLine("|-----------------------------|");
            Console.WriteLine("| 3. Glock 17 de 19mm         |");
            Console.WriteLine("| Precio: 299$                |");
            Console.WriteLine("|-----------------------------|");
            Console.WriteLine("| 4. Carabina colt m16 .22LR  |");
            Console.WriteLine("| Precio: 799$                |");
            Console.WriteLine("|-----------------------------|");
            Console.WriteLine("|  9. Ver total de compra     |");
            Console.WriteLine("|-----------------------------|");
            Console.WriteLine("| 0. salir sin comprar nada   |");
            Console.WriteLine("|-----------------------------|");
            Console.Write("Opcion:");
            respuesta = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (respuesta)
            {
                case 1:
                    total += 568;
                    Console.WriteLine("Rifle de precisió seleccionado");
                    break;
                case 2:
                    total += 749;
                    Console.WriteLine("Escopeta de calibre 12 seleccionado");
                    break;
                case 3:
                    total += 299;
                    Console.WriteLine("Glock 17 de 19mm seleccionado");
                    break;
                case 4:
                    total += 799;
                    Console.WriteLine("Carabina colt m16 .22LR seleccionado");
                    break;
                case 9:
                    Console.WriteLine($"Total de la compra: {total}$");
                    break;
                case 0:
                    Console.WriteLine("Gracias por su compra.");
                    break;
                default:
                    Console.WriteLine("");
                    Console.ReadKey();
                    break;
            }
            if (respuesta != 0 && respuesta != 9)
            {
                Console.WriteLine("¿Quiere seguir comprando?");
                Console.WriteLine("Pulse la tecla enter...");
            }
            else
            {
                Console.WriteLine($"El resultado total es: {total}$");
                Console.WriteLine("Presione ENTER para termianr...");
                Console.ReadKey();

            }

        }
    }
static void vercarrito ()
    {
    string carrito = "";
    int totalcarrito = 0;
        Console.Clear();
        Console.WriteLine("|====================|");
        Console.WriteLine("|Carrito de la compra|");
        Console.WriteLine("|====================|");


        if (carrito == "")
        {
            Console.WriteLine(" El carrito esta vacio.");
        }
        else
        {
            Console.WriteLine(carrito);
            Console.WriteLine("|=================|");
            Console.WriteLine($"| TOTAL DE COMPRA: {totalcarrito}$|");
        }
        Console.WriteLine("|================|");
        Console.WriteLine("Presione ENTER para volver...");
        Console.ReadKey();
    }
}