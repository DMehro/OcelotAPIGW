using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CatalogAPI.Services.Controllers
{
    [Route("api/[controller]")]
    public class CatalogController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Google Pixel", "Apple iPhone", "OnePlus Nord","Moto razor" };
        }
    }
}
