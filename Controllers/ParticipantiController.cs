using Microsoft.AspNetCore.Mvc;
using DAW.Models;
using DAW.Services.ParticipantService;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipantiController : Controller
    {
        private readonly IParticipantiService _participantiService;

        public ParticipantiController(IParticipantiService participantiService)
        {
            _participantiService = participantiService;
        }

        public Task<ActionResult<IEnumerable<Participanti>>> GetParticipanti()
        {
            return GetParticipanti(_participantiService);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Participanti>>> GetParticipanti(IParticipantiService _participantiService)
        {
            return Ok(await _participantiService.ObtineTotiParticipanti());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Participanti>> GetParticipanti(int id)
        {
            var participanti = await _participantiService.ObtineParticipanti(id);
            if (participanti == null)
            {
                return NotFound();
            }
            return Ok(participanti);
        }

        [HttpPost]
        public async Task<IActionResult> AdaugaParticipanti(Participanti participant)
        {
            await _participantiService.AdaugaParticipanti(participant);
            return Ok();
        }
    }
}
