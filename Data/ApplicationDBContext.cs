﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xUnitMoqDemoApp.Models;

namespace xUnitMoqDemoApp.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { 
        
        }
        public DbSet<User> Users { get; set; }
    }
}
