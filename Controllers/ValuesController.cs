using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SwaggerNetCore.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        /// <summary>
        /// Gets all values.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET: localhost:5000/api/values
        ///
        /// </remarks>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// gets a specific value.
        /// </summary>
        /// <param name="id"></param>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET: localhost:5000/api/values/1
        ///
        /// </remarks>
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Inserts specific value.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST: localhost:5000/api/values
        ///     {
        ///         "Id": 1,
        ///         "Name": "1",
        ///         "Description": "1"
        ///     }
        ///
        /// </remarks>
        /// <returns>A newly created Value</returns>
        /// <response code="201">Returns the newly created value</response>
        /// <response code="400">If the value is null</response>            
        [HttpPost]
        public void Post([FromBody]Models.Value value)
        {
        }

        /// <summary>
        /// Updates specific value.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST: localhost:5000/api/values
        ///     {
        ///         "Id": 1,
        ///         "Name": "1",
        ///         "Description": "1"
        ///     }
        ///
        /// </remarks>
        /// <returns>An updated Value</returns>
        /// <response code="201">Returns the updated value</response>
        /// <response code="400">If the value is null</response>            
        [HttpPut]
        public void Put([FromBody]Models.Value value)
        {
        }

        /// <summary>
        /// Deletes a specific value.
        /// </summary>
        /// <param name="id"></param> 
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
