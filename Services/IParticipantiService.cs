using DAW.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAW.Services.ParticipantService
{
    public interface IParticipantiService
    {
        Task AdaugaParticipanti(Participanti participanti);
        Task<Participanti> ObtineParticipanti(int id);
        Task ObtineTotiParticipanti();
    }
}
