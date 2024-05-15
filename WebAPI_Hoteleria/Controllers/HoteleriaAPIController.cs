using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
using WebAPI_Hoteleria.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;

namespace WebAPI_Hoteleria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HoteleriaAPIController : ControllerBase
    {
        private readonly HOTELERIA_SQLContext bd;

        public HoteleriaAPIController(HOTELERIA_SQLContext _bd)
        {
            bd = _bd;
        }


        // GET: api/<HoteleriaAPIController>
        [HttpGet("Usuarios_Reservaciones{id_usuario}")]
        public ActionResult Usuarios_Reservaciones(int id_usuario = 0)
        {
            var obj = bd.pa_usuarios_por_reservaciones.FromSqlRaw<pa_usuarios_por_reservaciones>
                ("pa_usuarios_por_reservaciones {0}", id_usuario).ToList();
            if (obj == null)
                return BadRequest("No se encontro el propietario buscado");
            return Ok(obj);
        }

        // GET api/<HoteleriaAPIController>/5
        [HttpGet("Servicio_Gastos{id_servicio}")]
        public ActionResult Servicio_Gastos(int id_servicio = 0)
        {
            var obj = bd.pa_servicio_por_gastos.FromSqlRaw<pa_servicio_por_gastos>
                ("pa_servicio_por_gastos {0}", id_servicio).ToList();
            if (obj == null)
                return BadRequest("No se encontro el propietario buscado");
            return Ok(obj);
        }

        // GET api/<HoteleriaAPIController>/5
        [HttpGet("Habitaciones_Tipo{id_tipo}/{piso}")]
        public ActionResult Habitaciones_Tipo(int id_tipo = 0, int piso = 0)
        {
            var obj = bd.pa_habitaciones_piso_tipo.FromSqlRaw<pa_habitaciones_piso_tipo>
                ("pa_habitaciones_piso_tipo {0}, {1}", id_tipo, piso).ToList();
            if (obj == null)
                return BadRequest("No se encontro el propietario buscado");
            return Ok(obj);
        }

        // GET api/<HoteleriaAPIController>/5
        [HttpGet("Reservaciones_Caras{id_tipo}/{precio}")]
        public ActionResult Reservaciones_Caras(int id_tipo = 0, int precio = 0)
        {
            var obj = bd.pa_reservaciones_caras.FromSqlRaw<pa_reservaciones_caras>
                ("pa_reservaciones_caras {0}, {1}", id_tipo, precio).ToList();
            if (obj == null)
                return BadRequest("No se encontro el propietario buscado");
            return Ok(obj);
        }

        [HttpGet("Lista_Usuarios")]
        public List<Usuario> Get()
        {
            var listado = bd.Usuarios.ToList();

            return listado;
        }

        [HttpGet("listaTipos")]
        public ActionResult Lista_Tipos()
        {
            var lista = bd.TipoHabitacions.ToList();
            return Ok(lista);
        }
        [HttpGet("listaServicios")]
        public ActionResult Lista_Servicios()
        {
            var lista = bd.Servicios.ToList();
            return Ok(lista);
        }
    }
}
