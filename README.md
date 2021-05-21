# Uma Musume Community REST API
This is a community REST API based on [Uma Musume: Pretty Derby](https://umamusume.jp/)'s `master.mdb` file that reads from a MySQL/MariaDB database. This is based on the Swagger UI/OpenAPI specification.

# Setup
Add `appsettings.json` and `appsettings.Development.json` at the project level (where the `.csproj` file lives). The template for both files is shown below, but configure your "DefaultConnection" to your MariaDB database for both development and production.

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "user id=root;password=$0meth1ngC00L;host=localhost;database=umamusume;character set=utf8mb4"
  }
}
```

NOTE: Make sure the database and all of its objects have the character set of `utf8mb4` and collation of `utf8mb4_generic_ci` as that is the official UTF-8. There are not only so many articles on this topic, but the devs from the [Pomelo.EntityFrameworkCore.MySql](https://github.com/PomeloFoundation/Pomelo.EntityFrameworkCore.MySql) project recommends this personally from their repo's README and [in this issue](https://github.com/PomeloFoundation/Pomelo.EntityFrameworkCore.MySql/issues/1427). I'm using their EF Core library to help scaffold the models and controllers since it's far more active and stable than the Oracle equivalent.

# Scaffold Commands
In case if you need to scaffold anything, here are some commands that may be useful:

This is a single-line command using the "Package Manager Console" in Visual Studio that allows you to generate all of the models and the DbContext class:
```powershell
Scaffold-DbContext 'User Id=root;Password=$0meth1ngC00L;Host=localhost;Database=umamusume;Character Set=utf8mb4' Pomelo.EntityFrameworkCore.MySql -OutputDir Models -ContextDir Context
```

This particular command is a modified version of [this StackOverflow answer](https://stackoverflow.com/a/54422926/2113548). I personally put the `.ps1` file in the same folder where `C:\Users\<YOUR_NAME_HERE>\.dotnet\tools` is located since I installed the `dotnet-aspnet-codegenerator.exe` from [this NuGet page](https://www.nuget.org/packages/dotnet-aspnet-codegenerator/) with the .NET CLI (Global) command.

NOTE: Please modify your repo path in the script below if it's not in the same location.
```powershell
Get-ChildItem "C:\Users\<YOUR_NAME_HERE>\source\repos\UmaMusumeAPI\UmaMusumeAPI\Models\Tables" -Filter *.cs | 
Foreach-Object {
    $scaffoldCmd = 
    'dotnet-aspnet-codegenerator.exe ' + 
    '-p "C:\Users\<YOUR_NAME_HERE>\source\repos\UmaMusumeAPI\UmaMusumeAPI\UmaMusumeAPI.csproj" ' +
    'controller ' + 
    '-name ' + $_.BaseName + 'Controller ' +
    '-api ' + 
    '-m UmaMusumeAPI.Models.Tables.' + $_.BaseName + ' ' +
    '-dc UmaMusumeDbContext ' +
    '-outDir Controllers ' +
    '-namespace UmaMusumeAPI.Controllers'

    # List commands for testing:
    $scaffoldCmd

    # Excute commands (uncomment this line):
    #iex $scaffoldCmd
}
```
