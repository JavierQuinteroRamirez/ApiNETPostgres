using Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserTableController : ControllerBase
    {
        private readonly Context _context;

        /// <summary>
        /// Controlador para la inserción de nuevos usuarios en la tabla usr_user.        
        /// </summary>
        /// <param name="context"></param>
        public UserTableController(Context context)
        {
            _context = context;
        }

        // GET: api/UserTable
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MOD_UserTable>>> GetListUser()
        {
            return await _context.usr_user.ToListAsync();
        }

        // GET: api/UserTable/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MOD_UserTable>> GetUserTable(int id)
        {
            var usr = await _context.usr_user.FindAsync(id);

            if (usr == null) { return NotFound(); }

            return usr;
        }       

        // POST: api/UserTable       
        [HttpPost]
        public async Task<ActionResult<MOD_UserTable>> PostUserTable([FromBody]MOD_UserTable usr)
        {
            _context.usr_user.Add(usr);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserTable", new { id = usr.id_usr }, usr);
        }       
    }
}
