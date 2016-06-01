using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using NgcookingBackend.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace NgcookingBackend.V._0.Controllers
{

    [Route("api/[controller]")]
    public class CommunautesController : Controller
    {
        // GET: /<controller>/
        ICommunautesRepository _communautesRepository { get; set; }

        public CommunautesController(ICommunautesRepository communautesRepository)
        {
            _communautesRepository = communautesRepository;
        }

        [HttpGet()]
        public JsonResult Get()
        {
            return Json(_communautesRepository.GetCommunautes());
        }

        [HttpGet("{id}")]
        public JsonResult Get(string id)
        {
            return Json(_communautesRepository.GetCommunauteById(int.Parse(id)));
        }

    }
}
