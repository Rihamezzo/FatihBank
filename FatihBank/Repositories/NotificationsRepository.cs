using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class NotificationsRepository : INotificationsRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public NotificationsRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_INF_Notifications>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_INF_Notifications.Count() / pageSize);

            var list = await dataContext.MSS_INF_Notifications
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_INF_Notifications>
            {
                List = list,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_INF_Notifications> Add(NotificationsDto notificationsDto)
        {
            var result = _mapper.Map<NotificationsDto, MSS_INF_Notifications>(notificationsDto);
            await dataContext.MSS_INF_Notifications.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, NotificationsDto notificationsDto)
        {
            var result = await dataContext.MSS_INF_Notifications.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(notificationsDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_INF_Notifications.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_INF_Notifications.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}
