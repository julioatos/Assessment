using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controllers
{
    public class CalculadoraController : Controller
    {
        [HttpGet("calculadora/suma/{a:int}/{b:int}", Name = "suma")]
        public IActionResult suma(int a, int b)
        {
            
            var result = a + b;
            return Ok(result);
        }

        [HttpGet("calculadora/resta/{a:int}/{b:int}", Name = "resta")]
        public IActionResult resta(int a, int b)
        {
            var result = a - b;

            return Ok(result);
        }

        [HttpGet("calculadora/mult/{a:int}/{b:int}", Name = "mult")]

        public IActionResult mult(int a, int b)
        {
            var result = a * b;

            return Ok(result);
        }

        [HttpGet("calculadora/div/{a:int}/{b:int}", Name = "div")]

        public IActionResult div(int a, int b)
        {
            if(b == 0)
            {
                return BadRequest("El operando b no puede ser igual a 0.");
            }
            var result = a/ b;

            return Ok(result);
        }

    }
}
