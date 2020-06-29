using System.Linq;
using Bogus;
using StaffStuff.Common.Models;

namespace StaffStuff.UI.SampleData
{
    public class SampleStaffDetailsViewModel
    {
        public Employee Employee { get; set; }

        public SampleStaffDetailsViewModel()
        {
            var faker = new Faker<Employee>()
                .RuleFor(e => e.FirstName, (f, e) => f.Name.FirstName())
                .RuleFor(e => e.LastName, (f, e) => f.Name.LastName())
                .RuleFor(e => e.Avatar, f => f.Internet.Avatar())
                .RuleFor(e => e.Email, (f, e) => f.Internet.Email(e.FirstName, e.LastName))
                .RuleFor(e => e.JobTitle, f => f.Name.JobTitle())
                .RuleFor(e => e.About, f => f.Lorem.Paragraph(10));

            Employee = faker.Generate(1).Single();
        }
    }
}
