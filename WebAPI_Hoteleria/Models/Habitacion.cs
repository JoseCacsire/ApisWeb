using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI_Hoteleria.Models
{
    public partial class Habitacion
    {
        public Habitacion()
        {
            FotoHabitacions = new HashSet<FotoHabitacion>();
            Reservacions = new HashSet<Reservacion>();
        }

        public int IdHabitacion { get; set; }
        public int NumeroHabitacion { get; set; }
        public int Piso { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio8Horas { get; set; }
        public decimal PrecioDia { get; set; }
        public int Eliminado { get; set; }
        public string Estado { get; set; }
        public int IdTipoHabitacion { get; set; }

        public virtual TipoHabitacion IdTipoHabitacionNavigation { get; set; }
        public virtual ICollection<FotoHabitacion> FotoHabitacions { get; set; }
        public virtual ICollection<Reservacion> Reservacions { get; set; }
    }
}
