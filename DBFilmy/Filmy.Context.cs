﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBFilmy
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class filmyEntities : DbContext
    {
        public filmyEntities()
            : base("name=filmyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Movie_Instance> Movie_Instance { get; set; }
        public virtual DbSet<Transactions> Transactions { get; set; }
        public virtual DbSet<Movie> Movie { get; set; }
        public virtual DbSet<MoviesRentedByAUser> MoviesRentedByAUser { get; set; }
    }
}