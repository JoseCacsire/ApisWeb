using System.ComponentModel.DataAnnotations;
using System;

namespace WebAPI_Hoteleria.Models
{
    public class pa_usuarios_por_reservaciones
    {
        [Key]
        public int idReservacion { get; set; }
        public int idHabitacion { get; set; }
        public int numeroHabitacion { get; set; }
        public int piso { get; set; }
        public decimal precio { get; set; }
        public DateTime fechaEntrada { get; set; }
        public DateTime fechaSalida { get; set; }
    }
}
