using FatihBank.DTOs;
using MediatR;

namespace FatihBank.Features.VacationsTypesFeatures.Commands
{
    public class UpdateVacationsTypesCommand : IRequest
    {
        public int Id { get; set; }
        public string name { get; set; }
        public virtual ICollection<VacationsDto>? vacations { get; set; }
    }
}
