using Microsoft.AspNetCore.Mvc;

namespace MVCFirstApp.Controllers
{
    [Route("test")]
    public class EmployeeController : Controller
    {
        [Route("Eswar")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
