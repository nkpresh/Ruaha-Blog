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
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace RuahaBlog.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IBlogPostRepository _blogPostRepository;
        private readonly IWebHostEnvironment hostEnvironment;
        private readonly AppDbContext context;
        private readonly UserManager<IdentityUser> userManager;

        public HomeController(IBlogPostRepository blogPostRepository,
            IWebHostEnvironment hostEnvironment,AppDbContext context,
            UserManager<IdentityUser> userManager)
        {
            _blogPostRepository = blogPostRepository;
            this.hostEnvironment = hostEnvironment;
            this.context = context;
            this.userManager = userManager;
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
            else
            {

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
                    Name=User.Identity.Name,
                    category = model.category,
                    WriteUp = model.WriteUp,
                    Visible = model.Visible,
                    Headline = model.Title,
                    PhotoPaths = uniqueFileName,
                    PostTime=DateTime.Now,
                };
                _blogPostRepository.Creat(blogPost);
                return RedirectToAction("index", new { id = blogPost.Id });
            }
            return View();
        }
        [HttpGet][HttpPost]
        public IActionResult blogLikes(int Id)
        {
            var Member = context.Users.FirstOrDefault(x => x.UserName == User.Identity.Name);
            LikePostViewModel likePostView = new LikePostViewModel();
            if (User.Identity.IsAuthenticated)
            {
                
                var Username = User.Identity.Name;
                BlogLikes likes = new BlogLikes
                {
                    BlogId =Id,
                    UserId = Member.Id,
                    LikedDate = DateTime.UtcNow,
                    Liked = true,
                };
                _blogPostRepository.CreateLikes(likes);
            }

            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public string UnlikeThis(int Id)
        {
            BogPost bogPost = context.BlogPosts.FirstOrDefault(x => x.Id == Id);
            if (User.Identity.IsAuthenticated)
            {
                var Username = User.Identity.Name;
                var Member = context.Users.FirstOrDefault(x => x.UserName == User.Identity.Name);
                BlogLikes like = context.BlogLikes.FirstOrDefault(z => z.Id == Id && z.UserId==Member.Id);
                context.BlogLikes.Remove(like);
                context.SaveChanges();
            }
            return context.BlogLikes.Count().ToString();
        }
        public ViewResult Details(int Id)
        {
            var blogPost = _blogPostRepository.GetBlogPost(Id);
            if (blogPost == null)
            {
                return View("Page Not Found", Id);
            }

            DetailsViewModel detailsViewModel = new DetailsViewModel()
            {
                BlogPost = blogPost,
                PageTitle = "Details"
            };
            return View(detailsViewModel);

        }
    }
}
