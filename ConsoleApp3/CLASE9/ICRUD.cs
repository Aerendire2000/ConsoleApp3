using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.CLASE9
{
    // INTERFAZ CRUD: CREATE, READ, UPDATE, DELETE
    internal interface ICRUD
    {
        void CreateData();
        void ReadData();
        void UpdateData();
        void DeleteData();
    }
}
