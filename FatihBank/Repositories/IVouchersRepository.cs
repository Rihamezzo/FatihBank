using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface IVouchersRepository
    {
        Task<MSS_DEF_Vouchers> Add(VouchersDto vouchersDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_DEF_Vouchers>> ListAll(int page, float pageSize);
        Task Update(int id, VouchersDto vouchersDto);
    }
}