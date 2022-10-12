using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.AvgFeatures.Commands
{
    public class AddAvgCommand : IRequest<MSS_FIN_Avg>
    {
        public int? Id { get; set; }
        public int main_avg { get; set; }
        public int? main_avgId { get; set; }

        public int operation_id { get; set; }
        public int type { get; set; }

        public double currency1_amount { get; set; }
        public double currency2_amount { get; set; }

        public int parent_id { get; set; }
        public int? parentId { get; set; }


        public int entered_by { get; set; }
        public DateTime entry_date { get; set; }

        public double price { get; set; }
    }
}