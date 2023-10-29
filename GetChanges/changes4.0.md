## 4.0

Total number of issues fixed in this release is : 105

### Enhancements

* [4521](https://github.com/nunit/nunit/issues/4521) Proposal: Async test case sources . Fixed by team [PR 4389](https://github.com/nunit/nunit/pull/4389)
* [4489](https://github.com/nunit/nunit/issues/4489) Use buffer pooling when calculating partition filters. Fixed by team [PR 4500](https://github.com/nunit/nunit/pull/4500)
* [4433](https://github.com/nunit/nunit/issues/4433) Add string syntax attributes (.NET 7+). Thanks to [Michael Render](https://github.com/RenderMichael) for [PR 4425](https://github.com/nunit/nunit/pull/4425)
* [4431](https://github.com/nunit/nunit/issues/4431) Improving error message handling and performing assert consolidation. Fixed by team [PR 4430](https://github.com/nunit/nunit/pull/4430)
* [4421](https://github.com/nunit/nunit/issues/4421) Add support for native .NET-6.0 target . Fixed by team [PR 4431](https://github.com/nunit/nunit/pull/4431)
* [4413](https://github.com/nunit/nunit/issues/4413) Assert.That methods should autogenerate message, if null. Fixed by team [PR 4419](https://github.com/nunit/nunit/pull/4419)
* [4394](https://github.com/nunit/nunit/issues/4394) Expand NUnitEquality to use Equality of all Properties. Fixed by team [PR 4436](https://github.com/nunit/nunit/pull/4436)
* [4391](https://github.com/nunit/nunit/issues/4391) Hash/Partition based Test Filter. Thanks to [Andrew Armstrong](https://github.com/Plasma) for [PR 4392](https://github.com/nunit/nunit/pull/4392)
* [4385](https://github.com/nunit/nunit/issues/4385) Add support for Test Cancellation. Fixed by team [PR 4386](https://github.com/nunit/nunit/pull/4386)
* [4355](https://github.com/nunit/nunit/issues/4355) Allow Is.AnyOf to be called with arrays or other collections. Fixed by team [PR 4356](https://github.com/nunit/nunit/pull/4356)
* [4149](https://github.com/nunit/nunit/issues/4149) Distribute optimized framework builds with easy debugging. Thanks to [Marko Lahma](https://github.com/lahma) for [PR 4350](https://github.com/nunit/nunit/pull/4350)
* [4144](https://github.com/nunit/nunit/issues/4144) Stderr/Console.Error will hold back unicode escaped log messages. Thanks to [Max Schmitt](https://github.com/mxschmitt) for [PR 4145](https://github.com/nunit/nunit/pull/4145)
* [4101](https://github.com/nunit/nunit/issues/4101) Expose ExpectedResult to the TestContext. Fixed by team [PR 4239](https://github.com/nunit/nunit/pull/4239)
* [4086](https://github.com/nunit/nunit/issues/4086) Perform case-insensitive string comparisons in-place. Fixed by team [PR 4088](https://github.com/nunit/nunit/pull/4088)
* [4053](https://github.com/nunit/nunit/issues/4053) Cache method discovery by migrating PR 4034 to main. Fixed by team [PR 4208](https://github.com/nunit/nunit/pull/4208)
* [3984](https://github.com/nunit/nunit/issues/3984) Add net6.0 targets. Fixed by team [PR 3988](https://github.com/nunit/nunit/pull/3988)
* [3936](https://github.com/nunit/nunit/issues/3936) Is there any way we could make use of CallerArgumentExpressionAttribute?. Fixed by team [PR 4419](https://github.com/nunit/nunit/pull/4419)
* [3899](https://github.com/nunit/nunit/issues/3899) Allow randomizing 'Guid' test arguments with [Random]. Thanks to [Arnaud TAMAILLON](https://github.com/Greybird) for [PR 3951](https://github.com/nunit/nunit/pull/3951)
* [3866](https://github.com/nunit/nunit/issues/3866) SupportedOSPlatform. Fixed by team [PR 3926](https://github.com/nunit/nunit/pull/3926)
* [3856](https://github.com/nunit/nunit/issues/3856) Theories in nested Testfixtures. Thanks to [Felix Krîner](https://github.com/Crown0815) for [PR 3857](https://github.com/nunit/nunit/pull/3857)
* [3718](https://github.com/nunit/nunit/issues/3718) Improve readability of "assert failed" message for DictionaryContainsKeyValuePairConstraint WithValue(). Fixed by team [PR 3778](https://github.com/nunit/nunit/pull/3778)
* [3457](https://github.com/nunit/nunit/issues/3457) Add DefaultConstraint. Thanks to [Oleksandr Liakhevych](https://github.com/Dreamescaper) for [PR 3781](https://github.com/nunit/nunit/pull/3781)
* [3432](https://github.com/nunit/nunit/issues/3432) Assert.That is blocking and might lead to deadlock when used with WCF.. Thanks to [Gavin Lambert](https://github.com/uecasm) for [PR 4322](https://github.com/nunit/nunit/pull/4322)
* [2843](https://github.com/nunit/nunit/issues/2843) Replacing ThrowsAsync with a composable async alternative. Thanks to [Gavin Lambert](https://github.com/uecasm) for [PR 4322](https://github.com/nunit/nunit/pull/4322)
* [1459](https://github.com/nunit/nunit/issues/1459) Support for params keyword in parameterized test fixtures. Thanks to [](https://github.com/Shiney) for [PR 4478](https://github.com/nunit/nunit/pull/4478)

### Bug fixes

* [4529](https://github.com/nunit/nunit/issues/4529) Forwardport: Missing stack trace when exception occurs during OneTimeSetUp #2466. Fixed by team [PR 4469](https://github.com/nunit/nunit/pull/4469)
* [4528](https://github.com/nunit/nunit/issues/4528) Forwardport: Is.SupersetOf and Is.SubsetOf no longer work with IImmmutableDictionary&lt;TKey,TValue&gt; in NUnit 3.13.3 #4095. Fixed by team [PR 4098](https://github.com/nunit/nunit/pull/4098)
* [4522](https://github.com/nunit/nunit/issues/4522) Missing stack trace when exception occurs during OneTimeSetUp #2466. Fixed by team [PR 4469](https://github.com/nunit/nunit/pull/4469)
* [4491](https://github.com/nunit/nunit/issues/4491) NUnit 4.0 fails when [Repeat] is present and test passes. Fixed by team [PR 4517](https://github.com/nunit/nunit/pull/4517)
* [4484](https://github.com/nunit/nunit/issues/4484) String not-regex constraint succeeds non-`string` actual value. Thanks to [Michael Render](https://github.com/RenderMichael) for [PR 4492](https://github.com/nunit/nunit/pull/4492)
* [4450](https://github.com/nunit/nunit/issues/4450) Missing comparison failure details for EqualTo when comparing two collection. Thanks to [Ashish Dawale](https://github.com/ashishdawale20) for [PR 4502](https://github.com/nunit/nunit/pull/4502)
* [4423](https://github.com/nunit/nunit/issues/4423) Chaining multiple collection asserts with index. Thanks to [Daniel Waechtler](https://github.com/crabstars) for [PR 4480](https://github.com/nunit/nunit/pull/4480)
* [4400](https://github.com/nunit/nunit/issues/4400) Within throws ArgumentException if null value is involved. Thanks to [Ashish Dawale](https://github.com/ashishdawale20) for [PR 4482](https://github.com/nunit/nunit/pull/4482)
* [4319](https://github.com/nunit/nunit/issues/4319) TextRunner accidentally disposes System.Out. Thanks to [Norm Johanson](https://github.com/normj) for [PR 4317](https://github.com/nunit/nunit/pull/4317)
* [4308](https://github.com/nunit/nunit/issues/4308) Random attribute with Distinct and wide range causes test to disappear. Thanks to [Russell Smith](https://github.com/mr-russ) for [PR 4316](https://github.com/nunit/nunit/pull/4316)
* [4264](https://github.com/nunit/nunit/issues/4264) Assert.Multiple method should fail only if a contained assertion failed. Thanks to [Samuel Delarosbil](https://github.com/sdelarosbil) for [PR 4313](https://github.com/nunit/nunit/pull/4313)
* [4259](https://github.com/nunit/nunit/issues/4259) Bug: Assert.That(IEnumerable&lt;Type&gt;, Has.All.Property(nameof(Type.Namespace)) fails.. Fixed by team [PR 4260](https://github.com/nunit/nunit/pull/4260)
* [4255](https://github.com/nunit/nunit/issues/4255) InternalTrace.Initialize fails with Nullref exception. Fixed by team [PR 4256](https://github.com/nunit/nunit/pull/4256)
* [4246](https://github.com/nunit/nunit/issues/4246) Stack overflow when running tests on machine with Thai regional format. Fixed by team [PR 4345](https://github.com/nunit/nunit/pull/4345)
* [4243](https://github.com/nunit/nunit/issues/4243) Type args are not deduced correctly for parameterized fixtures. Thanks to [Samuel Delarosbil](https://github.com/sdelarosbil) for [PR 4307](https://github.com/nunit/nunit/pull/4307)
* [4237](https://github.com/nunit/nunit/issues/4237) Bogus check for Windows 11. Fixed by team [PR 4374](https://github.com/nunit/nunit/pull/4374)
* [4158](https://github.com/nunit/nunit/issues/4158) SetupFixture should have an `AttributeUsage` of `Inherited = false`. Thanks to [TillW](https://github.com/x789) for [PR 4222](https://github.com/nunit/nunit/pull/4222)
* [4107](https://github.com/nunit/nunit/issues/4107) Incorrect type specified for Values attribute fails unrelated tests. Fixed by team [PR 4133](https://github.com/nunit/nunit/pull/4133)
* [4096](https://github.com/nunit/nunit/issues/4096) NUnit.Framework 3.13.2 introduced a breaking change that conceals problems with tests. Fixed by team [PR 4133](https://github.com/nunit/nunit/pull/4133)
* [3964](https://github.com/nunit/nunit/issues/3964) DictionaryContainsKeyValuePairConstraint doesn't work with `IDictionary&lt;TKey, TValue&gt;`. Thanks to [Louis Zanella](https://github.com/louis-z) for [PR 4014](https://github.com/nunit/nunit/pull/4014)
* [3961](https://github.com/nunit/nunit/issues/3961) OneTimeTearDown runs on a new thread with mismatched Thread Name and Worker Id. Thanks to [](https://github.com/EraserKing) for [PR 4004](https://github.com/nunit/nunit/pull/4004)
* [3953](https://github.com/nunit/nunit/issues/3953) Dispose is not called on test fixtures with LifeCycle.InstancePerTestCase without TearDown method. Fixed by team [PR 3963](https://github.com/nunit/nunit/pull/3963)
* [3872](https://github.com/nunit/nunit/issues/3872) Add support for `ref bool`, `ref bool?`, `in bool`, and `in bool?` when using `NUnit.Framework.ValuesAttribute`. Thanks to [Samuel Delarosbil](https://github.com/sdelarosbil) for [PR 4304](https://github.com/nunit/nunit/pull/4304)
* [3868](https://github.com/nunit/nunit/issues/3868) Order attribute skips classes with multiple test fixtures. Thanks to [Samuel Delarosbil](https://github.com/sdelarosbil) for [PR 4304](https://github.com/nunit/nunit/pull/4304)
* [3867](https://github.com/nunit/nunit/issues/3867) nunit Framework tests do not run with "dotnet test" nor inside VS2019 (Windows). Fixed by team [PR 4315](https://github.com/nunit/nunit/pull/4315)
* [3858](https://github.com/nunit/nunit/issues/3858) Running tests with ITestAction attributes leaks memory. Thanks to [Marko Lahma](https://github.com/lahma) for [PR 4300](https://github.com/nunit/nunit/pull/4300)
* [3811](https://github.com/nunit/nunit/issues/3811) Incorrect summary comments on Warn.If overloads. Fixed by team [PR 3845](https://github.com/nunit/nunit/pull/3845)
* [3735](https://github.com/nunit/nunit/issues/3735) Parallelizable TestFixtureSource with TestFixtureData not running in parallel. Thanks to [Julien Richard](https://github.com/jairbubbles) for [PR 4099](https://github.com/nunit/nunit/pull/4099)
* [3449](https://github.com/nunit/nunit/issues/3449) Assert.AreEqual overloads for nullable double are not useful. Thanks to [Anton Ashmarin](https://github.com/Antash) for [PR 3780](https://github.com/nunit/nunit/pull/3780)
* [3274](https://github.com/nunit/nunit/issues/3274) Overriden tests are not discovered in NUnit 3.12.0. Fixed by team [PR 4490](https://github.com/nunit/nunit/pull/4490)
* [3215](https://github.com/nunit/nunit/issues/3215) Better error message for generic test where type parameter cannot be determined. Thanks to [Ove Bastiansen](https://github.com/ovebastiansen) for [PR 4382](https://github.com/nunit/nunit/pull/4382)
* [2870](https://github.com/nunit/nunit/issues/2870) CollectionTally (EquivalentTo) should throw for non-transitive comparisons. Thanks to [Russell Smith](https://github.com/mr-russ) for [PR 4312](https://github.com/nunit/nunit/pull/4312)
* [2841](https://github.com/nunit/nunit/issues/2841) DelayedConstraint calls delegate twice. Fixed by team [PR 4488](https://github.com/nunit/nunit/pull/4488)
* [2436](https://github.com/nunit/nunit/issues/2436) Properties on System.Type cannot be used with either property constraint. Fixed by team [PR 4259](https://github.com/nunit/nunit/pull/4259)
* [1428](https://github.com/nunit/nunit/issues/1428) NUnitLite package always installs both Program.cs and Program.vb. Fixed by team [PR 3952](https://github.com/nunit/nunit/pull/3952)

### Refactorings

* [4434](https://github.com/nunit/nunit/issues/4434) Fixing the classic asserts. Fixed by team [PR 4438](https://github.com/nunit/nunit/pull/4438)
* [4416](https://github.com/nunit/nunit/issues/4416) Move classic asserts into its own project . Fixed by team [PR 4417](https://github.com/nunit/nunit/pull/4417)
* [4380](https://github.com/nunit/nunit/issues/4380) Consistently use _ prefix for field names. Fixed by team [PR 4387](https://github.com/nunit/nunit/pull/4387)
* [4378](https://github.com/nunit/nunit/issues/4378) Update code base to use 'is (not) null' consistently. Fixed by team [PR 4379](https://github.com/nunit/nunit/pull/4379)
* [4376](https://github.com/nunit/nunit/issues/4376) Update code base to explicitly specify accessibility. Fixed by team [PR 4377](https://github.com/nunit/nunit/pull/4377)
* [4364](https://github.com/nunit/nunit/issues/4364) Add NUnit.Analyzer to our test projects. Fixed by team [PR 4366](https://github.com/nunit/nunit/pull/4366)
* [4111](https://github.com/nunit/nunit/issues/4111) `Is.Empty` constraint on complex collections might hide bugs. Thanks to [Felix Krîner](https://github.com/Crown0815) for [PR 4120](https://github.com/nunit/nunit/pull/4120)
* [4051](https://github.com/nunit/nunit/issues/4051) Update codebase to use Array.Empty&lt;T&gt;. Thanks to [Marcin Jedrzejek](https://github.com/mjedrzejek) for [PR 4127](https://github.com/nunit/nunit/pull/4127)
* [3932](https://github.com/nunit/nunit/issues/3932) Make `Numerics` class internal. Thanks to [TillW](https://github.com/x789) for [PR 4205](https://github.com/nunit/nunit/pull/4205)

### Internal fixes

* [4432](https://github.com/nunit/nunit/issues/4432) Fix null message in internal static string? ExtendedMessage(string methodName, string? message, string actualExpression, string constraintExpression). Fixed by team [PR 4430](https://github.com/nunit/nunit/pull/4430)
* [4331](https://github.com/nunit/nunit/issues/4331) Add testing to "Accumulate further failures if any on AssertMultiple instead of throwing". Thanks to [Samuel Delarosbil](https://github.com/sdelarosbil) for [PR 4313](https://github.com/nunit/nunit/pull/4313)
* [4212](https://github.com/nunit/nunit/issues/4212) Add Windows11 support to the Platform attribute. Fixed by team [PR 4213](https://github.com/nunit/nunit/pull/4213)
* [4170](https://github.com/nunit/nunit/issues/4170) Add .NET7 as a build target for the test suite . Fixed by team [PR 4224](https://github.com/nunit/nunit/pull/4224)
* [4078](https://github.com/nunit/nunit/issues/4078) THREAD_ABORT not properly set. Fixed by team [PR 4079](https://github.com/nunit/nunit/pull/4079)
* [4075](https://github.com/nunit/nunit/issues/4075) Remove unnecessary allocations in NUnitEqualityComparer. Fixed by team [PR 4076](https://github.com/nunit/nunit/pull/4076)
* [4072](https://github.com/nunit/nunit/issues/4072) Use pattern matching in Constraints to avoid unecessary casts. Fixed by team [PR 4073](https://github.com/nunit/nunit/pull/4073)
* [4065](https://github.com/nunit/nunit/issues/4065) Use pattern matching in the comparers. Fixed by team [PR 4066](https://github.com/nunit/nunit/pull/4066)
* [4055](https://github.com/nunit/nunit/issues/4055) Use static Regex.IsMatch in ValueMatchFilter to take advantage of caching. Fixed by team [PR 4056](https://github.com/nunit/nunit/pull/4056)
* [4049](https://github.com/nunit/nunit/issues/4049) Simplify property retrieval in DefaultTestAssemblyBuilder.Build(). Thanks to [Scott Buchanan](https://github.com/Phyrik) for [PR 4054](https://github.com/nunit/nunit/pull/4054)
* [3935](https://github.com/nunit/nunit/issues/3935) `Numerics.IsFixedPointNumeric` should return false for decimals. Thanks to [Wellington Balbo](https://github.com/wbalbo) for [PR 3942](https://github.com/nunit/nunit/pull/3942)
* [3789](https://github.com/nunit/nunit/issues/3789) Change copyright header on files. Fixed by team [PR 3795](https://github.com/nunit/nunit/pull/3795)
* [3764](https://github.com/nunit/nunit/issues/3764) Switch to the dotnet tool version of Cake. Fixed by team [PR 3835](https://github.com/nunit/nunit/pull/3835)
* [2485](https://github.com/nunit/nunit/issues/2485) Remove\Trim copyright on individual files. Fixed by team [PR 3795](https://github.com/nunit/nunit/pull/3795)

### Deprecated features

* [4415](https://github.com/nunit/nunit/issues/4415) Remove use of params for messages. Fixed by team [PR 4419](https://github.com/nunit/nunit/pull/4419)
* [4036](https://github.com/nunit/nunit/issues/4036) Drop net45 build target in nunit4. Fixed by team [PR 4050](https://github.com/nunit/nunit/pull/4050)
* [3980](https://github.com/nunit/nunit/issues/3980) Drop netcoreapp2.1 targets. Fixed by team [PR 3988](https://github.com/nunit/nunit/pull/3988)
* [3769](https://github.com/nunit/nunit/issues/3769) Remove code marked "Obsolete". Fixed by team [PR 3836](https://github.com/nunit/nunit/pull/3836)
* [3758](https://github.com/nunit/nunit/issues/3758) Drop .NET 3.5 Build Targets. Fixed by team [PR 3760](https://github.com/nunit/nunit/pull/3760)
* [3708](https://github.com/nunit/nunit/issues/3708) Drop .NET 4.0 Build Target. Fixed by team [PR 3760](https://github.com/nunit/nunit/pull/3760)
* [3410](https://github.com/nunit/nunit/issues/3410) Consider deprecating NUnitEqualityComparer.AreEqual optional bool parameter. Thanks to [TillW](https://github.com/x789) for [PR 3960](https://github.com/nunit/nunit/pull/3960)
* [3132](https://github.com/nunit/nunit/issues/3132) Remove AssertionHelper and AssertionHelperTests. Fixed by team [PR 3836](https://github.com/nunit/nunit/pull/3836)

### Others

* [4504](https://github.com/nunit/nunit/issues/4504) Remove appveyor build. Fixed by team [PR 4509](https://github.com/nunit/nunit/pull/4509)
* [4112](https://github.com/nunit/nunit/issues/4112) Update documentation to clarify passing parameters to test cases. Thanks to [Aaron Franke](https://github.com/aaronfranke) for [PR 4114](https://github.com/nunit/nunit/pull/4114)
* [3989](https://github.com/nunit/nunit/issues/3989) Revisit build documentation relating to IDEs. Fixed by team [PR 4050](https://github.com/nunit/nunit/pull/4050)
* [3869](https://github.com/nunit/nunit/issues/3869) Copyright notices for third-party code. Thanks to [Lennart BrÅggemann](https://github.com/lennartb-) for [PR 4444](https://github.com/nunit/nunit/pull/4444)
* [3812](https://github.com/nunit/nunit/issues/3812) Add GitHub Actions. Fixed by team [PR 3819](https://github.com/nunit/nunit/pull/3819)
* [3798](https://github.com/nunit/nunit/issues/3798) Support abstract methods marked as tests. Fixed by team [PR 4490](https://github.com/nunit/nunit/pull/4490)
* [3376](https://github.com/nunit/nunit/issues/3376) Nullable Reference Types annotations. Fixed by team through multiple PRs. . Fixed by team [PR 3488](https://github.com/nunit/nunit/pull/3488)
* [3301](https://github.com/nunit/nunit/issues/3301) [HandleProcessCorruptedStateExceptions] has no effect unless we disable partial trust. Fixed by team [PR 4398](https://github.com/nunit/nunit/pull/4398)

### The following issues are marked as breaking changes

* [4416](https://github.com/nunit/nunit/issues/4416) Move classic asserts into its own project . Fixed by team [PR 4417](https://github.com/nunit/nunit/pull/4417)
* [4415](https://github.com/nunit/nunit/issues/4415) Remove use of params for messages. Fixed by team [PR 4419](https://github.com/nunit/nunit/pull/4419)

