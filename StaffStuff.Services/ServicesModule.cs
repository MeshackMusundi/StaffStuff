using Prism.Ioc;
using Prism.Modularity;
using StaffStuff.Common.Interfaces;
using StaffStuff.Services.Services;

namespace StaffStuff.Services
{
    public class ServicesModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IStaffData, StaffData>();
        }
    }
}