using Alteridem.GetChanges;

namespace GetChangesTest;

public class Tests
{
    private GitHubApi github;

    [OneTimeSetUp]
    public void Setup()
    {
        github = new GitHubApi("nunit", "nunit");
    }
    [Test]
    public async Task TestGetOpenMilestones()
    {
        var milestones = await github.GetOpenMilestones();
        Assert.That(milestones,Is.Not.Null);
        Assert.That(milestones,Has.Count.GreaterThan(0));
    }

    [Test]
    public async Task ThatWeCanLoadPullRequestOrIssue()
    {
        var pr = await github.GetIssueOrPulLRequest(4890);
        Assert.That(pr, Is.Not.Null);
        Assert.That(pr.Number, Is.EqualTo(4890));
    }

    [Test]
    public async Task ThatWeCanRetrivePulLRequestFromIssue()
    {
        var pr = await github.GetIssueOrPulLRequest(4890);
        Assert.That(pr,Is.Not.Null);
        Assert.That(pr.Number, Is.EqualTo(4884));

    }
}
