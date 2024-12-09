using EmirhanIdentityApp.Web.Areas.Admin.Models;
using EmirhanIdentityApp.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using EmirhanIdentityApp.Web.Extensions;

namespace EmirhanIdentityApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RolesController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;


        public RolesController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RoleCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RoleCreate(RoleCreateViewModel request)
        {
            var result = await _roleManager.CreateAsync(new AppRole() { Name = request.Name });

            if(!result.Succeeded)
            {
                ModelState.AddModelErrorList(result.Errors);
                return View();
            }

            return RedirectToAction(nameof(RolesController.Index));
        }
    }
}
