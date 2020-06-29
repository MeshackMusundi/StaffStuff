using System.Collections.Generic;
using Prism.Commands;
using Prism.Regions;
using StaffStuff.Common;
using StaffStuff.Common.Interfaces;
using StaffStuff.Common.Models;

namespace StaffStuff.UI.ViewModels
{
    public class StaffViewModel : ViewModelBase
    {
        private List<Employee> _employees;
        public List<Employee> Employees
        {
            get => _employees;
            set => SetProperty(ref _employees, value);
        }

        public DelegateCommand<Employee> EmployeeDetailsCommand { get; }

        public StaffViewModel(IStaffData staffData, IRegionManager regionManager) : base(regionManager)
        {
            Employees = staffData.GetEmployees();
            EmployeeDetailsCommand = new DelegateCommand<Employee>(StaffDetails);
        }

        private void StaffDetails(Employee employee)
        {
            var parameters = new NavigationParameters();
            parameters.Add(nameof(Employee), employee);

            RegionManager.RequestNavigate(RegionNames.ContentRegion, "StaffDetailsView", parameters);
        }
    }
}
