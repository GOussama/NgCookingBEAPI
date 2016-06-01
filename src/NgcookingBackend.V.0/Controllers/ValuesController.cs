using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using NgcookingBackend.Models;


namespace NgcookingBackend.V._0.Controllers
{
   //[Route("api/[controller]")]
    public class ValuesController : Controller
    {

        ICommunautesRepository _communautesRepository { get; set; }
       


        public ValuesController(ICommunautesRepository communautesRepository)
        {
            _communautesRepository = communautesRepository;
           
        }
        
       
        // GET: api/values
        //[HttpGet("api/communautes")]
        public JsonResult Get()
        {
            //return Json(_communautesRepository.GetCommunautes());
            return Json(_communautesRepository.GetAll());
        }

        /*
        //GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        */
        //GET api/values/5
       // [HttpGet("{id}")]

        //[HttpGet("api/communautes/{id}")]
        public JsonResult Get(string id)
        {
            return Json(_communautesRepository.GetCommunauteById(int.Parse(id)));
        }


        //POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        //PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        //DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
