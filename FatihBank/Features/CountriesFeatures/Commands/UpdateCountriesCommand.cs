using FatihBank.DTOs;
using MediatR;

namespace FatihBank.Features.CountriesFeatures.Commands
{
    public class UpdateCountriesCommand : IRequest
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string notes { get; set; }
        public int entered_by { get; set; }
        public DateTime entry_date { get; set; }
        public virtual ICollection<StoresDto>? stores { get; set; }
    }
}