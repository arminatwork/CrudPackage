using System.Collections.Generic;
using api.Data.Repositories;
using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeveloperController : ControllerBase
    {
        private readonly IDeveloperRepository _repository;

        public DeveloperController(IDeveloperRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Developer>> GetDeveloper()
        {
            return _repository.GetByList();
        }

        [HttpGet("{id}")]
        public ActionResult<Developer> GetDeveloper(int id)
        {
            var entity = _repository.GetById(id);
            if (entity is null) return NotFound($"Entity Developer Id:{id} not found!...");

            return entity;
        }

        [HttpPost]
        public ActionResult<Developer> AddDeveloper()
        {
            List<Developer> entities = new();
            entities.Add(new Developer
            {
                Id = 10,
                Name = "Test",
                Age = 40,
                Follower = "260000"
            });
            entities.Add(new Developer
            {
                Id = 20,
                Name = "Test2",
                Age = 60,
                Follower = "500000"
            });
            _repository.AddRange(entities);

            return Ok(entities);
        }

        // [HttpPut("{id}")]
        // public ActionResult<Developer> UpdateDeveloper(params int[] ids)
        // {
        //     var entities = _repository.GetById(ids);
        //     if (entities is null) return NotFound($"Entity Developer Id:{ids} not found!...");

        //     _repository.UpdateRange(entities);
        //     return NoContent();
        // }

        // [HttpDelete("{id}")]
        // public ActionResult<Developer> DeleteDeveloper(int id)
        // {
        //     var entity = _repository.GetById(id);
        //     if (entity is null) return NotFound($"Entity Developer Id:{id} not found!...");

        //     return NoContent();
        // }
    }
}