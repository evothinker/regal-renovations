using Microsoft.AspNetCore.Mvc;

namespace RRWebTest.Controllers
{
    public class VendorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
