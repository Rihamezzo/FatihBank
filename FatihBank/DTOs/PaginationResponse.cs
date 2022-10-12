using FatihBank.Models;

namespace FatihBank.DTOs
{
    public class PaginationResponse <T> where T : class
    {
        public List<T>? List { get; set; }
        public int? Pages { get; set; }
        public int? CurrentPage { get; set; }

        
    }
}
