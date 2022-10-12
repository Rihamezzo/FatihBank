
using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class CompaniesRepository : ICompaniesRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public CompaniesRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_TRS_Companies>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_TRS_Companies.Count() / pageSize);

            var list = await dataContext.MSS_TRS_Companies.Include(x => x.account).Include(x => x.cashier)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_TRS_Companies>
            {
                List = list,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_TRS_Companies> Add(CompaniesDto companiesDto)
        {
            var result = _mapper.Map<CompaniesDto, MSS_TRS_Companies>(companiesDto);
            await dataContext.MSS_TRS_Companies.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, CompaniesDto companiesDto)
        {
            var result = await dataContext.MSS_TRS_Companies.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(companiesDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_TRS_Companies.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_TRS_Companies.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}
