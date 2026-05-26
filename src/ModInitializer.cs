using OceanTools.Features;

namespace OceanTools.Core
{
    public class ModInitializer
    {
        public static void Start()
        {
            NavigationSystem.Initialize();
            ScannerSystem.Initialize();
            CompassUI.Initialize();
            ExplorationTools.Initialize();
        }
    }
}
