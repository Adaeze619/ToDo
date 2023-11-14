using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Configuration;
using System.Diagnostics.Metrics;
using System.Drawing;

namespace TodoApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            
            Application.Run(new Form1());
           
        }
    }
}