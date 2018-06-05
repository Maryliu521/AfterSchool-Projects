using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ResultDetails;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Post_Get_Info_InDesignWay.Controller
{
    [Route("api/[controller]")]
    public class ResultsController 
    {
        // GET: api/<controller>
        [HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "This is", " from result controller" };
        //}
        public string Get()
        {    
           // ResultDetail result = new ResultDetail();
            //connect with API 
            //HttpWebRequest req = (HttpWebRequest)WebRequest.Create("");
            //WebClient webClient = new WebClient();
            //string rawJason = webClient.DownloadString("");

            //geting data through file
            string str = File.ReadAllText("resultJson.json");
            var result = JsonConvert.DeserializeObject<ResultDetail>(str);

            return "\n\tResult Link is: " + result.link.href +
                "\n\tPlan's Key and Name are: " + result.results.result[0].key +" "+ result.results.result[0].planName
                + "\n\t Build start time is : " + result.results.result[0].buildStartedTime
                + "\n\t Build Completed time is : " + result.results.result[0].buildCompletedTime
                + "\n\t Artifacts : " + result.results.result[0].artifacts.size;
                
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
