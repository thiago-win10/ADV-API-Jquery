using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Mercado.Infraestrutura.Context;
using Mercado.Entidades.Events;
using FluentValidation.AspNetCore;
using Mercado.DomainCore.Bus;
using Mercado.Infraestrutura.Bus;
using Mercado.DomainCore.Notifications;
using Mercado.Application.Command;
using Mercado.Entidades.ViewModels;
using Mercado.Infraestrutura.Interface;
using Mercado.Infraestrutura.Repositorio;
using Mercado.Infraestrutura.UnitOfWork;
using Mercado.DomainCore.Events;

namespace WebApplication1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        private readonly IWebHostEnvironment _env;


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddControllers()
            .AddFluentValidation(fv =>
            {
                fv.ImplicitlyValidateChildProperties = true;
                fv.ImplicitlyValidateRootCollectionElements = true;


                fv.RegisterValidatorsFromAssemblyContaining<Startup>();
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Mercado-Api", Description = "Projeto Mercado-Api", Version = "v1" });
            });
            services.AddMediatR(typeof(Startup).Assembly);


            services.AddDbContext<MercadoContext>(options =>
            {
                options.UseSqlServer(
                    Configuration.GetConnectionString("MercadoApi"));
                if (_env.IsDevelopment())
                    options.EnableSensitiveDataLogging();

            });
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            // Domain - Events
            services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();
            services.AddScoped<INotificationHandler<ClienteRegisteredEvent>, ClienteEventHandler>();
            services.AddScoped<INotificationHandler<ClienteUpdatedEvent>, ClienteEventHandler>();
            services.AddScoped<INotificationHandler<ClienteRemovedEvent>, ClienteEventHandler>();


            services.AddScoped<IRequestHandler<AdicionarClienteCommand, ClienteViewModel>, AdicionarClienteCommandHandler>();
            services.AddScoped<IRequestHandler<AtualizarClienteCommand, ClienteViewModel>, AtualizarClienteCommandHandler>();
            services.AddScoped<IRequestHandler<RemoverClienteCommand, bool>, RemoverClienteCommandHandler>();

            services.AddScoped<IClienteRepositorio, ClienteRepositorio>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            // Infra - Data EventSourcing
            services.AddScoped<IEventStoreRepository, EventStoreSqlRepository>();
            services.AddScoped<IEventStore, SqlEventStore>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,ILoggerFactory loggerFactory)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");

                app.UseHsts();
            }
            app.UseCors(configurePolicy =>
            {
                configurePolicy.AllowAnyOrigin();
                configurePolicy.AllowAnyMethod();
                configurePolicy.AllowAnyHeader();
            });

            app.UseHttpsRedirection();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "CQRS API v1");
            });

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
