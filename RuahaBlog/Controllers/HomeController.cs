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
using Newtonsoft.Json;

namespace RuahaBlog.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IBlogPostRepository _blogPostRepository;
        private readonly IWebHostEnvironment hostEnvironment;
        private readonly AppDbContext context;
        private readonly UserManager<IdentityUser> userManager;
        private readonly ILikeRepository _likePostRepository;

        public HomeController(IBlogPostRepository blogPostRepository,
            IWebHostEnvironment hostEnvironment, AppDbContext context,
            UserManager<IdentityUser> userManager, ILikeRepository LikePostRepository)
        {
            _blogPostRepository = blogPostRepository;
            this.hostEnvironment = hostEnvironment;
            this.context = context;
            this.userManager = userManager;
            _likePostRepository = LikePostRepository;
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
                var fileStream = new FileStream(filePath, FileMode.Create);
                model.Photo.CopyTo(fileStream);
                fileStream.Close();
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
                    Name = User.Identity.Name,
                    Category = model.category,
                    WriteUp = model.WriteUp,
                    Visible = model.Visible,
                    Headline = model.Title,
                    PhotoPaths = uniqueFileName,
                    PostTime = DateTime.Now,
                };
                _blogPostRepository.Creat(blogPost);
                return RedirectToAction("index", new { id = blogPost.Id });
            }
            return View();
        }
        [HttpGet]
        [HttpPost]
        public IActionResult BlogLikes(int Id)
        {
            var Member = context.Users.FirstOrDefault(x => x.UserName == User.Identity.Name);
            LikePostViewModel likePostView = new LikePostViewModel();
            if (User.Identity.IsAuthenticated)
            {
                var Username = User.Identity.Name;
                BlogLikes likes = new BlogLikes
                {
                    BlogId = Id,
                    UserId = Member.Id,
                    Liked = true,

                };
                if (context.BlogLikes.Count()==0)
                {
                    _likePostRepository.CreateLikes(likes);
                }
                else
                {
                    BlogLikes postLike = context.BlogLikes.Find(likes.BlogId);
                    if (context.BlogLikes.Contains(postLike))
                    {
                        if (postLike.UserId == likes.UserId)
                        {

                            _likePostRepository.RemoveLike(postLike);
                        }
                        else
                        {
                            _likePostRepository.CreateLikes(likes);
                        }
                    }
                    else
                    {
                        _likePostRepository.CreateLikes(likes);
                    }
                }
            }
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        [HttpPost]
        public IActionResult UnlikeThis(int BlogId)
        {


            //if (User.Identity.IsAuthenticated)
            //{
            //    var Username = User.Identity.Name;
            //    var Member = context.Users.FirstOrDefault(x => x.UserName == User.Identity.Name);
            //    BlogLikes like = context.BlogLikes.FirstOrDefault(z => z.Id == Id && z.UserId==Member.Id);
            //    context.BlogLikes.Remove(like);
            //    context.SaveChanges();
            //}
            return RedirectToAction("Index", "Home");
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
