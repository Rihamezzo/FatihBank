
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.RegisterationFileFeatures.Commands
{
    public class AddRegisterationFileCommand : IRequest<MSS_INF_RegisterationFile>
    {
		public int? Id { get; set; }
		public int user_id { get; set; }
		public int? userId { get; set; }
		public DateTime entry_date { get; set; }
		public int operation_type { get; set; }
		public int operation_id { get; set; }
		public int action_type { get; set; }
		public int? Action_typeId { get; set; }
		public int? account_id { get; set; }
		public int? accountId { get; set; }
		public double? amount { get; set; }
		public int? subtype { get; set; }
		public int? cashier_id { get; set; }
		public int? cashierId { get; set; }
		public int? currency_id { get; set; }
		public int? currencyId { get; set; }
		public int? exchange_id { get; set; }
		public int? exchangeId { get; set; }
		public double? price { get; set; }
		public string computer_name { get; set; }
	}
}