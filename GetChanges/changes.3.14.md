## 3.14

Total number of issues fixed in this release is : 16

### Enhancements

* [4046](https://github.com/nunit/nunit/issues/4046) Backport .NET6 test infra + build improvements from #3984 onto v3.13 branch. Fixed by team [PR 4077](https://github.com/nunit/nunit/pull/4077) ( backport of issue 3984)
* [4009](https://github.com/nunit/nunit/issues/4009) Performance degradation on many tests. Thanks to [Marko Lahma](https://github.com/lahma) for [PR 4034](https://github.com/nunit/nunit/pull/4034)
* [3859](https://github.com/nunit/nunit/issues/3859) Proper test result exception message when hitting `TimeoutAttribute`. Fixed by team [PR 4118](https://github.com/nunit/nunit/pull/4118)
* [3601](https://github.com/nunit/nunit/issues/3601) Nunit 3.10.1.0 + ReSharper 2020.1.4: Test execution delayed by ~60seconds . Thanks to [Marko Lahma](https://github.com/lahma) for [PR 4034](https://github.com/nunit/nunit/pull/4034)
* [2729](https://github.com/nunit/nunit/issues/2729) Proposal: Async test case sources. Fixed by team [PR 4390](https://github.com/nunit/nunit/pull/4390)

### Bug fixes

* [4527](https://github.com/nunit/nunit/issues/4527) Backport: NUnit.Framework 3.13.2 introduced a breaking change that conceals problems with tests. Fixed by team [PR 4104](https://github.com/nunit/nunit/pull/4104) ( backport of issue 4096 by pr 4133)
* [4525](https://github.com/nunit/nunit/issues/4525) Backport: SetupFixture should have an AttributeUsage of Inherited = false . Thanks to [TillW](https://github.com/x789) for [PR 4223](https://github.com/nunit/nunit/pull/4223) ( backport of issue 4158 by pr 4222)
* [4523](https://github.com/nunit/nunit/issues/4523) Backport: Stack overflow when running tests on machine with Thai regional format. Fixed by team [PR 4346](https://github.com/nunit/nunit/pull/4346) ( backport of issue 4246 by pr 4345)
* [4324](https://github.com/nunit/nunit/issues/4324) Backport to v3:  TextRunner accidentally disposes System.Out. Thanks to [Norm Johanson](https://github.com/normj) for [PR 4325](https://github.com/nunit/nunit/pull/4325) ( backport of issue 4319 by pr 4317)
* [4095](https://github.com/nunit/nunit/issues/4095) Is.SupersetOf and Is.SubsetOf no longer work with IImmmutableDictionary<TKey,TValue> in NUnit 3.13.3. Fixed by team [PR 4097](https://github.com/nunit/nunit/pull/4097)
* [3859](https://github.com/nunit/nunit/issues/3859) Proper test result exception message when hitting `TimeoutAttribute`. Fixed by team [PR 4118](https://github.com/nunit/nunit/pull/4118)
* [3710](https://github.com/nunit/nunit/issues/3710) Calling NUnitLite from LINQpad, can't parse assembly path. Thanks to [Norm Johanson](https://github.com/normj) for [PR 4325](https://github.com/nunit/nunit/pull/4325)
* [2466](https://github.com/nunit/nunit/issues/2466) Missing stack trace when exception occurs during OneTimeSetUp. Fixed by team [PR 4467](https://github.com/nunit/nunit/pull/4467)

### Refactorings

None

### Internal fixes

* [4524](https://github.com/nunit/nunit/issues/4524) Backport: Add .NET7 as a build target for the test suite #4170. Fixed by team [PR 4302](https://github.com/nunit/nunit/pull/4302) ( backport of issue 4170 by pr 4224)
* [4293](https://github.com/nunit/nunit/issues/4293) .NET5 Test Suite is failing on Azure DevOps for Windows. Fixed by team [PR 4296](https://github.com/nunit/nunit/pull/4296)
* [2973](https://github.com/nunit/nunit/issues/2973) Write up recommended way to test and link it from the readme. Thanks to [Bruno Juchli](https://github.com/BrunoJuchli) for [PR 2971](https://github.com/nunit/nunit/pull/2971)

### Deprecated features

None

### Others


### The following issues are marked as breaking changes

None

