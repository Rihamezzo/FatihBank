using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.AccountsFeatures.Commands
{
    public class AddAccountsCommand : IRequest<MSS_DEF_Accounts>
    {


        public int? Id { get; set; }
        public int? oldId { get; set; }
        public int customer_id { get; set; }
        public int? customerId { get; set; }
        public int currency_id { get; set; }
        public int? currencyId { get; set; }
        public double start_amount { get; set; }
        public string notes { get; set; }
        public int entered_by { get; set; }
        public DateTime entery_date { get; set; }
        public int current_amount { get; set; }
        public int? type { get; set; }

        public int? commissioned { get; set; }
        public int? profit_id { get; set; }

        public string IBAN { get; set; }

        public virtual ICollection<ChecksDto>? checks { get; set; }
        public override string ToString()
        {
            return "Account command: Id :" + Id + "oldId : " + oldId + " customerId : " + customerId;
        }
    }
}
