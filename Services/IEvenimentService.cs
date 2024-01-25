using DAW.Models;

namespace DAW.Services.EvenimentService
{
    public interface IEvenimentService
    {
        Task AdaugaEveniment(Eveniment e);
        Task<Eveniment> ObtineEveniment(int id);

    }
}
