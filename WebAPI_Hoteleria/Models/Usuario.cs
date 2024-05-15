using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI_Hoteleria.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Reservacions = new HashSet<Reservacion>();
            Rols = new HashSet<Rol>();
        }

        public int IdUsuario { get; set; }
        public string Eliminado { get; set; }
        public int IdPais { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPadre { get; set; }
        public string ApellidoMadre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }

        public virtual Pai IdPaisNavigation { get; set; }
        public virtual ICollection<Reservacion> Reservacions { get; set; }
        public virtual ICollection<Rol> Rols { get; set; }
    }
}
