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
    
    public partial class PHANQUYEN
    {
        public int MaNhom { get; set; }
        public int MaChucNang { get; set; }
        public string GhiChu { get; set; }
    
        public virtual CHUCNANG CHUCNANG { get; set; }
        public virtual NHOMNGUOIDUNG NHOMNGUOIDUNG { get; set; }
    }
}
