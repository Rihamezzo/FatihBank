using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class VacationsTypesRepository : IVacationsTypesRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public VacationsTypesRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_ATT_VacationsTypes>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_ATT_VacationsTypes.Count() / pageSize);

            var list = await dataContext.MSS_ATT_VacationsTypes.Include(x => x.vacations)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_ATT_VacationsTypes>
            {
                List = list,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_ATT_VacationsTypes> Add(VacationsTypesDto vacationsTypesDto)
        {
            var result = _mapper.Map<VacationsTypesDto, MSS_ATT_VacationsTypes>(vacationsTypesDto);
            await dataContext.MSS_ATT_VacationsTypes.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, VacationsTypesDto vacationsTypesDto)
        {
            var result = await dataContext.MSS_ATT_VacationsTypes.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(vacationsTypesDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_ATT_VacationsTypes.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_ATT_VacationsTypes.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}
