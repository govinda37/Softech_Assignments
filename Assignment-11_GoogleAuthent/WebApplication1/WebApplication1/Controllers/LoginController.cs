using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GoogleAuthentication.Services;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> GoogleLoginCallback(string code) 
        {
            var clientId = "632718712016-h63qjdikufc3gifiefd309q8gertgd78.apps.googleusercontent.com";
            var url = "https://localhost:7212/Login/GoogleLoginCallback";
            var clientsecret = "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";
            var token=await GoogleAuth.GetAuthAccessToken(code,clientId,url,clientsecret);
            var userProfile = await GoogleAuth.GetProfileResponseAsync(token.AccessToken.ToString());

            return View();  
        }
       
    }
}
