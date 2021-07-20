using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIVersioningInASPNetCore.Controllers.v2
{
    [ApiVersion("2.0")]
    [Route("api/[controller]")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "data from api v2";
        }
    }
}
