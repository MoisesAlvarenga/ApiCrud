using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeFutebol.Interface;
using TimeFutebol.Models;
using TimeFutebol.Repository;

namespace TimeFutebol.Controllers
{
    [ApiController]
    [Route("Jogador/[controller]")]
    public class JogadorController : ControllerBase
    {
        private readonly IJogadorRepository _jogador;


        public JogadorController(IJogadorRepository jogador)
        {
            _jogador = jogador;
        }

        [HttpGet]
        public async Task<IEnumerable<JogadorModel>> Get(int? id)
        {
            return await _jogador.Get(id);
        }

        [HttpPost]
        public async Task<JogadorModel> Insert(JogadorModel jogador)
        {
            return await _jogador.Insert(jogador);
        }

        [HttpDelete("{id}")]
        public async Task<JogadorModel> Delete(int id)
        {
            var JogadorToDelete = await _jogador.GetObject(id);
            if(JogadorToDelete != null)
            {

                await _jogador.Delete(JogadorToDelete.IdJogador);
            }
            return null;
        }


        [HttpPut]
        public Task Update(JogadorModel jogador)
        {
            return _jogador.Update(jogador);
        }

    }
}
