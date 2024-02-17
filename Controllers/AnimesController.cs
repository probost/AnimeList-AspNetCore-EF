using AnimeList_AspNetCore_EF.Core.Entities;
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

        // post: animescontroller/create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(AnimesAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var anime = new Anime();
            anime.Title = model.Title;
            anime.Type = model.Type;
            anime.Episodes = model.Episodes;
            anime.WatchedEpisodes = model.WatchedEpisodes;
            anime.StartDate = model.StartDate;
            anime.FinishDate = model.FinishDate;
            anime.Score = model.Score;
            anime.WatchingStatus    = model.WatchingStatus;

            _dbContext.Animes.Add(anime);
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(List));
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
