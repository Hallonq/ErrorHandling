using Microsoft.AspNetCore.Mvc;

namespace ErrorHandling.Web.Controllers;

public class ErrorController : Controller
{
    [HttpGet("error/server")]
    public IActionResult ServerError()
    {
        return View();
    }

    [HttpGet("error/http/{code}")]
    public IActionResult HttpError(int code)
    {
        return View(code);
    }
}
