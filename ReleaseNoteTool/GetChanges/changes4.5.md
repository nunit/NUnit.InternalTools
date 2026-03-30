## 4.5

There are 38 issues fixed in this release.

### Enhancements

* [5100](https://github.com/nunit/nunit/issues/5100) Add an `Enum.Parse&lt;T&gt;()` method for .NET Framework builds. Thanks to [Shaig Mahmudov](https://github.com/shaig-mahmudov) for [PR 5102](https://github.com/nunit/nunit/pull/5102)
* [5073](https://github.com/nunit/nunit/issues/5073) Generically Typed UsingPropertiesComparer Consistency. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 5077](https://github.com/nunit/nunit/pull/5077)
* [5040](https://github.com/nunit/nunit/issues/5040) Add NET10 target for the framework tests. Thanks to [Zahran Yahia Khan](https://github.com/zahran001) for [PR 5041](https://github.com/nunit/nunit/pull/5041)
* [4900](https://github.com/nunit/nunit/issues/4900) CancelAfter & TestCaseSource with CancellationToken method parameter cause test failures. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5057](https://github.com/nunit/nunit/pull/5057)
* [4814](https://github.com/nunit/nunit/issues/4814) Assert.Multiple throws 'The assertion scope was disposed out of order' when run in parallel. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 5074](https://github.com/nunit/nunit/pull/5074)
* [4744](https://github.com/nunit/nunit/issues/4744) Introduce HookExtension to support high level tests. Thanks to [Rajiv Sinha](https://github.com/TravellerD14) for [PR 4986](https://github.com/nunit/nunit/pull/4986)
* [4693](https://github.com/nunit/nunit/issues/4693) Re-add "legacy" Assert methods. Thanks to NUnit Team member [Terje Sandstrom](https://github.com/OsirisTerje) for [PR 5054](https://github.com/nunit/nunit/pull/5054)
* [4662](https://github.com/nunit/nunit/issues/4662) StringAssert.IsNullOrEmpty overloads. Thanks to [Copilot](https://github.com/Copilot) for [PR 5063](https://github.com/nunit/nunit/pull/5063)
* [4613](https://github.com/nunit/nunit/issues/4613) Can you please give us back `Assert.IsNotNull`, `Assert.IsFalse` etc.?. Thanks to NUnit Team member [Terje Sandstrom](https://github.com/OsirisTerje) for [PR 5054](https://github.com/nunit/nunit/pull/5054)
* [4130](https://github.com/nunit/nunit/issues/4130) Detect if inside an Assert.Multiple. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 5081](https://github.com/nunit/nunit/pull/5081)
* [3922](https://github.com/nunit/nunit/issues/3922) Expose a way to provide 'StringComparison' value to 'StartsWith' assertions. Thanks to [Nancy Huynh](https://github.com/nancyhuyn) for [PR 5052](https://github.com/nunit/nunit/pull/5052)
* [3360](https://github.com/nunit/nunit/issues/3360) Add params object[] overload to SetArgDisplayNames. Thanks to [Copilot](https://github.com/Copilot) for [PR 5060](https://github.com/nunit/nunit/pull/5060)
* [3348](https://github.com/nunit/nunit/issues/3348) Incorrect exception thrown when using an old SynchronizationContext. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 5075](https://github.com/nunit/nunit/pull/5075)
* [2785](https://github.com/nunit/nunit/issues/2785) Retry attribute should handle unexpected exceptions. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 5058](https://github.com/nunit/nunit/pull/5058)
* [1883](https://github.com/nunit/nunit/issues/1883) TestCaseSource with Test Method with params arguments. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5057](https://github.com/nunit/nunit/pull/5057)
* [1388](https://github.com/nunit/nunit/issues/1388) Retry Decorator does not retry test if fail cause is an exception. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 5058](https://github.com/nunit/nunit/pull/5058)
* [1281](https://github.com/nunit/nunit/issues/1281) TestCaseSourceAttribute to support optional arguments. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5057](https://github.com/nunit/nunit/pull/5057)
* [1388](https://github.com/nunit/nunit/issues/1388) Retry Decorator does not retry test if fail cause is an exception. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 5058](https://github.com/nunit/nunit/pull/5058)
* [5089](https://github.com/nunit/nunit/issues/5089) Optional parameters aren't handled when using TestFixtureSource. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5090](https://github.com/nunit/nunit/pull/5090)
* [2958](https://github.com/nunit/nunit/issues/2958) Support Type Arguments alongside Constructor Arguments with [TestFixtureSource]. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5086](https://github.com/nunit/nunit/pull/5086)

### Bug fixes

* [5106](https://github.com/nunit/nunit/issues/5106) Test execution never ends when Ctrl+C key hit in MTP mode. Thanks to NUnit Team member [Terje Sandstrom](https://github.com/OsirisTerje) for [PR 5105](https://github.com/nunit/nunit/pull/5105)
* [5096](https://github.com/nunit/nunit/issues/5096) Unclear error if MTP times out in a setup fixture. Thanks to NUnit Team member [Terje Sandstrom](https://github.com/OsirisTerje) for [PR 5105](https://github.com/nunit/nunit/pull/5105)
* [5093](https://github.com/nunit/nunit/issues/5093) Generic Test Fixtures not run from VS Test Explorer. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 5094](https://github.com/nunit/nunit/pull/5094)
* [5082](https://github.com/nunit/nunit/issues/5082) `AssignableTo/From` among value types. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5083](https://github.com/nunit/nunit/pull/5083)
* [5061](https://github.com/nunit/nunit/issues/5061) TestCase (+ TestCaseSource) throw exception when passing arguments to params array in generic method. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 5066](https://github.com/nunit/nunit/pull/5066)
* [5051](https://github.com/nunit/nunit/issues/5051) `TestContext.CurrentContext.Test.AllCategories()` is not thread-safe. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 5053](https://github.com/nunit/nunit/pull/5053)
* [5031](https://github.com/nunit/nunit/issues/5031) `Repeat` attribute only prints output of last repetition after 4.4.0 update. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 5038](https://github.com/nunit/nunit/pull/5038)
* [5026](https://github.com/nunit/nunit/issues/5026) Assume.That no longer works in Setup. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 5029](https://github.com/nunit/nunit/pull/5029)
* [5025](https://github.com/nunit/nunit/issues/5025) PropertiesComparer fails on properties with new modifier. Thanks to [Luca Rampazzo](https://github.com/lrampazzo) for [PR 5028](https://github.com/nunit/nunit/pull/5028)
* [5023](https://github.com/nunit/nunit/issues/5023) System.ArgumentException: Argument name must not be the empty string Arg_ParamName_Name, name in `browser-wasm` runtime. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 5024](https://github.com/nunit/nunit/pull/5024)
* [4513](https://github.com/nunit/nunit/issues/4513) Randomizer.GetString can return strings that have invalid surrogate pairs. Thanks to NUnit Team member [Terje Sandstrom](https://github.com/OsirisTerje) for [PR 5078](https://github.com/nunit/nunit/pull/5078)
* [4119](https://github.com/nunit/nunit/issues/4119) Apartment(ApartmentState.STA) doesn't works together with Timeout. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 5123](https://github.com/nunit/nunit/pull/5123)
* [3930](https://github.com/nunit/nunit/issues/3930) Whole tests sequence is aborted when single test fails because of async bug. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 5068](https://github.com/nunit/nunit/pull/5068)
* [3740](https://github.com/nunit/nunit/issues/3740) SynchronizationContext not preserved from OneTimeSetup to Test method. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 5068](https://github.com/nunit/nunit/pull/5068)
* [3434](https://github.com/nunit/nunit/issues/3434) Handling of passing null as element to a parametric testmethod that accepts a params. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5090](https://github.com/nunit/nunit/pull/5090)
* [3125](https://github.com/nunit/nunit/issues/3125) TestCaseSource "Single" cannot be converted to "int" issue. Thanks to NUnit Team member [Terje Sandstrom](https://github.com/OsirisTerje) for [PR 5079](https://github.com/nunit/nunit/pull/5079)

### Refactorings

None
### Internal fixes

* [5062](https://github.com/nunit/nunit/issues/5062) Tests marked Explicit for being used as Testdata should be moved to NUnit.TestData project. Thanks to [Rajiv Sinha](https://github.com/TravellerD14) for [PR 5065](https://github.com/nunit/nunit/pull/5065)
* [5002](https://github.com/nunit/nunit/issues/5002) Allow TestBuilder to execute Explicit tests. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 5032](https://github.com/nunit/nunit/pull/5032)
* [5055](https://github.com/nunit/nunit/issues/5055) Convert sln file to slnx format. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5056](https://github.com/nunit/nunit/pull/5056)

### Deprecated features

None
### The following issues are marked as breaking changes

None

### Acknowledgements

We want to express our heartfelt gratitude to everyone who has contributed to this release
by reporting bugs, suggesting enhancements, and providing valuable feedback.
Your efforts help make NUnit better for the entire community.

A special thank you to the following reporters for identifying issues:

<table>
<tr>
<td><a href="https://github.com/afscrome">Alex Crome</a></td>
<td><a href="https://github.com/ant-jones-rg">Ant Jones</a></td>
<td><a href="https://github.com/bording">Brandon Ording</a></td>
<td><a href="https://github.com/astrohart">Brian</a></td>
</tr>
<tr>
<td><a href="https://github.com/BrunoJuchli">Bruno Juchli</a></td>
<td><a href="https://github.com/ChrisMaddock">Chris Maddock</a></td>
<td><a href="https://github.com/ackhack">Christoph FÅrbacher</a></td>
<td><a href="https://github.com/Gwindalmir">Daniel</a></td>
</tr>
<tr>
<td><a href="https://github.com/eberzosa">eberzosa</a></td>
<td><a href="https://github.com/doxxx">Gordon Tyler</a></td>
<td><a href="https://github.com/jnm2">Joseph Musser</a></td>
<td><a href="https://github.com/julealgon">Juliano Leal Goncalves</a></td>
</tr>
<tr>
<td><a href="https://github.com/lrampazzo">Luca Rampazzo</a></td>
<td><a href="https://github.com/maettu-this">maettu-this</a></td>
<td><a href="https://github.com/manfred-brands">Manfred Brands</a></td>
<td><a href="https://github.com/mikkelbu">Mikkel Nylander Bundgaard</a></td>
</tr>
<tr>
<td><a href="https://github.com/miroljub1995">Miroljub Tomic</a></td>
<td><a href="https://github.com/oznetmaster">Neil Colvin</a></td>
<td><a href="https://github.com/radim-bernatik-veeam">Radim Bernatik</a></td>
<td><a href="https://github.com/randersen">randersen</a></td>
</tr>
<tr>
<td><a href="https://github.com/rprouse">Rob Prouse</a></td>
<td><a href="https://github.com/reejk">Roman</a></td>
<td><a href="https://github.com/MgSam">Sam</a></td>
<td><a href="https://github.com/seanm-fathomhq">Sean Mackedie</a></td>
</tr>
<tr>
<td><a href="https://github.com/TSAVogt">Stefan Vogt</a></td>
<td><a href="https://github.com/stevenaw">Steven Weerdenburg</a></td>
<td><a href="https://github.com/OsirisTerje">Terje Sandstrom</a></td>
<td><a href="https://github.com/paatrofimov">Trofimov Pavel</a></td>
</tr>
</table>


and to the commenters who engaged in discussions and offered further insights:

<table>
<tr>
<td><a href="https://github.com/ant-jones-rg">Ant Jones</a></td>
<td><a href="https://github.com/Bouke">Bouke Haarsma</a></td>
<td><a href="https://github.com/bording">Brandon Ording</a></td>
<td><a href="https://github.com/nobrayner">Braydon Hall</a></td>
</tr>
<tr>
<td><a href="https://github.com/astrohart">Brian</a></td>
<td><a href="https://github.com/BrunoJuchli">Bruno Juchli</a></td>
<td><a href="https://github.com/CharliePoole">CharliePoole</a></td>
<td><a href="https://github.com/ChrisMaddock">Chris Maddock</a></td>
</tr>
<tr>
<td><a href="https://github.com/ackhack">Christoph FÅrbacher</a></td>
<td><a href="https://github.com/cPetru">cPetru</a></td>
<td><a href="https://github.com/d-Z-b">d-Z-b</a></td>
<td><a href="https://github.com/delgesso">delgesso</a></td>
</tr>
<tr>
<td><a href="https://github.com/nyghtly-derek">Derek Blankenship</a></td>
<td><a href="https://github.com/DJDoena">DJ Doena</a></td>
<td><a href="https://github.com/jnm2">Joseph Musser</a></td>
<td><a href="https://github.com/julealgon">Juliano Leal Goncalves</a></td>
</tr>
<tr>
<td><a href="https://github.com/xenaree">Kais</a></td>
<td><a href="https://github.com/LirazShay">Liraz Shay</a></td>
<td><a href="https://github.com/lrampazzo">Luca Rampazzo</a></td>
<td><a href="https://github.com/manfred-brands">Manfred Brands</a></td>
</tr>
<tr>
<td><a href="https://github.com/siburny">Maxim Rubis</a></td>
<td><a href="https://github.com/RenderMichael">Michael Render</a></td>
<td><a href="https://github.com/mikkelbu">Mikkel Nylander Bundgaard</a></td>
<td><a href="https://github.com/miroljub1995">Miroljub Tomic</a></td>
</tr>
<tr>
<td><a href="https://github.com/mitchellmaler">Mitchell Maler</a></td>
<td><a href="https://github.com/oznetmaster">Neil Colvin</a></td>
<td><a href="https://github.com/radim-bernatik-veeam">Radim Bernatik</a></td>
<td><a href="https://github.com/TravellerD14">Rajiv Sinha</a></td>
</tr>
<tr>
<td><a href="https://github.com/randersen">randersen</a></td>
<td><a href="https://github.com/renemadsen">RenÇ Schultz Madsen</a></td>
<td><a href="https://github.com/rprouse">Rob Prouse</a></td>
<td><a href="https://github.com/reejk">Roman</a></td>
</tr>
<tr>
<td><a href="https://github.com/MgSam">Sam</a></td>
<td><a href="https://github.com/phyrik">Scott Buchanan</a></td>
<td><a href="https://github.com/shaig-mahmudov">Shaig Mahmudov</a></td>
<td><a href="https://github.com/savornicesei">Simona Avornicesei</a></td>
</tr>
<tr>
<td><a href="https://github.com/Sputnik24">Sputnik24</a></td>
<td><a href="https://github.com/Stan-RED">Stanislav S. Yarmonov</a></td>
<td><a href="https://github.com/z002Holpp">Stefan Holpp</a></td>
<td><a href="https://github.com/TSAVogt">Stefan Vogt</a></td>
</tr>
<tr>
<td><a href="https://github.com/stevenaw">Steven Weerdenburg</a></td>
<td><a href="https://github.com/tekhedd">tekHedd</a></td>
<td><a href="https://github.com/OsirisTerje">Terje Sandstrom</a></td>
<td><a href="https://github.com/TomEdwardsEnscape">Tom Edwards</a></td>
</tr>
<tr>
<td><a href="https://github.com/paatrofimov">Trofimov Pavel</a></td>
<td><a href="https://github.com/zahran001">Zahran Yahia Khan</a></td>
</tr>
</table>

