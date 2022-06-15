using dotnetcore_angular_project.Data;
using dotnetcore_angular_project.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcore_angular_project.Controllers
{
    [ApiController]
    [Route("api/(controller)")]

    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            return  await _context.appusers.ToListAsync();
            
        }

        //api/appusers/3
        [HttpGet("{id}")]

        public async Task<ActionResult<AppUser>> GetUsers(int id)
        {
            return await _context.appusers.FindAsync(id);
            
        }
    }
}
