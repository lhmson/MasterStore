//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MasterSaveDemo.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class BAOCAODOANHSO
    {
        public string MaBaoCaoDoanhSo { get; set; }
        public System.DateTime NgayDoanhSo { get; set; }
        public string MaLoaiTietKiem { get; set; }
        public decimal TongThu { get; set; }
        public decimal TongChi { get; set; }
        public decimal ChenhLech { get; set; }
    
        public virtual LOAITIETKIEM LOAITIETKIEM { get; set; }
    }
}
