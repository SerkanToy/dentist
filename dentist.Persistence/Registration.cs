using dentist.domain.Entities;
using dentist.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace dentist.Persistence
{
    public static class Registration
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DentistContext>(opt => 
            opt.UseSqlServer(configuration.GetConnectionString("ConnectionStrings:DefaultConnection")));
            
            services.AddIdentityCore<User>()
                .AddRoles<Role>()
                .AddEntityFrameworkStores<DentistContext>();
        }
    }
}
