
using Conductor.Data;
using Conductor.Models;
using Microsoft.AspNetCore.Mvc;

namespace Conductor.Controllers
{
    public class PaymentController : Controller
    {
        private readonly AppDataContext _context;

        public PaymentController(AppDataContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("v1/payments")]
        public IActionResult Post([FromBody]Payment payment)
        {
            _context.Payments.Add(payment);
            _context.SaveChanges();
            return Ok(new { message = "Deu tudo certo my friend!" });
        }

        [HttpGet]
        [Route("v1/payments")]
        public IActionResult Get()
        {
            return Ok(_context.Payments);
        }
    }
}