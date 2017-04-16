using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace BankMgmt.MW.API.Controllers
{
    public class RutTienController
    {

        [HttpGet]
        [Route("api/gd/all")]
        public IHttpActionResult GetGDAll()
        {
            var gdBus = new BankMgmt.MW.BusinessLayer.GiaoDichBUS();
            return Ok(gdBus.GetAllGiaoDich());
        }

        [HttpPost]
        [Route("api/gd/them")]
        public HttpResponseMessage Them([FromBody]GiaoDich gd)
        {
            var gdBus = new BankMgmt.MW.BusinessLayer.GiaoDichBUS();
            gdBus.AddGiaoDich(gd);
            return Request.CreateResponse(HttpStatusCode.Created, gd);
        }

        [HttpPut]
        [Route("api/kh/capnhatsodu/{khId}")]
        public HttpResponseMessage UpdateRutTien([FromBody]KhachHang kh, int khId, int sodu)
        {
            var khBus = new BankMgmt.MW.BusinessLayer.KhachHangBUS();
            kh = khBus.GetKhachHang(khId);
            kh.SoDuTaiKhoan = sodu;
            khBus.UpdateKhachHang(kh);
            return Request.CreateResponse(HttpStatusCode.Created, kh);
        }

    }
}

