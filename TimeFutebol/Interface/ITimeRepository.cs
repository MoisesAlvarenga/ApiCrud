using System.Collections.Generic;
using System.Threading.Tasks;
using TimeFutebol.Models;

namespace TimeFutebol.Repository
{
    public interface ITimeRepository
    {
        Task<IEnumerable<TimeModel>> Get(int? id);

        Task<TimeModel> Insert(TimeModel jogador);

        Task<TimeModel> Update(TimeModel jogador);

        Task Delete(int id);
        public Task<TimeModel> GetObject(int id);
    }
}
