//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebDauGia.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.HistoryAuctions = new HashSet<HistoryAuction>();
            this.Products = new HashSet<Product>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Photo { get; set; }
        public Nullable<int> Credits { get; set; }
        public string Address { get; set; }
        public Nullable<int> Status { get; set; }
        public string UserName { get; set; }
        public Nullable<int> Role { get; set; }
        public Nullable<int> Positive { get; set; }
        public Nullable<int> Negative { get; set; }
        public string Code { get; set; }
        public Nullable<System.DateTime> DateStartSale { get; set; }
        public Nullable<System.DateTime> DateEndSale { get; set; }
        public Nullable<int> SaleStatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoryAuction> HistoryAuctions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
