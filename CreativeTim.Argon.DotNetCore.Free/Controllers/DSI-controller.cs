using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CreativeTim.Argon.DotNetCore.Free.Infrastructure;
using CreativeTim.Argon.DotNetCore.Free.Infrastructure.ErrorHandling;
using CreativeTim.Argon.DotNetCore.Free.Models;
using CreativeTim.Argon.DotNetCore.Free.Models.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;

namespace CreativeTim.Argon.DotNetCore.Free.Controllers
{
    public class DSI_controller : Controller
    {
        private readonly List <DSI_data> _myData;
        public IActionResult Index()
        {
            return View();
        }

        public List <DSI_data> getData()
        {

            List <DSI_data> _myData = new List <DSI_data>();
            DSI_data x = new DSI_data();
            x.dp_month = "June";
            x.dp_ordercount = 14;
            _myData.Add(x);

            DSI_data y = new DSI_data();
            y.dp_month = "June";
            y.dp_ordercount = 14;
            _myData.Add(y);

            DSI_data z = new DSI_data();
            z.dp_month = "June";
            z.dp_ordercount = 14;
            _myData.Add(z);

            return View ("myDSIData", _myData); 
        }

        [ImportModelState]
        [HttpGet("/profile")]
        public async Task<IActionResult> Profile()
        {
            //var user = await _userManager.GetUserAsync(User);
            //if (user == null)
            //{
            //    return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            //}

            //return View(new ProfileViewModel
            //{
            //    Username = user.UserName,
            //    Email = user.Email,
            //    FullName = user.FullName
            //});
        }
    }
}
