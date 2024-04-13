using Microsoft.AspNetCore.Mvc;
using ProSync.Application.Services;
using ProSync.Presentation.Models.Project;

namespace ProSync.Presentation.Controllers
{
    public class ProjectController : Controller
    {
        private readonly ProjectService _service;
        public ProjectController(ProjectService _service)
        {
            this._service = _service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        { 
            ProjectVm vm = new ProjectVm();
            return View("Presentation/Views/Project/Crud.cshtml", vm);
        }

        public IActionResult Edit(int projectId)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProjectVm vm)
        {
            try
            {
                //_service.Create(vm);
                ViewBag.Alert = "An error has occurred.";
                ViewBag.AlertType = "alert-danger";
            }
            catch (Exception)
            {
                throw;
            }
            return View("Presentation/Views/Project/Crud.cshtml", vm);
        }

        [HttpPost]
        public IActionResult Edit(ProjectVm vm)
        {
            try
            {
                _service.Update(vm);
            }
            catch (Exception)
            {

                throw;
            }

            return View();
        }

        [HttpPost]
        public IActionResult Delete(int projectId)
        {
            return View();
        }
    }
}
