using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using Web.Models.Pages.Base;

namespace Web.Models.Pages.StartPage
{
    [ContentType(DisplayName = "Start Page",
        GUID = "dbb32b88-59b0-4538-accf-b41c772fc339")]
    public class StartPage : SitePageData
    {
        [Display(Name = "Main Content", Order = 10, GroupName = SystemTabNames.Content)]
        public virtual ContentArea? MainContent { get; set; }
    }
}
