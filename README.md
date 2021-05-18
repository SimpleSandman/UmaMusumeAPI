# Uma Musume Community API
Community API based on Uma Musume: Pretty Derby's master.mdb file.

# Setup
Add `appsettings.json` and `appsettings.Development.json` at the project level (where the `.csproj` file lives). The template for both files is shown below, but configure your "DefaultConnection" to your MariaDB database for both development and production.

NOTE: Make sure the database and all of its objects have the character set of `utf8mb4` and collation of `utf8mb4_generic_ci` as that is the official UTF-8. There are not only so many articles on this topic, but the devs from the [Pomelo.EntityFrameworkCore.MySql](https://github.com/PomeloFoundation/Pomelo.EntityFrameworkCore.MySql) project recommends this personally from their repo's README and [in this issue](https://github.com/PomeloFoundation/Pomelo.EntityFrameworkCore.MySql/issues/1427). I'm using their EF Core library to help scaffold the models and controllers since it's far more active and stable than the Oracle equivalent.

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
