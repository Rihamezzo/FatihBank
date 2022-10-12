namespace FatihBank.DTOs
{
    public class ModulesDto
    {
        public int? Id { get; set; }
        public string name { get; set; }
        public int? group { get; set; }
        public virtual ICollection<PermissionsDto>? permissions { get; set; }
    }
}
