using MediatR;

namespace FatihBank.Features.SMSFeatures.Commands
{
    public class UpdateSMSCommand : IRequest
    {
        public int Id { get; set; }
        public int sent_by { get; set; }
        public int? sent_by_userId { get; set; }
        public int sent_to_customer { get; set; }
        public int? sentToCustomerId { get; set; }
        public long phone_number { get; set; }
        public DateTime date { get; set; }
        public string sms { get; set; }
        public string status { get; set; }
        public int type { get; set; }
    }
}