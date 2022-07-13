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
    public class ColleagueController : ControllerBase
    {
        private ColleagueContext _db;
        public ColleagueController(ColleagueContext db)
        {
            _db = db;
        }
        // GET: Colleagues
        [HttpGet]
        public IEnumerable<Colleague> Get()
        {
            return _db.Colleagues;
            //var colleague = (from c in _db.Colleagues
            //                 join a in _db.Addresses
            //                 on c.AddressId equals a.AddressId
            //                 //join d in _db.Departments
            //                 //on c.ColleagueId equals d.


            //                 select new Colleague
            //                 {
            //                     ColleagueId = c.ColleagueId,
            //                     ColleagueName = c.ColleagueName,
            //                     AddressId = c.ColleagueId,
            //                     created = c.created,
            //                     Address = a.City,


            //                 }
            //                 ).ToList();
            //return colleague;
        }


        // GET api/<ColleagueController>/5
        [HttpGet("{id}")]
        public Colleague Get(int id)
        {
            return _db.Colleagues.FirstOrDefault(s => s.ColleagueId == id);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post( Colleague value)
        {
            _db.Colleagues.Add(value);
            _db.SaveChanges();
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Colleague value)
        {
            var colleague = _db.Colleagues.FirstOrDefault(s => s.ColleagueId == id);
            if (colleague != null)
            {
                
                colleague.ColleagueName = value.ColleagueName;
                colleague.AddressId = value.AddressId;
                colleague.created = value.created;
                _db.SaveChanges();
            }
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var colleague = _db.Colleagues.FirstOrDefault(s => s.ColleagueId == id);
            if (colleague != null)
            {
                _db.Colleagues.Remove(colleague);
                _db.SaveChanges();
            }
        }
    }
}
