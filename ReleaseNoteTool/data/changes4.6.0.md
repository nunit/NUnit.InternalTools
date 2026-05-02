## 4.6

There are 27 issues fixed in this release.

### Enhancements

* [5232](https://github.com/nunit/nunit/issues/5232) Run the collection equivalency tests on MacOS. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5234](https://github.com/nunit/nunit/pull/5234)
* [5173](https://github.com/nunit/nunit/issues/5173) Access to the actual Exception object. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 5217](https://github.com/nunit/nunit/pull/5217)
* [5158](https://github.com/nunit/nunit/issues/5158) Constants for canonical platform names. Thanks to [Jonathan Gilbert](https://github.com/logiclrd) for [PR 5159](https://github.com/nunit/nunit/pull/5159)
* [5132](https://github.com/nunit/nunit/issues/5132) Thread.Abort() in Test causes "Test cancelled by user" result for NUnit 4.5.0. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 5171](https://github.com/nunit/nunit/pull/5171)
* [4824](https://github.com/nunit/nunit/issues/4824) Convert `TestDelegate` and `ActualValueDelegate` to `Action` and `Func&lt;T&gt;`. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 5196](https://github.com/nunit/nunit/pull/5196)
* [4254](https://github.com/nunit/nunit/issues/4254) Improve performance of equivalency, superset, and subset constraints for homogenous collections. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5224](https://github.com/nunit/nunit/pull/5224)
* [4240](https://github.com/nunit/nunit/issues/4240) Feature request: Run the tests in main thread. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5188](https://github.com/nunit/nunit/pull/5188)
* [4156](https://github.com/nunit/nunit/issues/4156) [Timeout] doesn't work on abstract class fixtures. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 5167](https://github.com/nunit/nunit/pull/5167)
* [4128](https://github.com/nunit/nunit/issues/4128) Improve how exception are displayed. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 5216](https://github.com/nunit/nunit/pull/5216)
* [3822](https://github.com/nunit/nunit/issues/3822) Make ArgDisplayNames public. Thanks to [Paul Irwin](https://github.com/paulirwin) for [PR 5236](https://github.com/nunit/nunit/pull/5236)
* [3663](https://github.com/nunit/nunit/issues/3663) When TestCaseSource produces empty cases collection, test should be Passed/Failed/Inconclusive per creator expectation. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5125](https://github.com/nunit/nunit/pull/5125)
* [2933](https://github.com/nunit/nunit/issues/2933) Add Is.SameAs overload with a reference type constraint. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5134](https://github.com/nunit/nunit/pull/5134)
* [4128](https://github.com/nunit/nunit/issues/4128) Improve how exception are displayed. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 5216](https://github.com/nunit/nunit/pull/5216)
* [3822](https://github.com/nunit/nunit/issues/3822) Make ArgDisplayNames public. Thanks to [Paul Irwin](https://github.com/paulirwin) for [PR 5236](https://github.com/nunit/nunit/pull/5236)
* [3663](https://github.com/nunit/nunit/issues/3663) When TestCaseSource produces empty cases collection, test should be Passed/Failed/Inconclusive per creator expectation. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5125](https://github.com/nunit/nunit/pull/5125)

### Bug fixes

* [5238](https://github.com/nunit/nunit/issues/5238) `HookData.Exception` will report an NUnit-wrapped exception object in `AfterTestHook(HookData hookData)`. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5240](https://github.com/nunit/nunit/pull/5240)
* [5237](https://github.com/nunit/nunit/issues/5237) `Assert.Pass()` can cause `HookData.Exception` to be populated with an exception. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5240](https://github.com/nunit/nunit/pull/5240)
* [5194](https://github.com/nunit/nunit/issues/5194) Add generic SameAs&lt;&gt; to `ConstraintExpression`. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5200](https://github.com/nunit/nunit/pull/5200)
* [5179](https://github.com/nunit/nunit/issues/5179) Change in behaviour in v4.5 when passing a single "null" to a "params" test method via testcasesource. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 5184](https://github.com/nunit/nunit/pull/5184)
* [5178](https://github.com/nunit/nunit/issues/5178) Passing IEnumerable&lt;object&gt; from TestCaseSource to a generic method seems to break in some cases. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 5195](https://github.com/nunit/nunit/pull/5195)
* [5161](https://github.com/nunit/nunit/issues/5161) PlatformAttribute is declared `AllowMultiple = true` but that doesn't work. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 5166](https://github.com/nunit/nunit/pull/5166)
* [5146](https://github.com/nunit/nunit/issues/5146) Stack overflow in PropertiesComparer when object has property of its own value type. 
* [4131](https://github.com/nunit/nunit/issues/4131) Platform filter is not inherited. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 5166](https://github.com/nunit/nunit/pull/5166)

### Refactorings

None
### Internal fixes

* [5198](https://github.com/nunit/nunit/issues/5198) Benchmarkdotnet. Thanks to NUnit Team member [Terje Sandstrom](https://github.com/OsirisTerje) for [PR 5203](https://github.com/nunit/nunit/pull/5203)
* [5186](https://github.com/nunit/nunit/issues/5186) Optimize NUnit's array unpacking. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5202](https://github.com/nunit/nunit/pull/5202)
* [5182](https://github.com/nunit/nunit/issues/5182) Remove unnecessary NUnit analyzer suppressions from latest analyzer package. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5183](https://github.com/nunit/nunit/pull/5183)
* [5168](https://github.com/nunit/nunit/issues/5168) Check tests and documentation for the Platform attribute. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5204](https://github.com/nunit/nunit/pull/5204)
* [5154](https://github.com/nunit/nunit/issues/5154) Apply some internal string optimizations. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5155](https://github.com/nunit/nunit/pull/5155)
* [5193](https://github.com/nunit/nunit/issues/5193) Update cake to v6.1. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5201](https://github.com/nunit/nunit/pull/5201)
* [5189](https://github.com/nunit/nunit/issues/5189) Update cake to latest 5.x version. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5190](https://github.com/nunit/nunit/pull/5190)

### Deprecated features

None
### The following issues are marked as breaking changes

* [4824](https://github.com/nunit/nunit/issues/4824) Convert `TestDelegate` and `ActualValueDelegate` to `Action` and `Func&lt;T&gt;`. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 5196](https://github.com/nunit/nunit/pull/5196)

  > [!IMPORTANT]
  > This issue is a partially breaking change.  
  > 
  > If you use TestDelegate and Action **explicitly** , you must either:
  > * Alternative 1:  Set your target framework to  .Net 9.0 or higher
  > * Alternative 2:  You must set your language version to 13 or higher, and use the Visual Studio 2022 version 17.12 or higher, or use .NET 9 SDK (which includes the C# 13 compiler), while still targeting .net8 or lower.
  > 
  > | Scenario                              | NUnit pre 4.6 | NUnit 4.6+ (.net < 9.0)  | NUnit 4.6+ (.net >= 9.0) | NUnit 4.6+ (.net<9.0 and  langversion >=13) |
  > | ------------------------------------- | ------------------------------- | ----------------- | ------ | ----- |
  > | Inline lambda                         | ✅                              | ❌ (breaking)                   | ✅                 | ✅                 |
  > | `Action` / `Func<T>` (inline lambda)  | ✅ (via implicit conversion)     | ❌ (breaking)                  | ✅                 |✅                 |
  > | `Action` / `Func<T>` (as variable)    | ❌ (type mismatch)              | ✅                 | ✅                 |✅                 |
  > | Explicit `TestDelegate` usage         | ✅                              | ❌ (breaking)      | ✅                 |✅                 |
  > | Evaluates functions | ❗  (success, but no eval) |  ✅ | ✅|✅                 |
  > ---
  > Examples of explicit TestDelegate usages are:
  > 
  > - Explicit variable (most common)
  > - Method return types
  > - Method parameters / helpers
  > - Fields / properties
  > - Extension / library code (important) (3rd party helpers or frameworks)
  > 
  > Code for reproduction of these cases can be found at https://github.com/nunit/nunit.issues/tree/main/Issue4824 


### Acknowledgements

We want to express our heartfelt gratitude to everyone who has contributed to this release
by reporting bugs, suggesting enhancements, and providing valuable feedback.
Your efforts help make NUnit better for the entire community.

A special thank you to the following reporters for identifying issues:

<table>
<tr>
<td><a href="https://github.com/AlexKay34">Alexander Kaiser</a></td>
<td><a href="https://github.com/bmalrat">bmalrat</a></td>
<td><a href="https://github.com/ccarmannt">ccarmannt</a></td>
<td><a href="https://github.com/logiclrd">Jonathan Gilbert</a></td>
</tr>
<tr>
<td><a href="https://github.com/jnm2">Joseph Musser</a></td>
<td><a href="https://github.com/manfred-brands">Manfred Brands</a></td>
<td><a href="https://github.com/WindingWinter">OccamRazor</a></td>
<td><a href="https://github.com/Sergey-Terekhin">Sergey Terekhin</a></td>
</tr>
<tr>
<td><a href="https://github.com/Socolin">Socolin - Bertrand Provost</a></td>
<td><a href="https://github.com/stevenaw">Steven Weerdenburg</a></td>
<td><a href="https://github.com/OsirisTerje">Terje Sandstrom</a></td>
<td><a href="https://github.com/tobyash86">tobyash86</a></td>
</tr>
<tr>
<td><a href="https://github.com/MrPerun">Tomáš Vichta</a></td>
<td><a href="https://github.com/willdean">Will Dean</a></td>
</tr>
</table>


and to the commenters who engaged in discussions and offered further insights:

<table>
<tr>
<td><a href="https://github.com/AlexKay34">Alexander Kaiser</a></td>
<td><a href="https://github.com/cbmarcum">Carl Marcum</a></td>
<td><a href="https://github.com/ccarmannt">ccarmannt</a></td>
<td><a href="https://github.com/CharliePoole">CharliePoole</a></td>
</tr>
<tr>
<td><a href="https://github.com/ChrisMaddock">Chris Maddock</a></td>
<td><a href="https://github.com/komdil">Dilshod Komilov</a></td>
<td><a href="https://github.com/twirlse">Evgeny Lukashevich</a></td>
<td><a href="https://github.com/FireController1847">FireController#1847</a></td>
</tr>
<tr>
<td><a href="https://github.com/logiclrd">Jonathan Gilbert</a></td>
<td><a href="https://github.com/JordanW9232">JordanW9232</a></td>
<td><a href="https://github.com/jnm2">Joseph Musser</a></td>
<td><a href="https://github.com/manfred-brands">Manfred Brands</a></td>
</tr>
<tr>
<td><a href="https://github.com/mbcrawfo">Michael Crawford</a></td>
<td><a href="https://github.com/mikkelbu">Mikkel Nylander Bundgaard</a></td>
<td><a href="https://github.com/WindingWinter">OccamRazor</a></td>
<td><a href="https://github.com/Dreamescaper">Oleksandr Liakhevych</a></td>
</tr>
<tr>
<td><a href="https://github.com/paulirwin">Paul Irwin</a></td>
<td><a href="https://github.com/rprouse">Rob Prouse</a></td>
<td><a href="https://github.com/Sergey-Terekhin">Sergey Terekhin</a></td>
<td><a href="https://github.com/SimonCropp">Simon Cropp</a></td>
</tr>
<tr>
<td><a href="https://github.com/Socolin">Socolin - Bertrand Provost</a></td>
<td><a href="https://github.com/z002Holpp">Stefan Holpp</a></td>
<td><a href="https://github.com/stevenaw">Steven Weerdenburg</a></td>
<td><a href="https://github.com/OsirisTerje">Terje Sandstrom</a></td>
</tr>
<tr>
<td><a href="https://github.com/Mikhinja">Vlad Catalina</a></td>
<td><a href="https://github.com/willdean">Will Dean</a></td>
<td><a href="https://github.com/anoftc">Zsolt Szabo-Resch</a></td>
</tr>
</table>

