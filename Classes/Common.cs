using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.Extensions.Configuration;
namespace WPFCore.Classes
{
    class Common
    {
        static Common()
        {

        }

        public string GetConnectionString()
        {
            var config = new ConfigurationBuilder();
            config.SetBasePath(Directory.GetCurrentDirectory());
            config.AddJsonFile(path: "appsettings.json");
            config.AddEnvironmentVariables(prefix: "ConnectionStrings");
            config.AddUserSecrets<InvalidProgramException>(optional: true);
            var configuration = config.Build();


            //Console.WriteLine(configuration["ConnectionStrings:Toufree"]);


            return configuration["ConnectionStrings:Toufree"];



        }
    }

}
