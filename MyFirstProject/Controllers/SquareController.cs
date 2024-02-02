using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyFirstProject.Controllers
{
    [Route("api/[controller]")]
    public class SquareController : Controller
    {
        // GET: api/square
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Returns the square of the integer input  
        /// </summary>
        /// <param name="id">The number to square</param>
        /// <returns>It Returns the square of the integer input </returns>
        /// <example>
        ///     GET : /api/square/10      ->      100
        /// </example>
        [HttpGet("{id}")]
        public int Get(int id)
        {
            return id * id;
        }
    }
}

