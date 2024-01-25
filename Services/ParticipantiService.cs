using DAW.Data;
using DAW.Models;
using DAW.Services.ParticipantService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;


namespace DAW.Services.ParticipantiService
{
    public class ParticipantiService : IParticipantiService
    {   
        private readonly ApplicationDBContext _dbContext;

        public ParticipantiService(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AdaugaParticipanti(Participanti participanti)
        {
            _dbContext.Participanti.Add(participanti);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Participanti> ObtineParticipanti(int id)
        {
            var participanti = await _dbContext.Participanti.FirstOrDefaultAsync(p => p.Id == id);
            if (participanti == null)
            {
                throw new Exception("Participantul nu a fost gasit.");
            }
            return participanti;
        }

        public Task ObtineTotiParticipanti()
        {
            throw new NotImplementedException();
        }
    }
}
