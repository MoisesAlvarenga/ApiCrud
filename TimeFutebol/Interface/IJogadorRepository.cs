using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using TimeFutebol.Models;


namespace TimeFutebol.Interface
{
    public interface IJogadorRepository
    {

        Task<JogadorModel> Insert(JogadorModel jogador);

        Task<JogadorModel> Update(JogadorModel jogador);

        Task Delete(int id);
        Task<IEnumerable<JogadorModel>> Get();
    }
}
