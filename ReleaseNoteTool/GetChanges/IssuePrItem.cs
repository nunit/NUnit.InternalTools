using System;
using System.Collections.Generic;
using System.Linq;
using Octokit;

namespace Alteridem.GetChanges;

public class IssuePrItem(Issue issue)
{
    public int IssueId { get; set; }
    public int PrNumber { get; set; }

    public Issue PullRequest { get; set; }

    public string Title => Issue.Title.EndsWith(".") ? Issue.Title : Issue.Title+".";
    public List<string> Labels => Issue.Labels.Select(l => l.Name).ToList();

    /// <summary>
    /// The effective PR author login (resolves bot authors to the human who triggered/merged)
    /// </summary>
    public string PrAuthorNick { get; set; } = "";

    /// <summary>
    /// The effective PR author display name
    /// </summary>
    public string PrAuthor { get; set; } = "";

    /// <summary>
    /// The effective PR author's GitHub profile URL
    /// </summary>
    public string PrAuthorUrl { get; set; } = "";

    public string ReporterNick => Issue.User.Login;

    /// <summary>
    /// The issue body text
    /// </summary>
    public string Body => Issue.Body ?? "";

    public HashSet<User> Commenters { get; set; } = [];
    public Issue Issue { get; set; } = issue;
    public HashSet<User> PullRequestCommenters { get; set; }

    /// <summary>
    /// Stores any [!IMPORTANT] note found in issue body or comments
    /// </summary>
    public string ImportantNote { get; set; }

    /// <summary>
    /// Extracts the [!IMPORTANT] callout content from a text block
    /// </summary>
    public static string ExtractImportantNote(string text)
    {
        if (string.IsNullOrEmpty(text))
            return null;

        // Look for GitHub markdown alert syntax: > [!IMPORTANT]
        var lines = text.Split('\n');
        var importantLines = new List<string>();
        bool inImportantBlock = false;

        foreach (var line in lines)
        {
            var trimmedLine = line.TrimStart();

            if (trimmedLine.StartsWith("> [!IMPORTANT]", StringComparison.OrdinalIgnoreCase))
            {
                inImportantBlock = true;
                continue; // Skip the [!IMPORTANT] marker line itself
            }

            if (inImportantBlock)
            {
                // Continue capturing lines that start with ">" (blockquote continuation)
                if (trimmedLine.StartsWith(">"))
                {
                    // Remove the leading "> " and add to our collection
                    var content = trimmedLine.Length > 1 ? trimmedLine.Substring(1).TrimStart() : "";
                    importantLines.Add(content);
                }
                else if (string.IsNullOrWhiteSpace(trimmedLine))
                {
                    // Empty line might be part of the block or end it
                    importantLines.Add("");
                }
                else
                {
                    // Non-blockquote line ends the important block
                    break;
                }
            }
        }

        if (importantLines.Count == 0)
            return null;

        // Trim trailing empty lines
        while (importantLines.Count > 0 && string.IsNullOrWhiteSpace(importantLines[importantLines.Count - 1]))
            importantLines.RemoveAt(importantLines.Count - 1);

        return string.Join("\n", importantLines);
    }
}

public class UserName
{
    /// <summary>
    /// Aka Nickname
    /// </summary>
    public string Login { get; set; }
    public string Name { get; set; }
    public string HtmlUrl { get; set; }
}


public class IssuesPrList 
{
    public HashSet<User> Users { get; set; } = [];
    public HashSet<UserName> UserNames { get; set; } = [];
    public List<IssuePrItem> Items { get; set; } = [];

    public void Add(IssuePrItem item)
    {
        Items.Add(item);
        Users.UnionWith(item.Commenters);
    }
}
