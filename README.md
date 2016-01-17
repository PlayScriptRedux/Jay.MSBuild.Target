# Jay.MSBuild.Target

> Adds `.jay` file MSBuild targets to your project. Works both on a developer workstation and on a CI build server.

For Mono's Jay (Yacc-based) parser generator:
[https://github.com/mono/mono/tree/master/mcs/jay](https://github.com/mono/mono/tree/master/mcs/jay)

## Supported:

* OS-X (tools\jay.darwin)
* Windows (tools\jay.exe)
	* Note: jay.exe is a 0-byte placeholder, place a local copy of jay.exe into the build directory for the target to be funcional.

## TODO:

* Add Linux support.