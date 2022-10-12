using MediatR;

namespace FatihBank.Features.P_PricesFeatures.Commands
{
    public class UpdateP_PricesCommand : IRequest
    {
        public int Id { get; set; }
        public int currency_id { get; set; }
        public int? currencyId { get; set; }
        public double price { get; set; }
        public int divide { get; set; }
        public DateTime last_update { get; set; }
        public int user_id { get; set; }
        public int? userId { get; set; }
    }
}