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
    
    public partial class JobCandidate
    {
        public int JobCandidateID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public string Resume { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
