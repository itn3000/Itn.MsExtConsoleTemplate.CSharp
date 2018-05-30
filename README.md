# Itn.MsExtConsoleTemplate.CSharp

dotnet new console template with Microsoft.Extensions packages

if you want to get detailed instructions about dotnet new template,
see https://docs.microsoft.com/en-us/dotnet/core/tutorials/create-custom-template 


# HowTo

## Creating nupkg

run the following command

`powershell(or pwsh) ./createnupkg.ps1`

then you get pkg/*.nupkg

## enable template

run the following command

`dotnet new -i ./pkg/[nupkgfilename]`

## creating project from template

run the following command

`dotnet new [templateshortname] --name [yourprojectname]`

## disable template

`dotnet new -u [template id]`

IDs are here;

* Itn.CakeBuildTemplate
* Itn.MsExtConsoleTemplate.CSharp
* Itn.NewClassTemplate.CSharp
* Itn.MsMLIrisTemplate.CSharp
* Itn.BDNTemplate.CSharp

## published packages

following templates are published in nuget.org.

* [Itn.BDNTemplate.CSharp](https://www.nuget.org/packages/Itn.BDNTemplate.CSharp)