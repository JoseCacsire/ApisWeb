using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPI_Hoteleria.Models
{
    public class pa_reservaciones_caras
    {
        [Key]
        public int idReservacion { get; set; }
        public DateTime fechaEntrada { get; set; }
        public DateTime fechaSalida { get; set; }
        public decimal precio { get; set; }
        public int numeroHabitacion { get; set; }
        public string Cliente { get; set; }
    }
}
