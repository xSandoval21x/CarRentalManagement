﻿using CarRentalManagement.Server.Data;
using CarRentalManagement.Server.IRepository;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Make> _makes;
        private IGenericRepository<Model> _models;
        private IGenericRepository<Color> _colors;
        private IGenericRepository<Vehicle> _vehicles;
        private IGenericRepository<Customer> _customers;
        private IGenericRepository<Booking> _bookings;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
        public IGenericRepository<Make> Makes => 
            _makes ??= new GenericRepository<Make>(_context);

        public IGenericRepository<Model> Models =>
            _models ??= new GenericRepository<Model>(_context);

        public IGenericRepository<Color> Colors =>
            _colors ??= new GenericRepository<Color>(_context);

        public IGenericRepository<Vehicle> Vehicles =>
            _vehicles ??= new GenericRepository<Vehicle>(_context);
        public IGenericRepository<Customer> Customers =>
           _customers ??= new GenericRepository<Customer>(_context);
        public IGenericRepository<Booking> Bookings =>
           _bookings ??= new GenericRepository<Booking>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            var user = httpContext.User.Identity.Name;

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);
            foreach (var entry in entries) {
                ((DomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((DomainModel)entry.Entity).UpdatedBy = user;
                if (entry.State == EntityState.Added) {
                    ((DomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((DomainModel)entry.Entity).CreatedBy = user;
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}
