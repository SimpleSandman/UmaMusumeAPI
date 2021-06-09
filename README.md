# Uma Musume REST API
This is a community REST API based on [Uma Musume: Pretty Derby](https://umamusume.jp/)'s `master.mdb` file that reads from a MariaDB database. This is based on the Swagger UI/OpenAPI specification. I'm using MariaDB instead of MySQL for the sake of keeping as much of this as open-source as possible. 

I've written a [loader app](https://github.com/SimpleSandman/UmaMusumeLoadSqlData) that allows you to load the `master.mdb`'s data from the [DMM version](https://dmg.umamusume.jp/) of this game into either SQL Server or MySQL/MariaDB databases. The reason for both is due to change in database specifications midway through development, but I didn't want to let my hard work go to waste.

This API not only has endpoints to the tables, but I've created views for basic info for frequently used tables. I've even implemented stored procedures for a few particular calculations like parent compatibility and recommendations.

# Initial Setup
Under `UmaMusumeAPI/Properties/launchSettings.json`, set the `JAWSDB_MARIA_URL` environment variable to your MariaDB database for development and on the hosting site's config variables section.

Simplified `launchSettings.json` Example:

```json
"profiles": {
  "IIS Express": {
    "environmentVariables": {
      "ASPNETCORE_ENVIRONMENT": "Development",
      "JAWSDB_MARIA_URL": "user id=root;password=$0meth1ngC00L;host=localhost;database=umamusume;character set=utf8mb4"
    }
  }
}
```

# Database Set Up

Use the scripts in `UmaMusumeAPI/SqlScripts` to generate everything you need for the database. As mentioned before, if you want to load all of the data from the DMM version of this game, use my [loader app](https://github.com/SimpleSandman/UmaMusumeLoadSqlData) and point the connection string to your new database.

Make sure the MariaDB database and all of its objects have the character set of `utf8mb4` and collation of `utf8mb4_generic_ci` as that is the official UTF-8 specification. There are not only so many articles on this topic, but the devs from the [Pomelo.EntityFrameworkCore.MySql](https://github.com/PomeloFoundation/Pomelo.EntityFrameworkCore.MySql) project recommends this personally from their repo's README and [in this issue](https://github.com/PomeloFoundation/Pomelo.EntityFrameworkCore.MySql/issues/1427). I'm using their EF Core library to help scaffold the models and controllers since it's far more active and stable than the Oracle equivalent.

# Scaffold Commands
In case if you need to scaffold anything, here are some commands that may be useful:

This is a single-line command using the "Package Manager Console" in Visual Studio that allows you to generate all of the models and the DbContext class.
```powershell
Scaffold-DbContext 'User Id=root;Password=$0meth1ngC00L;Host=localhost;Database=umamusume;Character Set=utf8mb4' Pomelo.EntityFrameworkCore.MySql -OutputDir Models -ContextDir Context
```

-----------

This particular command below is a modified version of [this StackOverflow answer](https://stackoverflow.com/a/54422926/2113548). I personally put the code into a `.ps1` file in the same folder where `C:\Users\<YOUR_NAME_HERE>\.dotnet\tools` is located. This is because I installed the `dotnet-aspnet-codegenerator.exe` from [this NuGet page](https://www.nuget.org/packages/dotnet-aspnet-codegenerator/) with the ".NET CLI (Global)" command. 

This will allow you to generate all of your controllers from all of the models in a given folder (i.e. tables and views).

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
