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

			private BusinessesApiContext _db;

			public BusinessesController(BusinessesApiContext db)
			{
				_db = db;
			}

			// GET api/businesses
			[HttpGet]
			public ActionResult<IEnumerable<Business>> Get()
			{
				return _db.Businesses.ToList();
			}

			//POST api/businesses
			public void Post([FromBody] Businesses business) //[FromBody] allows to actually put values/details of a business in the POST API call 
			{
				_db.Businesses.Add(business);
				_db.SaveChanges();
			}
    }
}
