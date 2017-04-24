using BankMgmt.MW.BusinessLayer;
using BankMgmt.MW.DataModel;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BankMgmt.MW.API.Controllers
{
    public class KhachHangController : ApiController
    {
        [HttpGet]
        [Route("api/kh/all")]
        public IHttpActionResult GetAll()
        {
            var khBus = new KhachHangBUS();
            return Ok(khBus.GetAllKhachHang());
        }

        [HttpGet]
        [Route("api/kh/{khId}")]
        public IHttpActionResult GetKhachHang(int khId)
        {
            var khBus = new BankMgmt.MW.BusinessLayer.KhachHangBUS();
            return Ok(khBus.GetKhachHang(khId));
        }

        [HttpPost]
        [Route("api/kh/add")]
        public HttpResponseMessage Add([FromBody]KhachHang kh)
        {
            var khBus = new KhachHangBUS();
            khBus.AddKhachHang(kh);
            return Request.CreateResponse(HttpStatusCode.Created, kh);
        }

        [HttpPut]
        [Route("api/kh/updateSoDu/{khId}")]
        public HttpResponseMessage Update([FromBody]KhachHang kh)
        {
            var khBus = new KhachHangBUS();
            khBus.UpdateKhachHang(kh);
            return Request.CreateResponse(HttpStatusCode.Created, kh);
        }

        [HttpPut]
        [Route("api/kh/updateSoDu/{khId}")]
        public HttpResponseMessage UpdateSoDu(int khId, int sodu)
        {
            var khBus = new KhachHangBUS();
            KhachHang kh = khBus.GetKhachHang(khId);
            kh.SoDuTaiKhoan = sodu;
            khBus.UpdateKhachHang(kh);
            return Request.CreateResponse(HttpStatusCode.Created, khId);
        }
    }
}