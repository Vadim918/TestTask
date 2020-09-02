using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestTask.Core.Entities;
using TestTask.Core.Repositories;
using TestTaskBus1.BL;
using TestTaskBus1.Models.ViewModels;

namespace TestTaskBus1.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _uow;

        public HomeController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        [Route("")]
        public async Task<IActionResult> Index()
        {
            var model = await _uow.MainRepository.List();

            return View(model);
        }

        [HttpGet("[controller]/[action]/{id:guid}")]
        public async Task<IActionResult> EditUrl(Guid id)
        {
            var entity = await _uow.MainRepository.FindById(id);
            if (entity == null) return NotFound();

            var model = new UrlEditModel
            {
                LongUrl = entity.LongUrl,
                Date = entity.Date
            };

            return View(model);
        }

        [HttpPost("[controller]/[action]/{id:guid}")]
        public async Task<IActionResult> EditUrl(UrlEditModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var entity = await _uow.MainRepository.FindById(model.Id);
            if (entity == null) return NotFound();
            entity.LongUrl = model.LongUrl;
            entity.Date = model.Date;

            _uow.Commit();
            return RedirectToAction("Index");
        }


        [HttpGet("[controller]/[action]")]
        public IActionResult Add()
        {
            var model = new UrlAddModel();

            return View(model);
        }

        [HttpPost("[controller]/[action]")]
        public IActionResult Add(UrlAddModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var shortUrl = TokenGenerator.GenerateShortUrl();

            var entity = new Main
            {
                Id = Guid.NewGuid(),
                LongUrl = model.LongUrl,
                EditableUrl = shortUrl,
                Date = DateTime.Now
            };

            _uow.MainRepository.Add(entity);
            _uow.Commit();
            return RedirectToAction("Index");
        }

        [HttpGet("{id}")]
        [HttpGet("[controller]/[action]/{id}")]
        public async Task<IActionResult> CountUrl(string id)
        {
            var entity = await _uow.MainRepository.FindByUrl(id);
            if (entity == null) return NotFound();

            _uow.MainRepository.Count(entity);
            _uow.Commit();

            return Redirect(entity.LongUrl);
        }

        [HttpPost("[controller]/[action]")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var entity = await _uow.MainRepository.FindById(id);
            if (entity == null) return NotFound();

            _uow.MainRepository.Remove(entity);
            _uow.Commit();

            return RedirectToAction("Index");
        }
    }
}