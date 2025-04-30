using EPiServer.Cms.TinyMce;
using EPiServer.Cms.TinyMce.Core;

namespace Web.Business
{
    public static class TinyMceConfigurationExtensions
    {
        public static IServiceCollection AddTinyMceConfiguration(this IServiceCollection services)
        {
            services.AddTinyMce();
            services.Configure<TinyMceConfiguration>(config =>
            {
                var defaultConfig = config.Default()
                       .DisableValidation(true);
                var defaultToolbar = defaultConfig.GetValueOrDefault("toolbar") as string[];
                var defaultPlugin = defaultConfig.GetValueOrDefault("plugins") as string[];

                // to allow inserting spans by editor
                defaultConfig.AddSetting("extended_valid_elements", "span[class|id|style]");

                if (defaultToolbar != null && defaultPlugin != null && defaultToolbar.Length > 0)
                {
                    // If nothing specified, at least add source code view
                    defaultPlugin = defaultPlugin.Append("code").ToArray();
                    defaultToolbar[^1] += " | code";
                    defaultConfig.AddPlugin(defaultPlugin).Toolbar(defaultToolbar);
                }
            });

            return services;
        }
    }
}
