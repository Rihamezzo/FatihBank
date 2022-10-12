namespace FatihBank.DTOs
{
    public class VacationsTypesDto
    {
        public int? Id { get; set; }
        public string name { get; set; }
        public virtual ICollection<VacationsDto>? vacations { get; set; }
    }
}
