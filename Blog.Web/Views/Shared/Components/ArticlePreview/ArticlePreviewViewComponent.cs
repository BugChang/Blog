using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Views.Shared.Components.ArticlePreview
{
    public class ArticlePreviewViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
