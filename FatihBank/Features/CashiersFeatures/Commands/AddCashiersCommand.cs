using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace FatihBank.Features.MSS_DEF_CashiersFeatures.Commands
{
    public class AddCashiersCommand : IRequest<MSS_DEF_Cashiers>
    {
        public int? Id { get; set; }
        public int currency_id { get; set; }
        public int? currencyId { get; set; }
        public string name { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime? date { get; set; }
        public double amount { get; set; }
        public string notes { get; set; }
        public int entered_by { get; set; }
        public DateTime entery_date { get; set; }
        public virtual ICollection<OperationsDto>? operations { get; set; }

    }
}