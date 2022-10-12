using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.SMSFeatures.Commands
{
    public class AddSMSCommand : IRequest<MSS_DEF_SMS>
    {
        public int? Id { get; set; }
        public int sent_by { get; set; }
        public int? sent_byId { get; set; }
        public int sent_to_customer { get; set; }
        public int? sent_to_CustomerId { get; set; }
        public long phone_number { get; set; }
        public DateTime date { get; set; }
        public string sms { get; set; }
        public string status { get; set; }
        public int type { get; set; }
    }
}