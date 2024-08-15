using Examination.BLL.Services;
using Examination.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Examination.Web.Controllers
{
    public class UsersController : Controller
    {
        private IAccountService _authService;

        public UsersController(IAccountService authService)
        {
            _authService = authService;
        }

        [HttpGet]
        public IActionResult Index(int pageNumber = 1, int pageSize = 10)
        {
            return View(_authService.GetAllTeacher(pageNumber, pageSize));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(UserViewModel vm)
        {
            if (ModelState.IsValid)
            {
                _authService.AddTeacher(vm);
                return RedirectToAction("Index");
            }
            return View();
        }
    }

}