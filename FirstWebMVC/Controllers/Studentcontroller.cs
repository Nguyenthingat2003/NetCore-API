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
        } 
        // GET: /Student/Welcome/ 
    }
}