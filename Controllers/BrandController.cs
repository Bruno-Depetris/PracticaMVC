using Microsoft.AspNetCore.Mvc;

namespace PracticaMVC.Controllers {
    public class BrandController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}
