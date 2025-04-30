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

        [Display(Name = "404 Page", Order = 10, GroupName = "Site Settings")]
        public virtual ContentReference? NotFoundPage { get; set; }

        [Display(Name = "500 Page", Order = 10, GroupName = "Site Settings")]
        public virtual ContentReference? ErrorPage { get; set; }
    }
}
