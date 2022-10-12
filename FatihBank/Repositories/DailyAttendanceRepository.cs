using AutoMapper;
using FatihBank.Data;
using FatihBank.DTOs;
using FatihBank.Models;
using Microsoft.EntityFrameworkCore;

namespace FatihBank.Repositories
{
    public class DailyAttendanceRepository : IDailyAttendanceRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public DailyAttendanceRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_ATT_Daily_Attendance>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_ATT_Daily_Attendance.Count() / pageSize);

            var dailyAttendance = await dataContext.MSS_ATT_Daily_Attendance.Include(x => x.employee)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_ATT_Daily_Attendance>
            {
                List = dailyAttendance,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_ATT_Daily_Attendance> Add(DailyAttendanceDto dailyAttendanceDto)
        {
            var result = _mapper.Map<DailyAttendanceDto, MSS_ATT_Daily_Attendance>(dailyAttendanceDto);
            await dataContext.MSS_ATT_Daily_Attendance.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, DailyAttendanceDto dailyAttendanceDto)
        {
            var result = await dataContext.MSS_ATT_Daily_Attendance.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(dailyAttendanceDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_ATT_Daily_Attendance.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_ATT_Daily_Attendance.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}
