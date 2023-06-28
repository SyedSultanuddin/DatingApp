using DatingApp.Data;
using DatingApp.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Controllers

{

    [ApiController]
    [Route("api/[controller]")]  // api users

    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]

        //-------------Synchronize code below 
        //  public ActionResult<IEnumerable<AppUser>> GetUsers()
        //  {

        //     var users = _context.Users.ToList();

        //     return users;
        //  }   


        //-------------------//

        //--------------Asynchronose code here----------------.

        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {

            var users = await _context.Users.ToListAsync();

            return users;
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<AppUser>> GetUser(int id)

        //  {
        //    var user = _context.Users.Find(id);
        //    return user;
        // }

        {

            return await _context.Users.FindAsync(id);


        }




    }
}