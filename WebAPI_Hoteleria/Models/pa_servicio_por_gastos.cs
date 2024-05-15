using System.ComponentModel.DataAnnotations;
using System;

namespace WebAPI_Hoteleria.Models
{
    public class pa_servicio_por_gastos
    {
        [Key]
        public int idUsuario { get; set; }
        public string nombre { get; set; }
        public string apellidoPadre { get; set; }
        public int numeroHabitacion { get; set; }
        public int piso { get; set; }
        public DateTime fecha { get; set; }
        public decimal Total { get; set; }
    }
}
