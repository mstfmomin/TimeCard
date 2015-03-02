using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TimeCard.Models
{
    public class ViewModelDbContext : DbContext
    {
        public System.Data.Entity.DbSet<ClockInClass> ClockInClassName { get; set; }
        public System.Data.Entity.DbSet<ClockOutClass> ClockOutClassName { get; set; }
        public System.Data.Entity.DbSet<TotalTimeClass> TotalTimeClassName { get; set; }
        public System.Data.Entity.DbSet<CourseChangeModalClass> CourseChangeModalClassName { get; set; }
    }
}