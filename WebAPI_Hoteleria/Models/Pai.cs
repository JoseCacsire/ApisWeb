using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI_Hoteleria.Models
{
    public partial class Pai
    {
        public Pai()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int IdPais { get; set; }
        public int Eliminado { get; set; }
        public string NombrePais { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
