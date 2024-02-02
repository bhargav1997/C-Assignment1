using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyFirstProject.Controllers
{
    [Route("api/[controller]")]
    public class AddTenController : Controller
    {
        // GET: api/AddTen
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Add Ten Controller (/api/AddTen/5)" };
        }

        /// <summary>
        /// Adds the 10 
        /// </summary>
        /// <param name="id">Passed Param for Adding 10</param>
        /// <returns>Adding 10 numbers in passed param in API</returns>
        /// <example>
        ///     GET : /api/AddTen/10      ->      20
        /// </example>
        [HttpGet("{id}")]
        public int Get(int id)
        {

            return id + 10;
        }
    }
}

