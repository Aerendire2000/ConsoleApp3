using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.PROYECTOS.INVENTARIO_CLASE9
{
    // CLASE GENERICA: SIRVE PARA GUARDAR EL HISTORIAL DE CUALQUIER TIPO
    internal class Historial<T>
    {
        List<T> registros = new List<T>();

        public void Agregar(T registro)
        {
            registros.Add(registro);
        }

        public List<T> ObtenerTodos()
        {
            return registros;
        }

        public int Cantidad()
        {
            return registros.Count;
        }
    }
}
