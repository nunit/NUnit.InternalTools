using CommandLine;

namespace Alteridem.GetChanges
{
    public class Options
    {
        [Option('o', "org", Required = true, HelpText = "The GitHub user or organization")]
        public string Organization { get; set; }

        [Option('r', "repo", Required = true, HelpText = "The GitHub repository")]
        public string Repository { get; set; }

        [Option('l', "link", HelpText = "Link issue numbers to the issues")]
        public bool LinkIssues { get; set; }

        [Option('c', "configure", HelpText = "Configure the application")]
        public bool Configure { get; set; }
    }
}
