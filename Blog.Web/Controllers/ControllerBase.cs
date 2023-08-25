using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Blog.Web.Controllers
{
    public class ControllerBase:Controller
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {

            if (HttpContext.Items.TryGetValue(nameof(ErrorResult), out var item))
            {
                if (item is ErrorResult errDto)
                {
                    ViewBag.ErrorResult = errDto;
                }
            }
            base.OnActionExecuted(context);
        }
    }
}
