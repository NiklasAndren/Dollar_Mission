﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Mission.Domain.Entities;
using Mission.Domain.Entities.FakeData;

namespace Mission.Domain.Contexts
{
    public class EFDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
    }

    public class MissionInitializer : DropCreateDatabaseAlways<EFDbContext>
    {
        protected override void Seed(EFDbContext context)
        {
            var fakeData = new FakeData();
            fakeData.testUserList().ForEach(s => context.Users.Add(s));
            context.SaveChanges();
            fakeData.testPostList().ForEach(s => context.Posts.Add(s));
            fakeData.testNewsList().ForEach(s => context.Posts.Add(s));

            context.SaveChanges();
        }
    }
}
