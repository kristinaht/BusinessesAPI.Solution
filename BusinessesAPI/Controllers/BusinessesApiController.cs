using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BusinessesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessesController : ControllerBase
    {
			// GET api/businesses
			[HttpGet]
			public ActionResult<IEnumerable<Business>> Get()
			{
					
			}

			// GET api/businesses/5
			[HttpGet("{id}")]
			public ActionResult<string> Get(int id)
			{
				return "value";
			}

			// POST api/businesses
			[HttpPost]
			public void Post([FromBody] string value)
			{
			}

			// PUT api/businesses/5
			[HttpPut("{id}")]
			public void Put(int id, [FromBody] string value)
			{
			}

			// DELETE api/businesses/5
			[HttpDelete("{id}")]
			public void Delete(int id)
			{
			}
    }
}
