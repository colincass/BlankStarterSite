using EPiServer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Models.Blocks;
using Web.Models.Pages.Base;

namespace Web.Models.Pages
{
    [ContentType(DisplayName = "Http Status Code Page", GUID = "4ff9765b-c4d0-4a43-8e84-d0d9de0bb39f")]
    public class HttpStatusCodePage : SitePageData
    {
        public virtual RichTextBlock? Content { get; set; }
    }
}
