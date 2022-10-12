using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.StoresFeatures.Commands
{
    public class AddStoresCommand : IRequest<MSS_DEF_Stores>
    {
        public int? Id { get; set; }
        public string name { get; set; }
        public int country_id { get; set; }
        public int? countryId { get; set; }
    }
}