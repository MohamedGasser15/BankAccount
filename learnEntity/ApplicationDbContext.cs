using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnEntity
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("options.UseSqlServer(@\"Data Source=(localdb)\\\\ProjectModels;Initial Catalog=master;Integrated Security=True\");"); 
        }
    }
}

