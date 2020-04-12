using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EPM.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EPM.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : Controller
    {
        
        

        public EmployeesController()
        {
        }

        [HttpGet]
        public IEnumerable<dynamic> Get()
        {
            var rng = new Random();
            var service  = new EmployeeService();
            // return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            // {
            //     Date = DateTime.Now.AddDays(index),
            //     TemperatureC = rng.Next(-20, 55),
            //     Summary = Summaries[rng.Next(Summaries.Length)]
            // })
            // .ToArray();
            return service.getEmployees();
        }
    }
}
