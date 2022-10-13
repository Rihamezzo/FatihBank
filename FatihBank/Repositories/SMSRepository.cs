using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class SMSRepository : ISMSRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public SMSRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_DEF_SMS>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_DEF_SMS.Count() / pageSize);

            var list = await dataContext.MSS_DEF_SMS.Include(x => x.sent_by_user).Include(x => x.sentToCustomer)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_DEF_SMS>
            {
                List = list,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_DEF_SMS> Add(SMSDto SMSDto)
        {
            var result = _mapper.Map<SMSDto, MSS_DEF_SMS>(SMSDto);
            await dataContext.MSS_DEF_SMS.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, SMSDto SMSDto)
        {
            var result = await dataContext.MSS_DEF_SMS.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(SMSDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_DEF_SMS.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_DEF_SMS.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}
