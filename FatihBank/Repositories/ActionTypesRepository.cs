using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class ActionTypesRepository : IActionTypesRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public ActionTypesRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_INF_Action_Types>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_INF_Action_Types.Count() / pageSize);

            var list = await dataContext.MSS_INF_Action_Types
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_INF_Action_Types>
            {
                List = list,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_INF_Action_Types> Add(ActionTypesDto actionTypesDto)
        {
            var result = _mapper.Map<ActionTypesDto, MSS_INF_Action_Types>(actionTypesDto);
            await dataContext.MSS_INF_Action_Types.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, ActionTypesDto actionTypesDto)
        {
            var result = await dataContext.MSS_INF_Action_Types.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(actionTypesDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_INF_Action_Types.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_INF_Action_Types.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}