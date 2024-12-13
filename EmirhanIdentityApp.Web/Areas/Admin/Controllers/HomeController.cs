using EmirhanIdentityApp.Web.Areas.Admin.Models;
using EmirhanIdentityApp.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmirhanIdentityApp.Web.Areas.Admin.Controllers
{


    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class HomeController : Controller
    {

        private readonly UserManager<AppUser> _userManager;

        public HomeController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> UserList(string searchUser)
        {
            
            var users = await _userManager.Users.ToListAsync();

           
            if (!string.IsNullOrEmpty(searchUser))
            {
                users = users
                    .Where(x => x.UserName.Contains(searchUser, StringComparison.OrdinalIgnoreCase) ||
                                x.Email.Contains(searchUser, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

          
            var userViewModelList = users.Select(x => new UserViewModel
            {
                Id = x.Id,
                Email = x.Email,
                Name = x.UserName
            }).ToList();

          
            ViewData["CurrentFilter"] = searchUser;

            if (!userViewModelList.Any())
            {
                ViewData["NoUsersFound"] = "Aradığınız kriterlere uygun kullanıcı bulunamadı.";
            }

            return View(userViewModelList);

        }
    }
}
