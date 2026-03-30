Issue 4855, Exception: The input string 'fdacdae7405e57e1c952287e51860eeceb024a8b' was not in a correct format.
## 4.3

There are 29 issues fixed in this release.

### Enhancements

* [4890](https://github.com/nunit/nunit/issues/4890) Add .net 8 as a target framework in the package. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 4884](https://github.com/nunit/nunit/pull/4884)
* [4886](https://github.com/nunit/nunit/issues/4886) Optimize ToArray()[0] with First() in TestAssert class in TestAssert.cs. Thanks to [Saurav-shres](https://github.com/Saurav-shres) for [PR 4888](https://github.com/nunit/nunit/pull/4888)
* [4862](https://github.com/nunit/nunit/issues/4862) PropertiesComparer 32 Property Limit Error Message. Thanks to [Cincidial](https://github.com/Cincidial) for [PR 4870](https://github.com/nunit/nunit/pull/4870)
* [4861](https://github.com/nunit/nunit/issues/4861) Always repeat Test x times. Thanks to [Christoph](https://github.com/cfuerbachersparks) for [PR 4864](https://github.com/nunit/nunit/pull/4864)
* [4852](https://github.com/nunit/nunit/issues/4852) Expand the usability of `Contains.Key(...).WithValue(...)`. Thanks to [Michael Render](https://github.com/RenderMichael) for [PR 4854](https://github.com/nunit/nunit/pull/4854)
* [4846](https://github.com/nunit/nunit/issues/4846) Add NET9 target for the framework tests. Thanks to [Leon Lux](https://github.com/Lachstec) for [PR 4851](https://github.com/nunit/nunit/pull/4851)
* [4839](https://github.com/nunit/nunit/issues/4839) Allow to use collection expressions with collection constraints. Thanks to [Oleksandr Liakhevych](https://github.com/Dreamescaper) for [PR 4840](https://github.com/nunit/nunit/pull/4840)
* [4832](https://github.com/nunit/nunit/issues/4832) Setting thread names to make debugging easier. Thanks to NUnit Team member [Terje Sandstrom](https://github.com/OsirisTerje) for [PR 4835](https://github.com/nunit/nunit/pull/4835)
* [4811](https://github.com/nunit/nunit/issues/4811) Assert.ThatAsync does not support polling. Thanks to [Oleksandr Liakhevych](https://github.com/Dreamescaper) for [PR 4813](https://github.com/nunit/nunit/pull/4813)
* [4771](https://github.com/nunit/nunit/issues/4771) Support tuples in inline data. Thanks to [MaxKot](https://github.com/MaxKot) for [PR 4772](https://github.com/nunit/nunit/pull/4772)
* [2492](https://github.com/nunit/nunit/issues/2492) EqualConstraint.Using(StringComparer.*) causes overload ambiguity error. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 4882](https://github.com/nunit/nunit/pull/4882)

### Bug fixes

* [4887](https://github.com/nunit/nunit/issues/4887) FileLoadException for NUnit 4.2.2 when upgrade the System.Buffers to 4.6.0. Thanks to NUnit Team member [Terje Sandstrom](https://github.com/OsirisTerje) for [PR 4891](https://github.com/nunit/nunit/pull/4891)
* [4877](https://github.com/nunit/nunit/issues/4877) Fix EqualTo modifiers for DateTime. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 4882](https://github.com/nunit/nunit/pull/4882)
* [4876](https://github.com/nunit/nunit/issues/4876) Equal.Within Fails With Negative Tolerance. Thanks to [Raffael Botschen](https://github.com/RaffaelCH) for [PR 4881](https://github.com/nunit/nunit/pull/4881)
* [4875](https://github.com/nunit/nunit/issues/4875) String constraints should not allow using Within. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 4882](https://github.com/nunit/nunit/pull/4882)
* [4874](https://github.com/nunit/nunit/issues/4874) IgnoreCase, Seconds and Minutes can be used on numerical constraints. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 4882](https://github.com/nunit/nunit/pull/4882)
* [4868](https://github.com/nunit/nunit/issues/4868) TestCase- and TestCaseSourceAttribute cannot handle generic test methods where method parameter is Nullable&lt;T&gt;. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 4872](https://github.com/nunit/nunit/pull/4872)
* [4836](https://github.com/nunit/nunit/issues/4836) PropertiesComparer doesn't work well with records. Thanks to [Oleksandr Liakhevych](https://github.com/Dreamescaper) for [PR 4837](https://github.com/nunit/nunit/pull/4837)
* [4807](https://github.com/nunit/nunit/issues/4807) Is.EqualTo with empty ValueTuple throws System.NotSupportedException "Specified Tolerance not supported for instances of type 'System.ValueTuple' and 'System.ValueTuple'" after updating to NUnit 4.2.2. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 4809](https://github.com/nunit/nunit/pull/4809)
* [4281](https://github.com/nunit/nunit/issues/4281) Throws and Delayed (.After) Constraints do not cooperate, resulting in incorrectly failing test. Thanks to [Oleksandr Liakhevych](https://github.com/Dreamescaper) for [PR 4815](https://github.com/nunit/nunit/pull/4815)
* [4110](https://github.com/nunit/nunit/issues/4110) Support running single-threaded async tests on Linux. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 4883](https://github.com/nunit/nunit/pull/4883)
* [3772](https://github.com/nunit/nunit/issues/3772) IsEquivalent on default ImmutableArray throws exception. Thanks to [Sergio L.](https://github.com/mr-sergito) for [PR 4850](https://github.com/nunit/nunit/pull/4850)
* [3713](https://github.com/nunit/nunit/issues/3713) Description of --where=EXPRESSION missing from Notes section. Thanks to [rsjackson3](https://github.com/rsjackson3) for [PR 4817](https://github.com/nunit/nunit/pull/4817)
* [150](https://github.com/nunit/nunit/issues/150) Improve inference of type arguments in generic test methods. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 4873](https://github.com/nunit/nunit/pull/4873)

### Refactorings

None

### Internal fixes

* [4865](https://github.com/nunit/nunit/issues/4865) Increase Legacy NUnit so at least all methods are covered. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 4871](https://github.com/nunit/nunit/pull/4871)
* [4841](https://github.com/nunit/nunit/issues/4841) MacOS test failure. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 4842](https://github.com/nunit/nunit/pull/4842)
* [4819](https://github.com/nunit/nunit/issues/4819) Remove `StringUtil.Compare()` and update references in the tests. Thanks to [Sergio L.](https://github.com/mr-sergito) for [PR 4827](https://github.com/nunit/nunit/pull/4827)
* [4798](https://github.com/nunit/nunit/issues/4798) Add a test to ensure direct framework dependencies in csproj are reflected in nuspec. Thanks to NUnit Team member [Terje Sandstrom](https://github.com/OsirisTerje) for [PR 4799](https://github.com/nunit/nunit/pull/4799)

### Deprecated features

None

### Others


### The following issues are marked as breaking changes

None


### Acknowledgements

First and foremost, we want to recognize the exceptional contributions of team members [Manfred Brands](https://github.com/manfred-brands) and [Steven Weerdenburg](https://github.com/stevenaw) for their dedicated efforts on this release, particularly their work on improving type safety.

We also express our heartfelt gratitude to everyone who has contributed to this release
by reporting bugs, suggesting enhancements, and providing valuable feedback.
Your efforts help make NUnit better for the entire community.

A special thank you to the following reporters for identifying issues:

<table>
<tr>
<td><a href="https://github.com/cfuerbachersparks">Christoph</a></td>
<td><a href="https://github.com/KrzysFR">Christophe Chevalier</a></td>
<td><a href="https://github.com/Cincidial">Cincidial</a></td>
<td><a href="https://github.com/jnm2">Joseph Musser</a></td>
</tr>
<tr>
<td><a href="https://github.com/Lachstec">Leon Lux</a></td>
<td><a href="https://github.com/manfred-brands">Manfred Brands</a></td>
<td><a href="https://github.com/MaxKot">MaxKot</a></td>
<td><a href="https://github.com/MCMrARM">MCMrARM</a></td>
</tr>
<tr>
<td><a href="https://github.com/RenderMichael">Michael Render</a></td>
<td><a href="https://github.com/michaelamaura">Michaela Maura Elschner</a></td>
<td><a href="https://github.com/mzh3511">mzh3511</a></td>
<td><a href="https://github.com/Dreamescaper">Oleksandr Liakhevych</a></td>
</tr>
<tr>
<td><a href="https://github.com/RaffaelCH">Raffael Botschen</a></td>
<td><a href="https://github.com/biocoder-frodo">Sander</a></td>
<td><a href="https://github.com/Saurav-shres">Saurav-shres</a></td>
<td><a href="https://github.com/seesharks">seesharks</a></td>
</tr>
<tr>
<td><a href="https://github.com/stevenaw">Steven Weerdenburg</a></td>
<td><a href="https://github.com/OsirisTerje">Terje Sandstrom</a></td>
<td><a href="https://github.com/wimvangool">Wim van Gool</a></td>
</tr>
</table>


and to the commenters who engaged in discussions and offered further insights:

<table>
<tr>
<td><a href="https://github.com/CharliePoole">CharliePoole</a></td>
<td><a href="https://github.com/ChrisMaddock">Chris Maddock</a></td>
<td><a href="https://github.com/cfuerbachersparks">Christoph</a></td>
<td><a href="https://github.com/KrzysFR">Christophe Chevalier</a></td>
</tr>
<tr>
<td><a href="https://github.com/Cincidial">Cincidial</a></td>
<td><a href="https://github.com/Kooddammn">Harsh Jain</a></td>
<td><a href="https://github.com/jnm2">Joseph Musser</a></td>
<td><a href="https://github.com/Lachstec">Leon Lux</a></td>
</tr>
<tr>
<td><a href="https://github.com/manfred-brands">Manfred Brands</a></td>
<td><a href="https://github.com/MaxKot">MaxKot</a></td>
<td><a href="https://github.com/RenderMichael">Michael Render</a></td>
<td><a href="https://github.com/michaelamaura">Michaela Maura Elschner</a></td>
</tr>
<tr>
<td><a href="https://github.com/mikkelbu">Mikkel Nylander Bundgaard</a></td>
<td><a href="https://github.com/Dreamescaper">Oleksandr Liakhevych</a></td>
<td><a href="https://github.com/PicNet">PicNet</a></td>
<td><a href="https://github.com/RaffaelCH">Raffael Botschen</a></td>
</tr>
<tr>
<td><a href="https://github.com/rprouse">Rob Prouse</a></td>
<td><a href="https://github.com/rsjackson3">rsjackson3</a></td>
<td><a href="https://github.com/sba-schleupen">Sascha Bartl</a></td>
<td><a href="https://github.com/Saurav-shres">Saurav-shres</a></td>
</tr>
<tr>
<td><a href="https://github.com/mr-sergito">Sergio L.</a></td>
<td><a href="https://github.com/stevenaw">Steven Weerdenburg</a></td>
<td><a href="https://github.com/OsirisTerje">Terje Sandstrom</a></td>
<td><a href="https://github.com/wimvangool">Wim van Gool</a></td>
</tr>
</table>

