using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.EntityFramework;
using Entities;

namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //builder.Services. Diye Yazmamýz lazým
            builder.Services.AddSingleton<IComputerService, ComputerManager>(); // IComputerService istenirse ComputerManager ver
            builder.Services.AddSingleton<IComputerDal, EfComputerDal>(); // IComputerDal istenirse EfComputerDal ver

           

            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                                       builder =>
                                       {
                        builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                    }); 
               
            });


            var app = builder.Build();

           app.UseCors();
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