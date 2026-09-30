using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.PROYECTOS.INVENTARIO_CLASE9
{
    // [S] SRP: MOSTRAR REPORTES ES UNA RESPONSABILIDAD APARTE
    internal interface IReporteInventario
    {
        void MostrarLista(string titulo, IEnumerable<string> lineas);
        void MostrarMensaje(string mensaje);
    }
}
