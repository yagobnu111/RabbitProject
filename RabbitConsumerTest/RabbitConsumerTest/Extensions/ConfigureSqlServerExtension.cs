using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitConsumerTest.Extensions
{
    public static class ConfigureSqlServerExtension
    {
        public static void AddSqlServerConfiguration(this IServiceCollection services)
        {
            services.AddDbContext<MainContext>(options =>
            options.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=RabbitConsumerDB;User Id=sa; Password=sa;Integrated Security=True"));
        }
    }
}
