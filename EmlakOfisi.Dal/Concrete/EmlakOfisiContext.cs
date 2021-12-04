using EmlakOfisi.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmlakOfisi.Dal.Concrete
{
	public class EmlakOfisiContext : DbContext
	{
		public EmlakOfisiContext(DbContextOptions<EmlakOfisiContext> options) : base(options)
		{

		}
		public DbSet<UserEntity> Users { get; set; }
		public DbSet<AdminEntity> Admins { get; set; }
		public DbSet<AgentEntity> Agents { get; set; }
	}
}
