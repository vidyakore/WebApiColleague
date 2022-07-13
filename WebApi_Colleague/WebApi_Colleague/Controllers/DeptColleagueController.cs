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
    public class DeptColleagueController : ControllerBase
    {
        private ColleagueContext _db;
        public DeptColleagueController(ColleagueContext db)
        {
            _db = db;
        }
        // GET: AddressController
        [HttpGet]
        public IEnumerable<DeptColleague> Get()
        {
            return _db.DeptColleagues;
        }


        // GET api/<AddressController>/5
        [HttpGet("{id}")]
        public DeptColleague Get(int id)
        {
            return _db.DeptColleagues.FirstOrDefault(s => s.id == id);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] DeptColleague value)
        {
            _db.DeptColleagues.Add(value);
            _db.SaveChanges();
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DeptColleague value)
        {
            var deptColleague = _db.DeptColleagues.FirstOrDefault(s => s.id == id);
            if (deptColleague != null)
            {

                deptColleague.ColleagueId = value.ColleagueId;
                deptColleague.DepartmentId = value.DepartmentId;
                
                _db.SaveChanges();
            }
            
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var deptColleague = _db.DeptColleagues.FirstOrDefault(s => s.id == id);
            if (deptColleague != null)
            {
                _db.DeptColleagues.Remove(deptColleague);
                _db.SaveChanges();
            }
        }
    }
}
