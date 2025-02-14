using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using Web.Models.Blocks.Base;

namespace Web.Models.Blocks
{
    [ContentType(DisplayName = "Rich Text Block", GUID = "718fa277-287a-49f6-8ca3-f53c9d80a2e4")]
    public class RichTextBlock : SiteBlockData
    {
        [Display(Name = "Text", GroupName = SystemTabNames.Content)]
        public virtual XhtmlString? Text { get; set; }
    }
}
