## 4.6

There are 10 issues fixed in this release.

### Enhancements

* [1138](https://github.com/nunit/nunit3-vs-adapter/issues/1138) Add partition filter parsing to the adapter. 
* [1114](https://github.com/nunit/nunit3-vs-adapter/issues/1114) Is test result file creation now supported by NUnit using dotnet test?. 

### Bug fixes

* [1186](https://github.com/nunit/nunit3-vs-adapter/issues/1186) Failure during unit test discovery doesn't cause entire test suite to fail. 
* [1110](https://github.com/nunit/nunit3-vs-adapter/issues/1110) ConsoleOut=1 should be default. 
* [1109](https://github.com/nunit/nunit3-vs-adapter/issues/1109) ConsoleOut=0 should turn off console output but doesn't. 

### Refactorings

* [1115](https://github.com/nunit/nunit3-vs-adapter/issues/1115) Use mutex for file determination in TestOutputXml. 

### Internal fixes

* [1163](https://github.com/nunit/nunit3-vs-adapter/issues/1163) Update packages and clean up new warnings. 
* [1159](https://github.com/nunit/nunit3-vs-adapter/issues/1159) Remove azure pipeline and appveyor builds. 
* [1158](https://github.com/nunit/nunit3-vs-adapter/issues/1158) Acceptance tests not working after NUnit 4 was released.. 

### Deprecated features

None

### Others

* [1122](https://github.com/nunit/nunit3-vs-adapter/issues/1122) testcentric.engine.metadata (vulnerable dependency). 

### The following issues are marked as breaking changes

* [1110](https://github.com/nunit/nunit3-vs-adapter/issues/1110) ConsoleOut=1 should be default. Change from former where ConsoleOut=2 was default.

