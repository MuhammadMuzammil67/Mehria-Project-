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
    
    public partial class AdditionalFacility
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AdditionalFacility()
        {
            this.AdditionalFacilitiesandFunctions = new HashSet<AdditionalFacilitiesandFunction>();
        }
    
        public int additionalID { get; set; }
        public string additionalName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdditionalFacilitiesandFunction> AdditionalFacilitiesandFunctions { get; set; }
    }
}