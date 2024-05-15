using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI_Hoteleria.Models
{
    public partial class Servicio
    {
        public Servicio()
        {
            Gastos = new HashSet<Gasto>();
        }

        public int IdServicio { get; set; }
        public int IdTipoServicio { get; set; }
        public int Eliminado { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        public virtual TipoServicio IdTipoServicioNavigation { get; set; }
        public virtual ICollection<Gasto> Gastos { get; set; }
    }
}
