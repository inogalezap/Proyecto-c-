using System.Collections.Generic;

class Program
{
    //VARIABLES PARA INICIAR SESION
    static bool sesion = false;
    static string User = "";

    //Una lista de lista para el carrito
    static List<string> carrito = new List<string>();
    static int totalcarrito = 0;
    static void Main(string[] args)
    {
        Menu();
    }
    // Esto es el menu principal que verá el usuario
    static void Menuprincipal()
    {
        Console.Clear();
        Console.WriteLine("|========MENU=========|");
        Console.WriteLine("|1. Inicio de sesion  |");
        Console.WriteLine("|=====================|");
        Console.WriteLine("|2. Comprar ropa      |");
        Console.WriteLine("|=====================|");
        Console.WriteLine("|3. Comprar armas     |");
        Console.WriteLine("|=====================|");
        Console.WriteLine("|4. informacion legal |");
        Console.WriteLine("|=====================|");
        Console.WriteLine("|5. Tienda mediaeval  |");
        Console.WriteLine("|=====================|");
        Console.WriteLine("|8. Realizar compra   |");
        Console.WriteLine("|=====================|");
        Console.WriteLine("|9. Ver Carrito       |");
        Console.WriteLine("|=====================|");

    }

    //Un menu para sus opciones que despues llevarán al usuario a donde eliga
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
                    iniciosesion();
                    break;
                case 2:
                    Comprarropa();
                    break;
                case 3:
                    Compraarmas();
                    break;
                case 4:
                    informacion();
                    break;
                case 5:
                    medieval();
                    break;
                case 8:
                    Realizarcompra();
                    break;
                case 9:
                    vercarrito();
                    break;

            }
        }

    }
    //La primera tienda de ropa
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
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|    1. Camiseta basica        |");
            Console.WriteLine("|Precio: 39$                   |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|    2. pantalon tactico       |");
            Console.WriteLine("|Precio: 299$                  |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|    3. Chaqueta multicam 150$ |");
            Console.WriteLine("|Precio: 150$                  |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|    4. Polar USAF MIL-TEC     |");
            Console.WriteLine("|Precio: 49$                   |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|    5. Benelli M3 (Escopeta)  |");
            Console.WriteLine("|Precio: 700$                  |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|    9. Ver total de compra    |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|    0. salir al menu principal|");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("Eliga una opcion: ");
            respuesta = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            //switch para que eliga y ademas se va sumando todo lo que eliga
            switch (respuesta)
            {

                case 1:
                    total += 40;
                    totalcarrito += 40;
                    Console.WriteLine("Has añadido una camiseta basica (40$)");
                    break;
                case 2:
                    total += 299;
                    totalcarrito += 299;
                    Console.WriteLine("Has añadido una camiseta basica (299$)");
                    break;
                case 3:
                    total += 150;
                    totalcarrito += 150;
                    Console.WriteLine("Has añadido una camiseta basica (150$)");
                    break;
                case 4:
                    total += 49;
                    totalcarrito += 49;
                    Console.WriteLine("Has añadido un Polar USAF MIL-TEC (49$) ");
                    break;
                case 5:
                    total += 700;
                    totalcarrito += 700;
                    Console.WriteLine("Has añadido un Polar USAF MIL-TEC (49$) ");
                    break;
                case 9:
                    Console.WriteLine($"total de tu compra: {total}$");
                    Console.WriteLine("Gracias por comprar!");
                    break;
                case 0:
                    Console.WriteLine("Gracias por su compra.");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Opcion no valida, introduzca otra vez:");
                    break;
            }
            //Aqui debe elegir un numero y si pone 9 le dira el total de dinero que tiene acumulado
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
    //Aqui esta la segunda tienda de armas, el codigo es mas de lo mismo que el de la tienda anterior
    static void Compraarmas()
    {

        int total = 0;
        int respuesta = 1;
        while (respuesta != 0)
        {
            Console.Clear();
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|     Elige tu compra          |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("| 1.  Rifle de precisión       |");
            Console.WriteLine("| Precio: 568$                 |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("| 2. Escopeta de calibre 12    |");
            Console.WriteLine("| Precio: 749$                 |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("| 3. Glock 17 de 19mm          |");
            Console.WriteLine("| Precio: 299$                 |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("| 4. Carabina colt m16 .22LR   |");
            Console.WriteLine("| Precio: 799$                 |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|    5. Benelli M3 (Escopeta)  |");
            Console.WriteLine("|Precio: 700$                  |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|  9. Ver total de compra      |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("| 0. salir al menu principal   |");
            Console.WriteLine("|------------------------------|");
            Console.Write("Opcion:");
            respuesta = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (respuesta)
            {
                case 1:
                    total += 568;
                    totalcarrito += 568;
                    Console.WriteLine("Rifle de precisió seleccionado");
                    break;
                case 2:
                    total += 749;
                    totalcarrito += 749;
                    Console.WriteLine("Escopeta de calibre 12 seleccionado");
                    break;
                case 3:
                    total += 299;
                    totalcarrito += 299;
                    Console.WriteLine("Glock 17 de 19mm seleccionado");
                    break;
                case 4:
                    total += 799;
                    totalcarrito += 799;
                    Console.WriteLine("Carabina colt m16 .22LR seleccionado");
                    break;
                case 5:
                    total += 700;
                    totalcarrito += 700;
                    Console.WriteLine("Benelli M3 (Escopeta)");
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
    //Aqui podra ver el carrito de la compra que verá todo lo acumulado de la compra
    static void vercarrito()
    {
        string carrito = "";
        int totalcarrito = 0;
        Console.Clear();
        Console.WriteLine("|====================|");
        Console.WriteLine("|Carrito de la compra|");
        Console.WriteLine("|====================|");

        Console.Clear();
        if (carrito == "")
        {
            Console.WriteLine(" El carrito esta vacio.");
        }
        else
        {
            Console.Clear();
            Console.WriteLine(carrito);
            Console.WriteLine("|=======================|");
            Console.WriteLine($"| TOTAL DE COMPRA: {totalcarrito}$|");
        }
        Console.WriteLine("|======================|");
        Console.WriteLine("Presione ENTER para volver...");
        Console.ReadKey();
    }
    //aqui realizara la compra
    static void Realizarcompra()
    {
        Console.Clear();
        Console.WriteLine("|========================|");
        Console.WriteLine("|    FINALIZA COMPRA     |");
        Console.WriteLine("|========================|");
        if (carrito.Count == 0)
        {
            Console.WriteLine("No hay ningun producto en el carrito");
        }
        else
        {
            Console.WriteLine("Productos comprados son: ");
            foreach (string producto in carrito)
            {
                Console.WriteLine(producto);
            }
            Console.WriteLine(" |=======================================|");
            Console.WriteLine($"|Total de la compra es: {totalcarrito}$ |");
            Console.WriteLine(" |   Gracias por su compra!              |");
            Console.WriteLine(" |=======================================|");
        }
        Console.WriteLine("|============================|");
        Console.WriteLine("Presione ENTER para volver...");
        Console.ReadKey();
            
        
    }
    //Este es un inicio de sesion solo tengo puesto un usuario que es (cliente) y su contraseña es (cliente1)
    static void iniciosesion()
    {
        Console.Clear();
        Console.WriteLine("|==================|");
        Console.WriteLine("| INICIO DE SESION |");
        Console.WriteLine("|==================|");
        Console.Clear();
        Console.WriteLine("Por favor introduzca el nombre de Usuario:");
        string user = Console.ReadLine();
        Console.WriteLine("Por favor introduzca la contraseña de Usuario:");
        string contraseña = Console.ReadLine();
        if (user == "cliente" && contraseña == "cliente1")
        {
            sesion = true;
            User = user;
            Console.WriteLine("Se ha iniciado sesion correctamente");
        }
        else
        {
            Console.WriteLine("Contraseña incorrecta, Vuelva a introducir una contraseña valida");
        }
        Console.WriteLine("Presiona ENTER para volver al menu principal...");
        Console.ReadKey();
    }
    //Información legal de la pagina. 
    static void informacion()
    {
        Console.Clear();
        Console.WriteLine("=================");
        Console.WriteLine("INFORMACION LEGAL");
        Console.WriteLine("=================");
        Console.WriteLine("Somos una emprese dedicada la venta y compra de armamentos, Todo aquel que deseé poseér un arma será totalmente responsable de sus actos");
        Console.WriteLine("por motivos legales tenemos que asegurarnos de que la persona que porte un arma esta totalmente capacitadas tanto psicologicamente como de");
        Console.WriteLine("no tener ninguna sancion por parte de la policia.");
        Console.WriteLine("El proceso de obtener un arma será evaluado por profesionales que determinarán si la persona es apta para portar dicha arma. Se harán diferentes pruebas");
        Console.WriteLine("por norma general no suele ser mas de 2 semanas de preparación.");
        Console.WriteLine("=====================================================================================================================================================================");
        Console.WriteLine("Por nuestra parte, en el caso hipotético de que alguien haga algo indevido no nos hacemos cargo de nada. Recordamos que tenemos todos los datos por si ocurriera algo.");
        Console.WriteLine("Gracias por leer esto.");
        Console.WriteLine();
        Console.WriteLine("Presione ENTER para volver...");
        Console.ReadKey();
        Console.Clear();
       
    }
    //Otra tienda pero de tematica medieval
    static void medieval()
    {
        int total = 0;
        int respuesta = 1;
        while (respuesta != 0)
        {
            Console.Clear();
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|     Elige tu arma medieval   |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("| 1.  casco de acero templado  |");
            Console.WriteLine("| Precio: 80$                  |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("| 2.  Cota de malla            |");
            Console.WriteLine("| Precio: 200$                 |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("| 3.  Arco de roble            |");
            Console.WriteLine("| Precio: 150$                 |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("| 4. Maza de guerra            |");
            Console.WriteLine("| Precio: 180$                 |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|    5. Espada larga de acero  |");
            Console.WriteLine("|Precio: 120$                  |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|  9. Ver total de compra      |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("| 0. salir al menu principal   |");
            Console.WriteLine("|------------------------------|");
            Console.Write("Opcion:");
            respuesta = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (respuesta)
            {
                case 1:
                    total += 80;
                    totalcarrito += 80;
                    Console.WriteLine("Rifle de precisió seleccionado");
                    break;
                case 2:
                    total += 200;
                    totalcarrito += 200;
                    Console.WriteLine("Escopeta de calibre 12 seleccionado");
                    break;
                case 3:
                    total += 150;
                    totalcarrito += 150;
                    Console.WriteLine("Glock 17 de 19mm seleccionado");
                    break;
                case 4:
                    total += 180;
                    totalcarrito += 180;
                    Console.WriteLine("Carabina colt m16 .22LR seleccionado");
                    break;
                case 5:
                    total += 120;
                    totalcarrito += 120;
                    Console.WriteLine("Benelli M3 (Escopeta)");
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


}