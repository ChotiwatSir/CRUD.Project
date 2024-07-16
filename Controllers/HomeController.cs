using Microsoft.AspNetCore.Mvc;

namespace CRUD.Project.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class HomeController : ControllerBase
    {

        [HttpGet]
        public ActionResult GetUser()
        {
            return Ok("ควย");

        }
    }
}