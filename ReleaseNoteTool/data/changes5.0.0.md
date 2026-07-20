## 5.0

There are 33 issues fixed in this release.

### Enhancements

* [5354](https://github.com/nunit/nunit/issues/5354) Expose a property for ActiveTests in the TestContext. Thanks to NUnit Team member [Terje Sandstrom](https://github.com/OsirisTerje) for [PR 5355](https://github.com/nunit/nunit/pull/5355)
* [5349](https://github.com/nunit/nunit/issues/5349) Use ArgumentOutOfRangeException throw helper and remove CA1512 diagnostic. Thanks to [Shaurya Srivastava](https://github.com/Shaurya2k06) for [PR 5350](https://github.com/nunit/nunit/pull/5350)
* [5348](https://github.com/nunit/nunit/issues/5348) Use ArgumentNullException throw helper and remove CA1510 diagnostic. Thanks to [ANSH SINGH](https://github.com/SinghAnsh07) for [PR 5351](https://github.com/nunit/nunit/pull/5351)
* [5323](https://github.com/nunit/nunit/issues/5323) Report compiler error when asserting non-attribute in `Has.Attribute&lt;T&gt;()`. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5322](https://github.com/nunit/nunit/pull/5322)
* [5316](https://github.com/nunit/nunit/issues/5316) Add .net 10 as target. Thanks to NUnit Team member [Terje Sandstrom](https://github.com/OsirisTerje) for [PR 5317](https://github.com/nunit/nunit/pull/5317)
* [5260](https://github.com/nunit/nunit/issues/5260) Add a "warning" threshold to the `MaxTime` attribute. Thanks to [Ricardo Macedo](https://github.com/RicardoMacedo-prj) for [PR 5261](https://github.com/nunit/nunit/pull/5261)
* [5220](https://github.com/nunit/nunit/issues/5220) Repeat test cases with threshold-based success/failure. Thanks to NUnit Team member [Terje Sandstrom](https://github.com/OsirisTerje) for [PR 5318](https://github.com/nunit/nunit/pull/5318)
* [4857](https://github.com/nunit/nunit/issues/4857) Drop .NET 6 as a build target of the framework. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 4884](https://github.com/nunit/nunit/pull/4884)
* [4717](https://github.com/nunit/nunit/issues/4717) Provide generic type definitions for `TestCaseData` to make it type safe. Thanks to [Jonathan Gilbert](https://github.com/logiclrd) for [PR 5138](https://github.com/nunit/nunit/pull/5138)
* [4384](https://github.com/nunit/nunit/issues/4384) Assert.ThrowsAsync, Assert.CatchAsync, and Assert.DoesNotThrowAsync should be awaitable. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5268](https://github.com/nunit/nunit/pull/5268)
* [3947](https://github.com/nunit/nunit/issues/3947) Simplify asserting ArgumentException.ParamName. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5304](https://github.com/nunit/nunit/pull/5304)

### Bug fixes

* [5341](https://github.com/nunit/nunit/issues/5341) Confusing difference in Run Settings display between NUnitLite and ConsoleRunner. Thanks to [Amir Tahan](https://github.com/AmirTahan80) for [PR 5361](https://github.com/nunit/nunit/pull/5361)
* [5324](https://github.com/nunit/nunit/issues/5324) C++/CLI compiler warning C4642 in EqualNumericConstraint and EqualNumericWithoutUsingConstraint. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 5321](https://github.com/nunit/nunit/pull/5321)
* [5273](https://github.com/nunit/nunit/issues/5273) Verify that generic AssignableToConstraint and AssignableFromConstraint works as expected. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5277](https://github.com/nunit/nunit/pull/5277)
* [5252](https://github.com/nunit/nunit/issues/5252) Upgrade to 4.6.0 containing #4824 is source-incompatible in F# even on net9. 
* [5247](https://github.com/nunit/nunit/issues/5247) Assert for null-valued `dynamic` variables doesn't work in 4.6.0. 
* [4320](https://github.com/nunit/nunit/issues/4320) AssemblyHelper throws Exception when loading dynamically compiled Assemblies. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5308](https://github.com/nunit/nunit/pull/5308)
* [3849](https://github.com/nunit/nunit/issues/3849) Assert.Catch inside Assert.Multiple gives unclear failure message. Thanks to NUnit Team member [Terje Sandstrom](https://github.com/OsirisTerje) for [PR 5280](https://github.com/nunit/nunit/pull/5280)
* [1001](https://github.com/nunit/nunit/issues/1001) Too many Inconclusive test results. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5251](https://github.com/nunit/nunit/pull/5251)

### Refactorings

* [5273](https://github.com/nunit/nunit/issues/5273) Verify that generic AssignableToConstraint and AssignableFromConstraint works as expected. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5277](https://github.com/nunit/nunit/pull/5277)
* [5222](https://github.com/nunit/nunit/issues/5222) AssemblyVersion. 
* [5180](https://github.com/nunit/nunit/issues/5180) Change namespace for legacy String-, Collection-, File- and DirectoryAssert classes. Thanks to NUnit Team member [Terje Sandstrom](https://github.com/OsirisTerje) for [PR 5181](https://github.com/nunit/nunit/pull/5181)

### Internal fixes

* [5301](https://github.com/nunit/nunit/issues/5301) Update README and nuspec files for NUnit 5. Thanks to NUnit Team member [Terje Sandstrom](https://github.com/OsirisTerje) for [PR 5302](https://github.com/nunit/nunit/pull/5302)
* [5228](https://github.com/nunit/nunit/issues/5228) Set assembly version to Minver default for the 5.0.0.0 release. Thanks to NUnit Team member [Terje Sandstrom](https://github.com/OsirisTerje) for [PR 5299](https://github.com/nunit/nunit/pull/5299)
* [5222](https://github.com/nunit/nunit/issues/5222) AssemblyVersion. 
* [5197](https://github.com/nunit/nunit/issues/5197) Add files to support AI agent coding. Thanks to [Joel Dickson](https://github.com/joeldickson) for [PR 5225](https://github.com/nunit/nunit/pull/5225)

### Deprecated features

* [5265](https://github.com/nunit/nunit/issues/5265) 4.6 breaks our tests because of TestDelegate / Action ambiguity. 
* [5263](https://github.com/nunit/nunit/issues/5263) Deprecate non-generic CollectionTally class and move the result class out of nested class. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5310](https://github.com/nunit/nunit/pull/5310)
* [5253](https://github.com/nunit/nunit/issues/5253) Remove TestDelegate and ActualValueDelegate. Thanks to NUnit Team member [Terje Sandstrom](https://github.com/OsirisTerje) for [PR 5262](https://github.com/nunit/nunit/pull/5262)

### Others

* [5271](https://github.com/nunit/nunit/issues/5271) Update Collection Equivalency performance tests to use MaxTime. Thanks to [Silva Dev BR](https://github.com/Will-thom) for [PR 5276](https://github.com/nunit/nunit/pull/5276)
* [5267](https://github.com/nunit/nunit/issues/5267) Remove the `OverloadResolutionPriority` attributes added to support the transition to Action and Func-based APIs. 
* [5218](https://github.com/nunit/nunit/issues/5218) Feat/allow custom comparer null self. 
* [5145](https://github.com/nunit/nunit/issues/5145) Remove the `object?` overloads for `Is.SameAs` and underlying constraint. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5160](https://github.com/nunit/nunit/pull/5160)
* [5007](https://github.com/nunit/nunit/issues/5007) Create generic type checking constraints. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5191](https://github.com/nunit/nunit/pull/5191)
* [3669](https://github.com/nunit/nunit/issues/3669) Update recognized platform names so that "NET" and "DotNET" means .NET instead of .NET Framework. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5300](https://github.com/nunit/nunit/pull/5300)

### The following issues are marked as breaking changes

* [5323](https://github.com/nunit/nunit/issues/5323) Report compiler error when asserting non-attribute in `Has.Attribute&lt;T&gt;()`. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5322](https://github.com/nunit/nunit/pull/5322)
* [5265](https://github.com/nunit/nunit/issues/5265) 4.6 breaks our tests because of TestDelegate / Action ambiguity. 
* [5263](https://github.com/nunit/nunit/issues/5263) Deprecate non-generic CollectionTally class and move the result class out of nested class. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5310](https://github.com/nunit/nunit/pull/5310)
* [5253](https://github.com/nunit/nunit/issues/5253) Remove TestDelegate and ActualValueDelegate. Thanks to NUnit Team member [Terje Sandstrom](https://github.com/OsirisTerje) for [PR 5262](https://github.com/nunit/nunit/pull/5262)
* [5180](https://github.com/nunit/nunit/issues/5180) Change namespace for legacy String-, Collection-, File- and DirectoryAssert classes. Thanks to NUnit Team member [Terje Sandstrom](https://github.com/OsirisTerje) for [PR 5181](https://github.com/nunit/nunit/pull/5181)
* [5145](https://github.com/nunit/nunit/issues/5145) Remove the `object?` overloads for `Is.SameAs` and underlying constraint. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5160](https://github.com/nunit/nunit/pull/5160)
* [5007](https://github.com/nunit/nunit/issues/5007) Create generic type checking constraints. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5191](https://github.com/nunit/nunit/pull/5191)
* [4857](https://github.com/nunit/nunit/issues/4857) Drop .NET 6 as a build target of the framework. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 4884](https://github.com/nunit/nunit/pull/4884)
* [4384](https://github.com/nunit/nunit/issues/4384) Assert.ThrowsAsync, Assert.CatchAsync, and Assert.DoesNotThrowAsync should be awaitable. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5268](https://github.com/nunit/nunit/pull/5268)

  > [!IMPORTANT]
  > This issue is a breaking change.  
  > 
  > The following assertions now return a `Task` which much be awaited in order for the assertion to be evaluated.
  > - `Assert.ThrowsAsync`
  > - `Assert.CatchAsync`
  > - `Assert.DoesNotThrowAsync`
  > 
  > Version 4.14 or higher of the `nunit.analyzers` nuget package can help automate this conversion by reporting and optionally fixing unawaited assertions. The analyzer will also update the immediately enclosing function to return a `Task` if necessary.

* [3669](https://github.com/nunit/nunit/issues/3669) Update recognized platform names so that "NET" and "DotNET" means .NET instead of .NET Framework. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5300](https://github.com/nunit/nunit/pull/5300)

  > [!IMPORTANT]
  > This issue is a breaking change.  
  > 
  > The meaning of "NET" and "DotNET" in the `PlatformAttribute` have been updated in NUnit 5 to better align with Microsoft's current terminology. These identifiers could previously be used to allow tests to run only on .NET Framework. Modern .NET releases such as .NET 8, 9, or 10 are now generally known as just ".NET" and so "NET" and "DotNET" will now be used to target modern .NET platforms rather than .NET Framework. New `NETFramework` and `DotNETFramework` identifiers have also been added to better differentiate. Existing usages of "NET" or "DotNET" which are intended to target to .NET Framework will need to be updated to either "NETFramework" or "DotNETFramework".
  > 
  > Please see the below compatibility table for more info. `netfx` refers to .NET Framework and `modern .NET` refers to .NET Core and newer releases.
  > 
  > | Identifier                  | NUnit 4          |          NUnit 5 |
  > | --------------------- | --------------- | --------------- |
  > | NET                          | netfx              | modern .NET  |
  > | NETFramework        |    ❌              | netfx               |
  > | NETCore                  | modern .NET | modern .NET   |
  > | DotNET                   | netfx               | modern .NET   |
  > | DotNETCore            | modern .NET  | modern .NET  |
  > | DotNETFramework  |    ❌              | netfx               |


### Acknowledgements

We want to express our heartfelt gratitude to everyone who has contributed to this release
by reporting bugs, suggesting enhancements, and providing valuable feedback.
Your efforts help make NUnit better for the entire community.

A special thank you to the following reporters for identifying issues:

<table>
<tr>
<td><a href="https://github.com/CharliePoole">CharliePoole</a></td>
<td><a href="https://github.com/heaths">Heath Stewart</a></td>
<td><a href="https://github.com/hfickes">HF</a></td>
<td><a href="https://github.com/joeldickson">Joel Dickson</a></td>
</tr>
<tr>
<td><a href="https://github.com/MaceWindu">MaceWindu</a></td>
<td><a href="https://github.com/mikkelbu">Mikkel Nylander Bundgaard</a></td>
<td><a href="https://github.com/Smaug123">Patrick Stevens</a></td>
<td><a href="https://github.com/provegard">Per Rovegård</a></td>
</tr>
<tr>
<td><a href="https://github.com/rmiller-glrealitylabs">R. Miller</a></td>
<td><a href="https://github.com/rachied">Rachid</a></td>
<td><a href="https://github.com/rprouse">Rob Prouse</a></td>
<td><a href="https://github.com/stevenaw">Steven Weerdenburg</a></td>
</tr>
<tr>
<td><a href="https://github.com/OsirisTerje">Terje Sandstrom</a></td>
</tr>
</table>


and to the commenters who engaged in discussions and offered further insights:

<table>
<tr>
<td><a href="https://github.com/AmirTahan80">Amir Tahan</a></td>
<td><a href="https://github.com/SinghAnsh07">ANSH SINGH</a></td>
<td><a href="https://github.com/CharliePoole">CharliePoole</a></td>
<td><a href="https://github.com/hfickes">HF</a></td>
</tr>
<tr>
<td><a href="https://github.com/joeldickson">Joel Dickson</a></td>
<td><a href="https://github.com/logiclrd">Jonathan Gilbert</a></td>
<td><a href="https://github.com/jnm2">Joseph Musser</a></td>
<td><a href="https://github.com/m4ggo">m4ggo</a></td>
</tr>
<tr>
<td><a href="https://github.com/MaceWindu">MaceWindu</a></td>
<td><a href="https://github.com/manfred-brands">Manfred Brands</a></td>
<td><a href="https://github.com/MartinFayRAX">MartinFayRAX</a></td>
<td><a href="https://github.com/mikeparker">Mike Parker</a></td>
</tr>
<tr>
<td><a href="https://github.com/mikkelbu">Mikkel Nylander Bundgaard</a></td>
<td><a href="https://github.com/seky16">Ondřej Sekáč</a></td>
<td><a href="https://github.com/Smaug123">Patrick Stevens</a></td>
<td><a href="https://github.com/provegard">Per Rovegård</a></td>
</tr>
<tr>
<td><a href="https://github.com/rmiller-glrealitylabs">R. Miller</a></td>
<td><a href="https://github.com/rachied">Rachid</a></td>
<td><a href="https://github.com/RicardoMacedo-prj">Ricardo Macedo</a></td>
<td><a href="https://github.com/rprouse">Rob Prouse</a></td>
</tr>
<tr>
<td><a href="https://github.com/mr-russ">Russell Smith</a></td>
<td><a href="https://github.com/Shaurya2k06">Shaurya Srivastava</a></td>
<td><a href="https://github.com/Will-thom">Silva Dev BR</a></td>
<td><a href="https://github.com/stevenaw">Steven Weerdenburg</a></td>
</tr>
<tr>
<td><a href="https://github.com/OsirisTerje">Terje Sandstrom</a></td>
</tr>
</table>

