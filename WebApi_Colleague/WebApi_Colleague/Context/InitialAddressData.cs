using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_Colleague.Models;

namespace WebApi_Colleague.Context
{
    public static class InitialAddressData
    {

        public static void Seed(this ColleagueContext dbContext)
        {
            if (!dbContext.Addresses.Any())
            {
                dbContext.Addresses.Add(new Address
                {
                    AddLine1 = "Aditya Complex",
                    AddLine2 = "Pimple Nilakh",
                    City = "Pune",
                    Zipcode = "411027",
                    State = "Maharashtra",
                    Country = "India",
                    Created = new DateTime(2022, 06, 19, 11, 45, 00)

                });
                dbContext.Addresses.Add(new Address
                {
                    AddLine1 = "Aditya Complex",
                    AddLine2 = "Pimple Nilakh",
                    City = "Pune",
                    Zipcode = "411027",
                    State = "Maharashtra",
                    Country = "India",
                    Created = new DateTime(2022, 06, 19, 11, 45, 05)
                });


                dbContext.SaveChanges();
            }
        }
    }
}
