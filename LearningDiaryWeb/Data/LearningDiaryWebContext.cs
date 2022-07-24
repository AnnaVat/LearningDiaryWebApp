using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LearningDiaryWeb.Models;

namespace LearningDiaryWeb.Data
{
    public class LearningDiaryWebContext : DbContext
    {
        public LearningDiaryWebContext (DbContextOptions<LearningDiaryWebContext> options)
            : base(options)
        {
        }

        public DbSet<LearningDiaryWeb.Models.Topic> Topic { get; set; }
    }
}
