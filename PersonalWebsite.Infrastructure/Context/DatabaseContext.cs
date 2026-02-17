using Microsoft.EntityFrameworkCore;
using PersonalWebsite.Doamin.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalWebsite.Infrastructure.Context
{
    public class DatabaseContext: DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        #region User

        public DbSet<User> Users { get; set; }

        #endregion

        //#region Education

        //public DbSet<Education> Educations { get; set; }

        //#endregion

        //#region Experience
        //public DbSet<Experience> Experiences { get; set; }

        //#endregion
        //#region skils
        //public DbSet<Skill> Skills { get; set; }

        //#endregion
        //#region Contact
        //public DbSet<Contact> Contacts { get; set; }
        //#endregion

        //#region Relation

        //public DbSet<Relation> Relations { get; set; }
        //#endregion

        //#region Blogs

        //public DbSet<ArticleCategory> ArticleCategories { get; set; }
        //public DbSet<Article> Articles { get; set; }

        //#endregion


        //#region Project
        //public DbSet<Project> Projects { get; set; }
        //#endregion

        #region On Model Creating

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(s => s.GetForeignKeys()))
            {

            }

            base.OnModelCreating(modelBuilder);
        }

        #endregion
    }
}
