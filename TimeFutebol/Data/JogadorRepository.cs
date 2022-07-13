using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeFutebol.Interface;
using TimeFutebol.Models;
using System.Web.Http;
using System.Net;
using System.Net.Http;

namespace TimeFutebol.Data
{
    public class JogadorRepository : IJogadorRepository
    {

        public readonly DataContext _context;
        

        public JogadorRepository(DataContext context)
        {
            _context = context;
        }


        public async Task Delete(int id)
        {
            var JogadorToDelete = await _context.Jogador.FindAsync(id);
            _context.Jogador.Remove(JogadorToDelete);
            await _context.SaveChangesAsync();           
        }

        public async Task<IEnumerable<JogadorModel>> Get(int? id)
        {
            if (id != null)
            {
                return await _context.Jogador.Where(x => x.IdJogador == id).ToListAsync();
            }
            else
            {
                return await _context.Jogador.Select(j => j).Include(t => t.Time).ToListAsync();
            }
        }


        public async Task<JogadorModel> GetObject(int id)
        {
            return await _context.Jogador.FindAsync(id);
        }

        public async Task<JogadorModel> Insert(JogadorModel jogador)
        {
            var JsonString = new JogadorModel();
            try
            {
                _context.Jogador.Add(jogador);
                await _context.SaveChangesAsync();
                return jogador;
            }
            catch (DbUpdateException ex)
            {
                
               var error =  ex.InnerException.HResult.ToString();
                if(error == "-2147467259")
                {

                    var resp = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                    {
                        Content = new StringContent(string.Format($"Já existe um jogador com a camisa {jogador.Camisa}")),
                        ReasonPhrase = "Não pode haver dois jogadores com o mesmo uniforme."
                    };
                    throw new HttpResponseException(resp);
                }
                return jogador;
            }
      
        }

        public async Task Update(JogadorModel jogador)
        {
            _context.Entry(jogador).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
