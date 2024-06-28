using CleanWave_Backend.Booking.Domain.Model.Aggregates;
using CleanWave_Backend.iam.Domain.Model.Aggregates;
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
        // Apply SnakeCase Naming Convention
        builder.UseSnakeCaseWithPluralizedTableNamingConvention();
        
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
        
    }
}