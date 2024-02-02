using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyFirstProject.Controllers
{
    [Route("api/[controller]")]
    public class NumberMachineController : Controller
    {
        // GET: api/NumberMachine
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Create a method which has an input {id}, and applies four mathematical operations to it.
        /// </summary>
        /// <param name="id">Passed Param for 4 operation on same param</param>
        /// <returns>Applying all mathematical operation on that param</returns>
        /// <example>
        ///     GET : /api//NumberMachine/10    ->
        ///     Addition: 20
        ///     Substract: 0
        ///     Multiply: 100
        ///     Division: 1
        /// </example>
        [HttpGet("{id}")]
        public string Get(int id)
        {
            // Addition Operation
            int add = id + id;
            string addStr = $"Addition: {add} \n";

            // Subtraction Operation
            int minus = id - id;
            addStr = addStr + $"Substract: {minus} \n";

            // Multiply
            int multiply = id * id;
            addStr = addStr + $"Multiply: {multiply} \n";

            // Division
            if (id != 0)
            {
                double divide = (double)id / id;
                addStr = addStr + $"Division: {divide} \n";
            }
            else
            {
                addStr = addStr + "Cannot perform division by zero.\n";
            }
            return addStr;
        }
    }
}

