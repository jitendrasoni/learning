using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Examples.Commands;
using Examples.Queries;
using Microsoft.AspNetCore.Mvc;

namespace Examples.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IQueryService _queries;
        private readonly ICommandService _commands;

        public PostController(IQueryService queries, ICommandService commands)
        {
            _queries = queries ?? throw new ArgumentNullException(nameof(queries));
            _commands = commands ?? throw new ArgumentNullException(nameof(commands));
        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<int>>> Get()
        {
            return (await _queries.GetAllPostId()).ToList();
        }



        // POST api/values
        [HttpPost]
        public void SavePost([FromBody] SaveProductDTO value)
        {
            _commands.SaveProduct(value.Id, value.Name);
        }

    }
}