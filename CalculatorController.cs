using CalculatorWebApp.DataAccess;
using CalculatorWebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApp
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : Controller
    {
        CalculatorDataAccessLayer objCalculator = new CalculatorDataAccessLayer();

        [HttpPost]
        [Route("api/Calculator/Create")]
        public void Create([FromBody] Calculator calculator)
        {
            objCalculator.AddCalculator(calculator);
        }
    }
}
