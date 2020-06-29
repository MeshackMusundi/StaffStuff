using System.Collections.Generic;
using Bogus;
using StaffStuff.Common.Interfaces;
using StaffStuff.Common.Models;

namespace StaffStuff.Services.Services
{
    public class StaffData : IStaffData
    {
        public List<Employee> GetEmployees()
        {
            var faker = new Faker<Employee>()
                .RuleFor(e => e.FirstName, (f, e) => f.Name.FirstName())
                .RuleFor(e => e.LastName, (f, e) => f.Name.LastName())
                .RuleFor(e => e.Avatar, f => f.Internet.Avatar())
                .RuleFor(e => e.Email, (f, e) => f.Internet.Email(e.FirstName, e.LastName))
                .RuleFor(e => e.JobTitle, f => f.Name.JobTitle())
                .RuleFor(e => e.About, f => f.Lorem.Paragraph(10));

            return faker.Generate(3);
        }
    }
}
