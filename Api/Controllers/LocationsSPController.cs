using Api.BLL;
using Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsSPController : ControllerBase
    { 
        /// <summary>
        /// Controlador para cargar el datatable que relaciona las ciudades 
        /// con los estados y países.
        /// </summary>
        /// <returns></returns>

        // GET: api/<LocationController>
        [HttpGet]
        public IEnumerable<MOD_LocationsSP> Get()
        {
            return BLL_LocationsSP.Query_Locations();
        }      
    }
}
