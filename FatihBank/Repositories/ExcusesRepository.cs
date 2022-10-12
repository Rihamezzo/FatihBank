using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class ExcusesRepository : IExcusesRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public ExcusesRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_ATT_Excuses>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_ATT_Excuses.Count() / pageSize);

            var list = await dataContext.MSS_ATT_Excuses.Include(x => x.employee).Include(x => x.excusesType)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_ATT_Excuses>
            {
                List = list,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_ATT_Excuses> Add(ExcusesDto excusesDto)
        {
            var result = _mapper.Map<ExcusesDto, MSS_ATT_Excuses>(excusesDto);
            await dataContext.MSS_ATT_Excuses.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, ExcusesDto excusesDto)
        {
            var result = await dataContext.MSS_ATT_Excuses.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(excusesDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_ATT_Excuses.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_ATT_Excuses.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}