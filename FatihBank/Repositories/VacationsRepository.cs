using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class VacationsRepository : IVacationsRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public VacationsRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_ATT_Vacations>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_ATT_Vacations.Count() / pageSize);

            var list = await dataContext.MSS_ATT_Vacations.Include(x => x.employee).Include(x => x.vacationsType)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_ATT_Vacations>
            {
                List = list,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_ATT_Vacations> Add(VacationsDto vacationsDto)
        {
            var result = _mapper.Map<VacationsDto, MSS_ATT_Vacations>(vacationsDto);
            await dataContext.MSS_ATT_Vacations.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, VacationsDto vacationsDto)
        {
            var result = await dataContext.MSS_ATT_Vacations.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(vacationsDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_ATT_Vacations.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_ATT_Vacations.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}