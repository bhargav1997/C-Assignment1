using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstProject.Controllers
{
    [Route("api/[controller]")]
    public class HostingCost : Controller
    {

        /// <summary>
        ///    Get Calculated Cost per fortnight, with HST
        /// </summary>
        /// <param name="id">Passes fortnight days</param>
        /// <returns>
        /// Calculate Cost per fortnight
        /// </returns>
        ///  <example>
        ///     GET : api/HostingCost/14     ->
        ///     "Cost per Fortnight: $5.50","HST (13%): $0.72  - Included","Total Hosting Cost: $6.21"
        /// </example>
        [HttpGet("{id}")]
        public ActionResult<string[]> Get(int id)
        {
            // Calculate hosting cost
            double hostingCost = calculateHostingCost(id);

            // Calculate HST Rate
            double hstRate = calculateHST(hostingCost);

            // Add HST to the total cost
            double totalCostWithHST = hostingCost + hstRate;

            // Format output strings
            string[] output = GenerateOutput(totalCostWithHST, hstRate);

            // Return the result
            return output;
        }

        // Function to calculate HST based on the given amount and HST rate
        public double calculateHST(double amount)
        {
            double hstRate = 0.13;

            return amount * hstRate;
        }

        // Function to calculate hosting cost
        private double calculateHostingCost(int days)
        {
            // Constants for pricing
            double costPerFortnight = 5.50;

            // Calculate total cost without HST
            double totalCost = costPerFortnight * Math.Ceiling((double)days / 14);

            return totalCost;
        }

        // Function to format output strings
        private string[] GenerateOutput(double hostingCost, double hstRate)
        {
            // Format strings as per requirements
            string costPerFortnightString = $"Cost per Fortnight: $5.50";
            string hstString = $"HST (13%): ${String.Format("{0:N2}", hstRate)}  - Included";
            string totalCostString = $"Total Hosting Cost: ${hostingCost:F2}";

            return new string[] { costPerFortnightString, hstString, totalCostString };
        }
    }
}

