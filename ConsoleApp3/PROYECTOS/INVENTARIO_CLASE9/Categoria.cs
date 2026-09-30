using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.PROYECTOS.INVENTARIO_CLASE9
{
    // ENUM CON CLASE: LAS UNICAS CATEGORIAS VALIDAS SON ESTAS
    public class Categoria
    {
        public static readonly Categoria Tecnologia = new Categoria("Tecnologia");
        public static readonly Categoria Accesorios = new Categoria("Accesorios");
        public static readonly Categoria Consumibles = new Categoria("Consumibles");

        private string Name { get; }

        private Categoria(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
