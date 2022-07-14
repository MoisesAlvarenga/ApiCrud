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
    public class TimeController : ControllerBase
    {
        private readonly ITimeRepository _time;


        public TimeController(ITimeRepository time)
        {
            _time = time;
        }

        [HttpGet]
        public async Task<IEnumerable<TimeModel>> Get(int? id)
        {
            return await _time.Get(id);
        }


        [HttpPost]
        public async Task<ActionResult<TimeModel>> Insert(TimeModel time)
        {

            return await _time.Insert(time);

        }

        [HttpDelete("{id}")]
        public async Task<TimeModel> Delete(int id)
        {
            var TimeToDelete = await _time.GetObject(id);
            if (TimeToDelete != null)
            {

                await _time.Delete(TimeToDelete.IdTime);
            }
            return null;
        }


        [HttpPut]
        public Task Update(TimeModel time)
        {
            return _time.Update(time);
        }

    }
}