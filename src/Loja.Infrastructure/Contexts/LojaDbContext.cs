using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Infrastructure.Contexts;
public class LojaDbContext : DbContext
{
	public LojaDbContext(DbContextOptions<LojaDbContext> options)  : base(options)
	{

	}

}
