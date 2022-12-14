using MediatR;

namespace FatihBank.Features.PricesFeatures.Commands
{
    public class UpdatePricesCommand : IRequest
    {
        public int Id { get; set; }
        public int currency1_id { get; set; }
        public int? currency1Id { get; set; }
        public int currency2_id { get; set; }
        public int? currency2Id { get; set; }
        public double s_price { get; set; }
        public double b_price { get; set; }
        public double commission { get; set; }
        public DateTime last_update { get; set; }
        public int update_by { get; set; }
    }
}