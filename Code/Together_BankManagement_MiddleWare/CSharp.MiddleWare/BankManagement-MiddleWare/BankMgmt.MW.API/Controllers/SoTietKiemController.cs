using BankMgmt.MW.DataModel;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Linq;

namespace BankMgmt.MW.API.Controllers
{
    public class SoTietKiemController : ApiController
    {
        [HttpGet]
        [Route("api/stk/all")]
        public IHttpActionResult GetAll()
        {
            var stkBus = new BankMgmt.MW.BusinessLayer.SoTietKiemBUS();

            var listSTK = stkBus.GetAllSoTietKiem().Select(item => new
            {
                item.MaSoTietKiem,
                item.SoTienGui,
                item.NgayGui,
                item.NgayDaoHan,
                item.KyHan,
                item.LaiSuat,
                item.KhachHang.HoTen
            }).ToList();

            return Ok(listSTK);
        }

        [HttpGet]
        [Route("api/stk/{stkId}")]
        public IHttpActionResult GetSoTietKiem(int stkId)
        {
            var stkBus = new BankMgmt.MW.BusinessLayer.SoTietKiemBUS();
            return Ok(stkBus.GetSoTietKiem(stkId));
        }

        [HttpPost]
        [Route("api/stk/add")]
        public HttpResponseMessage Add([FromBody]SoTietKiem stk)
        {
            var stkBus = new BankMgmt.MW.BusinessLayer.SoTietKiemBUS();
            stkBus.AddSoTietKiem(stk);
            return Request.CreateResponse(HttpStatusCode.Created, stk);
        }

        [HttpPost]
        [Route("api/stk/remove/{stkId}")]
        public HttpResponseMessage RemoveSoTietKiem(int stkId)
        {
            var stkBus = new BankMgmt.MW.BusinessLayer.SoTietKiemBUS();
            SoTietKiem stk = stkBus.GetSoTietKiem(stkId);
            stk.TinhTrang = 0;
            stkBus.UpdateSoTietKiem(stk);
            return Request.CreateResponse(HttpStatusCode.Created, stkId);
        }
    }
}