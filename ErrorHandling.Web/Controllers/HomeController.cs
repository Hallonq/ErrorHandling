using ErrorHandling.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace ErrorHandling.Web.Controllers;

public class HomeController : Controller
{
    [HttpGet("")]
    public async Task <IActionResult> IndexAsync()
    {
        var slowService = new SlowService();
        await slowService.DoSlowWorkAsync();
        return View();
    }

    [HttpGet("/throw")]
    public IActionResult Throw()
    {
        //throw new Exception("test");
        return View();
    }
}
