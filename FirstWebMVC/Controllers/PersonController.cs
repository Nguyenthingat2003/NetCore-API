using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class PersonController : Controllers
    {
        public IActionReult Index ()
        { 
            return View();
            
        }
    }
}