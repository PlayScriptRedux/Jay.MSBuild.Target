CONFIG?=Debug

all: clean compile task test pack content 

compile:
	xbuild /target:Build /p:Configuration=${CONFIG}

pack:
	nuget pack Jay.MSBuild.Target.nuspec

test: 

task:

clean:
	xbuild /target:Clean /p:Configuration=${CONFIG} ${ARGS}
	-rm Jay.MSBuild.Target.*.nupkg

publish: clean all
	nuget push Jay.MSBuild.*.nupkg $(MyGetApiKey) -source https://www.myget.org/F/playscript/api/v2

content:
	unzip -l Jay.MSBuild.*.nupkg
