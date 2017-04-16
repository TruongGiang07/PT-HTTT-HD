using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BankMgmt.MW.DataAccessLayer;

namespace BankMgmt.MW.API.Controllers
{
    public class SoTietKiemController : ApiController
    {
        [HttpGet]
        [Route("api/stk/all")]
        public IHttpActionResult GetAll()
        {
            var stkBus = new BankMgmt.MW.BusinessLayer.SoTietKiemBUS();
            return Ok(stkBus.GetAllSoTietKiem());
        }

        [HttpPost]
        [Route("api/stk/add")]
        public HttpResponseMessage Add([FromBody]SoTietKiem stk)
        {
            var stkBus = new BankMgmt.MW.BusinessLayer.SoTietKiemBUS();
            stkBus.AddSoTietKiem(stk);
            return Request.CreateResponse(HttpStatusCode.Created, stk);
        }
    }
}
}