//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.AdventureWorks.Data.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class VendorContact
    {
        public int VendorID { get; set; }
        public int ContactID { get; set; }
        public int ContactTypeID { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual Contact Contact { get; set; }
        public virtual ContactType ContactType { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
