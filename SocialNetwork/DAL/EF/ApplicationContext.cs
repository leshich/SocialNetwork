﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Entities.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DAL.EF
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser,ApplicationRole,int,ApplicationUserLogin,ApplicationUserRole,ApplicationUserClaim>
    {
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Interests> Interests { get; set; }
        public DbSet<Friend> Friends { get; set; }
        public DbSet<Conversation> Conversations { get; set; }
        public DbSet<Message> Messages { get; set; }
        public ApplicationContext(string connectionString) : base(connectionString)
        {

        }

         protected override void OnModelCreating(DbModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
        }

        public ApplicationContext()
        {
            
        }

        
    }

    //public class UserDbInitializer : DropCreateDatabaseAlways<ApplicationContext>
    //{
    //    protected override void Seed(ApplicationContext db)
    //    {
    //        //db.Roles.Add(new ApplicationRole { Id = "1", Name = "admin" });
    //        //db.Roles.Add(new ApplicationRole { Id = "2", Name = "user" });
    //        base.Seed(db);
    //    }
    //}
}
