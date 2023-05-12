using System.Diagnostics.CodeAnalysis;
using Blog.Blazor.ViewModels;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Components;

namespace Blog.Blazor.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (model.Username.Equals("admin") && model.Password.Equals("123456"))
            {
                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                identity.AddClaim(new Claim(ClaimTypes.Name, "admin"));
                await HttpContext.SignInAsync(new ClaimsPrincipal(identity), new AuthenticationProperties() { IsPersistent = true, ExpiresUtc = DateTimeOffset.Now.AddMinutes(30) });
                return Ok();
            }
            return BadRequest();
        }

       
    }

    public class AjaxOption
    {
        /// <summary>获取/设置 要上传的参数类</summary>
        public object? Data { [return: NotNull] get; set; }

        /// <summary>获取/设置 传输方式，默认为POST</summary>
        public string Method { get; set; } = "POST";

        /// <summary>获取/设置 请求的URL</summary>
        public string? Url { [return: NotNull] get; set; }
    }
}
