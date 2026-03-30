5137, No pull request found
## 4.5.1

There are 7 issues fixed in this release.

### Enhancements

* [5126](https://github.com/nunit/nunit/issues/5126) `ITestResult.TotalCount` does not seem to behave as specified. Thanks to [maettu-this](https://github.com/maettu-this) for [PR 5127](https://github.com/nunit/nunit/pull/5127)

### Bug fixes

* [5152](https://github.com/nunit/nunit/issues/5152) Assert of byte with Is.EqualTo().Within().Percent fails unexpectedly. Thanks to NUnit Team member [Steven Weerdenburg](https://github.com/stevenaw) for [PR 5153](https://github.com/nunit/nunit/pull/5153)
* [5137](https://github.com/nunit/nunit/issues/5137) Task Synchronization Issue after upgrading to 4.5.0. 
* [5133](https://github.com/nunit/nunit/issues/5133) All tests fail with "TargetFramework doesn't support timeout on tests" when switching from NUnit 4.4 to NUnit 4.5. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 5140](https://github.com/nunit/nunit/pull/5140)
* [5129](https://github.com/nunit/nunit/issues/5129) Passing `Array` as test parameter fails with 4.5.0. Thanks to NUnit Team member [Terje Sandstrom](https://github.com/OsirisTerje) for [PR 5130](https://github.com/nunit/nunit/pull/5130)
* [4658](https://github.com/nunit/nunit/issues/4658) Apartment attribute ignored when .runsettings contains DefaultTimeout. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 5140](https://github.com/nunit/nunit/pull/5140)

### Refactorings

None
### Internal fixes

None
### Deprecated features

None
### Others

* [5131](https://github.com/nunit/nunit/issues/5131) Migrate in-memory assembly generation in the tests to run on all runtimes. Thanks to NUnit Team member [Manfred Brands](https://github.com/manfred-brands) for [PR 5142](https://github.com/nunit/nunit/pull/5142)

### The following issues are marked as breaking changes

None

### Acknowledgements

We want to express our heartfelt gratitude to everyone who has contributed to this release
by reporting bugs, suggesting enhancements, and providing valuable feedback.
Your efforts help make NUnit better for the entire community.

A special thank you to the following reporters for identifying issues:

<table>
<tr>
<td><a href="https://github.com/cbersch">Christoph Bersch</a></td>
<td><a href="https://github.com/dd-eg">dd-eg</a></td>
<td><a href="https://github.com/JakenVeina">Jake Meiergerd</a></td>
<td><a href="https://github.com/maettu-this">maettu-this</a></td>
</tr>
<tr>
<td><a href="https://github.com/michaelmuller12">michaelmuller12</a></td>
<td><a href="https://github.com/RalfKoban">Ralf Koban</a></td>
<td><a href="https://github.com/stevenaw">Steven Weerdenburg</a></td>
</tr>
</table>


and to the commenters who engaged in discussions and offered further insights:

<table>
<tr>
<td><a href="https://github.com/freever">Adrian Frielinghaus</a></td>
<td><a href="https://github.com/apps/cursor">cursor[bot]</a></td>
<td><a href="https://github.com/dd-eg">dd-eg</a></td>
<td><a href="https://github.com/flownzu">Florian J„ckel</a></td>
</tr>
<tr>
<td><a href="https://github.com/JakenVeina">Jake Meiergerd</a></td>
<td><a href="https://github.com/jzapletal95">Jir¡ Zapletal</a></td>
<td><a href="https://github.com/maettu-this">maettu-this</a></td>
<td><a href="https://github.com/manfred-brands">Manfred Brands</a></td>
</tr>
<tr>
<td><a href="https://github.com/michaelmuller12">michaelmuller12</a></td>
<td><a href="https://github.com/mikkelbu">Mikkel Nylander Bundgaard</a></td>
<td><a href="https://github.com/RichardR-cg">Richard R.</a></td>
<td><a href="https://github.com/rprouse">Rob Prouse</a></td>
</tr>
<tr>
<td><a href="https://github.com/simontom">Saymon</a></td>
<td><a href="https://github.com/stevenaw">Steven Weerdenburg</a></td>
<td><a href="https://github.com/OsirisTerje">Terje Sandstrom</a></td>
</tr>
</table>

