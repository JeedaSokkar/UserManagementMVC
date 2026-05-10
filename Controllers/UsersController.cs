using Microsoft.AspNetCore.Mvc;
using MvcUsersProject.Data;
using MvcUsersProject.Models;

namespace MvcUsersProject.Controllers
{
    public class UsersController : Controller
    {
        ApplictionDbContext context= new ApplictionDbContext();
        public ViewResult Index()
        {
            var user = context.Users.ToList();
            return View("Index",user);
        }
        public ViewResult Create()
        {
            return View("Create");
        }
        public RedirectToActionResult Store(User request)
        {
            context.Users.Add(request);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
