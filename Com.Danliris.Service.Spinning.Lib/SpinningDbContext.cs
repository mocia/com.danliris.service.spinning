﻿using System;
using System.Collections.Generic;
using System.Text;
using Com.Moonlay.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Com.Danliris.Service.Spinning.Lib.Models;
using Com.Danliris.Service.Spinning.Lib.Configs;

namespace Com.Danliris.Service.Spinning.Lib
{
    public class SpinningDbContext : BaseDbContext
    {
        public SpinningDbContext(DbContextOptions<SpinningDbContext> options) : base(options)
        {
        }

        public DbSet<Yarn> Yarns { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new YarnConfig());
        }
    }
}