using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreSignalRDemo.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

}
