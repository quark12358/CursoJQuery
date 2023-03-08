using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApi_Back.Models;

namespace MiProyecto.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        
        //HttpContext.Response.AddHeader("Access-Control-Allow-Origin", "*");
        private readonly List<Usuario> _usuarios;

        public UsuarioController()
        {
            // Datos mock
            _usuarios = new List<Usuario>
            {
                new Usuario { Id = 1, Nombre = "Juan", Apellido = "Pérez", Email = "juan.perez@mail.com" },
                new Usuario { Id = 2, Nombre = "María", Apellido = "García", Email = "maria.garcia@mail.com" },
                new Usuario { Id = 3, Nombre = "Pedro", Apellido = "Rodríguez", Email = "pedro.rodriguez@mail.com" },
            };
        }

        [HttpGet]
        public ActionResult<IEnumerable<Usuario>> Get()
        {
           
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
            return Ok(_usuarios);
        }

        [HttpGet("{id}")]
        public ActionResult<Usuario> GetById(int id)
        {
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
            var usuario = _usuarios.FirstOrDefault(u => u.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);
        }

        [HttpPost]
        public ActionResult<Usuario> Create(Usuario usuario)
        {
            
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
            usuario.Id = _usuarios.Count + 1;
            _usuarios.Add(usuario);
            return CreatedAtAction(nameof(GetById), new { id = usuario.Id }, usuario);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Usuario usuario)
        {
            //ilpilpilp
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
            var usuarioToUpdate = _usuarios.FirstOrDefault(u => u.Id == id);
            if (usuarioToUpdate == null)
            {
                return NotFound();
            }
            usuarioToUpdate.Nombre = usuario.Nombre;
            usuarioToUpdate.Apellido = usuario.Apellido;
            usuarioToUpdate.Email = usuario.Email;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
            var usuarioToDelete = _usuarios.FirstOrDefault(u => u.Id == id);
            if (usuarioToDelete == null)
            {
                return NotFound();
            }
            _usuarios.Remove(usuarioToDelete);
            return NoContent();
        }
    }
}
