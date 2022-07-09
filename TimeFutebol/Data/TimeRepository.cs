using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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



        public Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<TimeModel>> Get(int? id)
        {
            return await _context.Times.ToListAsync();
        }

        public Task<TimeModel> Insert(TimeModel jogador)
        {
            throw new System.NotImplementedException();
        }

        public Task<TimeModel> Update(TimeModel jogador)
        {
            throw new System.NotImplementedException();
        }
    }
}
