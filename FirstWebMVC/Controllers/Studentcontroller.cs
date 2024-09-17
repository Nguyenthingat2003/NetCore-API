using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace FirstWebMVC.Controllers
{
    public class Stdentcontroller : Controller
    { 
        // GET: /Student/
        public IActionResult Demo()
        {
            return View ();
        } 
        // GET: /Student/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
