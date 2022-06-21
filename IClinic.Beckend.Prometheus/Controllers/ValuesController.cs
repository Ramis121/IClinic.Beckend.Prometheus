using Microsoft.AspNetCore.Mvc;
using Prometheus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IClinic.Beckend.Prometheus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        Counter counter = Metrics.CreateCounter("my_counter", "Metrict counter");
        // GET: api/<ValuesController>
        [HttpGet]
        public Counter Get()
        {
            while (true)
            {
                counter.Inc();
                return counter;
            }
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
    }
}
