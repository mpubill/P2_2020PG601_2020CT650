using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using P2_2020PG601_2020CT650.Models;

namespace P2_2020PG601_2020CT650.Controllers
{
    public class casos_reportadosController : Controller
    {
        private readonly covidDbContext _covidDbContext;
        public casos_reportadosController(covidDbContext covidDbContext)
        {
            _covidDbContext = covidDbContext;
        }
        public IActionResult Index()
        {
            var listaDeGenero = (from m in _covidDbContext.genero
                                     select m).ToList();
            ViewData["ListadoDeGenero"] = new SelectList(listaDeGenero, "generoId", "nombreGenero");

            var listaDeDepartamento = (from m in _covidDbContext.departamento
                                 select m).ToList();
            ViewData["ListadoDeDepartamento"] = new SelectList(listaDeDepartamento, "departamentoId", "nombreDepartamento");

            var listadoDeCasos = (from e in _covidDbContext.casos_reportados
                                    join m in _covidDbContext.genero on e.generoId equals m.generoId
                                    join j in _covidDbContext.departamento on e.departamentoId equals j.departamentoId
                                    select new
                                    {
                                        departamento = j.nombreDepartamento,
                                        genero = m.nombreGenero,
                                        confirmados = e.confirmados,
                                        recuperados = e.recuperados,
                                        fallecidos = e.fallecidos

                                    }).ToList();
            ViewData["listadoDeCasos"] = listadoDeCasos;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("departamentoId, generoId," +
            " confirmados, recuperados, fallecidos")]casos_reportados nuevoCaso)
        {
            _covidDbContext.Add(nuevoCaso);
            _covidDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
