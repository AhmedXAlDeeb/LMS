using DSproject;
using Learning_Managment_System;
using Microsoft.Extensions.DependencyInjection;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Services;
using WinFormsApp1.Data;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            // Services 
            services.AddSingleton<AppDbContext>();
            services.AddTransient<Form1>();
            services.AddTransient<StudentService>();
            services.AddTransient<ProfessorService>();
            services.AddSingleton<ControlsService>();
            services.AddSingleton<AccountManager>();
            services.AddTransient<ClassService>();
            services.AddTransient<SignUP>();
            services.AddTransient<SignIn>();

            using ServiceProvider serviceProvider = services.BuildServiceProvider();
            var mainForm = serviceProvider.GetRequiredService<Form1>();

            Application.Run(mainForm);
        }
    }
}


