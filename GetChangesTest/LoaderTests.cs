using Alteridem.GetChanges;

namespace GetChangesTest;

internal class LoaderTests
{
    private Loader loader;

    [OneTimeSetUp]
    public void Setup()
    {
        var options = new Options
        {
            Organization = "nunit",
            Repository = "nunit",
            Milestone = "4.3",
            LinkIssues = true
        };
        loader = new Loader(options);
    }


    [Test]
    public async Task TestLoadMilestone()
    {
        await loader.LoadMilestone();
        Assert.That(loader.Milestone, Is.Not.Null);
    }

    [Test]
    public async Task TestLoadIssues()
    {
        await loader.LoadMilestone();
        await loader.LoadIssues();
        Assert.That(loader.IssuePrItemList, Is.Not.Null);
        Assert.That(loader.IssuePrItemList.Items, Has.Count.GreaterThan(0));
        TestContext.WriteLine($"Loaded {loader.IssuePrItemList.Items.Count} issues");
    }

    [Test]
    public async Task TestLoadIssueWithPr()
    {
        var issue = await loader.Github.GetIssueOrPulLRequest(3772);
        var result = await loader.LoadIssueWithPr(issue);
        Assert.That(result, Is.Not.Null);
        Assert.That(result.PullRequest, Is.Not.Null);
        Assert.That(result.PullRequest.Number,Is.EqualTo(4850));

    }
}