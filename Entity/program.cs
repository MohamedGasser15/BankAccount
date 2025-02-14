using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
     class program
    {
        static void Main(string[] args)
        {
            var _context = new ApplicationDbContext(); // class in another project

            _context.SaveChanges(); // to save it
        }
    }
}
