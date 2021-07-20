using ContractManagement.Application.ApplicationServices.Auth;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ContractManagement.Areas.Admin.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthApplicationService authApplicationService;

        public AuthController(IAuthApplicationService authApplicationService)
        {
            this.authApplicationService = authApplicationService;
        }

        public async Task<IActionResult> Login()
        {
            var result = await this.authApplicationService.SignIn("admin", "admin");

            if (result == true)
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }

            return View();
        }

        public async Task<IActionResult> Logout()
        {
            var result = await this.authApplicationService.SignOut();

            if (result == true)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
    }
}
