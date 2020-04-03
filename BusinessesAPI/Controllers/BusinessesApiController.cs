using System;
using System.Collections.Generic;
using System.Linq;
// using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessesApi.Models;

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
			public ActionResult<IEnumerable<Business>> Get(string name, string description)
			{
				var query = _db.Businesses.AsQueryable();

				if (name != null)
				{
					query = query.Where(entry => entry.Name == name);
				}

				if(description != null)
				{
					query = query.Where(entry => entry.Description == description);
				}

				return query.ToList();
			}

			//POST api/businesses
			[HttpPost]
			public void Post([FromBody] Business business) //[FromBody] allows to actually put values/details of a business in the POST API call 
			{
				_db.Businesses.Add(business);
				_db.SaveChanges();
			}

			//GET api/businesses/1
			[HttpGet("{id}")]
			public ActionResult<Business> Get(int id)
			{
				return _db.Businesses.FirstOrDefault(entry => entry.BusinessId == id);
			}

			//PUT api/businesses/1
		  [HttpPut("{id}")]
			public void Put(int id, [FromBody] Business business)
			{
				business.BusinessId = id;
				_db.Entry(business).State = EntityState.Modified;
				_db.SaveChanges();
			}

			//DELETE api/businesses/1
			[HttpDelete("{id}")]
			public void Delete(int id)
			{
				var businessToDelete = _db.Businesses.FirstOrDefault(entry => entry.BusinessId == id);
				_db.Businesses.Remove(businessToDelete);
				_db.SaveChanges();
			}

    }
}
