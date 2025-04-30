using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Web.Models.Pages;

namespace Web.Controllers
{
    public class HttpStatusCodePageController : PageController<HttpStatusCodePage>
    {
        public IActionResult Index(HttpStatusCodePage currentContent)
        {
            return View(currentContent);
        }
    }
}
