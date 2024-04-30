using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Appointment_calendar.Domain.Entities.Concreate;


namespace Appointment_calendar.Domain.DatabaseAccess
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }
		public DbSet<ServiceItem> ServiceItems { get; set; }
		public DbSet<User> Users { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "my@email.com",
                NormalizedEmail = "MY@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "90b824e4-fe7b-431f-bea7-d6c96495a09d",
                Name = "therapist",
                NormalizedName = "THERAPIST"
			});

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "2dec81ab-0190-496b-954f-681b495b7d70",
                UserName = "therapist",
                NormalizedUserName = "THERAPIST",
                Email = "my@email.com",
                NormalizedEmail = "MY@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "puperpassword"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                UserId = "3b62472e-4f66-49fa-a20f-e7685b9565d8"
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "90b824e4-fe7b-431f-bea7-d6c96495a09d",
                UserId = "2dec81ab-0190-496b-954f-681b495b7d70"
            });


            modelBuilder.Entity<TextField>().HasData(new TextField { 
                Id = new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"), 
                CodeWord = "PageIndex", 
                Title = "Главная"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"), 
                CodeWord = "PageContacts", 
                Title = "Контакты"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("86cf2b31-c56e-49f7-98ba-6dc0c4d21d18"),
                CodeWord = "PageAboutUs",
                Title = "О нас"
            });
			modelBuilder.Entity<TextField>().HasData(new TextField
			{
				Id = new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
				CodeWord = "PageServices",
				Title = "Предоставляемы услуги"
			});
			modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("8b74b23c-ec9b-4375-9c5e-acc3431c4f6b"),
                CodeWord = "PageClientDataField",
                Title = "Заявка на оказание услуги"
            });


		}
    }
}
