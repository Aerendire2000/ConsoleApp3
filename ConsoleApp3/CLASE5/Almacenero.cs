using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CLASE5
{
    // HERENCIA: ALMACENERO ES UN USUARIO
    public class Almacenero : Usuario
    {
        public string AreaAlmacen;

        public Almacenero(
            string areaAlmacen,
            string nombre,
            int edad
            ) : base(nombre, edad)
        {
            this.AreaAlmacen = areaAlmacen;
        }

        public void OrganizarInventario()
        {
            Console.WriteLine($"{Nombre} esta organizando el inventario del area {AreaAlmacen}.");
        }
    }

    // ROLES QUE FALTAN EN LA TIENDA:
    // admin
    // supervisor o jefe de tienda
    // supervisor de almacen
    // cliente
}
