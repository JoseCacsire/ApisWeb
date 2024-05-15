using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI_Hoteleria.Models
{
    public partial class Reservacion
    {
        public Reservacion()
        {
            Gastos = new HashSet<Gasto>();
        }

        public int IdReservacion { get; set; }
        public int Eliminado { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public decimal Precio { get; set; }
        public int IdHabitacion { get; set; }
        public int IdUsuario { get; set; }

        public virtual Habitacion IdHabitacionNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Gasto> Gastos { get; set; }
    }
}
