using Api.BLL;
using Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserSPController : ControllerBase
    {

        /// <summary>
        /// Controlador para la consulta sobre la función sp_query_users 
        /// que retorna el datatable con el usuario relacionado con su ciudad, y ésta con el estado y el país.
        /// </summary>
        /// <returns></returns>

        //[HttpGet]
        public IEnumerable<MOD_UserSP> Get()
        {
            return BLL_UserSP.Query_Users();            
        }

        // GET: api/UserSP/5
        [HttpGet("{id}")]
        public ActionResult<MOD_UserSP> GetMOD_UserSP(int id)
        {
            return BLL_UserSP.Query_Users(id).FirstOrDefault();           
        }       
    }
}
