using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Web.Models.Pages.StartPage;

namespace Web.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        public IActionResult Index(StartPage currentContent)
        {
            return View(currentContent);
        }
    }
}
