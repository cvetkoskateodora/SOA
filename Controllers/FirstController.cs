using Microsoft.AspNetCore.Mvc;

namespace ProjectSOA.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

[ApiController]
[Route("[controller]")]
public class  FirstController : Controller
{
    [HttpGet]
    public ActionResult<string> Get()
    {
        return "Helo, World!";
    }
}