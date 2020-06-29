using System.Collections.Generic;
using StaffStuff.Common.Models;

namespace StaffStuff.Common.Interfaces
{
    public interface IStaffData
    {
        List<Employee> GetEmployees();
    }
}
