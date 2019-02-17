using Microsoft.AspNetCore.Mvc;
using System;

namespace FJFMarketing.Controllers
{
    public class AdminController : ControllerBase
    {
        [HttpGet("admin/heartbeat")]
        public string Heartbeat()
        {
            //this.logger.LogInformation("Heartbeat requested");
            return DateTime.Now.ToString("yyy-MM-ddTHH:mm:ssK") + "AlvinE";
        }
    }
}
