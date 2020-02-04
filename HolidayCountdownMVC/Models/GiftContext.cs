using System;
using Microsoft.EntityFrameworkCore;

namespace HolidayCountdownMVC.Models
{
    public class GiftContext:DbContext
    {
        public GiftContext(DbContextOptions<GiftContext> options):base(options)
        {

        }

        public DbSet<Gift> Gifts { get; set; }
    }
}
