using System;
using System.IO;

namespace Alteridem.GetChanges
{
    internal static class Secrets
    {
        public static string Token
        {
            get => File.Exists(ConfigFile) ? File.ReadAllText(ConfigFile) : string.Empty;
            set => File.WriteAllText(ConfigFile, value);
        }

        public static bool Configured =>
            !string.IsNullOrWhiteSpace(Token);

        public static void Configure()
        {
            Console.Write("Enter your GitHub API Token (See README.md): ");
            Secrets.Token = Console.ReadLine();
        }

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