using System.ComponentModel.DataAnnotations;

namespace FatihBank.Models
{
    public class MSS_DEF_Users
    {
        public int Id { get; set; }
        public int userId { get; set; }
        [MaxLength(255)]
        public string loginName { get; set; }
        public string password { get; set; }
        public int groupId { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public string username { get; set; }

        public int? is_online { get; set; }
        public virtual ICollection<MSS_DEF_Permissions> permissions { get; set; }
        public MSS_DEF_Users()
        {

        }
    }
}
