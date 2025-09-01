using Microsoft.AspNetCore.Mvc;

namespace Traveler.Areas.Member.Controllers
{
    [Area("Member")]
    public class InformationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
