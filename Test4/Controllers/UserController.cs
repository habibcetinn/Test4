using BLL;
using Microsoft.AspNetCore.Mvc;

namespace Test4.Controllers
{
    public class UserController : Controller
    {
        UserService _userService;
        public UserController(UserService userService)
        {
                _userService = userService;
        }
        public IActionResult Index()
        {
            var result=_userService.GetAll();
            return View(result);
        }
        public IActionResult Detail()
        {
            var result = _userService.GetAll();
            return View(result);
        }
    }
}
