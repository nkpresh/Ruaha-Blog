using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using RuahaBlog.Models;
using RuahaBlog.ViewModels;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace RuahaBlog.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IBlogPostRepository _blogPostRepository;
        private readonly IWebHostEnvironment hostEnvironment;

        public HomeController(IBlogPostRepository blogPostRepository,IWebHostEnvironment hostEnvironment)
        {
            _blogPostRepository = blogPostRepository;
            this.hostEnvironment = hostEnvironment;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            var model = _blogPostRepository.GetAllBlogPost();
            return View(model);
        }
        [HttpGet]
        public IActionResult Creat()
        {
            return View();
        }

        private string ProcessUploadedFile(CreatViewModel model)
        {
            string uniqueFileName = null;
            if (model.Photo != null)
            {
                string UploadsFolder = Path.Combine(hostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                string filePath = Path.Combine(UploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Photo.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }

        [HttpPost]
        public IActionResult Creat(CreatViewModel model)
        {
            string uniqueFileName = ProcessUploadedFile(model);
            if (ModelState.IsValid)
            {
                BogPost blogPost = new BogPost
                {
                    Name = model.Name,
                    category = model.category,
                    WriteUp = model.WriteUp,
                    Visible = model.Visible,
                    Headline = model.Title,
                    PhotoPaths = uniqueFileName,
                };
                _blogPostRepository.Creat(blogPost);
                return RedirectToAction("index", new { id = blogPost.Id });
            }
            return View();
        }
    }
}
