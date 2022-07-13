using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_Colleague.Models;

namespace WebApi_Colleague.Context
{
    public class ColleagueContext : DbContext
    {
        
        public ColleagueContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Colleague> Colleagues { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<DeptColleague> DeptColleagues { get; set; }
        

    }
}
