using Demo_Product.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Product.Controllers
{
    
   public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        
        public async Task<IActionResult> Index(UserRegisterViewModel model)
        {
            AppUser appUser = new AppUser()
            {
                Name = model.Name,
                SurName = model.SurName,
                Gender = model.Gender,
                Email = model.Email,
                UserName = model.UserName,
                
                
            };

            if (model.Password == model.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(appUser, model.Password);

                if (result.Succeeded)
                {
                    // Kullanıcı başarıyla oluşturuldu
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    // ❗ Hataları logla ve ekrana bas
                    foreach (var error in result.Errors)
                    {
                        
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "Şifreler uyuşmuyor.");
            }

            return View(model);
        }
    }
}
