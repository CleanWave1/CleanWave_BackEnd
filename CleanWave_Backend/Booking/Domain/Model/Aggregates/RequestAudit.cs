using System.ComponentModel.DataAnnotations.Schema;
using EntityFrameworkCore.CreatedUpdatedDate.Contracts;

namespace CleanWave_Backend.Booking.Domain.Model.Aggregates;

public partial class Request : IEntityWithCreatedUpdatedDate
{
    [Column("CreatedAt")] public DateTimeOffset? CreatedDate { get; set; }
    
    [Column("UpdatedAt")] public DateTimeOffset? UpdatedDate { get; set; }

}