﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PP_2023MAG.baza
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PPMAG_20023Entities1 : DbContext
    {
        private static PPMAG_20023Entities1 _context;
        public static PPMAG_20023Entities1 GetContext()
        {
            if (_context == null)
                _context = new PPMAG_20023Entities1();
            return _context;
        }
        public PPMAG_20023Entities1()
            : base("name=PPMAG_20023Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Достижения> Достижения { get; set; }
        public virtual DbSet<Пользователи> Пользователи { get; set; }
    }
}