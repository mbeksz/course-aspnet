using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class CourseController : Controller{
        public IActionResult Index(){
            var model =Repository.Applications;
            return View(model);
            
        }
        public IActionResult Apply(){
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Apply(Candidate model){
            if(Repository.Applications.Any(c => c.Email == model.Email)){
                ModelState.AddModelError("Email", "This email address has already applied");
            }

            if(ModelState.IsValid){
                Repository.AddApplication(model);
                return View("Feedback", model);
            }
            else{
                return View();
            }
    
        }
    }
}