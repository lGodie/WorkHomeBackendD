using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkHomeBackend.Common.Request;
using WorkHomeBackend.Common.Responses;
using WorkHomeBackend.Data.Context;
using WorkHomeBackend.Services.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WorkHomeBackend.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoutinesController : ControllerBase
    {
        private readonly IRoutineService _routineService;
        public RoutinesController(IRoutineService routineService)
        {
            _routineService = routineService;
        }
        // GET: api/<RoutinesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<RoutinesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RoutinesController>
        [HttpPost]
        public async Task <ActionResult<Response<Routine>>> Post([FromBody] RoutineRequest routine)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                Routine DbRoutine = new Routine();
                DbRoutine.Name = routine.Name;
                DbRoutine.Description = routine.Description;
                DbRoutine.SerieNumber = routine.SerieNumber;

                Response<Routine> response = await _routineService.Create(DbRoutine);

                if (response.Success) return StatusCode(200, response);

                return StatusCode(400, response);
            }
            catch (Exception ex)
            {

                return new BadRequestObjectResult(new { success = false, statusCode = 400, message = "Error creando rutina.", error= ex });
            }
        }

        // PUT api/<RoutinesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RoutinesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
