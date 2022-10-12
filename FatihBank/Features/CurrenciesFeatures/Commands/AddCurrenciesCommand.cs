using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.MSS_DEF_CurrenciesFeatures.Commands
{
    public class AddCurrenciesCommand : IRequest<MSS_DEF_Currencies>
    {
        public int? Id { get; set; }
        public string name { get; set; }
        public string notes { get; set; }
        public string shortcut { get; set; }
        public int isMain { get; set; }
        public int entered_by { get; set; }
        public DateTime entery_date { get; set; }
    }
}
