using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;

namespace Web.Business.Rendering;

[ServiceConfiguration(typeof(IViewTemplateModelRegistrator))]
public class TemplateCoordinator : IViewTemplateModelRegistrator
{
    public const string BlockFolder = "~/Views/Shared/Blocks/";
    public const string PagePartialsFolder = "~/Views/Shared/PagePartials/";

    public static void OnTemplateResolved(object sender, TemplateResolverEventArgs args)
    {

    }

    /// <summary>
    /// Registers renderers/templates which are not automatically discovered,
    /// i.e. partial views whose names does not match a content type's name.
    /// </summary>
    /// <remarks>
    /// Using only partial views instead of controllers for blocks and page partials
    /// has performance benefits as they will only require calls to RenderPartial instead of
    /// RenderAction for controllers.
    /// Registering partial views as templates this way also enables specifying tags and
    /// that a template supports all types inheriting from the content type/model type.
    /// </remarks>
    public void Register(TemplateModelCollection viewTemplateModelRegistrator)
    {

    }

    private static string BlockPath(string fileName) => $"{BlockFolder}{fileName}";

    private static string PagePartialPath(string fileName) => $"{PagePartialsFolder}{fileName}";
}
