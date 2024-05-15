using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI_Hoteleria.Models
{
    public partial class Gasto
    {
        public int IdGastos { get; set; }
        public int IdReservacion { get; set; }
        public int IdServicio { get; set; }
        public int Eliminado { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

        public virtual Reservacion IdReservacionNavigation { get; set; }
        public virtual Servicio IdServicioNavigation { get; set; }
    }
}
