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
    
    public partial class AdditionalFacilitiesandFunction
    {
        public int additionalandfunctionID { get; set; }
        public int functionID { get; set; }
        public int additionalID { get; set; }
        public Nullable<int> additionalFacilityPrice { get; set; }
    
        public virtual AdditionalFacility AdditionalFacility { get; set; }
        public virtual Bookingdata Bookingdata { get; set; }
    }
}