using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using HtmlAgilityPack;

class Program
{
    static async Task Main(string[] args)
    {
        // GitHub API details
        const string repoOwner = "nunit";
        const string repoName = "nunit";
      
        const string baseUrl = $"https://api.github.com/repos/{repoOwner}/{repoName}/issues";

        // List of issue numbers
        var issueNumbers = new[]
        {
            4876, 4890, 4886, 4862, 4861, 4852, 4846, 4839, 4832, 4811, 4771, 2492,
            4887, 4877, 4875, 4874, 4868, 4836, 4807, 4281, 3772, 3713,
            150, 4865, 4841, 4819, 4798
        };

        using var httpClient = new HttpClient();
        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("token", token);
        httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("ConsoleApp");

        foreach (var issueNumber in issueNumbers)
        {
            var issueUrl = $"https://github.com/{repoOwner}/{repoName}/issues/{issueNumber}";
            try
            {
                // Step 1: Retrieve the issue's HTML content
                var htmlResponse = await httpClient.GetStringAsync(issueUrl);

                // Step 2: Parse the HTML to find the pull request link
                var htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(htmlResponse);

                // Find the div with the class "css-truncate my-1" and extract the <a> href
                var my1Nodes = htmlDoc.DocumentNode.SelectNodes("//div[contains(@class, 'my-1')]");
                bool prFound = false;
                if (my1Nodes != null)
                {
                    foreach (var node in my1Nodes)
                    {
                        // Check if this node contains "pull" in its HTML
                        if (node.InnerHtml.Contains("/pull/"))
                        {
                            prFound = true;
                            // Find the first <a> tag within this specific div
                            var firstAnchor = node.SelectSingleNode(".//a[contains(@href, '/pull/')]");
                            if (firstAnchor != null)
                            {
                                var relativePrUrl = firstAnchor.GetAttributeValue("href", null);
                                if (!string.IsNullOrEmpty(relativePrUrl))
                                {
                                    // Build the full URL
                                    var prNumber = relativePrUrl.Split('/').Last();

                                    // Print result in "issueNumber, prNumber" format
                                    Console.WriteLine($"{issueNumber}, {prNumber}");
                                }
                                else
                                {
                                    Console.WriteLine($"{issueNumber}, No linked pull request found");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"{issueNumber}, No <a> tag with /pull/ found in div");
                            }
                            break; // Stop after processing the correct div
                        }
                    }
                    if (!prFound)
                    {
                        Console.WriteLine($"{issueNumber}, No pull request found");
                    }
                }
                else
                {
                    Console.WriteLine($"{issueNumber}, No 'my-1' divs found");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Issue {issueNumber}, Exception: {ex.Message}");
            }
        }


    }
}
