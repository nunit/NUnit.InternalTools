## 4.3

There are 27 issues fixed in this release.

### Enhancements

* [4890](https://github.com/nunit/nunit/issues/4890) Add .net 8 as a target framework in the package. 
* [4886](https://github.com/nunit/nunit/issues/4886) Optimize ToArray()[0] with First() in TestAssert class in TestAssert.cs. 
* [4862](https://github.com/nunit/nunit/issues/4862) PropertiesComparer 32 Property Limit Error Message. 
* [4861](https://github.com/nunit/nunit/issues/4861) Always repeat Test x times. 
* [4852](https://github.com/nunit/nunit/issues/4852) Expand the usability of `Contains.Key(...).WithValue(...)`. 
* [4846](https://github.com/nunit/nunit/issues/4846) Add NET9 target for the framework tests. 
* [4839](https://github.com/nunit/nunit/issues/4839) Allow to use collection expressions with collection constraints. 
* [4832](https://github.com/nunit/nunit/issues/4832) Setting thread names to make debugging easier. 
* [4811](https://github.com/nunit/nunit/issues/4811) Assert.ThatAsync does not support polling. 
* [4771](https://github.com/nunit/nunit/issues/4771) Support tuples in inline data. 
* [2492](https://github.com/nunit/nunit/issues/2492) EqualConstraint.Using(StringComparer.*) causes overload ambiguity error. 

### Bug fixes

* [4887](https://github.com/nunit/nunit/issues/4887) FileLoadException for NUnit 4.2.2 when upgrade the System.Buffers to 4.6.0. 
* [4877](https://github.com/nunit/nunit/issues/4877) Fix EqualTo modifiers for DateTime. 
* [4876](https://github.com/nunit/nunit/issues/4876) Equal.Within Fails With Negative Tolerance. 
* [4875](https://github.com/nunit/nunit/issues/4875) String constraints should not allow using Within. 
* [4874](https://github.com/nunit/nunit/issues/4874) IgnoreCase, Seconds and Minutes can be used on numerical constraints. 
* [4868](https://github.com/nunit/nunit/issues/4868) TestCase- and TestCaseSourceAttribute cannot handle generic test methods where method parameter is Nullable&lt;T&gt;. 
* [4836](https://github.com/nunit/nunit/issues/4836) PropertiesComparer doesn't work well with records. 
* [4807](https://github.com/nunit/nunit/issues/4807) Is.EqualTo with empty ValueTuple throws System.NotSupportedException "Specified Tolerance not supported for instances of type 'System.ValueTuple' and 'System.ValueTuple'" after updating to NUnit 4.2.2. 
* [4281](https://github.com/nunit/nunit/issues/4281) Throws and Delayed (.After) Constraints do not cooperate, resulting in incorrectly failing test. 
* [3772](https://github.com/nunit/nunit/issues/3772) IsEquivalent on default ImmutableArray throws exception.. 
* [3713](https://github.com/nunit/nunit/issues/3713) Description of --where=EXPRESSION missing from Notes section. 
* [150](https://github.com/nunit/nunit/issues/150) Improve inference of type arguments in generic test methods. 

### Refactorings

None

### Internal fixes

* [4865](https://github.com/nunit/nunit/issues/4865) Increase Legacy NUnit so at least all methods are covered. 
* [4841](https://github.com/nunit/nunit/issues/4841) MacOS test failure. 
* [4819](https://github.com/nunit/nunit/issues/4819) Remove `StringUtil.Compare()` and update references in the tests. 
* [4798](https://github.com/nunit/nunit/issues/4798) Add a test to ensure direct framework dependencies in csproj are reflected in nuspec. 

### Deprecated features

None

### The following issues are marked as breaking changes

None

