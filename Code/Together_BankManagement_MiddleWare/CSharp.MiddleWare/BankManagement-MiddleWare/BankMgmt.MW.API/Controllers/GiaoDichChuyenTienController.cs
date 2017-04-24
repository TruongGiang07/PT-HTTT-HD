using BankMgmt.MW.DataModel;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BankMgmt.MW.API.Controllers
{
    public class GiaoDichChuyenTienController : ApiController
    {
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

    }
}
