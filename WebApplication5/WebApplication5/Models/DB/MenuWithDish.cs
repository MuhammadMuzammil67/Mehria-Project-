//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class MenuWithDish
    {
        public int menuanddishID { get; set; }
        public int menuID { get; set; }
        public int dishID { get; set; }
    
        public virtual Dish Dish { get; set; }
        public virtual Menu Menu { get; set; }
    }
}