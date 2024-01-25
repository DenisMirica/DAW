using Microsoft.AspNetCore.Mvc;
using DAW.Data;
using DAW.Models;
using DAW.Services;  
using DAW.Services.EvenimentService;
namespace DAW.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class EvenimentController : Controller
    {
        private readonly IEvenimentService _evenimentservice;
        public EvenimentController(IEvenimentService evenimentservice)
        {
            _evenimentservice = evenimentservice;
        }

        [HttpGet]
        public async Task<ActionResult<Eveniment>> GetEveniment(int id)
        {
            var eveniment = await _evenimentservice.ObtineEveniment(id);
            if (eveniment == null)
            {
                return NotFound();
            }
            return Ok(eveniment);


        }
        [HttpPost]
        public async Task<IActionResult> AdaugaEveniment(Eveniment e)
        {
            await _evenimentservice.AdaugaEveniment(e);
            return Ok();
        }

    }
}
