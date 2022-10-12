using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface ISMSRepository
    {
        Task<MSS_DEF_SMS> Add(SMSDto SMSDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_DEF_SMS>> ListAll(int page, float pageSize);
        Task Update(int id, SMSDto SMSDto);
    }
}