using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_Colleague.Context;
using WebApi_Colleague.Models;

namespace WebApi_Colleague.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class AddressController : ControllerBase
    {
        private ColleagueContext _db;
       public AddressController(ColleagueContext db)
        {
            _db = db;
        }
        // GET: AddressController
        [HttpGet]
        public IEnumerable<Address> Get()
        {
            return _db.Addresses;
        }

       
        // GET api/<AddressController>/5
        [HttpGet("{id}")]
        public Address Get(int id)
        {
            return _db.Addresses.FirstOrDefault(s => s.AddressId == id);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] Address value)
        {
            _db.Addresses.Add(value);
            _db.SaveChanges();
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Address value)
        {
            var address = _db.Addresses.FirstOrDefault(s => s.AddressId == id);
            if (address != null)
            {
                //_db.Entry<Address>(address).CurrentValues.SetValues(value);

                //address.ColleagueName = colleague.ColleagueName;
                //entry.AddressId = colleague.AddressId;
                address.AddLine1 = value.AddLine1;
                address.AddLine2 = value.AddLine2;
                address.City = value.City;
                address.State = value.State;
                address.Country = value.Country;
                address.Zipcode = value.Zipcode;
                address.Created = value.Created;
                _db.SaveChanges();
            }
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var address = _db.Addresses.FirstOrDefault(s => s.AddressId == id);
            if (address != null)
            {
                _db.Addresses.Remove(address);
                _db.SaveChanges();
            }
        }
    }
}

    
