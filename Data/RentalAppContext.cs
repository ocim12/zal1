using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

public class RentalAppContext : DbContext
{
    public DbSet<Rental> Rentals { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Model> Models { get; set; }
    
    public RentalAppContext(DbContextOptions<RentalAppContext> options) : base(options) { }
}