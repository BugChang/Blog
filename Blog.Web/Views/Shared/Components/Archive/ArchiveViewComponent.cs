using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Views.Shared.Components.Archive
{
    public class ArchiveViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
