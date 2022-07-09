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
    [Route("[controller]")]
    public class JogadorController : ControllerBase
    {
        private readonly IJogadorRepository _jogador;
        private readonly ITimeRepository _time;


        public JogadorController(IJogadorRepository jogador, ITimeRepository time)
        {
            _jogador = jogador;
            _time = time;
        }

        [HttpGet]
        public async Task<IEnumerable<JogadorModel>> Get()
        {

            return await _jogador.Get();
            
            
        }
    }
}
