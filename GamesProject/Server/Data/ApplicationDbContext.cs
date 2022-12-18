using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamesProject.Server.Models;
using GamesProject.Server.Configurations.Entities;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace GamesProject.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
        }
    }
}
