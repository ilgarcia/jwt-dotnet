using Microsoft.AspNetCore.Mvc;

namespace auth.Controllers
{
  [Route(template: "")]
  [ApiController]
  public class AuthController : Controller
  {
    [HttpGet]
    public IActionResult Hello()
    {
      return Ok("success");
    }
  }
}