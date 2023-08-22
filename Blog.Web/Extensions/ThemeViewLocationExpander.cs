using Microsoft.AspNetCore.Mvc.Razor;

namespace Blog.Web.Extensions
{
    public class ThemeViewLocationExpander : IViewLocationExpander
    {
        private readonly IConfiguration _configuration;

        public ThemeViewLocationExpander(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void PopulateValues(ViewLocationExpanderContext context)
        {
            string theme = _configuration["Theme"];
            context.ActionContext.HttpContext.Items["Theme"] = theme ?? "default";
        }

        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            string theme = _configuration["Theme"];

            // Modify view location formats based on the selected theme
            foreach (var location in viewLocations)
            {
                yield return location.Replace("/Views/", $"/Views/Themes/{theme}/");
                yield return location;
            }
        }
    }
}
