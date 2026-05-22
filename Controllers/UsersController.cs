using Microsoft.AspNetCore.Mvc;
using MvcUsersProject.Data;
using MvcUsersProject.Models;

namespace MvcUsersProject.Controllers
{
    public class UsersController : Controller
    {
        ApplictionDbContext context= new ApplictionDbContext();

        //GET : Users
        public ViewResult Index()
        {
            var user = context.Users.ToList();
            return View("Index",user);
        }
        //add User 
        public ViewResult Create()
        {
            return View("Create",new User());
        }
        //store user you add
        public IActionResult Store(User request)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", request);
            }
            context.Users.Add(request);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        //details
        public IActionResult Details(int id)
        {
            var user = context.Users.Find(id);
            return View("Details", user);
        }
        //delete
        public IActionResult Delete(int id)
        {
            var user = context.Users.Find(id);
            context.Users.Remove(user);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        //Edit
        public IActionResult Edit(int id)
        {
            var user = context.Users.Find(id);
            return View("Edit", user);
        }
        public IActionResult Update(User request)
        {
            context.Users.Update(request);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
