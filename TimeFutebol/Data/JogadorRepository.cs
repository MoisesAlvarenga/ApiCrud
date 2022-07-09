using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeFutebol.Interface;
using TimeFutebol.Models;

namespace TimeFutebol.Data
{
    public class JogadorRepository : IJogadorRepository
    {

        public readonly DataContext _context;

        public JogadorRepository(DataContext context)
        {
            _context = context;
        }


        public Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<JogadorModel>> Get()
        {
            return await _context.Jogador.Select(j => j).Include(t => t.Time).ToListAsync();
        }

        public Task<JogadorModel> Insert(JogadorModel jogador)
        {
            throw new System.NotImplementedException();
        }

        public Task<JogadorModel> Update(JogadorModel jogador)
        {
            throw new System.NotImplementedException();
        }
    }
}
