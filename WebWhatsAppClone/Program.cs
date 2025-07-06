using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebWhatsAppClone.DataBase;
using WebWhatsAppClone.DTOs.Continent;
using WebWhatsAppClone.DTOs.FileCategory;
using WebWhatsAppClone.DTOs.FileFormat;
using WebWhatsAppClone.DTOs.Region;
using WebWhatsAppClone.DTOs.SubRegion;
using WebWhatsAppClone.Helpers;
using WebWhatsAppClone.Services.Abstracts;
using WebWhatsAppClone.Services.Concretes;

namespace WebWhatsAppClone
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddValidatorsFromAssemblyContaining<FileFormatCreateDTO>();
            builder.Services.AddValidatorsFromAssemblyContaining<FileFormatUpdateDTO>();
            builder.Services.AddValidatorsFromAssemblyContaining<FileCategoryCreateDTO>();
            builder.Services.AddValidatorsFromAssemblyContaining<FileCategoryUpdateDTO>();
            builder.Services.AddValidatorsFromAssemblyContaining<ContinentCreateDTO>();
            builder.Services.AddValidatorsFromAssemblyContaining<ContinentUpdateDTO>();
            builder.Services.AddValidatorsFromAssemblyContaining<RegionCreateDTO>();
            builder.Services.AddValidatorsFromAssemblyContaining<RegionUpdateDTO>();
            builder.Services.AddValidatorsFromAssemblyContaining<SubRegionCreateDTO>();
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services
            .AddDbContext<DataContext>(ob =>
            {
                var connectionString = builder.Configuration.GetConnectionString("Default");

                ob.UseNpgsql(connectionString);
            })
            .AddScoped<IFileManagementService, FileManagementService>()
            .AddSingleton<ReflectionHelper>();

            builder.Services.Configure<ApiBehaviorOptions>((c) =>
            {
                c.SuppressModelStateInvalidFilter = true;
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
