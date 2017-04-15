using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BankMgmt.MW.DataAccessLayer;

namespace BankMgmt.MW.API.Controllers
{
    public class KhachHangController : ApiController
    {
        [HttpGet]
        [Route("api/kh/all")]
        public IHttpActionResult GetAll()
        {
            var khBus = new BankMgmt.MW.BusinessLayer.KhachHangBUS();
            return Ok(khBus.GetAllKhachHang());
        }

        [HttpPost]
        [Route("api/kh/add")]
        public HttpResponseMessage Add([FromBody]KhachHang kh)
        {
            var khBus = new BankMgmt.MW.BusinessLayer.KhachHangBUS();
            khBus.AddKhachHang(kh);
            return Request.CreateResponse(HttpStatusCode.Created, kh);
        }
    }
}