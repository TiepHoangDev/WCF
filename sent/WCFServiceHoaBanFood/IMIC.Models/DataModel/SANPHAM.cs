//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IMIC.Models.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class SANPHAM
    {
        public SANPHAM()
        {
            this.ANHSANPHAMs = new HashSet<ANHSANPHAM>();
            this.BAIVETSANPHAMs = new HashSet<BAIVETSANPHAM>();
            this.BINHLUANs = new HashSet<BINHLUAN>();
            this.CHITIETDATHANGs = new HashSet<CHITIETDATHANG>();
            this.CHITIETKHUYENMAIs = new HashSet<CHITIETKHUYENMAI>();
            this.DANHGIAs = new HashSet<DANHGIA>();
            this.VIDEOSANPHAMs = new HashSet<VIDEOSANPHAM>();
            this.NHANVIENs = new HashSet<NHANVIEN>();
        }
    
        public System.Guid MASP { get; set; }
        public Nullable<System.Guid> MADMSP { get; set; }
        public string TENSP { get; set; }
        public Nullable<decimal> GIA { get; set; }
        public byte[] ANHLONSP { get; set; }
        public string DONVISP { get; set; }
        public Nullable<int> SOLUONG { get; set; }
        public Nullable<int> LUOTVIEW { get; set; }
        public Nullable<int> LUOTTHICH { get; set; }
        public string THONGTIN { get; set; }
        public string THONGBAO { get; set; }
        public Nullable<bool> ISPENDING { get; set; }
        public Nullable<bool> ISPUBLISH { get; set; }
        public Nullable<bool> ISDELETE { get; set; }
    
        public virtual ICollection<ANHSANPHAM> ANHSANPHAMs { get; set; }
        public virtual ICollection<BAIVETSANPHAM> BAIVETSANPHAMs { get; set; }
        public virtual ICollection<BINHLUAN> BINHLUANs { get; set; }
        public virtual ICollection<CHITIETDATHANG> CHITIETDATHANGs { get; set; }
        public virtual ICollection<CHITIETKHUYENMAI> CHITIETKHUYENMAIs { get; set; }
        public virtual ICollection<DANHGIA> DANHGIAs { get; set; }
        public virtual DANHMUCSANPHAM DANHMUCSANPHAM { get; set; }
        public virtual ICollection<VIDEOSANPHAM> VIDEOSANPHAMs { get; set; }
        public virtual ICollection<NHANVIEN> NHANVIENs { get; set; }
    }
}