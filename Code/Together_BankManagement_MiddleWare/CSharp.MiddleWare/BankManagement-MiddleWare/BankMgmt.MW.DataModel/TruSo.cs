//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankMgmt.MW.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class TruSo
    {
        public TruSo()
        {
            this.ChiNhanhs = new HashSet<ChiNhanh>();
        }
    
        public int MaTruSo { get; set; }
        public string TenTruSo { get; set; }
        public string DiaChi { get; set; }
        public string SoDT { get; set; }
    
        public virtual ICollection<ChiNhanh> ChiNhanhs { get; set; }
    }
}
