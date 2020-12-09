﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication5.Models.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MehriamarqueeEntities : DbContext
    {
        public MehriamarqueeEntities()
            : base("name=MehriamarqueeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AdditionalFacility> AdditionalFacilities { get; set; }
        public virtual DbSet<AdditionalFacilitiesandFunction> AdditionalFacilitiesandFunctions { get; set; }
        public virtual DbSet<Dish> Dishes { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<MenuWithDish> MenuWithDishes { get; set; }
        public virtual DbSet<Program> Programs { get; set; }
        public virtual DbSet<ProgramsandMenu> ProgramsandMenus { get; set; }
        public virtual DbSet<Beverage> Beverages { get; set; }
        public virtual DbSet<Desert> Deserts { get; set; }
        public virtual DbSet<DishWithItem> DishWithItems { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<beveragesWithFunctionWithMenu> beveragesWithFunctionWithMenus { get; set; }
        public virtual DbSet<DesertWithFunctionWithMenu> DesertWithFunctionWithMenus { get; set; }
        public virtual DbSet<headOfAccount> headOfAccounts { get; set; }
        public virtual DbSet<subTypesOfHeadAccount> subTypesOfHeadAccounts { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountTransaction> AccountTransactions { get; set; }
        public virtual DbSet<SubAccountBalance> SubAccountBalances { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<QuantityupdateBeveragestable> QuantityupdateBeveragestables { get; set; }
        public virtual DbSet<QuantityupdatedDeserttable> QuantityupdatedDeserttables { get; set; }
        public virtual DbSet<QuantityupdatedItemtable> QuantityupdatedItemtables { get; set; }
        public virtual DbSet<FunctionRequestedTable> FunctionRequestedTables { get; set; }
        public virtual DbSet<Bookingdata> Bookingdatas { get; set; }
    }
}
