using DAW.Models;
using DAW.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace DAW.Services.EvenimentService

{
    public class EvenimentService : IEvenimentService
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private readonly ApplicationDBContext _dbcontext;
        public EvenimentService(ApplicationDBContext dBContext)
        {
            _dbcontext = dBContext;
        }
        public async Task AdaugaEveniment(Eveniment e)
        {
            _dbcontext.Eveniment.Add(e);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task<Eveniment> ObtineEveniment(int id)
        {
            var eveniment = await _dbcontext.Eveniment.FirstOrDefaultAsync(e => e.Id == id);
            if (eveniment == null)
            {
                throw new Exception();

            }
            return eveniment;
        }



    }
}
