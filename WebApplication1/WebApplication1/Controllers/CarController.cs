﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{    //This class is used to Get the Cars[] array or a Cars[id] element of the array
    public class CarController : ApiController
    {   
       
        // GET: api/Car
        public Car[] Get()
        {
            return Car.GetCars() ;//returns Car.Cars Array
        }

        // GET: api/Car/5
        public Car Get(int id)
        {
            Car auto = new Car();
            auto = Car.GetCars()[id-1];
            return auto ; //returns Car.Cars[id] element of the array
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
