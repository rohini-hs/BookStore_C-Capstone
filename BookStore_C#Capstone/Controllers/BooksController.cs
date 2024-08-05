using BookStore_C_Capstone.Data;
using BookStore_C_Capstone.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore_C_Capstone.Controllers
{
    //eg:LocalHost:****/api/Books
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly ApplicationDBContext dBContext;

        public  BooksController(ApplicationDBContext dBContext )
        {
            this.dBContext = dBContext;
        }


        [HttpGet]
        public IActionResult GetAllBooks()
        {
            var allBooks = dBContext.Books.ToList();
            return Ok(allBooks);

        }


        //DTo - Data transfer Object
        [HttpPost]
        public IActionResult AddBook(Models.AddBookDto addBookDto)
        {
            //Convert Dto to entity
            var booksEntity = new Books()
            {
                Title = addBookDto.Title,
                AuthorId = addBookDto.AuthorId,
                GenreId = addBookDto.GenreId,
                Price = addBookDto.Price,
                PublicationDate = addBookDto.PublicationDate
            };


            dBContext.Books.Add(booksEntity);
            dBContext.SaveChanges();
            return Ok(booksEntity);
        }
    }
}
