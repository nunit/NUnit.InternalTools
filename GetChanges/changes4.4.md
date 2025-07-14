4998, No pull request found
4995, No pull request found
4994, No pull request found
4990, No pull request found
4981, No pull request found
4975, No pull request found
4968, No pull request found
4964, No pull request found
4954, No pull request found
4945, No pull request found
4937, No pull request found
4935, No pull request found
4933, No pull request found
4930, No pull request found
4919, No pull request found
4917, No pull request found
4916, No pull request found
4909, No pull request found
4906, No pull request found
4687, No pull request found
4545, No pull request found
4537, No pull request found
4244, No pull request found
2841, No pull request found
## 4.4

There are 24 issues fixed in this release.

### Enhancements

* [4975](https://github.com/nunit/nunit/issues/4975) Support ignoring line ending format when comparing strings. 
* [4968](https://github.com/nunit/nunit/issues/4968) Asserts with UsingPropertiesComparer and Tolerance crashes unxpectedly if using TimeSpan and the class contains Properties with different types. 
* [4945](https://github.com/nunit/nunit/issues/4945) Integer `Assert.That(i, Is.Even);`/`Assert.That(i, Is.Odd);` and `Assert.That(i, Is.MultipleOf(step));`. 
* [4935](https://github.com/nunit/nunit/issues/4935) [Feature Request] PropertiesComparer for different types. 
* [4909](https://github.com/nunit/nunit/issues/4909) Assertion failures with PropertiesComparer are hard to debug when combined with other modifiers. 
* [4687](https://github.com/nunit/nunit/issues/4687) Value equality on subset of object properties. 
* [4244](https://github.com/nunit/nunit/issues/4244) [Feature request] EquivalentTo that compares similar objects of different types. 

### Bug fixes

* [4998](https://github.com/nunit/nunit/issues/4998) `PropertyConstraint` Causes Unexpected Behavior Because the Property's Value Is `object` Instead of the Property's Actual Type. 
* [4981](https://github.com/nunit/nunit/issues/4981) ContainsKey doesn't support IgnoreCase, IgnoreWhiteSpace, or IgnoreLineEndingFormat. 
* [4964](https://github.com/nunit/nunit/issues/4964) Is.Not.EqualTo does not work correctly with Using comparer. 
* [4954](https://github.com/nunit/nunit/issues/4954) Regression in `Is.EqualTo(DateTime)` constraint in 4.3.x for types that implement `IEquatable&lt;DateTime&gt;`. 
* [4937](https://github.com/nunit/nunit/issues/4937) `PartitionFilter.ComputeHasValue` throws exception when test name is greater than 4096 characters. 
* [4933](https://github.com/nunit/nunit/issues/4933) Dictionary assertion falsely passes with PropertiesComparer when subtypes are involved. 
* [4919](https://github.com/nunit/nunit/issues/4919) Assert.ThatAsync doesn't work correctly if calling nested Asserts. 
* [4917](https://github.com/nunit/nunit/issues/4917) Multiple unannounced breaking changes in minor version. 
* [4916](https://github.com/nunit/nunit/issues/4916) Is.EqualTo(double).Using(EqualityComparer&lt;double&gt;) causes overload ambiguity error. 
* [4545](https://github.com/nunit/nunit/issues/4545) DelegatingConstraintResult does not use its `_innerResult` for `WriteMessageTo` . 
* [4537](https://github.com/nunit/nunit/issues/4537) AssertException in TearDown hides Exception in Test. 
* [2841](https://github.com/nunit/nunit/issues/2841) DelayedConstraint calls delegate twice. 

### Refactorings

* [4930](https://github.com/nunit/nunit/issues/4930) What to do with `IConstraint.Apply&lt;TActual&gt;(ref TActual)`. 

### Internal fixes

* [4995](https://github.com/nunit/nunit/issues/4995) Check and fix properties for sideeffects. 
* [4994](https://github.com/nunit/nunit/issues/4994) Fix or remove ToString in class ConstraintExpression. 
* [4990](https://github.com/nunit/nunit/issues/4990) FileLoadException for NUnit 4.3.2: System.Buffers 4.0.4 missing. 

### Deprecated features

None
### Others

* [4906](https://github.com/nunit/nunit/issues/4906) Test error in TestContextOneTimeTearDownTests. 

### The following issues are marked as breaking changes

* [4930](https://github.com/nunit/nunit/issues/4930) What to do with `IConstraint.Apply&lt;TActual&gt;(ref TActual)`. 


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
<td><a href="https://github.com/Sputnik24">Sputnik24</a></td>
</tr>
<tr>
<td><a href="https://github.com/Star62enis">Star62enis</a></td>
<td><a href="https://github.com/SFrank1966">Stefan Frank</a></td>
<td><a href="https://github.com/stevenaw">Steven Weerdenburg</a></td>
<td><a href="https://github.com/OsirisTerje">Terje Sandstrom</a></td>
</tr>
<tr>
<td><a href="https://github.com/vvidetta-gearset">Vito Videtta</a></td>
</tr>
</table>

