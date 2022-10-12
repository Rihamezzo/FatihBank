using AutoMapper;
using FatihBank.Data;
using FatihBank.DTOs;
using FatihBank.Models;
using Microsoft.EntityFrameworkCore;

namespace FatihBank.Repositories
{
    public class ChecksRepository : IChecksRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public ChecksRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_ACC_Checks>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_ACC_Checks.Count() / pageSize);

            var checks = await dataContext.MSS_ACC_Checks.Include(x => x.account)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_ACC_Checks>
            {
                List = checks,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_ACC_Checks> Add(ChecksDto checksDto)
        {
            var result = _mapper.Map<ChecksDto, MSS_ACC_Checks>(checksDto);
            await dataContext.MSS_ACC_Checks.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, ChecksDto checksDto)
        {
            var result = await dataContext.MSS_ACC_Checks.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(checksDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_ACC_Checks.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_ACC_Checks.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}
