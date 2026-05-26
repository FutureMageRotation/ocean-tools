using System.IO;

namespace OceanTools.Utils
{
    public static class ConfigManager
    {
        public static string ConfigPath => "config.json";

        public static void CreateDefault()
        {
            if (!File.Exists(ConfigPath))
            {
                File.WriteAllText(ConfigPath, "{}");
            }
        }
    }
}
