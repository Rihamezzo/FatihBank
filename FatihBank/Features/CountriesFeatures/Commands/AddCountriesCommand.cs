
using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.CountriesFeatures.Commands
{
    public class AddCountriesCommand : IRequest<MSS_DEF_Countries>
    {
        public int? Id { get; set; }
        public string name { get; set; }
        public string notes { get; set; }
        public int entered_by { get; set; }
        public DateTime entry_date { get; set; }
        public virtual ICollection<StoresDto>? stores { get; set; }
    }
}