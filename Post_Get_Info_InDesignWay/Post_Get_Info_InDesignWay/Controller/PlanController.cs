using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Plan.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Post_Get_Info_InDesignWay.Controller
{
    [Route("api/[controller]")]
    public class PlanController 
    {
        // GET: api/<controller>
        [HttpGet]
        public string Get()
        {
            string str = File.ReadAllText("planJson.json");
            var plan = JsonConvert.DeserializeObject<PlanDetail>(str);
            return "\n\t Plan Name is: " + plan.plans.plan[0].name +
                  "\n\t Plan size is: " + plan.plans.size +
                  "\n\t Plan link is: " + plan.plans.plan[0].link.href;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
