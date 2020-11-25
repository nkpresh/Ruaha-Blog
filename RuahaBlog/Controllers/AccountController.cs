using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RuahaBlog.Models;
using RuahaBlog.ViewModels;

namespace RuahaBlog.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<CustomisedUser> userManager;
        private readonly SignInManager<CustomisedUser> signIn;
        private readonly IWebHostEnvironment webHostEnvironment;

        public AccountController(UserManager<CustomisedUser> userManager,
            SignInManager<CustomisedUser> signIn,IWebHostEnvironment webHostEnvironment)
        {
            this.userManager = userManager;
            this.signIn = signIn;
            this.webHostEnvironment = webHostEnvironment;
        }
        private string ProcessUploadedFile(RegisterViewModel model)
        {
            string uniqueFileName;
            if (model.Photo != null)
            {
                string UploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                string filePath = Path.Combine(UploadsFolder, uniqueFileName);
                var fileStream = new FileStream(filePath, FileMode.Create);
                model.Photo.CopyTo(fileStream);
                fileStream.Close();
            }
            else
            {
                uniqueFileName = "~/images/profile.png";
            }
            return uniqueFileName;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model )
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = ProcessUploadedFile(model);
                var user = new CustomisedUser()
                {
                    UserName=model.Name,
                    Email=model.Email,
                    ProfilePicture=uniqueFileName,
                };
                var result= await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await signIn.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("index", "home");
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var result = await signIn.PasswordSignInAsync(model.UserName, model.Password, isPersistent: false, true);
                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnUrl))
                    {
                        return LocalRedirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "home");
                    }
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signIn.SignOutAsync();
            return RedirectToAction("index", "home");
        }
    }
}
