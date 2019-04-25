using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class RocketElevatorContext : DbContext
    {
        public RocketElevatorContext(DbContextOptions<RocketElevatorContext> options) : base(options) { }
        public DbSet<Elevator> Elevators { get; set; }
        public DbSet<Battery> Batteries { get; set; }
        public DbSet<Column> Columns { get; set; }

    }
}