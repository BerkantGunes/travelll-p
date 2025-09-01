using Microsoft.AspNetCore.Mvc;

namespace Traveler.Areas.Member.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
