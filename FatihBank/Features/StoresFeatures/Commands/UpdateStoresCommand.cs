using MediatR;

namespace FatihBank.Features.StoresFeatures.Commands
{
    public class UpdateStoresCommand : IRequest
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int country_id { get; set; }
        public int? countryId { get; set; }
    }
}