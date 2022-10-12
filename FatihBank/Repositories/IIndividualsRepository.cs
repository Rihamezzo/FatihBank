using FatihBank.DTOs;
using FatihBank.Models;

namespace FatihBank.Repositories
{
    public interface IIndividualsRepository
    {
        Task<MSS_TRS_Individuals> Add(IndividualsDto individualsDto);
        Task Delete(int id);
        Task<PaginationResponse<MSS_TRS_Individuals>> ListAll(int page, float pageSize);
        Task Update(int id, IndividualsDto individualsDto);
    }
}