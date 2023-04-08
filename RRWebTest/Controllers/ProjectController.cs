using Microsoft.AspNetCore.Mvc;
using RRWebTest.Models;

namespace RRWebTest.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            ProjectViewModel projectVm = new ProjectViewModel()
            {
                ProjectName = "Holiday Inn Buffalo",
                ProjectAddress = "Address 1",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(20)
            };
            return View(projectVm);
        }

        public IActionResult CreateItem(ProjectViewModel projectViewModel)
        {
            return View("Index");
        }

    }
}
