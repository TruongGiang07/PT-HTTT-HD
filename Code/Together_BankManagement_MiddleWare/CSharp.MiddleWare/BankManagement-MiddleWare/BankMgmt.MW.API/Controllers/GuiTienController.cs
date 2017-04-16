using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BankMgmt.MW.API.Controllers
{
    public class GuiTienController : ApiController
    {
        [HttpGet]
        [Route("api/kh/all")]
        public IHttpActionResult GetKHAll()
        {
            var khBus = new BankMgmt.MW.BusinessLayer.KhachHangBUS();
            return Ok(khBus.GetAllKhachHang());
        }

        [HttpGet]
        [Route("api/kh/sodu/{khId}")]
        public IHttpActionResult KiemTraSoDu(int khId)
        {
            var khBus = new BankMgmt.MW.BusinessLayer.KhachHangBUS();
            return Ok(khBus.GetSoDu(khId));
        }

        [HttpGet]
        [Route("api/gd/all")]
        public IHttpActionResult GetGDAll()
        {
            var gdBus = new BankMgmt.MW.BusinessLayer.GiaoDichBUS();
            return Ok(gdBus.GetAllGiaoDich());
        }

        [HttpPost]
        [Route("api/gd/guitien")]
        public HttpResponseMessage Them([FromBody]GiaoDich gt)
        {
            var gtBus = new BankMgmt.MW.BusinessLayer.GiaoDichBUS();
            gtBus.AddGiaoDich(gd);
            return Request.CreateResponse(HttpStatusCode.Created, gt);
        }
        

        [HttpPut]
        [Route("api/kh/UpdateGuiTien/{khId}")]
        public HttpResponseMessage UpdateGuiTien([FromBody]KhachHang kh, int khId, int sodu)
        {
            var khBus = new BankMgmt.MW.BusinessLayer.KhachHangBUS();
            kh = khBus.GetKhachHang(khId);
            kh.SoDuTaiKhoan = sodu;
            khBus.UpdateKhachHang(kh);
            return Request.CreateResponse(HttpStatusCode.Created, kh);
        }
    }
}
