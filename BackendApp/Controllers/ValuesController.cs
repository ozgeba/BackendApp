using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BackendApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return string.Format("value={0}",id);
        }

        // GET api/values/GetException
        [HttpGet("GetException")]
        public string GetException()
        {
            throw new Exception("asdsad");
        }

        //POST api/values/Post
        [HttpPost("Post")]
        public string Post([FromBody]int id)
        {
            return string.Format("post value={0}", id);
        }

        //POST api/values/ThrowException
        [HttpPost("ThrowException")]
        public void ThrowException()
        {
            throw new Exception("asdsad");
        }        

    }
}
