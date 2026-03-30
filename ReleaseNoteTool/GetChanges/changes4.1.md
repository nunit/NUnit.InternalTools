## 4.1

There are 8 issues fixed in this release.

### Enhancements

* [4600](https://github.com/nunit/nunit/issues/4600) Add `DateTime`/`TimeSpan` support for inequality tolerance. Thanks to [Michael Render](https://github.com/RenderMichael) for [PR 4618](https://github.com/nunit/nunit/pull/4618)
* [4572](https://github.com/nunit/nunit/issues/4572) Make new PropertiesComparer optional. Fixed by team [PR 4608](https://github.com/nunit/nunit/pull/4608) ( Adding modifier UsingPropertiesComparer() to AnyOf-)
* [1215](https://github.com/nunit/nunit/issues/1215) Explicit specification of generic method types on TestCase and TestCaseSource. Fixed by team [PR 4620](https://github.com/nunit/nunit/pull/4620) ( See [TestOf](https://docs.nunit.org/articles/nunit/writing-tests/attributes/testof.html) documentation.)

### Bug fixes

* [4602](https://github.com/nunit/nunit/issues/4602) WpfMessagePumpStrategy - change from Dispatcher.Run to Dispatcher.PushFrame . Thanks to [soerendd](https://github.com/soerendd) for [PR 4603](https://github.com/nunit/nunit/pull/4603)
* [4591](https://github.com/nunit/nunit/issues/4591) Parameter count mismatch with indexer. Fixed by team [PR 4608](https://github.com/nunit/nunit/pull/4608)
* [4581](https://github.com/nunit/nunit/issues/4581) NUnit 4 needs System.Threading.Tasks.Extensions for net472 tests. Fixed by team [PR 4582](https://github.com/nunit/nunit/pull/4582)

### Refactorings

* [4626](https://github.com/nunit/nunit/issues/4626) Remove link in readme to the google discuss group, it's spammed.. Fixed by team [PR 4627](https://github.com/nunit/nunit/pull/4627)

### Internal fixes

* [4606](https://github.com/nunit/nunit/issues/4606) GitHub Actions fail on `master` for Windows and Linux builds. Fixed by team [PR 4607](https://github.com/nunit/nunit/pull/4607)

### Deprecated features

None

### The following issues are marked as breaking changes

None

