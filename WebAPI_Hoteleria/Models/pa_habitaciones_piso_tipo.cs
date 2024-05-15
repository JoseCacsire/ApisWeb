using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPI_Hoteleria.Models
{
    public class pa_habitaciones_piso_tipo
    {
        [Key]
        public int idHabitacion { get; set; }
        public int numeroHabitacion { get; set; }
        public int piso { get; set; }
        public string descripcion { get; set; }
        public decimal Horas { get; set; }
        public decimal Dia { get; set; }
        public string estado { get; set; }      
    }
}
