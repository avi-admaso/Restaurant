using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Restaurant.Controllers.Api
{
    public class WaiterController : ApiController
    {
        ResturantDC DbContext = new ResturantDC ();
        // GET: api/Waiter
        public IHttpActionResult Get()
        {
           
            return Ok( DbContext.Waiters.ToList());
        }

        // GET: api/Waiter/5
        public IHttpActionResult Get(int id)
        {
            DbContext;
            return Ok();
        }

        // POST: api/Waiter
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Waiter/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Waiter/5
        public void Delete(int id)
        {
        }
    }
}
