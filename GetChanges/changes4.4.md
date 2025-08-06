## 4.4

There are 26 issues fixed in this release.

### Enhancements

* [4975](https://github.com/nunit/nunit/issues/4975) Support ignoring line ending format when comparing strings. Thanks to [Jihoon Park](https://github.com/Bartleby2718) for [PR 4976](https://github.com/nunit/nunit/pull/4976)
* [4968](https://github.com/nunit/nunit/issues/4968) Asserts with UsingPropertiesComparer and Tolerance crashes unxpectedly if using TimeSpan and the class contains Properties with different types. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 4972](https://github.com/nunit/nunit/pull/4972)
* [4945](https://github.com/nunit/nunit/issues/4945) Integer `Assert.That(i, Is.Even);`/`Assert.That(i, Is.Odd);` and `Assert.That(i, Is.MultipleOf(step));`. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 4946](https://github.com/nunit/nunit/pull/4946)
* [4935](https://github.com/nunit/nunit/issues/4935) [Feature Request] PropertiesComparer for different types. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 4925](https://github.com/nunit/nunit/pull/4925)
* [4909](https://github.com/nunit/nunit/issues/4909) Assertion failures with PropertiesComparer are hard to debug when combined with other modifiers. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 4922](https://github.com/nunit/nunit/pull/4922)
* [4687](https://github.com/nunit/nunit/issues/4687) Value equality on subset of object properties. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 4925](https://github.com/nunit/nunit/pull/4925)
* [4244](https://github.com/nunit/nunit/issues/4244) [Feature request] EquivalentTo that compares similar objects of different types. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 4925](https://github.com/nunit/nunit/pull/4925)

### Bug fixes

* [5011](https://github.com/nunit/nunit/issues/5011) Breaking change in version 4.4.0-beta.1. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 5013](https://github.com/nunit/nunit/pull/5013)
* [4998](https://github.com/nunit/nunit/issues/4998) `PropertyConstraint` Causes Unexpected Behavior Because the Property's Value Is `object` Instead of the Property's Actual Type. Thanks to [LeQuackers](https://github.com/LeQuackers) for [PR 5003](https://github.com/nunit/nunit/pull/5003)
* [4981](https://github.com/nunit/nunit/issues/4981) ContainsKey doesn't support IgnoreCase, IgnoreWhiteSpace, or IgnoreLineEndingFormat. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 4989](https://github.com/nunit/nunit/pull/4989)
* [4964](https://github.com/nunit/nunit/issues/4964) Is.Not.EqualTo does not work correctly with Using comparer. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 4965](https://github.com/nunit/nunit/pull/4965)
* [4954](https://github.com/nunit/nunit/issues/4954) Regression in `Is.EqualTo(DateTime)` constraint in 4.3.x for types that implement `IEquatable&lt;DateTime&gt;`. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 4957](https://github.com/nunit/nunit/pull/4957)
* [4937](https://github.com/nunit/nunit/issues/4937) `PartitionFilter.ComputeHasValue` throws exception when test name is greater than 4096 characters. Thanks to [Will Ray](https://github.com/WillRayAtPropertyMe) for [PR 4941](https://github.com/nunit/nunit/pull/4941)
* [4933](https://github.com/nunit/nunit/issues/4933) Dictionary assertion falsely passes with PropertiesComparer when subtypes are involved. Thanks to [Oleksandr Liakhevych](https://github.com/Dreamescaper) for [PR 4934](https://github.com/nunit/nunit/pull/4934)
* [4919](https://github.com/nunit/nunit/issues/4919) Assert.ThatAsync doesn't work correctly if calling nested Asserts. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 4922](https://github.com/nunit/nunit/pull/4922)
* [4917](https://github.com/nunit/nunit/issues/4917) Multiple unannounced breaking changes in minor version. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 4927](https://github.com/nunit/nunit/pull/4927)
* [4916](https://github.com/nunit/nunit/issues/4916) Is.EqualTo(double).Using(EqualityComparer&lt;double&gt;) causes overload ambiguity error. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 4951](https://github.com/nunit/nunit/pull/4951)
* [4545](https://github.com/nunit/nunit/issues/4545) DelegatingConstraintResult does not use its `_innerResult` for `WriteMessageTo` . Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 4922](https://github.com/nunit/nunit/pull/4922)
* [4537](https://github.com/nunit/nunit/issues/4537) AssertException in TearDown hides Exception in Test. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 4979](https://github.com/nunit/nunit/pull/4979)
* [2841](https://github.com/nunit/nunit/issues/2841) DelayedConstraint calls delegate twice. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 4929](https://github.com/nunit/nunit/pull/4929)

### Refactorings

* [4930](https://github.com/nunit/nunit/issues/4930) What to do with `IConstraint.Apply&lt;TActual&gt;(ref TActual)`. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 4944](https://github.com/nunit/nunit/pull/4944)

### Internal fixes

* [5014](https://github.com/nunit/nunit/issues/5014) Use span-based APIs to construct random GUIDs on non-framework codepath. Thanks to [zaidonolsen](https://github.com/zaidonolsen) for [PR 5015](https://github.com/nunit/nunit/pull/5015)
* [4995](https://github.com/nunit/nunit/issues/4995) Check and fix properties for sideeffects. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 5001](https://github.com/nunit/nunit/pull/5001)
* [4994](https://github.com/nunit/nunit/issues/4994) Fix or remove ToString in class ConstraintExpression. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 5001](https://github.com/nunit/nunit/pull/5001)
* [4990](https://github.com/nunit/nunit/issues/4990) FileLoadException for NUnit 4.3.2: System.Buffers 4.0.4 missing. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 4991](https://github.com/nunit/nunit/pull/4991)

### Deprecated features

None
### Others

* [4906](https://github.com/nunit/nunit/issues/4906) Test error in TestContextOneTimeTearDownTests. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 4928](https://github.com/nunit/nunit/pull/4928)

### The following issues are marked as breaking changes

* [4930](https://github.com/nunit/nunit/issues/4930) What to do with `IConstraint.Apply&lt;TActual&gt;(ref TActual)`. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 4944](https://github.com/nunit/nunit/pull/4944)


### Acknowledgements

We want to express our heartfelt gratitude to everyone who has contributed to this release
by reporting bugs, suggesting enhancements, and providing valuable feedback.
Your efforts help make NUnit better for the entire community.

A special thank you to the following reporters for identifying issues:

<table>
<tr>
<td><a href="https://github.com/Taron-art">Artur Kharin</a></td>
<td><a href="https://github.com/KrzysFR">Christophe Chevalier</a></td>
<td><a href="https://github.com/metoule">Christophe PLAT</a></td>
<td><a href="https://github.com/Rabadash8820">Dan Vicarel</a></td>
</tr>
<tr>
<td><a href="https://github.com/Edgaras91">Edgaras</a></td>
<td><a href="https://github.com/verdie-g">GrÇgoire</a></td>
<td><a href="https://github.com/IgorVyatkin">Igor Vyatkin</a></td>
<td><a href="https://github.com/Bartleby2718">Jihoon Park</a></td>
</tr>
<tr>
<td><a href="https://github.com/appel1">Johan Appelgren</a></td>
<td><a href="https://github.com/killergege">Julien Nigay</a></td>
<td><a href="https://github.com/juergstaub">JÅrg Staub</a></td>
<td><a href="https://github.com/LeQuackers">LeQuackers</a></td>
</tr>
<tr>
<td><a href="https://github.com/maettu-this">maettu-this</a></td>
<td><a href="https://github.com/manfred-brands">Manfred Brands</a></td>
<td><a href="https://github.com/Dreamescaper">Oleksandr Liakhevych</a></td>
<td><a href="https://github.com/Sputnik24">Sputnik24</a></td>
</tr>
<tr>
<td><a href="https://github.com/SFrank1966">Stefan Frank</a></td>
<td><a href="https://github.com/stevenaw">Steven Weerdenburg</a></td>
<td><a href="https://github.com/OsirisTerje">Terje Sandstrom</a></td>
<td><a href="https://github.com/WillRayAtPropertyMe">Will Ray</a></td>
</tr>
</table>


and to the commenters who engaged in discussions and offered further insights:

<table>
<tr>
<td><a href="https://github.com/anders9ustafsson">Anders Gustafsson</a></td>
<td><a href="https://github.com/agray">Andrew Gray</a></td>
<td><a href="https://github.com/CharliePoole">CharliePoole</a></td>
<td><a href="https://github.com/cfuerbachersparks">Christoph</a></td>
</tr>
<tr>
<td><a href="https://github.com/metoule">Christophe PLAT</a></td>
<td><a href="https://github.com/Rabadash8820">Dan Vicarel</a></td>
<td><a href="https://github.com/schrufygroovy">David Schruf</a></td>
<td><a href="https://github.com/Edgaras91">Edgaras</a></td>
</tr>
<tr>
<td><a href="https://github.com/glassesarms">ethan</a></td>
<td><a href="https://github.com/verdie-g">GrÇgoire</a></td>
<td><a href="https://github.com/IgorVyatkin">Igor Vyatkin</a></td>
<td><a href="https://github.com/Bartleby2718">Jihoon Park</a></td>
</tr>
<tr>
<td><a href="https://github.com/appel1">Johan Appelgren</a></td>
<td><a href="https://github.com/jnm2">Joseph Musser</a></td>
<td><a href="https://github.com/killergege">Julien Nigay</a></td>
<td><a href="https://github.com/juergstaub">JÅrg Staub</a></td>
</tr>
<tr>
<td><a href="https://github.com/LeQuackers">LeQuackers</a></td>
<td><a href="https://github.com/maettu-this">maettu-this</a></td>
<td><a href="https://github.com/manfred-brands">Manfred Brands</a></td>
<td><a href="https://github.com/mikkelbu">Mikkel Nylander Bundgaard</a></td>
</tr>
<tr>
<td><a href="https://github.com/Dreamescaper">Oleksandr Liakhevych</a></td>
<td><a href="https://github.com/pembebiri">pembebiri</a></td>
<td><a href="https://github.com/SeanKilleen">Sean Killeen</a></td>
<td><a href="https://github.com/siva1160github">Sivasubramanian T</a></td>
</tr>
<tr>
<td><a href="https://github.com/Sputnik24">Sputnik24</a></td>
<td><a href="https://github.com/Star62enis">Star62enis</a></td>
<td><a href="https://github.com/SFrank1966">Stefan Frank</a></td>
<td><a href="https://github.com/stevenaw">Steven Weerdenburg</a></td>
</tr>
<tr>
<td><a href="https://github.com/OsirisTerje">Terje Sandstrom</a></td>
<td><a href="https://github.com/vvidetta-gearset">Vito Videtta</a></td>
<td><a href="https://github.com/WillRayAtPropertyMe">Will Ray</a></td>
<td><a href="https://github.com/zaidonolsen">zaidonolsen</a></td>
</tr>
</table>

