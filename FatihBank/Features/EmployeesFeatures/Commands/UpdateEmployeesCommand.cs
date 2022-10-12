using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.EmployeesFeatuers.Commands
{
    public class UpdateEmployeesCommand : IRequest
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string last_name { get; set; }
        public string nationality { get; set; }
        public DateTime? birthdate { get; set; }
        public long? mobile { get; set; }
        public long? phone { get; set; }
        public string passport { get; set; }
        public string idphoto { get; set; }
        public string address { get; set; }
        public string notes { get; set; }


    }
}
