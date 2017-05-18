using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ERP.Web.Models.Database;
using System.Data.SqlClient;

namespace ERP.Web.Api.MuaHang
{
    public class Api_MH_DE_NGHI_NHAP_KHOController : ApiController
    {
        private ERP_DATABASEEntities db = new ERP_DATABASEEntities();

        // GET: api/Api_MH_DE_NGHI_NHAP_KHO
        [Route("api/Api_MH_DE_NGHI_NHAP_KHO/GetAllMH_DeNghiNhapKho/")]
        public List<GetAll_DeNghiMuaHang_Result> GetAllMH_DeNghiNhapKho()
        {
            var data = db.Database.SqlQuery<GetAll_DeNghiMuaHang_Result>("GetAll_DeNghiMuaHang");
            return data.ToList();
        }


        // GET: api/Api_MH_DE_NGHI_NHAP_KHO/5
        public class GetMH_DeNghiNhapKho
        {
            public GetDeNghiMuaHang_Result mhdenghinhapkho { set; get; }
            public List<GetAll_ChiTiet_DeNghiNhapKho_Result> ctmhdenghinhapkho { set; get; }
        }
        
        [Route("api/Api_MH_DE_NGHI_NHAP_KHO/GetDetailMH_DeNghiNhapKho/{masodenghi}")]
        public GetMH_DeNghiNhapKho GetDetailMH_DeNghiNhapKho(string masodenghi)
        {

            //Lưu thông tin nhập kho
            GetMH_DeNghiNhapKho dnnk = new GetMH_DeNghiNhapKho();
            var query = db.Database.SqlQuery<GetDeNghiMuaHang_Result>("GetDeNghiMuaHang @masodn", new SqlParameter("masodn", masodenghi));
            var data = db.Database.SqlQuery<GetAll_ChiTiet_DeNghiNhapKho_Result>("GetAll_ChiTiet_DeNghiNhapKho @masodn", new SqlParameter("masodn", masodenghi));
            dnnk.mhdenghinhapkho = query.FirstOrDefault();
            dnnk.ctmhdenghinhapkho = data.ToList();
            return dnnk;

        }

        // PUT: api/Api_MH_DE_NGHI_NHAP_KHO/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMH_DE_NGHI_NHAP_KHO(string id, MH_DE_NGHI_NHAP_KHO mH_DE_NGHI_NHAP_KHO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mH_DE_NGHI_NHAP_KHO.MA_SO_DN)
            {
                return BadRequest();
            }

            db.Entry(mH_DE_NGHI_NHAP_KHO).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MH_DE_NGHI_NHAP_KHOExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Api_MH_DE_NGHI_NHAP_KHO
        [ResponseType(typeof(MH_DE_NGHI_NHAP_KHO))]
        public IHttpActionResult PostMH_DE_NGHI_NHAP_KHO(MH_DE_NGHI_NHAP_KHO mH_DE_NGHI_NHAP_KHO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.MH_DE_NGHI_NHAP_KHO.Add(mH_DE_NGHI_NHAP_KHO);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (MH_DE_NGHI_NHAP_KHOExists(mH_DE_NGHI_NHAP_KHO.MA_SO_DN))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = mH_DE_NGHI_NHAP_KHO.MA_SO_DN }, mH_DE_NGHI_NHAP_KHO);
        }

        // DELETE: api/Api_MH_DE_NGHI_NHAP_KHO/5
        [ResponseType(typeof(MH_DE_NGHI_NHAP_KHO))]
        public IHttpActionResult DeleteMH_DE_NGHI_NHAP_KHO(string id)
        {
            MH_DE_NGHI_NHAP_KHO mH_DE_NGHI_NHAP_KHO = db.MH_DE_NGHI_NHAP_KHO.Find(id);
            if (mH_DE_NGHI_NHAP_KHO == null)
            {
                return NotFound();
            }

            db.MH_DE_NGHI_NHAP_KHO.Remove(mH_DE_NGHI_NHAP_KHO);
            db.SaveChanges();

            return Ok(mH_DE_NGHI_NHAP_KHO);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MH_DE_NGHI_NHAP_KHOExists(string id)
        {
            return db.MH_DE_NGHI_NHAP_KHO.Count(e => e.MA_SO_DN == id) > 0;
        }
    }
}