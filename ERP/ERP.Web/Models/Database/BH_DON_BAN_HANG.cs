
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ERP.Web.Models.Database
{

using System;
    using System.Collections.Generic;
    
public partial class BH_DON_BAN_HANG
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public BH_DON_BAN_HANG()
    {

        this.BH_CT_DON_BAN_HANG = new HashSet<BH_CT_DON_BAN_HANG>();

        this.KHO_XUAT_KHO = new HashSet<KHO_XUAT_KHO>();

    }


    public string MA_SO_BH { get; set; }

    public System.DateTime NGAY_BH { get; set; }

    public string MA_KHACH_HANG { get; set; }

    public string TEN_LIEN_HE { get; set; }

    public string HINH_THUC_THANH_TOAN { get; set; }

    public Nullable<decimal> TONG_TIEN_HANG { get; set; }

    public string SO_TIEN_VIET_BANG_CHU { get; set; }

    public System.DateTime NGAY_GIAO_HANG { get; set; }

    public string DIA_DIEM_GIAO_HANG { get; set; }

    public string NHAN_VIEN_QUAN_LY { get; set; }

    public Nullable<bool> DA_XUAT_KHO { get; set; }

    public string MA_SO_XUAT_KHO { get; set; }

    public string TRUC_THUOC { get; set; }

    public double TONG_TIEN_THANH_TOAN { get; set; }

    public double TONG_TIEN_THUE_GTGT { get; set; }

    public bool DA_LAP_HOA_DON { get; set; }

    public string MA_SO_PO { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<BH_CT_DON_BAN_HANG> BH_CT_DON_BAN_HANG { get; set; }

    public virtual KH KH { get; set; }

    public virtual CCTC_NHAN_VIEN CCTC_NHAN_VIEN { get; set; }

    public virtual CCTC_CONG_TY CCTC_CONG_TY { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<KHO_XUAT_KHO> KHO_XUAT_KHO { get; set; }

}

}
