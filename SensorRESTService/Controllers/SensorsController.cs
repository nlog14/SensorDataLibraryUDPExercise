using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SensorDataLibraryUDPExercise;
using SensorRESTService.Managers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SensorRESTService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SensorsController : ControllerBase
    {
        private SensorsManager _manager = new SensorsManager();

        // GET: api/<SensorsController>
        [HttpGet]
        public IEnumerable<SensorData> Get()
        {
            return _manager.GetAll();
            
        }

        // GET api/<SensorsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SensorsController>
        [HttpPost]
        public SensorData Post([FromBody] SensorData newData)
        {
           return _manager.Create(newData);
        }

        // PUT api/<SensorsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SensorsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
