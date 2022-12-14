using Microsoft.AspNetCore.Mvc;
using ShoeStore.Dtos;
using ShoeStore.Models;
using ShoeStore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeStore.Controllers
{
    [ApiController]
    [Route("shoes")]
    public class ShoesController : ControllerBase
    {
        private readonly IShoesRepository _repository;
        
        public ShoesController(IShoesRepository repository)
        {
            _repository = repository;
        }

        // GET api/v1/shoes/
        [HttpGet]
        public IEnumerable<ShoeDto> GetShoes()
        {
            return _repository.GetShoes().Select(shoes => shoes.AsDto());
        }
    }
}
