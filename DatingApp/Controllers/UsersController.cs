using DatingApp.Data;
using DatingApp.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DatingApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController: ControllerBase
    {
        private DataContext Contexte { get; }

        public UsersController(DataContext contexte)
        {
            Contexte = contexte;
        }

        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            return await Contexte.Users.ToListAsync();
        }
        
        [HttpGet("{Id}")]
        public async Task<ActionResult<AppUser>> GetUser(int Id)
        {
            return await Contexte.Users.FindAsync(Id);
        }
    }
}
