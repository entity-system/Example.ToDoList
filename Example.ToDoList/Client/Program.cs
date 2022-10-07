using System;
using System.Net.Http;
using EntitySystem.Client.Fluent;
using Example.ToDoList.Client;
using Example.ToDoList.Client.Services;
using Example.ToDoList.Shared;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddSingleton(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddEntitySystemClientFluent<ToDoService, ToDo>();

await builder.Build().RunAsync();
