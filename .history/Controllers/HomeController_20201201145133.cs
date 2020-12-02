using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace portTwo.Controllers     //be sure to use your own project's namespace!
{
    public class HomeController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /) local host 5000
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpGet]
        [Route("hello")]
        public ViewResult Contact()
        {
            return View("Contact");

        }

        [HttpGet]
        [Route("hello/goodbye")]
        public ViewResult Projects()
        {
            return ViewResult("Projects")
        }


    }
}