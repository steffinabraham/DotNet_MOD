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


        [HttpGet]
        [Route("GetAll")]
        public List<Technology> Get()
        {
            return _repository.GetAll();
        }






        [HttpGet("{id}", Name = "Get")]
        [Route("GetById/{id}")]
        public Technology Get(long id)
        {
            return _repository.GetById(id);
        }


        [HttpPost]
        [Route("Add")]
        public IActionResult Post([FromBody] Technology item)
        {
            _repository.AddTechnology(item);
            return Ok("Record Added");
        }


        [HttpPut("{id}")]
        [Route("Update/{id}")]

        public void Put(Technology item)
        {
            _repository.UpdateTechnology(item);
        }


        //[HttpDelete("{id}")]
        //[Route("Delete/{id}")]
        //public void Delete(long id)
        //{
        //    _repository.DeleteTechnology(id);
        //}
        //public void Block(long id)
        //{
        //    _repository.BlockTechnology(id);
        //}


    }
}
