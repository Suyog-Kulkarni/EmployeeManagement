using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.DataProtection;
using System.Diagnostics.CodeAnalysis;
using EmployeeManagement.Models;

public class Program
{
    /*private readonly IConfiguration? _config; // Iconfiguration is used to access the configuration files like appsetting, launchsetting, appsetting.development.json etc
   
    private readonly IWebHostEnvironment? _hostingEnvironment;
    public Program(IConfiguration config, IWebHostEnvironment hosting)
    {
        _config = config;
        _hostingEnvironment = hosting;
    }*/
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddMvc();
        NewMethod(builder);
        builder.Services.AddMvc(option => option.EnableEndpointRouting = false);

        var app = builder.Build();

        // usefileserver combines the functionality of usestaticfiles, usedefaultfiles and usedirectorybrowser middelware


        app.UseStaticFiles();
        // app.UseDefaultFiles();
        app.UseMvcWithDefaultRoute();
        app.Run();

        static void NewMethod(WebApplicationBuilder builder)
        {
            builder.Services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();
        }
    }
    /* what is routing
         The ASP.NET Routing module is responsible 
         for mapping incoming browser requests to particular MVC controller actions.
 */


    /*Configuration sources in asp.net core

        Files(appsetting.json, appsetting.{environment}.json)
        user secrets
        environment variables
        command-lone arguments

        THEY WILL OVERRIDE VALUES FOLLOWED BY GIVEN SERIERS*/

}