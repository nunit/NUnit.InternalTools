## 6.2

There are 8 issues fixed in this release.

### Enhancements

* [1426](https://github.com/nunit/nunit3-vs-adapter/issues/1426) [MTP] --list-tests does not respect --filter. Thanks to NUnit Team member [Terje Sandstrom](https://github.com/OsirisTerje) for [PR 1427](https://github.com/nunit/nunit3-vs-adapter/pull/1427)
* [1227](https://github.com/nunit/nunit3-vs-adapter/issues/1227)  Listing the discovered tests doesn't respect the filter. Thanks to NUnit Team member [Terje Sandstrom](https://github.com/OsirisTerje) for [PR 1427](https://github.com/nunit/nunit3-vs-adapter/pull/1427)
* [438](https://github.com/nunit/nunit3-vs-adapter/issues/438) vstest.console's `--TestCaseFilter` is ignored when listing tests. Thanks to NUnit Team member [Terje Sandstrom](https://github.com/OsirisTerje) for [PR 1427](https://github.com/nunit/nunit3-vs-adapter/pull/1427)

### Bug fixes

* [1400](https://github.com/nunit/nunit3-vs-adapter/issues/1400) Nunit3TestAdapter 6.1.0 copies unwanted version of Microsoft.Extensions.DependencyModel.dll into output. Thanks to NUnit Team member [Terje Sandstrom](https://github.com/OsirisTerje) for [PR 1401](https://github.com/nunit/nunit3-vs-adapter/pull/1401)
* [1398](https://github.com/nunit/nunit3-vs-adapter/issues/1398) NUnit3TestAdapter &gt;= 6.0.1 requires pinning Microsoft.Extensions.DependencyModel when using Microsoft.Testing.Extensions.CodeCoverage. Thanks to NUnit Team member [Terje Sandstrom](https://github.com/OsirisTerje) for [PR 1401](https://github.com/nunit/nunit3-vs-adapter/pull/1401)
* [1396](https://github.com/nunit/nunit3-vs-adapter/issues/1396) Resharper test runner fails with NUnit3TestAdapter 6.0.1. Thanks to NUnit Team member [Terje Sandstrom](https://github.com/OsirisTerje) for [PR 1401](https://github.com/nunit/nunit3-vs-adapter/pull/1401)
* [1361](https://github.com/nunit/nunit3-vs-adapter/issues/1361) `dotnet test` using MTP with NUnit3TestAdapter cannot be cancelled on CLI. Thanks to NUnit Team member [Terje Sandstrom](https://github.com/OsirisTerje) for [PR 1412](https://github.com/nunit/nunit3-vs-adapter/pull/1412)

### Refactorings

* [1386](https://github.com/nunit/nunit3-vs-adapter/issues/1386) Get rid of assembly refs, use package refs. Thanks to NUnit Team member [Terje Sandstrom](https://github.com/OsirisTerje) for [PR 1401](https://github.com/nunit/nunit3-vs-adapter/pull/1401)

### Internal fixes

None
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
<td><a href="https://github.com/bradford-fisher">Bradford Fisher</a></td>
<td><a href="https://github.com/davidbarrowsatasos">David Barrows</a></td>
<td><a href="https://github.com/julealgon">Juliano Leal Goncalves</a></td>
<td><a href="https://github.com/Lexy2">Lexy</a></td>
</tr>
<tr>
<td><a href="https://github.com/BrightLight">Markus Hastreiter</a></td>
<td><a href="https://github.com/siegfriedpammer">Siegfried Pammer</a></td>
<td><a href="https://github.com/starosta33">starosta33</a></td>
<td><a href="https://github.com/OsirisTerje">Terje Sandstrom</a></td>
</tr>
</table>


and to the commenters who engaged in discussions and offered further insights:

<table>
<tr>
<td><a href="https://github.com/andrewimcclement">andrewimcclement</a></td>
<td><a href="https://github.com/bradford-fisher">Bradford Fisher</a></td>
<td><a href="https://github.com/CharliePoole">CharliePoole</a></td>
<td><a href="">Copilot</a></td>
</tr>
<tr>
<td><a href="https://github.com/ds-ms2soft">Dave Sweeton</a></td>
<td><a href="https://github.com/davidbarrowsatasos">David Barrows</a></td>
<td><a href="https://github.com/julealgon">Juliano Leal Goncalves</a></td>
<td><a href="https://github.com/MaceWindu">MaceWindu</a></td>
</tr>
<tr>
<td><a href="https://github.com/manfred-brands">Manfred Brands</a></td>
<td><a href="https://github.com/siegfriedpammer">Siegfried Pammer</a></td>
<td><a href="https://github.com/stevenaw">Steven Weerdenburg</a></td>
<td><a href="https://github.com/OsirisTerje">Terje Sandstrom</a></td>
</tr>
<tr>
<td><a href="https://github.com/thomasdgx">thomasdgx</a></td>
<td><a href="https://github.com/Youssef1313">Youssef Victor</a></td>
</tr>
</table>

