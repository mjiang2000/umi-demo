using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Web.Resource;
using Microsoft.Identity.Web;
using Newtonsoft.Json;
using System;

namespace DemoAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        public HomeController()
        {
        }

        // GET: api/TestApi
        [HttpGet]
        [Route("TestApi")]
        [Authorize(Policy = "RequirRole")]
        public ActionResult TestApi()
        {
            try
            {
                return new OkObjectResult(JsonConvert.SerializeObject(this.HttpContext.User.Claims.Select(e => new { Type = e.Type, Value = e.Value }), Formatting.Indented));
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }
    }
}
