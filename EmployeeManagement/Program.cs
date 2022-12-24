using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.DataProtection;

public class Program
{
    private readonly IConfiguration? _config; // Iconfiguration is used to access the configuration files like appsetting, launchsetting, appsetting.development.json etc
   
    private readonly IWebHostEnvironment? _hostingEnvironment;
    private readonly IServiceCollection _services1;


    
    public Program(IConfiguration config, IWebHostEnvironment hosting, IServiceCollection services)
    {
        _config = config;
        _hostingEnvironment = hosting;
        _services1 = services;

    }
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddMvc();
        builder.Services.AddMvc(option => option.EnableEndpointRouting = false);

        var app = builder.Build();

        //app.MapGet("/", () => _config["Key"]);

        /*FileServerOptions fileServerOptions = new();
        fileServerOptions.DefaultFilesOptions.DefaultFileNames.Clear();
        fileServerOptions.DefaultFilesOptions.DefaultFileNames.Add("foo.html");
        app.UseFileServer(fileServerOptions);*/// to use non default files
        // usefileserver combines the functionality od=f usestaticfiles, usedefaultfiles and usedirectorybrowser middelware

        app.UseDefaultFiles();
        /*DeveloperExceptionPageOptions developerExceptionPageOptions = new();
        {
            SourceCodeLineCount = 10;
        }*/
        // use to show the number of lines above and below the error line

        /*ServiceCollection services = new();*/

        /*IServiceCollection? services = default;
        services.AddMvc();*/
        

        app.UseStaticFiles();
        app.UseMvcWithDefaultRoute();
        app.Run() ;
    }


    /*Configuration sources in asp.net core

        Files(appsetting.json, appsetting.{environment}.json)
        user secrets
        environment variables
        command-lone arguments

        THEY WILL OVERRIDE VALUES FOLLOWED BY GIVEN SERIERS*/

}