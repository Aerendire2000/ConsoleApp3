using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CLASE8
{
    // LOS 5 PRINCIPIOS SOLID: 5 REGLAS DE ORO PARA CODIGO FACIL DE MANTENER Y ESCALAR

    // [S] SINGLE RESPONSIBILITY: UNA CLASE, UNA SOLA RAZON PARA CAMBIAR
    // MAL: LA CLASE CARRITO AGREGA PRODUCTOS, CALCULA Y ADEMAS IMPRIME
    // BIEN: SEPARAR LA IMPRESION EN OTRA CLASE
    public class Carrito
    {
        public List<string> productos = new List<string>();

        public void AgregarProducto(string producto)
        {
            productos.Add(producto);
        }
    }

    public class TicketImpresora
    {
        public void Imprimir(Carrito c)
        {
            Console.WriteLine($"Ticket: {string.Join(", ", c.productos)}");
        }
    }

    // [O] OPEN/CLOSED: ABIERTO PARA EXTENDERSE, CERRADO PARA MODIFICARSE
    // MAL: USAR MULTIPLES 'IF' PARA CADA NUEVO TIPO DE DESCUENTO
    // BIEN: USAR INTERFACES O CLASES ABSTRACTAS
    public interface IDescuento
    {
        double Aplicar(double total);
    }

    public class DescuentoVIP : IDescuento
    {
        public double Aplicar(double t) => t * 0.80;
    }

    // [L] LISKOV SUBSTITUTION: LAS HIJAS DEBEN PODER SUSTITUIR AL PADRE SIN ROMPERSE
    // BIEN: SEPARAR LA LOGICA PARA NO HEREDAR COMPORTAMIENTOS IMPOSIBLES
    public abstract class ProductoBase { public string Nombre { get; set; } }

    public class ProductoFisico : ProductoBase, IEnviable
    {
        public double CalcularPeso() => 1.5;
    }

    public class ProductoDigital : ProductoBase, IDescargable
    {
        public void GenerarLink() => Console.WriteLine($"Link de descarga de {Nombre} generado.");
    }

    // [I] INTERFACE SEGREGATION: NO OBLIGAR A DEPENDER DE INTERFACES QUE NO SE USAN
    // BIEN: INTERFACES PEQUENIAS Y ESPECIFICAS
    public interface IDescargable
    {
        void GenerarLink();
    }

    public interface IEnviable
    {
        double CalcularPeso();
    }

    // [D] DEPENDENCY INVERSION: DEPENDER DE ABSTRACCIONES, NO DE CLASES CONCRETAS
    // BIEN: EL CARRITO RECIBE UNA INTERFAZ POR SU CONSTRUCTOR
    public interface IBaseDatos
    {
        void Guardar(string dato);
    }

    public class BaseDatosMemoria : IBaseDatos
    {
        public void Guardar(string dato) => Console.WriteLine($"Guardado en memoria: {dato}");
    }

    public class CarritoConBaseDatos
    {
        private readonly IBaseDatos _db;

        public CarritoConBaseDatos(IBaseDatos db)
        {
            _db = db;
        }

        public void Guardar(string producto)
        {
            _db.Guardar(producto);
        }
    }
}
