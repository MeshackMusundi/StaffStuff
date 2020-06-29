using StaffStuff.UI.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using StaffStuff.Common;

namespace StaffStuff.UI
{
    public class UIModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RequestNavigate(RegionNames.ContentRegion, nameof(StaffView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<StaffView>();
            containerRegistry.RegisterForNavigation<StaffDetailsView>();
        }
    }
}