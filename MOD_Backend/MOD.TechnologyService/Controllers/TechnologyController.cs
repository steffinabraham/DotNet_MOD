using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.TechnologyService.Models;
using MOD.TechnologyService.Repository;

namespace MOD.TechnologyService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TechnologyController : ControllerBase
    {
        private readonly ITechnologyRepository _repository;

        public TechnologyController(ITechnologyRepository repository)
        {
            _repository = repository;
        }
        // get: api/technology
        //[httpget]
        //public IActio<string> get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Technology/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Technology
        [HttpPost]
        [Route("Add")]
        public IActionResult Post(Technology item)
        {
            _repository.AddSkill(item);
            return Ok("Record Added");
        }

        // PUT: api/Technology/5
        [HttpPut("{id}")]
        [Route("updateSkill/{id}")]
        public IActionResult Put(int id, [FromBody] Technology item)
        {
            _repository.UpdateSkill(item);
            return Ok("Record Added");
        }

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
