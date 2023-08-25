using Blog.Application.DTOs;
using Blog.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Blog.Web.Extensions
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception is BusinessException businessException)
            {
                var errDto = new ErrorResult((int)businessException.ErrCode, businessException.ErrMsg);
                if (context.ActionDescriptor is ControllerActionDescriptor actionDescriptor)
                {
                    var controllerName = actionDescriptor.ControllerName;
                    var actionName = actionDescriptor.ActionName;

                    // Store error message in TempData
                    context.HttpContext.Items[nameof(ErrorResult)] = errDto;

                    context.Result = new RedirectToActionResult(actionName, controllerName, null);
                }
                context.ExceptionHandled = true;
            }
        }
    }
}
