using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BankMgmt.MW.DataAccessLayer;

namespace BankMgmt.MW.API.Controllers
{
    public class ChuyenTienController : ApiController
    {
        [HttpGet]
        [Route("api/kh/all")]
        public IHttpActionResult GetKHAll()
        {
            var khBus = new BankMgmt.MW.BusinessLayer.KhachHangBUS();
            return Ok(khBus.GetAllKhachHang());
        }

        [HttpGet]
        [Route("api/gdct/all")]
        public IHttpActionResult GetGDCTAll()
        {
            var gdctBus = new BankMgmt.MW.BusinessLayer.GiaoDichChuyenTienBUS();
            return Ok(gdctBus.GetAllGiaoDichChuyenTien());
        }

        [HttpPost]
        [Route("api/gdct/add")]
        public HttpResponseMessage Add([FromBody]GiaoDichChuyenTien gdct)
        {
            var gdctBus = new BankMgmt.MW.BusinessLayer.GiaoDichChuyenTienBUS();
            gdctBus.AddGiaoDichChuyenTien(gdct);
            return Request.CreateResponse(HttpStatusCode.Created, gdct);
        }

        [HttpGet]
        [Route("api/kh/all/{khId}")]
        public IHttpActionResult KiemTraKhachHangNhan(int khId)
        {
            var khBus = new BankMgmt.MW.BusinessLayer.KhachHangBUS();
            return Ok(khBus.GetKhachHang(khId));
        }

        [HttpGet]
        [Route("api/kh/sodu/{khId}")]
        public IHttpActionResult KiemTraSoDu(int khId)
        {
            var khBus = new BankMgmt.MW.BusinessLayer.KhachHangBUS();
            return Ok(khBus.GetSoDu(khId));
        }

        [HttpPut]
        [Route("api/kh/updsodu/{khId}")]
        public HttpResponseMessage Update([FromBody]KhachHang kh, int khId, int sodu)
        {
            var khBus = new BankMgmt.MW.BusinessLayer.KhachHangBUS();
            kh = khBus.GetKhachHang(khId);
            kh.SoDuTaiKhoan = sodu;
            khBus.UpdateKhachHang(kh);
            return Request.CreateResponse(HttpStatusCode.Created, kh);
        }
    }
}
