using Microsoft.AspNetCore.Mvc;

namespace WatchFilm.Controllers
{
    public class UserSettingController : Controller
    {
        public IActionResult ChangeInfor()
        {
            return View();
        }
    }
}
