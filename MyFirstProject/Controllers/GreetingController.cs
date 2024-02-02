using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyFirstProject.Controllers
{
    [Route("api/[controller]")]
    public class GreetingController : Controller
    {
        // <summary>Returns the string  "Hello World!"</summary>
        /// <returns>It Returns "Hello World!" </returns>
        /// <example>
        ///     POST : /api/greeting      ->     "Hello World!" 
        /// </example>
        [HttpPost]
        public IEnumerable<string> Get()
        {
            return new string[] { "Hello, World!" };
        }

        // <summary>Returns the string “Greetings to {id} people!” where id is an integer value.</summary>
        /// <param name="id">Passed Param for Adding into greeting message</param>
        /// <returns>It Returns “Greetings to {id} people!”</returns>
        /// <example>
        ///     POST : /api/greeting/4      ->     Greetings to 4 people! 
        /// </example>
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "Greetings to " + id + " people!";
        }
    }
}

