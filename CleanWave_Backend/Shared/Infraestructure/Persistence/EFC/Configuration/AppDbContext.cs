using CleanWave_Backend.Booking.Domain.Model.Aggregates;
using CleanWave_Backend.iam.Domain.Model.Aggregates;
using CleanWave_Backend.Profiles.Domain.Model.Aggregates;
using CleanWave_Backend.Shared.Infraestructure.Persistence.EFC.Configuration.Extensions;
using EntityFrameworkCore.CreatedUpdatedDate.Extensions;
using Microsoft.EntityFrameworkCore;

namespace CleanWave_Backend.Shared.Infraestructure.Persistence.EFC.Configuration;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        base.OnConfiguring(builder);
        //Enable Audit Fields Interceptors
        builder.AddCreatedUpdatedInterceptor();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        //Profiles Context
        builder.Entity<Customer>().HasKey(c => c.Id);
        builder.Entity<Customer>().Property(c => c.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Customer>().Property(c => c.Name).IsRequired().HasColumnName("Name");
        builder.Entity<Customer>().Property(c => c.LastName).IsRequired().HasColumnName("LastName");
        builder.Entity<Customer>().Property(c => c.Email).IsRequired().HasColumnName("Email");
        builder.Entity<Customer>().Property(c => c.Phone).IsRequired().HasColumnName("Phone");
        builder.Entity<Customer>().OwnsOne(c => c.Space, s =>
        {
            s.WithOwner().HasForeignKey("Id");
            s.Property(p => p.PropertyType).HasColumnName("PropertyType");
            s.Property(p => p.CleaningType).HasColumnName("CleaningType");
            s.Property(p => p.SpaceSize).HasColumnName("SpaceSize");
            s.Property(p => p.NumberRooms).HasColumnName("NumberRooms");
            s.Property(p => p.FloorType).HasColumnName("FloorType");
            s.Property(p => p.Instructions).HasColumnName("Instructions");
        });
        
        //Cleaning Entrepreneur Context
        builder.Entity<CleaningEntrepreneur>().HasKey(c => c.Id);
        builder.Entity<CleaningEntrepreneur>().Property(c => c.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<CleaningEntrepreneur>().Property(c => c.Name).IsRequired().HasColumnName("Name");
        builder.Entity<CleaningEntrepreneur>().Property(c => c.Email).IsRequired().HasColumnName("Email");
        builder.Entity<CleaningEntrepreneur>().Property(c => c.Username).IsRequired().HasColumnName("Username");
        // IAM context
        builder.Entity<User>().HasKey(u => u.Id);
        builder.Entity<User>().Property(u => u.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<User>().Property(u => u.Username).IsRequired();
        builder.Entity<User>().Property(u => u.PasswordHash).IsRequired();
        
        // Booking Context 
        builder.Entity<Request>().HasKey(t => t.Id);
        builder.Entity<Request>().Property(t => t.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Request>().Property(t => t.Name).IsRequired().HasMaxLength(50);
        builder.Entity<Request>().Property(t => t.Address).HasMaxLength(150);
        builder.Entity<Request>().Property(t => t.Date).HasMaxLength(150);
        
        builder.Entity<Request>().OwnsOne(i => i.ServiceId,
            ai =>
            {
                ai.WithOwner().HasForeignKey("Id");
                ai.Property(p => p.Identifier).HasColumnName("ServiceIdentifier");
            });
        
        // Apply SnakeCase Naming Convention
        builder.UseSnakeCaseWithPluralizedTableNamingConvention();
    }
}