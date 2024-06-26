﻿
using lap2.Models;
using Microsoft.EntityFrameworkCore;
using lap2.Controllers;

namespace lap2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string txt = "hi";
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<ITIDbContext>(op=>op.UseSqlServer(builder.Configuration.GetConnectionString("iticon")));

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(txt,
                builder =>
                {
                    builder.AllowAnyOrigin();
                    builder.AllowAnyMethod();
                    builder.AllowAnyHeader();
                });
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

            app.UseCors(txt);



            app.MapControllers();

                        //app.MapStudentEndpoints();

            app.Run();
        }
    }
}
