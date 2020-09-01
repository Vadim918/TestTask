using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestTask.Core.Repositories;
using TestTaskBus1.Models.ViewModels;

namespace TestTaskBus1.Controllers
{
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

        [HttpPost("[controller]/[action]")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var entity = await _uow.MainRepository.Find(id);
            if (entity == null) return NotFound();

            _uow.MainRepository.Remove(entity);
            _uow.Commit();

            return RedirectToAction("Index");
        }

        [HttpGet("[controller]/[action]")]
        public IActionResult Add()
        {
            var model = new UrlEditModel();

            return View(model);
        }


        [HttpPost("[controller]/[action]")]
        public async Task<IActionResult> CountUrl(Guid id)
        {
            var entity = await _uow.MainRepository.Find(id);
            if (entity == null) return NotFound();

            _uow.MainRepository.Count(entity);
            _uow.Commit();

            return Redirect(entity.EditableUrl);
        }
    }
}