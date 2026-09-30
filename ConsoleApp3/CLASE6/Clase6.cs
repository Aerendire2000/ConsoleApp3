using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3.CLASE6
{
    // CLASE 6: LISTAS, DICCIONARIOS, GENERICOS E INTERFACES
    internal class Clase6
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- CLASE 6: LISTAS, DICCIONARIOS E INTERFACES ---");

            Listas();
            ListaDeObjetos();
            Diccionarios();
            Genericos();
            Interfaces();
        }

        // LIST<T>: UNA LISTA QUE CRECE Y SE ACHICA SOLA
        static void Listas()
        {
            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };

            names.Add("David");
            names.Add("David Alejandro");
            names.Add("Diana");

            names[3] = "Daniel";      // MODIFICAR POR POSICION
            names.Remove("Bob");      // REMOVER EL PRIMER ELEMENTO QUE ENCUENTRE

            Console.WriteLine($"Total names: {names.Count}");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            ConcatenarNombre(names);
        }

        static void ConcatenarNombre(List<string> nombres)
        {
            string resultado = string.Join(", ", nombres);
            Console.WriteLine($"Nombres concatenados: {resultado}");
        }

        static void ListaDeObjetos()
        {
            List<Usuario> usuarios = new List<Usuario>();

            usuarios.Add(new Usuario { Nombre = "David", Edad = 25 });
            usuarios.Add(new Usuario { Nombre = "David Alejandro", Edad = 30 });
            usuarios.Add(new Usuario { Nombre = "Bob", Edad = 25 });
            usuarios.Add(new Usuario { Nombre = "Diana", Edad = 28 });

            usuarios[3] = new Usuario { Nombre = "Daniel", Edad = 35 };

            // REMOVER EL PRIMER ELEMENTO QUE ENCUENTRE
            usuarios.Remove(usuarios.FirstOrDefault(u => u.Nombre == "Bob"));

            // REMOVER EL ELEMENTO EN LA POSICION 0
            usuarios.RemoveAt(0);

            // MOSTRAR LOS NOMBRES Y EDADES CON EL BUCLE FOR
            for (int i = 0; i < usuarios.Count; i++)
            {
                Console.WriteLine($"Nombre: {usuarios[i].Nombre}, Edad: {usuarios[i].Edad}");
            }
        }

        // DICTIONARY: GUARDA PARES CLAVE -> VALOR
        static void Diccionarios()
        {
            // key, value
            // CREACION DEL DICCIONARIO USUARIOS
            Dictionary<string, Usuario> usuarios = new Dictionary<string, Usuario>();

            // ANIADIR ELEMENTOS AL DICCIONARIO
            usuarios.Add("user1", new Usuario { Nombre = "Juan", Edad = 25 });

            // ANIADIR O MODIFICAR UN ELEMENTO EN EL DICCIONARIO
            usuarios["user2"] = new Usuario { Nombre = "Ana", Edad = 25 };

            // ANIADIR ELEMENTOS EN BUCLE CON CANTIDAD DEFINIDA
            for (int i = 3; i <= 5; i++)
            {
                usuarios.Add($"user{i}", new Usuario { Nombre = $"Usuario {i}", Edad = 20 + i });
            }

            // MENU CON DO-WHILE PARA SEGUIR AGREGANDO USUARIOS
            int salida = 0;
            do
            {
                Console.WriteLine("Ingrese un usuario:");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la edad:");
                int edad = int.Parse(Console.ReadLine());
                usuarios[nombre] = new Usuario { Nombre = nombre, Edad = edad };

                Console.WriteLine("Desea salir? (1 = si, 0 = no)");
                salida = int.Parse(Console.ReadLine());
                if (salida == 1)
                {
                    break;
                }
            } while (true);

            // BUSCAR UN ELEMENTO SIN QUE SE CAIGA SI NO EXISTE
            Console.WriteLine("Que usuario quieres buscar?");
            string input = Console.ReadLine();
            if (usuarios.TryGetValue(input, out Usuario usuario))
            {
                Console.WriteLine($"Usuario encontrado: {usuario.Nombre}, Edad: {usuario.Edad}");
            }
            else
            {
                Console.WriteLine("Usuario no encontrado.");
            }

            // BORRAR UN ELEMENTO DEL DICCIONARIO
            usuarios.Remove("user1");

            // MOSTRAR TODOS LOS ELEMENTOS DEL DICCIONARIO
            foreach (var kvp in usuarios)
            {
                Console.WriteLine($"Clave: {kvp.Key}, Nombre: {kvp.Value.Nombre}, Edad: {kvp.Value.Edad}");
            }
        }

        static void Genericos()
        {
            Codigo<string> idUser = new Codigo<string>();
            idUser.Identificador = "Usuario123";
            idUser.Agregar("admin");

            Codigo<int> idOrdenado = new Codigo<int>();
            idOrdenado.Identificador = 456;

            Console.WriteLine($"Codigo string: {idUser.Identificador} | Codigo int: {idOrdenado.Identificador}");

            Pair<int, int> coord = new Pair<int, int>(10, 20);
            Console.WriteLine(coord);

            Pair<string, string> nombreApellido = new Pair<string, string>("Juan", "Perez");
            Console.WriteLine(nombreApellido);
            Console.WriteLine($"Primer dato: {nombreApellido.PrimerDato()}");
        }

        static void Interfaces()
        {
            Producto producto = new Producto();
            producto.GuardarProducto("Cuaderno", 5.50);

            ProductoElectronico productoElectronico = new ProductoElectronico("220V");
            productoElectronico.GuardarProducto("Laptop", 3500);

            PedidoOnline pedido = new PedidoOnline();
            pedido.GuardarProducto("Mouse", 45);
            pedido.PagarProducto("Mouse", 45);
            pedido.EntregarProducto("Mouse", 45);
        }
    }
}
