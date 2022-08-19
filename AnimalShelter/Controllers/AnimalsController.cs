using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using AnimalShelter.Models;


namespace Animals.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class AnimalsController : ControllerBase
    {

        private readonly AnimalShelterContext _db;

        public AnimalsController(AnimalShelterContext db)
        {
            _db = db;
        }

        /// <summary>
        /// Returns a list of all available animals.
         /// </summary>

        
        [HttpGet]
        public ActionResult<IEnumerable<Animal>> Get(int age, string name, string species, string breed, string gender)
        {
            
            var query = _db.Animals.AsQueryable();

            if (name == null && species == null && gender == null && age == 0)
            {
                return _db.Animals.ToList();
            }

            if (name != null)
            {
                query = query.Where(entry => entry.Name == name);
            }

            if (species != null)
            {
                query = query.Where(entry => entry.Species == species);
            }

            if (gender != null)
            {
                query = query.Where(entry => entry.Gender == gender);
            }

            if (breed != null)
            {
                query = query.Where(entry => entry.Breed == breed);
            }

            if (age > 0)
            {
                query = query.Where(entry => entry.Age == age);
            }

            return query.ToList();
        }

        /// <summary>
        /// Creates an animal listing.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        /// POST /animals
        /// { 
        ///    "AnimalId" = 1, 
        ///    "Name" = "Rutabega", 
        ///    "Gender" = "Female",
        ///    "Species" = "Dog",
        ///    "Breed" = "Pitty / Black lab mix",
        ///    "Age" = 9,
        ///    "Description" = "Loves to be a landshark."}
        ///
        /// </remarks>
        /// <returns>A newly created Animal</returns>
        
        [HttpPost]
        public async Task<ActionResult<Animal>> Post(Animal animal)
        {
        _db.Animals.Add(animal);
        await _db.SaveChangesAsync();

        return CreatedAtAction(nameof(GetAnimal), new { id = animal.AnimalId }, animal);
        }

        


        /// <summary>
        /// Searches for a specific animal by Id.
        /// </summary>
        /// <param name="id"></param>
        // GET api/Animals/5

        [HttpGet("{id}")]
        public async Task<ActionResult<Animal>> GetAnimal(int id)
        {
            var animal = await _db.Animals.FindAsync(id);

            if (animal == null)
            {
                return NotFound();
            }

            return animal;
        }

        /// <summary>
        /// Edits a specific animal by Id.
        /// </summary>


        [HttpPut("{id}")] 
        public async Task<IActionResult> Put(int id, [FromBody] Animal animal)
        {
        if (id != animal.AnimalId)
        {
            return BadRequest();
        }

        _db.Entry(animal).State = EntityState.Modified;

        try 
        {
            await _db.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!AnimalExists(id))
            {
            return NotFound();
            }
            
            
            else
            {
            throw;
            }
        }

        return NoContent();
        }

        /// <summary>
        /// Deletes a specific animal.
        /// </summary>
        /// <param name="id"></param>
        // DELETE api/animals/5
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnimal(int id)
        {
        var animal = await _db.Animals.FindAsync(id);
        if (animal == null)
        {
            return NotFound();
        }

        _db.Animals.Remove(animal);
        await _db.SaveChangesAsync();

        return NoContent();
        }

        private bool AnimalExists(int id)    
        {
        return _db.Animals.Any(e => e.AnimalId == id);
        }
    }
}
