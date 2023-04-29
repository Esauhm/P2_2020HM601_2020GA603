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
            var listaDeGeneros = (from m in _CovidDbContext.generos
                                  select m).ToList();

            ViewData["listaDeGeneros"] = new SelectList(listaDeGeneros, "id_genero", "genero");



            var listadoDeCasos = (from e in _CovidDbContext.casosResportados
                                  join d in _CovidDbContext.departamentos on e.id_departamento equals d.id_departamento
                                  join g in _CovidDbContext.generos on e.id_generos equals g.id_genero
                                  select new
                                    {
                                        departamentos = d.nombre,
                                        genero = g.genero,
                                        confirmados = e.confirmados,
                                        recuperados = e.recuperados,
                                        fallecidos = e.fallecidos
                                    }).ToList();


            ViewData["listadoDeCasos"] = listadoDeCasos;


            return View();
        }

        public IActionResult CrearCasos(CasoReportado nuevoCaso)
        {
            _CovidDbContext.Add(nuevoCaso);
            _CovidDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
