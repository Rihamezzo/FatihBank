using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class IndividualsRepository : IIndividualsRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public IndividualsRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_TRS_Individuals>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_TRS_Individuals.Count() / pageSize);

            var list = await dataContext.MSS_TRS_Individuals.Include(x => x.account).Include(x => x.cashier)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_TRS_Individuals>
            {
                List = list,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_TRS_Individuals> Add(IndividualsDto individualsDto)
        {
            var result = _mapper.Map<IndividualsDto, MSS_TRS_Individuals>(individualsDto);
            await dataContext.MSS_TRS_Individuals.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, IndividualsDto individualsDto)
        {
            var result = await dataContext.MSS_TRS_Individuals.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(individualsDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_TRS_Individuals.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_TRS_Individuals.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}
