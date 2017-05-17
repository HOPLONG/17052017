using ERP.Web.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP.Web.Models.NewModels.MuaHang
{
    public class ChiTietPOMuaHang
    {
        public string MA_SO_PO { set; get; }
        public string MA_HANG { set; get; }
        public int SL { set; get; }
        public decimal DON_GIA_CHUA_VAT { set; get; }
        public decimal THANH_TIEN_CHUA_VAT { set; get; }
        public string THOI_GIAN_GIAO_HANG { set; get; }
        public string GHI_CHU { set; get; }
        public bool DA_NHAP_KHO { set; get; }
        public decimal GIA_BAN_RA { set; get; }
        public int ID_BAN_HANG { set; get; }

        public GetAll_ThongTinChungDonHangPO_MuaHang_Result ChungPO { get; set; }
        public List<GetAll_ChiTiet_DonHangPO_MuaHang_Result> ChiTietPO { get; set; }
    }
}