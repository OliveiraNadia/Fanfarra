using System;
using System.Linq;
using System.Threading.Tasks;
using Fanfarra.Domain.Connectors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fanfarra.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RendaFixaController : Controller
    {
        private readonly IRendaFixaConnector _rendaFixaConnnector;

        public RendaFixaController(IRendaFixaConnector rendaFixaConnector)
        {
            _rendaFixaConnnector = rendaFixaConnector;
        }

        // GET: RendaFixaController
        public async Task<IActionResult> ObterCustodia()
        {
            var response = await _rendaFixaConnnector.ObterCustodia();

            return Ok(response.ToList());
        }

        // GET: RendaFixaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RendaFixaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RendaFixaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RendaFixaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RendaFixaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RendaFixaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RendaFixaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
