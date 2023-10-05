using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementApp.Controllers
{
    public class LibraryHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult About()
        {
            return View();
        }
    }

        
    
}
