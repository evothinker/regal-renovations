using Microsoft.AspNetCore.Mvc;
using RRWebTest.Models;

namespace RRWebTest.Controllers
{
    public class ItemController : Controller
    {
        private static List<ItemViewModel> _items = new List<ItemViewModel>();
        public IActionResult Index()
        {

            return View(_items);

        }

        public IActionResult Create()
        {
            var itemVm = new ItemViewModel();
            return View(itemVm);
        }
        public IActionResult CreateItem(ItemViewModel itemViewModel)
        {
            _items.Add(itemViewModel);
            return RedirectToAction(nameof(Index));
           // return View("Index");
        }

        public string ReturnItem()
        {
            return "Item Info";
        }
    }
}
