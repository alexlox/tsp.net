using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Proiect3
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : Controller
    {
        [HttpGet]
        public IActionResult Get([FromQuery(Name = "path")] string path)
        {
            var image = System.IO.File.OpenRead(path);
            return File(image, "image/jpeg");
        }
    }
}
