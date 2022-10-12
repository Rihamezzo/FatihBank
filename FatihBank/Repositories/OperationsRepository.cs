using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class OperationsRepository : IOperationsRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public OperationsRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_CAS_Operations>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_CAS_Operations.Count() / pageSize);

            var list = await dataContext.MSS_CAS_Operations.Include(x => x.cashier)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_CAS_Operations>
            {
                List = list,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_CAS_Operations> Add(OperationsDto operationsDto)
        {
            var result = _mapper.Map<OperationsDto, MSS_CAS_Operations>(operationsDto);
            await dataContext.MSS_CAS_Operations.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, OperationsDto operationsDto)
        {
            var result = await dataContext.MSS_CAS_Operations.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(operationsDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_CAS_Operations.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_CAS_Operations.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}
