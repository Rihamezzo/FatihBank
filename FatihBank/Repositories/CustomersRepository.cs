using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;

namespace FatihBank.Repositories
{
    public class CustomersRepository : ICustomersRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public CustomersRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_DEF_Customers>> ListAll(int page, float pageSize)
        {

            var pageCount = Math.Ceiling(dataContext.MSS_DEF_Customers.Count() / pageSize);

            var customers = await dataContext.MSS_DEF_Customers.Include(x => x.accounts)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_DEF_Customers>
            {
                List = customers,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_DEF_Customers> Add(CustomersDto customersDto)
        {
            var result = _mapper.Map<CustomersDto, MSS_DEF_Customers>(customersDto);
            await dataContext.MSS_DEF_Customers.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, CustomersDto customersDto)
        {
            var result = await dataContext.MSS_DEF_Customers.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(customersDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_DEF_Customers.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_DEF_Customers.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}
