using System;
using System.IO;

namespace Alteridem.GetChanges
{
    internal static class Secrets
    {
        internal static string Token
        {
            get => File.Exists(ConfigFile) ? File.ReadAllText(ConfigFile) : string.Empty;
            set => File.WriteAllText(ConfigFile, value);
        }

        internal static bool Configured =>
            !string.IsNullOrWhiteSpace(Token);

        private static string ConfigDirectory
        {
            get
            {
                var configDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "GetChanges");
                if (!Directory.Exists(configDir))
                    Directory.CreateDirectory(configDir);
                return configDir;
            }
        }

        private static string ConfigFile =>
            Path.Combine(ConfigDirectory, ".config");
    }
}