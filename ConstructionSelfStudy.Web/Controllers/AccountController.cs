using Microsoft.AspNetCore.Mvc;

namespace ConstructionSelfStudy.Web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
