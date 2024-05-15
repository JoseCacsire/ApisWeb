using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI_Hoteleria.Models
{
    public partial class TipoHabitacion
    {
        public TipoHabitacion()
        {
            Habitacions = new HashSet<Habitacion>();
        }

        public int IdTipoHabitacion { get; set; }
        public string Categoria { get; set; }
        public int Eliminado { get; set; }
        public int Camas { get; set; }
        public string Jacuzzi { get; set; }
        public string Netflix { get; set; }
        public string Internet { get; set; }
        public string Exterior { get; set; }
        public string Salon { get; set; }
        public string Terraza { get; set; }

        public virtual ICollection<Habitacion> Habitacions { get; set; }
    }
}
