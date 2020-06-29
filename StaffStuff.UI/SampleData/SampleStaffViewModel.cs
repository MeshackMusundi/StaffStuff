using System.Collections.Generic;
using Bogus;
using StaffStuff.Common.Models;

namespace StaffStuff.UI.SampleData
{
    public class SampleStaffViewModel
    {
        public List<Employee> Employees { get; set; }

        public SampleStaffViewModel()
        {
            var faker = new Faker<Employee>()
                .RuleFor(e => e.FirstName, (f, e) => f.Name.FirstName())
                .RuleFor(e => e.LastName, (f, e) => f.Name.LastName())
                .RuleFor(e => e.Avatar, f => f.Internet.Avatar())
                .RuleFor(e => e.JobTitle, f => f.Name.JobTitle());

           Employees = faker.Generate(3);
        }
    }
}
