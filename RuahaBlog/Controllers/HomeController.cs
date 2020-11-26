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

        private readonly UserManager<CustomisedUser> userManager;

        private readonly ILikeRepository _likePostRepository;
        private readonly ICommentRepository _commentRepository;
        public HomeController(IBlogPostRepository blogPostRepository,
            IWebHostEnvironment hostEnvironment, AppDbContext context,
            UserManager<CustomisedUser> userManager, ILikeRepository LikePostRepository,
            ICommentRepository commentRepository)

        {
            _blogPostRepository = blogPostRepository;
            this.hostEnvironment = hostEnvironment;
            this.context = context;
            this.userManager = userManager;
            _likePostRepository = LikePostRepository;
            _commentRepository = commentRepository;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            var model = _blogPostRepository.GetAllBlogPost();
            context.SaveChanges();
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
                    BlogLikes postLike = context.BlogLikes.FirstOrDefault(x => x.UserId == userManager.GetUserId(User));
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
            var like = context.BlogLikes.Where(x => x.BlogId == Id);
            var post = context.BlogPosts.FirstOrDefault(x => x.Id == Id);
            post.NumberOfLikes = like.Count();
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [AllowAnonymous]
        [HttpGet]
        public ViewResult Details(int Id)
        {
            DetailsViewModel Model = new DetailsViewModel()
            {
                
                Post = context.BlogPosts.FirstOrDefault(x=>x.Id==Id),
                Comments = _commentRepository.GetAllComment(Id),
            };
            return View(Model);

        }
        [HttpGet]
        public IActionResult Comment(int Id)
        {
            CommentViewModel commentView = new CommentViewModel()
            {
                PostId =Id,
                GetUser=userManager.Users.FirstOrDefault((x=>x.Id==userManager.GetUserId(User))),
                ListOfComments=_commentRepository.GetAllComment(Id),
            };
            return View(commentView);
        }
        [HttpPost]
        public IActionResult Comment( CommentViewModel model)
        {
            if (ModelState.IsValid)
            {
                var Comment = new BlogComments()
                {
                    UserName = model.UserName,
                    UserId = userManager.GetUserId(User),
                    BlogPostId = model.PostId,
                    Body = model.Comment,
                    TimeOfComment = DateTime.Now,
                    UserPicture=model.ProfilePicture,
                };
                _commentRepository.Comment(Comment);
                _blogPostRepository.GetBlogPost(model.PostId).NumberOfComments = context.BlogComments.Where(x => x.BlogPostId == model.PostId).Count();
                context.SaveChanges();
                return RedirectToAction("Details", new {id=Comment.BlogPostId });

            }
            return View();
        }

        [HttpGet]
        public IActionResult About()
        {
            return View();
        }
    }
}
