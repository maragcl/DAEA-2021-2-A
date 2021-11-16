using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab13.Models;

namespace Lab13.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listar(string searchBy, string search)
        {
            List<Persona> personas = new List<Persona>();

            personas.Add(new Persona
            {
                PersonaID = 1,
                Nombre = "Juan",
                Apellido = "Perez",
                Direccion = "Av. Evergen 123",
                FechaNac = Convert.ToDateTime("1997-11-07"),
                Email = "juan@mail.com"
            });

            personas.Add(new Persona
            {
                PersonaID = 2,
                Nombre = "María",
                Apellido = "Salas",
                Direccion = "Av. Progreso 325",
                FechaNac = Convert.ToDateTime("1995-10-28"),
                Email = "maria@mail.com"
            });

            personas.Add(new Persona
            {
                PersonaID = 3,
                Nombre = "Carlos",
                Apellido = "Martinez",
                Direccion = "Av. Los manzanos 3101",
                FechaNac = Convert.ToDateTime("1982-02-14"),
                Email = "carlos@mail.com"
            });

            if (searchBy == "Nombre")
            {
                return View(personas.Where(x => x.Nombre.StartsWith(search) || search == null).ToList());
            }
            else if(searchBy == "Apellido")
            {
                return View(personas.Where(x => x.Apellido.StartsWith(search) || search == null).ToList());
            }
            else
            {
                return View(personas);
            }

            //return View(personas);
        }

        public ActionResult Mostrar(int id)
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona
            {
                PersonaID = 1,
                Nombre = "Juan",
                Apellido = "Perez",
                Direccion = "Av. Evergen 123",
                FechaNac = Convert.ToDateTime("1997-11-07"),
                Email = "juan@mail.com"
            });

            personas.Add(new Persona
            {
                PersonaID = 2,
                Nombre = "María",
                Apellido = "Salas",
                Direccion = "Av. Progreso 325",
                FechaNac = Convert.ToDateTime("1995-10-28"),
                Email = "maria@mail.com"
            });

            personas.Add(new Persona
            {
                PersonaID = 3,
                Nombre = "Carlos",
                Apellido = "Martinez",
                Direccion = "Av. Los manzanos 3101",
                FechaNac = Convert.ToDateTime("1982-02-14"),
                Email = "carlos@mail.com"
            });

            Persona persona = (from p in personas
                               where p.PersonaID == id
                               select p).FirstOrDefault();

            return View(persona);
        }

    }
}