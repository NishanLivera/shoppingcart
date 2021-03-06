﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.Extensions.Configuration;


namespace ShoppingCartApp.DataAccessLayer.DataContext
{
    public class AppConfiguration
    {
        public AppConfiguration()
        {
            var configBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configBuilder.AddJsonFile(path,false);
            var root = configBuilder.Build();
            var appSettings = root.GetSection("ConnectionStrings:DefaultConnection");
            sqlConnectionString = appSettings.Value;

        }
        public string sqlConnectionString { get; set; }
    }
}
