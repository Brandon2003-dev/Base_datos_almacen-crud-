using AlmacenProductos.DAO;
using AlmacenProductos.Models;

Console.WriteLine("\n---------------------------------------------------------");
Console.WriteLine("            BIENVENIDO A SU ALMACEN DE CONFIANZA :D        ");
Console.WriteLine("-----------------------------------------------------------");

CrudProductos CrudProductos = new CrudProductos();
Producto Producto = new Producto();

bool comprobar = true;
while (comprobar == true)
{
    Console.WriteLine("\n\n Coloque el numero de la accion a realizar ");
    Console.WriteLine("------------------------------------");
    Console.WriteLine("               MENU                 ");
    Console.WriteLine("------------------------------------");
    Console.WriteLine("      1. Ingresar Productos         ");
    Console.WriteLine("      2. Productos registrados      ");
    Console.WriteLine("      3. Salir                      ");
    Console.WriteLine("------------------------------------");

    Console.Write("- ¿Que desea hacer? ");
    var Menu = Convert.ToInt32(Console.ReadLine());

    switch (Menu)
    {
        case 1:
            int bucle = 1;
            while (bucle == 1)
            {
                Console.WriteLine("\n\n  Ingresar productos:");
                Console.WriteLine("------------------------------------");

                Console.WriteLine("- Nombre del producto: ");
                Producto.Nombre = Console.ReadLine();
                Console.WriteLine("- Descripcion:");
                Producto.Descripcion = Console.ReadLine();
                Console.WriteLine("- Precio: ");
                Producto.Precio = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("- Cantidad de productos en stock: ");
                Producto.Stock = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-----------------------------------\n");
                CrudProductos.AgregarProductos(Producto);

                Console.WriteLine(" - Producto ingresado correctamente \n");

                Console.WriteLine("Seleccione: ");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("   1. Continuar ingresando          ");
                Console.WriteLine("   2. Salir                         ");
                Console.WriteLine("-----------------------------------");
                Console.Write("- ¿Que desea realizar? ");
                bucle = Convert.ToInt32(Console.ReadLine());

            }
            break;

        case 2:
            Console.WriteLine("\n\n  Productos registrados:");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(" Id Cant. Producto Descripcion Precio ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Problemas con el servidor ingrese mas tarde: ");

            comprobar = false;

            break;

        case 3:
            Console.WriteLine("\n---------------------------------------------------------");
            Console.WriteLine("      Gracias por su visita, lo esperamos nuevamente :D      ");
            Console.WriteLine("-------------------------------------------------------------");

            comprobar = false;

            break;

    }
}
