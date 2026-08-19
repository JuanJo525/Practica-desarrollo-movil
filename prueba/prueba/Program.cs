using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace prueba
{
    internal class Program
    {
        class Producto
        {
            public string Nombre { get; set; }
            public double Precio { get; set; }
        }


        static List<Producto> productos = new List<Producto>();

        static void RegistrarProducto()
        {
            Console.Write("Ingrese el nombre del producto: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el precio del producto: ");
            double precio = double.Parse(Console.ReadLine());

            Producto nuevoProducto = new Producto();
            nuevoProducto.Nombre = nombre;
            nuevoProducto.Precio = precio;

            productos.Add(nuevoProducto);

            Console.WriteLine("Producto registrado correctamente.");
        }

        static void MostrarProductos()
        {
            Console.WriteLine("\n===== PRODUCTOS DISPONIBLES =====");

            if (productos.Count == 0)
            {
                Console.WriteLine("No hay productos registrados.");
            }
            else
            {
                for (int i = 0; i < productos.Count; i++)
                {
                    Console.WriteLine(
                        (i + 1) + ". " +
                        productos[i].Nombre +
                        " - $" +
                        productos[i].Precio
                    );
                }
            }
        }


        //-----------------------menu---------------------
        static void Main(string[] args)
        {
            bool inicio = true;
            while (inicio)
            {
                Console.WriteLine("=================================");
                Console.WriteLine("       BIENVENIDO A MI TIENDA");
                Console.WriteLine("=================================");
                Console.WriteLine();

                Console.WriteLine("1. Ver productos");
                Console.WriteLine("2. Agregar productos");
                Console.WriteLine("3. Ver carrito");
                Console.WriteLine("4. Finalizar compra");
                Console.WriteLine("5. Salir");

                Console.WriteLine();
                Console.Write("Seleccione una opción: ");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ver productos");
                        MostrarProductos();
                        break;

                    case 2:
                        RegistrarProducto();
                        break;

                    case 3:
                        Console.WriteLine("Ver carrito");
                        break;

                    case 4:
                        Console.WriteLine("Finalizar compra");
                        break;

                    case 5:
                        Console.WriteLine("¡Hasta luego!");
                        inicio = false;
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.ReadKey();
            }

        }


    }
    
}
