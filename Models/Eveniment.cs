using DAW.Services.EvenimentService;
using System.ComponentModel.DataAnnotations.Schema;
namespace DAW.Models
{
    public class Eveniment
    {
        public int Id { get; set; }

        public string Participanti { get; set; }

        public string Organizatori { get; set; }

        public string Specatatori { get; set;}

        public string Evenimente { get; set; }

    }
}
