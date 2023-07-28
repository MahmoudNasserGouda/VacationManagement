using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VacationManagement.ViewModels;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _usermanager;
        private readonly SignInManager<IdentityUser> _signinmanager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _usermanager = userManager;
            _signinmanager = signInManager;
        }

        public IActionResult Login()
        {
            return View(new LoginUserVM());
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginUserVM user)
        {
            if (ModelState.IsValid)
            {
                IdentityUser myuser = await _usermanager.FindByNameAsync(user.UserName);

                if (myuser != null)
                {
                    var res = await _signinmanager.CheckPasswordSignInAsync(myuser, user.Password, false);
                    if (res.Succeeded)
                    {
                        await _signinmanager.SignInAsync(myuser, user.IsPersisted);
                        if (User.IsInRole("Admin"))
                        {
                            return RedirectToAction("Index", "Vacation");
                        }
                        else
                        {
                            return RedirectToAction("Create", "Vacation");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("Error:", "Wrong UserName or Passowrd");
                        return View();
                    }
                }
                else
                {
                    ModelState.AddModelError("Error", "Wrong UserName or Passowrd");
                    return View();
                }
            }
            else
            {
                ModelState.AddModelError("Error", "Wrong UserName or Passowrd");
            }

            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await _signinmanager.SignOutAsync();

            return RedirectToAction("Login", "Account");

        }

    }



}
