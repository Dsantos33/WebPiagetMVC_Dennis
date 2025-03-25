using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebPiagetMVC_Dennis.Models;

namespace WebPiagetMVC_Dennis.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

public DbSet<WebPiagetMVC_Dennis.Models.Aluno> Aluno { get; set; } = default!;
}
