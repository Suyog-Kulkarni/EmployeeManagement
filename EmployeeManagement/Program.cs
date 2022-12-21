using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Runtime.CompilerServices;

public class Program
{
    private readonly IConfiguration _config; // Iconfiguration is used to access the configuration files like appsetting, launchsetting, appsetting.development.json etc
    public Program(IConfiguration config) 
    {
        _config= config;
        
    }
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        // app.MapGet("/", () => "j");

        FileServerOptions fileServerOptions = new();
        fileServerOptions.DefaultFilesOptions.DefaultFileNames.Clear();
        fileServerOptions.DefaultFilesOptions.DefaultFileNames.Add("foo.html");
        app.UseFileServer(fileServerOptions);// to use non default files
        // usefileserver combines the functionality od=f usestaticfiles, usedefaultfiles and usedirectorybrowser middelware
        
        app.UseDefaultFiles();

        app.UseStaticFiles();

        app.Run() ;
    }
    /*Configuration sources in asp.net core

        Files(appsetting.json, appsetting.{environment}.json)
        user secrets
        environment variables
        command-lone arguments

        THEY WILL OVERRIDE VALUES FOLLOWED BY GIVEN SERIERS*/

}