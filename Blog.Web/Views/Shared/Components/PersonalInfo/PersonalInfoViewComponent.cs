using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Views.Shared.Components.PersonalInfo
{
    public class PersonalInfoViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
