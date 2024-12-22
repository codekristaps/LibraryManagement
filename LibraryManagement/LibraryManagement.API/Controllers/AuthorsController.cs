using LibraryManagement.API.Data;
using LibraryManagement.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly LibraryManagementDbContext _dbContext;

        public AuthorController(LibraryManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAuthors()
        {
            var authors =  await _dbContext.Authors.ToListAsync();
            return Ok(authors);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuthor(Guid id)
        {
            var author = await _dbContext.Authors.FirstOrDefaultAsync(a => a.AuthorId == id);

            if (author == null)
            {
                return NotFound();
            }

            return Ok(author);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAuthor(Author author)
        {
            author.AuthorId = Guid.NewGuid();
            _dbContext.Authors.Add(author);
            await _dbContext.SaveChangesAsync();
            return Ok(author);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAuthor(Guid id, Author author)
        {
            if (id != author.AuthorId)
            {
                return BadRequest();
            }

            _dbContext.Update(author);
            await _dbContext.SaveChangesAsync();

            return Ok(author);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuthor(Guid id)
        {
            var author = await _dbContext.Authors.FindAsync(id);

            if (author == null)
            {
                return NotFound();
            }

            _dbContext.Authors.Remove(author);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
