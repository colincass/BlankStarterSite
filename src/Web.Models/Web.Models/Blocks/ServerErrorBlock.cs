using EPiServer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Models.Blocks.Base;

namespace Web.Models.Blocks
{
    [ContentType(DisplayName = "Error Simulation Block", GUID = "6cb6ba04-d8fd-4ab8-aa82-e66790a849cf")]
    public class ServerErrorBlock : SiteBlockData
    {
    }
}
