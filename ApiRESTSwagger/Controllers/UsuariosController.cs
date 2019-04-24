using ApiRESTSwagger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiRESTSwagger.Controllers
{
    public class UsuariosController : ApiController
    {
        Usuarios[] usuarios = new Usuarios[]{
            new Usuarios { ID = 1, Name = "Mark", Age = 30 },
            new Usuarios { ID = 2, Name = "Allan", Age = 35 },
            new Usuarios { ID = 3, Name = "Johny", Age = 21 }
        };

        public IEnumerable<Usuarios> GetAllEmployees()
        {
            return usuarios;
        }

        public IHttpActionResult GetEmployee(int id)
        {
            var employee = usuarios.FirstOrDefault((p) => p.ID == id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }
    }
}
