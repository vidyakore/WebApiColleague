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
    public class DepartmentController : ControllerBase
    {
        private ColleagueContext _db;
        public DepartmentController(ColleagueContext db)
        {
            _db = db;
        }
        // GET: AddressController
        [HttpGet]
        public IEnumerable<Department> Get()
        {
            return _db.Departments;
        }


        // GET api/<AddressController>/5
        [HttpGet("{id}")]
        public Department Get(int id)
        {
            return _db.Departments.FirstOrDefault(s => s.DepartmentId == id);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] Department value)
        {
            _db.Departments.Add(value);
            _db.SaveChanges();
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Department value)
        {
            var department = _db.Departments.FirstOrDefault(s => s.DepartmentId == id);
            if (department != null)
            {

                department.DepartmentName = value.DepartmentName;
                department.Created = value.Created;
                _db.SaveChanges();
            }
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var department = _db.Departments.FirstOrDefault(s => s.DepartmentId == id);
            if (department != null)
            {
                _db.Departments.Remove(department);
                _db.SaveChanges();
            }
        }
    }
}
