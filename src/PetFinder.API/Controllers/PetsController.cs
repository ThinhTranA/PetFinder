using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetFinder.Core.Entities;
using PetFinder.Infrastructure.Data;

namespace PetFinder.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PetsController : ControllerBase
    {
        private readonly PetFinderContext _context;

        public PetsController(PetFinderContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Pet>>> GetPets()
        {
            var pets = await  _context.Pets.ToListAsync();

            return Ok(pets);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Pet>> GetPet(Guid id)
        {
            return await _context.Pets.FindAsync(id);
        }
    }
}
