using System.Collections.Generic;
using System.Threading.Tasks;
using API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class InfosController : ControllerBase
    {
        private readonly DataContext _context;
        public InfosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Infos>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Infos>>> GetInfos()
     
        {
            return await _context.Infos.ToListAsync();
        }
    }
}