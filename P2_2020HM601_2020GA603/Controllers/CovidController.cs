using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using P2_2020HM601_2020GA603.Models;

namespace P2_2020HM601_2020GA603.Controllers
{
    public class CovidController : Controller
    {
        private readonly DBCovidContext _CovidDbContext;

        public CovidController(DBCovidContext covidDbContext)
        {
            _CovidDbContext = covidDbContext;
        }

        public IActionResult Index()
        {
            //Lista de departamentos
            var listaDeDepartamentos = (from m in _CovidDbContext.departamentos
                                 select m).ToList();

            ViewData["listaDeDepartamentos"] = new SelectList(listaDeDepartamentos, "id_departamento", "nombre");


            //lista de generos
            //var listaDeGeneros = (from m in _CovidDbContext.generos
            //                            select m).ToList();

            //ViewData["listaDeGeneros"] = new SelectList(listaDeGeneros, "id_genero", "genero");



            //var listadoDeEquipos = (from e in _equiposDbContext.equipos
            //                        join m in _equiposDbContext.marcas on e.marca_id equals m.id_marcas
            //                        select new
            //                        {
            //                            nombre = e.nombre,
            //                            descripcion = e.descripcion,
            //                            marca_id = e.marca_id,
            //                            marca_nombre = m.nombre_marca
            //                        }).ToList();
            //ViewData["listadoDeEquipos"] = listadoDeEquipos;


            return View();
        }
    }
}
