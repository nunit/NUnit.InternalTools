## 4.2

There are 37 issues fixed in this release.

### Enhancements

* [4777](https://github.com/nunit/nunit/issues/4777) Publicly expose `IgnoreAttribute.Reason`. Thanks to [Michael Render](https://github.com/RenderMichael) for [PR 4781](https://github.com/nunit/nunit/pull/4781)
* [4738](https://github.com/nunit/nunit/issues/4738) QoL suggestion: fail fast in Assert.Multiple under debugger. Thanks to [MaceWindu](https://github.com/MaceWindu) for [PR 4749](https://github.com/nunit/nunit/pull/4749)
* [4710](https://github.com/nunit/nunit/issues/4710) Improve PropertiesComparer diagnostics. Fixed by team [PR 4712](https://github.com/nunit/nunit/pull/4712)
* [4686](https://github.com/nunit/nunit/issues/4686) Provide a ProgressTraceListener to redirect Trace output to the NUnit Progress output. Thanks to [maettu-this](https://github.com/maettu-this) for [PR 4709](https://github.com/nunit/nunit/pull/4709)
* [4353](https://github.com/nunit/nunit/issues/4353) TestContext.AddTestAttachment with long file paths. Thanks to [Rohit Aggarwal](https://github.com/Meet2rohit99) for [PR 4665](https://github.com/nunit/nunit/pull/4665)
* [4134](https://github.com/nunit/nunit/issues/4134) NUnit 3 console does not display logs from background thread from a library. Thanks to [maettu-this](https://github.com/maettu-this) for [PR 4709](https://github.com/nunit/nunit/pull/4709)
* [3918](https://github.com/nunit/nunit/issues/3918) String comparison without whitespace. Fixed by team [PR 4664](https://github.com/nunit/nunit/pull/4664)
* [3829](https://github.com/nunit/nunit/issues/3829) Consider optimizing `StreamsComparer` for happy path. Thanks to [Mithilesh Zavar](https://github.com/mithileshz) for [PR 4668](https://github.com/nunit/nunit/pull/4668)
* [3767](https://github.com/nunit/nunit/issues/3767) Incorrect number of items listed in failure message. Thanks to [Dmitrij](https://github.com/iamdmitrij) for [PR 4702](https://github.com/nunit/nunit/pull/4702)
* [1396](https://github.com/nunit/nunit/issues/1396) Class Level Category Missing from TestContext. Fixed by team [PR 4757](https://github.com/nunit/nunit/pull/4757)
* [796](https://github.com/nunit/nunit/issues/796) `TestContext.CurrentContext.Test.Properties` from TestFixture should be available from `TestContext` for Test. Fixed by team [PR 4757](https://github.com/nunit/nunit/pull/4757)
* [548](https://github.com/nunit/nunit/issues/548) Properties set on a parameterized method are not accessible to TestContext. Fixed by team [PR 4757](https://github.com/nunit/nunit/pull/4757)
* [4587](https://github.com/nunit/nunit/issues/4587) Feature request: Assert.Multiple() could return an IDisposable, avoiding passing an Action around.. Fixed by team [PR 4758](https://github.com/nunit/nunit/pull/4758)

### Bug fixes

* [4782](https://github.com/nunit/nunit/issues/4782) Bug report: [ValueSource] doesn't play nice with [CancelAfter]. Fixed by team [PR 4783](https://github.com/nunit/nunit/pull/4783)
* [4770](https://github.com/nunit/nunit/issues/4770) Bug report: [Values] doesn't play nice with [CancelAfter]. Fixed by team [PR 4774](https://github.com/nunit/nunit/pull/4774)
* [4750](https://github.com/nunit/nunit/issues/4750) `DefaultFloatingPointTolerance` ignored for `TestCaseData`. Fixed by team [PR 4754](https://github.com/nunit/nunit/pull/4754)
* [4723](https://github.com/nunit/nunit/issues/4723) CurrentContext.Result.Outcome.Status is inconclusive in TearDown if Timeout attribute is used in 4.x. Fixed by team [PR 4727](https://github.com/nunit/nunit/pull/4727)
* [4705](https://github.com/nunit/nunit/issues/4705) The dll's in the release 4.1 has version 4.0.1. Fixed by team [PR 4706](https://github.com/nunit/nunit/pull/4706)
* [4670](https://github.com/nunit/nunit/issues/4670) `.ContainKey().WithValue()` and `.Or`/`.And` interact incorrectly. Fixed by team [PR 4672](https://github.com/nunit/nunit/pull/4672)
* [4659](https://github.com/nunit/nunit/issues/4659) TestCaseSource that contains Exception with InnerException - not running tests. Fixed by team [PR 4663](https://github.com/nunit/nunit/pull/4663)
* [4651](https://github.com/nunit/nunit/issues/4651) After upgrade from version 3.14.0 to 4.* running multiple test categories in parentheses separated with 'OR' stopped working. Fixed by team [PR 4760](https://github.com/nunit/nunit/pull/4760)
* [4639](https://github.com/nunit/nunit/issues/4639) `ValueTask` is not being properly consumed by the `AwaitAdapter`. Fixed by team [PR 4640](https://github.com/nunit/nunit/pull/4640)
* [4598](https://github.com/nunit/nunit/issues/4598) DefaultTimeout in .runsettings + TearDown method seems to break test output. Fixed by team [PR 4692](https://github.com/nunit/nunit/pull/4692)
* [4589](https://github.com/nunit/nunit/issues/4589) Exception when using test filters from .runsettings or --filter argument from dotnet test. Fixed by team [PR 4760](https://github.com/nunit/nunit/pull/4760)
* [4584](https://github.com/nunit/nunit/issues/4584) Nunit 4.0.x Test case selection is incorrect with certain test data. Fixed by team [PR 4773](https://github.com/nunit/nunit/pull/4773)
* [1358](https://github.com/nunit/nunit/issues/1358) TestContext.CurrentContext.Test.Properties does not contain value(s) from PropertyAttribute when using TestCaseAttribute. Fixed by team [PR 4757](https://github.com/nunit/nunit/pull/4757)

### Refactorings

* [4577](https://github.com/nunit/nunit/issues/4577) Remove some version hard-coding in the OSPlatformTranslator. Fixed by team [PR 4756](https://github.com/nunit/nunit/pull/4756)

### Internal fixes

* [4735](https://github.com/nunit/nunit/issues/4735) StreamComparer - Pool allocating the byte array reduces memory allocation by 96%. Thanks to [Mithilesh Zavar](https://github.com/mithileshz) for [PR 4737](https://github.com/nunit/nunit/pull/4737)
* [4733](https://github.com/nunit/nunit/issues/4733) Improve speed of Randomizer.GetString. Fixed by team [PR 4512](https://github.com/nunit/nunit/pull/4512)
* [3981](https://github.com/nunit/nunit/issues/3981) Switch default branch to main. Fixed by team [PR 4753](https://github.com/nunit/nunit/pull/4753)
* [4649](https://github.com/nunit/nunit/issues/4649) Switch to using MacOS 14 in GitHub Actions. Fixed by team [PR 4648](https://github.com/nunit/nunit/pull/4648)
* [3757](https://github.com/nunit/nunit/issues/3757) Re-Add WinForms and WPF based tests. Fixed by team [PR 4776](https://github.com/nunit/nunit/pull/4776)

### Deprecated features

None

### Others

* [4765](https://github.com/nunit/nunit/issues/4765) Document ThrowOnEachFailurUnderDebugger.
* [4730](https://github.com/nunit/nunit/issues/4730) Remove reference to the mailing list from CONTRIBUTING.md. Fixed by team [PR 4752](https://github.com/nunit/nunit/pull/4752)
* [4726](https://github.com/nunit/nunit/issues/4726) `Using&lt;TCollectionType, TMemberType&gt;` is unclear. Thanks to [Michael Render](https://github.com/RenderMichael) for [PR 4729](https://github.com/nunit/nunit/pull/4729)
* [4684](https://github.com/nunit/nunit/issues/4684) Increment StreamsComparer by 'Actual bytes read' rather than the buffer size. Fixed by team [PR 4671](https://github.com/nunit/nunit/pull/4671)

### The following issues are marked as breaking changes

None

