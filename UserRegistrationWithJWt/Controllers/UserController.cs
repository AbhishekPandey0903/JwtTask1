using Microsoft.AspNetCore.Mvc;
using UserRegistrationWithJWt.Models;

namespace UserRegistrationWithJWt.Controllers
{ 
    public class UserController : Controller
    {
        private readonly UserContext dbcontext = null;
        public UserController(UserContext _dbContxet)
        {
            dbcontext = _dbContxet;
        }
        public  IActionResult Index()
        {
            return View(dbcontext.JwTtable.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(UserModel usr)
        {
            dbcontext.JwTtable.Add(usr);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return RedirectToAction("Index");
            }
            return View(dbcontext.JwTtable.Find(id));
            
        }
        [HttpPost]
        public IActionResult Edit(UserModel usr)
        {
            dbcontext.JwTtable.Update(usr);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public  IActionResult  Delete(UserModel d)
        {
            dbcontext.JwTtable.Remove(d);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

