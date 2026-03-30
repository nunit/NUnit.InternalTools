using System.Linq;
using Octokit;

namespace Alteridem.GetChanges;

public static class Extensions
{
    public static bool LabelExist(this Issue issue, string labelName)
    {
        return issue.Labels.FirstOrDefault(l => l.Name == labelName) != null;
    }

    public static bool LabelStartsWith(this IssuePrItem issue, string labelName)
    {
        return issue.Labels.FirstOrDefault(l => l.StartsWith(labelName)) != null;
    }

    /// <summary>
    /// IssueId is either not labeled with closed: or is labeled with closed:done
    /// </summary>
    public static bool ClosedDone(this Issue issue)
    {
        var label = issue.Labels.FirstOrDefault(l => l.Name.StartsWith("closed:"));
        return label == null || label.Name.EndsWith("done");
    }
}