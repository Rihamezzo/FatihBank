using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;
namespace FatihBank.Features.MSS_DEF_CustomersFeatures.Commands
{
    public class AddCustomersCommand : IRequest<MSS_DEF_Customers>
    {
        public int? Id { get; set; }
        public string name { get; set; }
        public long? phone { get; set; }
        public int sms { get; set; }
        public long? mobile { get; set; }
        public string email { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string passport { get; set; }
        public string ident { get; set; }
        public string notes { get; set; }
        public int? entered_by { get; set; }
        public DateTime? entery_date { get; set; }
        public string photo { get; set; }
        public int? special { get; set; }
        public int employee { get; set; }
        public int shipping { get; set; }

        public string personal_photo { get; set; }
        public int? is_private { get; set; }
        public int suspended { get; set; }

        public int? canOverLimit { get; set; }
        public DateTime? notificationDate { get; set; }
        public double? limit { get; set; }
        public int? isPublic { get; set; }
        public virtual ICollection<AccountsDto>? accounts { get; set; }
    }
}
