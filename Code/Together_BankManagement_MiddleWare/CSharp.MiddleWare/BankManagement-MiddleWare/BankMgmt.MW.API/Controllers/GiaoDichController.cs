using BankMgmt.MW.BusinessLayer;
using BankMgmt.MW.DataModel;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BankMgmt.MW.API.Controllers
{
    public class GiaoDichController : ApiController
    {
        [HttpGet]
        [Route("api/gd/all")]
        public IHttpActionResult GetAll()
        {
            var gdBus = new BankMgmt.MW.BusinessLayer.GiaoDichBUS();
            return Ok(gdBus.GetAllGiaoDich());
        }

        [HttpPost]
        [Route("api/gd/add")]
        public HttpResponseMessage Add([FromBody]GiaoDich gd)
        {
            var gdBus = new GiaoDichBUS();
            gdBus.AddGiaoDich(gd);
            return Request.CreateResponse(HttpStatusCode.Created, gd);
        }
    }
}