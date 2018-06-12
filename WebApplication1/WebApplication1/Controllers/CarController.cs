using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CarController : ApiController
    {
        // GET: api/Car
        public IEnumerable<string> Get()
        {
            return new string[] { "Car1", "Car2" };
        }

        // GET: api/Car/5
        public string Get(int id)
        {
            Car Panda = new Car();
            Panda.Brand = "FIAT";

            return "Some car";
        }

        // POST: api/Car
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Car/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Car/5
        public void Delete(int id)
        {
        }
    }
}
