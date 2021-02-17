using Microsoft.AspNetCore.Mvc;
namespace RazerFun
{
    public class RazerController : Controller
    {
        [HttpGet("")]
        public ViewResult Razer()
        {
            return View();
        }
    }
}