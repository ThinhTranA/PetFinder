dotnet ef migrations add InitialCreate -o Data/Migrations

## Check what command available for database
dotnet ef database --help

## Update or create databae, create sqlite.db file if not exist
 dotnet ef database update
