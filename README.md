# ConsoleApp3 — Desarrollo Web Fullstack C# + IA
### Opción 1 — Desde el Release (sin Visual Studio)
1. Ve a la sección **Releases** del repositorio.
2. Descarga `ConsoleApp3-v1.0.0.zip`.
3. Descomprímelo y haz doble clic en **`ConsoleApp3.exe`**.

### Opción 2 — Desde el código fuente
```bash
git clone https://github.com/Aerendire2000/ConsoleApp3.git
```
1. Abre `ConsoleApp3.slnx` en Visual Studio.
2. Presiona **F5** (o **Ctrl + F5** para que la consola no se cierre al terminar).
3. En el menú principal elige la opción **10** para entrar al inventario.

### Contenido por clase

| Opción | Clase | Temas |
|:---:|---|---|
| 1 | Clase 1 | Variables, tipos y operadores |
| 2 | Clase 2 | Condicionales, bucles y métodos |
| 3 | Clase 3 | do-while, `static` y `ref` |
| 4 | Clase 4 | Clases y objetos |
| 5 | Clase 5 | Struct, enum, encapsulamiento y herencia |
| 6 | Clase 6 | Listas, diccionarios, genéricos e interfaces |
| 7 | Clase 7 | Polimorfismo, `Math` y refactoring con Copilot |
| 8 | Clase 8 | SOLID y LINQ |
| 9 | Clase 9 | Captura de errores y patrón Repository |

--- PROYECTO CONTROL DE INVENTARIO ---
1. Ver inventario
2. Agregar producto nuevo
3. Registrar ingreso
4. Registrar salida
5. Cambiar precio
6. Eliminar producto
7. Ver productos con stock critico
8. Ver productos ordenados por stock
9. Resumen por categoria
10. Top 3 productos de mayor valor
11. Calcular reposicion
12. Ver historial de movimientos
13. Ver ultimo movimiento
0. Salir

### Principios SOLID aplicados

| Principio | Dónde se aplica |
|---|---|
| **S** — Responsabilidad única | `ServicioInventario` solo tiene la lógica; `ReporteConsola` solo imprime; `EntradaDatosConsola` solo lee |
| **O** — Abierto/cerrado | Un impuesto nuevo es una clase nueva que implementa `ICalculoIGV`; un tipo de producto nuevo se agrega en la Factory |
| **L** — Sustitución de Liskov | Cualquier hija de `Producto` funciona donde se espera un `Producto` |
| **I** — Segregación de interfaces | `IMovimientoStock` e `IReportable` son interfaces pequeñas con solo lo necesario |
| **D** — Inversión de dependencias | `ServicioInventario` recibe el repositorio y la calculadora por el constructor |

### Conceptos de C# aplicados

| Concepto | Ejemplo en el código |
|---|---|
| `const` | `Producto.STOCK_MINIMO_POR_DEFECTO = 5`, `UNIDADES_POR_CAJA = 6` |
| `static` | `ServicioInventario.TotalMovimientos`, `ProductoRepository._siguienteId` |
| `readonly` | Dependencias de `MenuInventario` y `ServicioInventario`; `Categoria.Tecnologia` |
| Clase abstracta y `protected` | `Producto` con `_stockMinimo` protegido y 3 clases hijas |
| Interfaces y genéricos | `IRepository<T>`, `Historial<T>` |
| Colecciones | `List<Producto>` e índice `Dictionary<string, Producto>` en el repositorio |
| LINQ | `Where`, `OrderBy`, `OrderByDescending`, `Take`, `GroupBy`, `Select`, `Sum` |
| Excepciones | `throw` en `Producto`, `ProductoRepository` y `ServicioInventario`; `try/catch` en `MenuInventario` |

## Autor
**LeviSolucionesTI** — [@Aerendire2000](https://github.com/Aerendire2000)
