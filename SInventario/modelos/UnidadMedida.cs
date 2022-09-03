using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SInventario.modelos
{
    public class UnidadMedida
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string abreviatura { get; set; }

        public UnidadMedida(int id, string nombre, string abreviatura)
        {
            this.id = id;
            this.nombre = nombre;
            this.abreviatura = abreviatura;
        }
    }
}
