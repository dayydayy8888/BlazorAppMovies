using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BlazorApp1.Data;

namespace BlazorApp1.Data
{
	public class BlazorApp1Context : IdentityDbContext<BlazorApp1User>
	{
		public BlazorApp1Context(DbContextOptions<BlazorApp1Context> options) : base(options)
		{
		}

		public DbSet<Movie> Movie { get; set; } = default!;
	}
}
