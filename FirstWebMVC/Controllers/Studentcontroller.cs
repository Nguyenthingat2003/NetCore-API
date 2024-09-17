using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace FirstWebMVC.Controllers
{
    public class StudentController : Controller
    { 
        // GET: /Student/
        public IActionResult Index()
        {
            return View ();

             public IActionResult Demo()
             return View ();
        } 
        // GET: /Student/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
