using LibraryManagement.API.Data;
using LibraryManagement.API.Models.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly LibraryManagementDbContext _dbContext;

        public BooksController(LibraryManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }


    }
}
