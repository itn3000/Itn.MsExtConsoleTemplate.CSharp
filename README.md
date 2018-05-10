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

`dotnet new msextconsole --name [yourprojectname]`

## disable template

`dotnet new -u [template id]`

IDs are here;

* Itn.MsExtConsoleTemplate.CSharp
* Itn.NewClassTemplate.CSharp
* Itn.MsMLIrisTemplate.CSharp