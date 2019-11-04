#addin "nuget:?package=Cake.SqlServer"

// Database Configuraion
var dbServer = "";
var dbPort = "1433";
var dbDirectaUser = "";
var dbDirectaPassword  = "";
var dbDirectaDatabase = "";

// Connections String
var connectionServer = $@"Server={dbServer},{dbPort};User={dbDirectaUser};Password={dbDirectaPassword};";
var connectionDatabase = $@"Database={dbDirectaDatabase}";
var connectionString = connectionServer + connectionDatabase;

// Other Configurations
var target = Argument("target", "Default");
var tags = Argument("tags", "");

// Task´s Configuration
Task("Install-FluentMigrator-Cli")
    .ContinueOnError()
    .Does(() => {
        DotNetCoreTool("tool install -g FluentMigrator.DotNet.Cli");
    });    

Task("Apply-Migrations")
    .Does(() => {
        DotNetCoreTool(
            "fm migrate -p sqlserver" + 
            " -c " + connectionString + 
            (tags != "" ? " -t " + tags : "") + 
            " -a ../../bin/Debug/netstandard2.0/Genius.Migrations.dll"
        );
    });

Task("Apply-Rollback")
    .Does(() => {
        DotNetCoreTool(
            "fm roolback -p sqlserver" + 
            " -c " + connectionString + 
            (tags != "" ? " -t " + tags : "") + 
            " -a ../../bin/Debug/netstandard2.0/Genius.Migrations.dll"
        );
    });    

Task("Create-Database")
    .Does(() => {
        CreateDatabaseIfNotExists(connectionServer, dbDirectaDatabase);
    });

Task("Build-Migrations-Project")
    .ContinueOnError()
    .Does(() => {
        DotNetCoreTool("build ../../Genius.Migrations.csproj");
    });

Task("Default")
    .IsDependentOn("Build-Migrations-Project")
    .IsDependentOn("Create-Database")
    .IsDependentOn("Install-FluentMigrator-Cli")
    .IsDependentOn("Apply-Migrations");

// Run Task´s
RunTarget(target);
