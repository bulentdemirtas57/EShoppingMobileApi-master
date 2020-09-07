using Microsoft.EntityFrameworkCore;
using MobileApp.Data.Models;

namespace MobileApp.Data.Context
{
    public class MobileAppDbContext : bcc_MyAppxContext
    {


        public MobileAppDbContext(DbContextOptions options)
           : base(options)
        {
        }

        public MobileAppDbContext(DbContextOptions<bcc_MyAppxContext> options)
           : base(options)
        {
        }

    }
}
