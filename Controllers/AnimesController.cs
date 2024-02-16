using AnimeList_AspNetCore_EF.Models.Animes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationMvcEfCore.Core.Persistence;

namespace AnimeList_AspNetCore_EF.Controllers
{
    public class AnimesController : Controller
    {
        private readonly AppDbContext _dbContext;

        public AnimesController()
        {
            _dbContext = new AppDbContext();
        }

        public ActionResult List()
        {
            var animes = _dbContext.Animes.ToList();
            var model = new AnimesListViewModel(animes);
            return View(model);
        }

        // GET: AnimesController/Details/5
        public ActionResult Detail(int id)
        {
            return View();
        }

        // GET: AnimesController/Create
        public ActionResult Add()
        {
            var model = new AnimesAddViewModel();
            return View(model);
        }

        // POST: AnimesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(AnimesAddViewModel model)
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

        // GET: AnimesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AnimesController/Edit/5
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

        // GET: AnimesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AnimesController/Delete/5
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
