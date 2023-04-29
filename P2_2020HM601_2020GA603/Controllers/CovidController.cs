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



            var listadoDeCasos = (from e in _CovidDbContext.casosReportados
                                  join d in _CovidDbContext.departamentos on e.id_departamento equals d.id_departamento
                                  join g in _CovidDbContext.generos on e.id_genero equals g.id_genero
                                  select new
                                    {
                                        
                                        confirm = e.confirmados,
                                        recuper = e.recuperados,
                                        fallec = e.fallecidos,
                                        departamentos = d.nombre,
                                        generos = g.genero
                                  }).ToList();


            ViewData["listadoDeCasos"] = listadoDeCasos;


            return View();
        }

        public IActionResult CrearCasos(CasosReportados nuevoCaso)
        {
            _CovidDbContext.Add(nuevoCaso);
            _CovidDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
