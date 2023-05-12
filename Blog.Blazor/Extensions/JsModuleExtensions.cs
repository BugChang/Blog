using Microsoft.JSInterop;
using System.Reflection;
using Blog.Blazor.Utils;

namespace Blog.Blazor.Extensions
{
    public static class JsModuleExtensions
    {
        static string _tick;
        static string GetVersion()
        {
            _tick ??= DateTime.Now.ToString("HHmmss");
            return _tick;
        }

        /// <summary>
        /// IJSRuntime 扩展方法 动态加载脚本 脚本目录为 modules
        /// </summary>
        /// <param name="jsRuntime"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static async Task<JSModule> LoadModule(this IJSRuntime jsRuntime, string fileName)
        {
            var jSObjectReference = await jsRuntime.InvokeAsync<IJSObjectReference>(identifier: "import", $"{fileName}?v={GetVersion()}");
            return new JSModule(jSObjectReference);
        }

    }
}
