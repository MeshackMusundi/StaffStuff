using Prism.Commands;
using Prism.Regions;
using StaffStuff.Common.Models;

namespace StaffStuff.UI.ViewModels
{
    public class StaffDetailsViewModel : ViewModelBase
    {
        private Employee _employee;
        public Employee Employee
        {
            get => _employee; 
            set => SetProperty(ref _employee, value); 
        }

        private IRegionNavigationJournal _journal;

        public DelegateCommand GoBackCommand { get; }
        
        public StaffDetailsViewModel(IRegionManager regionManager) : base(regionManager)
        {
            GoBackCommand = new DelegateCommand(GoBack);
        }

        private void GoBack() => _journal.GoBack();

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            Employee = navigationContext.Parameters[nameof(Employee)] as Employee;
            _journal = navigationContext.NavigationService.Journal;
        }
    }
}
