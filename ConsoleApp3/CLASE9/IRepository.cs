using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CLASE9
{
    // PATRON REPOSITORY: CAPA INTERMEDIA ENTRE LA LOGICA DE NEGOCIO Y LA BASE DE DATOS
    // OBJETIVO: CENTRALIZAR EL ACCESO A LOS DATOS DE FORMA LIMPIA
    internal interface IRepository<T>
    {
        IEnumerable<T> ObtenerTodos();
        T ObtenerPorId(int id);
        void Agregar(T entidad);
        void Actualizar(T entidad);
        void Eliminar(int id);
    }
}
