using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeFutebol.Models;
using TimeFutebol.Repository;

namespace TimeFutebol.Data
{
    public class TimeRepository : ITimeRepository
    {


        public readonly DataContext _context;

        public TimeRepository(DataContext context)
        {
            _context = context;
        }



        public async Task Delete(int id)
        {
            var timeDelete = await _context.Times.FindAsync(id);
            _context.Times.Remove(timeDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TimeModel>> Get(int? id)
        {
            if (id != null)
            {
                return await _context.Times.Where(x => x.IdTime == id).ToListAsync();
            }
            else
            {
                return await _context.Times.ToListAsync();
            }
        }

        public async Task<TimeModel> Insert(TimeModel time)
        {
            _context.Times.Add(time);
            await _context.SaveChangesAsync();
            return time;
        }

        public async Task Update(TimeModel time)
        {
            _context.Entry(time).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<TimeModel> GetObject(int id)
        {
            return await _context.Times.FindAsync(id);
        }
    }
}
