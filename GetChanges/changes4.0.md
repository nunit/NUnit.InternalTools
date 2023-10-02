## 4.0

### Enhancements

* [4421](https://github.com/nunit/nunit/issues/4421) Add support for native .NET-6.0 target 
* [4355](https://github.com/nunit/nunit/issues/4355) Allow Is.AnyOf to be called with arrays or other collections
* [4149](https://github.com/nunit/nunit/issues/4149) Distribute optimized framework builds with easy debugging
* [4144](https://github.com/nunit/nunit/issues/4144) Stderr/Console.Error will hold back unicode escaped log messages
* [4101](https://github.com/nunit/nunit/issues/4101) Expose ExpectedResult to the TestContext
* [4086](https://github.com/nunit/nunit/issues/4086) Perform case-insensitive string comparisons in-place
* [4053](https://github.com/nunit/nunit/issues/4053) Cache method discovery by migrating PR 4034 to main
* [3984](https://github.com/nunit/nunit/issues/3984) Add net6.0 targets
* [3936](https://github.com/nunit/nunit/issues/3936) Is there any way we could make use of CallerArgumentExpressionAttribute?
* [3899](https://github.com/nunit/nunit/issues/3899) Allow randomizing 'Guid' test arguments with [Random]
* [3866](https://github.com/nunit/nunit/issues/3866) SupportedOSPlatform
* [3856](https://github.com/nunit/nunit/issues/3856) Theories in nested Testfixtures
* [3718](https://github.com/nunit/nunit/issues/3718) Improve readability of "assert failed" message for DictionaryContainsKeyValuePairConstraint WithValue()
* [3457](https://github.com/nunit/nunit/issues/3457) Add DefaultConstraint
* [3432](https://github.com/nunit/nunit/issues/3432) Assert.That is blocking and might lead to deadlock when used with WCF.
* [2843](https://github.com/nunit/nunit/issues/2843) Replacing ThrowsAsync with a composable async alternative

### Features

* [4415](https://github.com/nunit/nunit/issues/4415) Remove use of params for messages
* [4413](https://github.com/nunit/nunit/issues/4413) Assert.That methods should autogenerate message, if null

### Bugs

* [4319](https://github.com/nunit/nunit/issues/4319) TextRunner accidentally disposes System.Out
* [4308](https://github.com/nunit/nunit/issues/4308) Random attribute with Distinct and wide range causes test to disappear
* [4255](https://github.com/nunit/nunit/issues/4255) InternalTrace.Initialize fails with Nullref exception
* [4243](https://github.com/nunit/nunit/issues/4243) Type args are not deduced correctly for parameterized fixtures
* [4237](https://github.com/nunit/nunit/issues/4237) Bogus check for Windows 11
* [3964](https://github.com/nunit/nunit/issues/3964) DictionaryContainsKeyValuePairConstraint doesn't work with `IDictionary<TKey, TValue>`
* [3961](https://github.com/nunit/nunit/issues/3961) OneTimeTearDown runs on a new thread with mismatched Thread Name and Worker Id
* [3953](https://github.com/nunit/nunit/issues/3953) Dispose is not called on test fixtures with LifeCycle.InstancePerTestCase without TearDown method
* [3872](https://github.com/nunit/nunit/issues/3872) Add support for `ref bool`, `ref bool?`, `in bool`, and `in bool?` when using `NUnit.Framework.ValuesAttribute`
* [3868](https://github.com/nunit/nunit/issues/3868) Order attribute skips classes with multiple test fixtures
* [3858](https://github.com/nunit/nunit/issues/3858) Running tests with ITestAction attributes leaks memory
* [3811](https://github.com/nunit/nunit/issues/3811) Incorrect summary comments on Warn.If overloads
* [3449](https://github.com/nunit/nunit/issues/3449) Assert.AreEqual overloads for nullable double are not useful
* [2870](https://github.com/nunit/nunit/issues/2870) CollectionTally (EquivalentTo) should throw for non-transitive comparisons
* [1428](https://github.com/nunit/nunit/issues/1428) NUnitLite package always installs both Program.cs and Program.vb

### Refactorings

* [4434](https://github.com/nunit/nunit/issues/4434) Fixing the classic asserts
* [4416](https://github.com/nunit/nunit/issues/4416) Move classic asserts into its own project 
* [4051](https://github.com/nunit/nunit/issues/4051) Update codebase to use Array.Empty<T>
* [3932](https://github.com/nunit/nunit/issues/3932) Make `Numerics` class internal

### Internals

* [4331](https://github.com/nunit/nunit/issues/4331) Add testing to "Accumulate further failures if any on AssertMultiple instead of throwing"
* [4078](https://github.com/nunit/nunit/issues/4078) THREAD_ABORT not properly set
* [4075](https://github.com/nunit/nunit/issues/4075) Remove unnecessary allocations in NUnitEqualityComparer
* [4065](https://github.com/nunit/nunit/issues/4065) Use pattern matching in the comparers
* [4055](https://github.com/nunit/nunit/issues/4055) Use static Regex.IsMatch in ValueMatchFilter to take advantage of caching
* [4049](https://github.com/nunit/nunit/issues/4049) Simplify property retrieval in DefaultTestAssemblyBuilder.Build()
* [3935](https://github.com/nunit/nunit/issues/3935) `Numerics.IsFixedPointNumeric` should return false for decimals
* [3789](https://github.com/nunit/nunit/issues/3789) Change copyright header on files
* [3764](https://github.com/nunit/nunit/issues/3764) Switch to the dotnet tool version of Cake
* [2485](https://github.com/nunit/nunit/issues/2485) Remove\Trim copyright on individual files

### Deprecations

* [4036](https://github.com/nunit/nunit/issues/4036) Drop net45 build target in nunit4
* [3980](https://github.com/nunit/nunit/issues/3980) Drop netcoreapp2.1 targets
* [3769](https://github.com/nunit/nunit/issues/3769) Remove code marked "Obsolete"
* [3758](https://github.com/nunit/nunit/issues/3758) Drop .NET 3.5 Build Targets
* [3708](https://github.com/nunit/nunit/issues/3708) Drop .NET 4.0 Build Target
* [3410](https://github.com/nunit/nunit/issues/3410) Consider deprecating NUnitEqualityComparer.AreEqual optional bool parameter

### Others

* [4431](https://github.com/nunit/nunit/issues/4431) Improving error message handling and performing assert consolidation
* [4112](https://github.com/nunit/nunit/issues/4112) Update documentation to clarify passing parameters to test cases
* [3989](https://github.com/nunit/nunit/issues/3989) Revisit build documentation relating to IDEs
* [3869](https://github.com/nunit/nunit/issues/3869) Copyright notices for third-party code
* [3867](https://github.com/nunit/nunit/issues/3867) nunit Framework tests do not run with "dotnet test" nor inside VS2019 (Windows)
* [3812](https://github.com/nunit/nunit/issues/3812) Add GitHub Actions
* [3376](https://github.com/nunit/nunit/issues/3376) Nullable Reference Types annotations
* [3301](https://github.com/nunit/nunit/issues/3301) [HandleProcessCorruptedStateExceptions] has no effect unless we disable partial trust
* [3132](https://github.com/nunit/nunit/issues/3132) Remove AssertionHelper and AssertionHelperTests

### The following issues above is marked as breaking changes

* [4416](https://github.com/nunit/nunit/issues/4416) Move classic asserts into its own project 
* [4415](https://github.com/nunit/nunit/issues/4415) Remove use of params for messages

