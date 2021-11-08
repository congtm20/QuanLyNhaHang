using Microsoft.EntityFrameworkCore;
using QLNH_APIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNH_APIs.DAO
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        DbSet<UserModel> User { get; set; }
    }
}
