//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Movie_Instance
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movie_Instance()
        {
            this.Transactions = new HashSet<Transactions>();
        }
    
        public int ID_Movie_Instance { get; set; }
        public Nullable<int> FK_ID_Movie { get; set; }
        public Nullable<bool> Is_Rented { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transactions> Transactions { get; set; }
        public virtual Movie Movie { get; set; }
    }
}