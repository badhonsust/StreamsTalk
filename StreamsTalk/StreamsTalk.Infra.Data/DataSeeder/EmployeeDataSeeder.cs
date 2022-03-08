using StreamsTalk.Domain.Entities;
using System.Collections.Generic;

namespace StreamsTalk.Infra.Data.DataSeeder
{
    public class EmployeeDataSeeder
    {
        public static List<Employee> SeedData()
        {
            var data = new List<Employee>
            {
                new Employee { FirstName = "Md", MiddleName = "Badhon", LastName = "AshfaQ" },
                new Employee { FirstName = "John", MiddleName = "Max", LastName = "Well" },
                new Employee { FirstName = "Tom", MiddleName = "Tang", LastName = "Goong" },
                new Employee { FirstName = "Tokio", MiddleName = "Servei", LastName = "Oscer" },
                new Employee { FirstName = "Mark", MiddleName = "Tiger", LastName = "Allen" },
                new Employee { FirstName = "Alen", MiddleName = "Max", LastName = "Pirer" },
                new Employee { FirstName = "Rasell", MiddleName = "Shaw", LastName = "Barnerd" },
                new Employee { FirstName = "Envy", MiddleName = "Goodwill", LastName = "John" }
            };
            return data;
        }

    }
}
