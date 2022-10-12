using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.VacationsTypesFeatures.Commands
{
    public class AddVacationsTypesCommand : IRequest<MSS_ATT_VacationsTypes>
    {
        public int? Id { get; set; }
        public string name { get; set; }
        public virtual ICollection<VacationsDto>? vacations { get; set; }
    }
}