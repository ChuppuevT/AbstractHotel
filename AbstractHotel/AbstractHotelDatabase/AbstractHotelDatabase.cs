﻿using AbstractHotelDatabase.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractHotelDatabase
{
    public class AbstractHotelDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source = DESKTOP-6CHU0IL\SQLEXPRESS;Initial Catalog=AbstractHotel;Integrated Security=True;MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Client> Clients { set; get; }
        public virtual DbSet<Сonference> Сonferences { set; get; }
        public virtual DbSet<Room> Rooms { set; get; }
        public virtual DbSet<RoomСonference> RoomsСonferences { set; get; }
        public virtual DbSet<Lunch> Lunches { set; get; }
        public virtual DbSet<LunchRoom> LunchesRooms { set; get; }
        public virtual DbSet<Request> Requests { set; get; }
        public virtual DbSet<RequestLunch> RequestLunches { set; get; }
    }
}
