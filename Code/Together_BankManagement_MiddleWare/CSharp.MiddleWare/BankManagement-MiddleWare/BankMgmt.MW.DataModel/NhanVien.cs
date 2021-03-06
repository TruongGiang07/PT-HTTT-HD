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
    
    public partial class NhanVien
    {
        public NhanVien()
        {
            this.GiaoDiches = new HashSet<GiaoDich>();
            this.GiaoDichChuyenTiens = new HashSet<GiaoDichChuyenTien>();
        }
    
        public int MaNhanVien { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string HoTen { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public Nullable<bool> GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public Nullable<int> MaCNLamViec { get; set; }
    
        public virtual ChiNhanh ChiNhanh { get; set; }
        public virtual ICollection<GiaoDich> GiaoDiches { get; set; }
        public virtual ICollection<GiaoDichChuyenTien> GiaoDichChuyenTiens { get; set; }
    }
}
