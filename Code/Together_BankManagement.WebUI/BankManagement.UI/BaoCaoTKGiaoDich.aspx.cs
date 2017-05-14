using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankManagement.UI
{
    public partial class BaoCaoTKGiaoDich : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8080/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync("api/tongketgd/all").Result;
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string lsGiaoDich = response.Content.ReadAsStringAsync().Result;
                    var result = JsonConvert.DeserializeObject<List<TKGD>>(lsGiaoDich);
                    gvBaoCaoGiaoDich.DataSource = result;
                    gvBaoCaoGiaoDich.DataBind();
                }
            }
        }
        
    }

    public class TKGD
    {
        public int id { get; set; }
        public DateTime ngayGiaoDich { get; set; }
        public int maChiNhanh { get; set; }
        public int maTruSo { get; set; }
        public int slGDRutTien { get; set; }
        public double soTienGDRutTien { get; set; }
        public int slGDGuiTien { get; set; }
        public double soTienGDGuiTien { get; set; }
        public int slGDChuyenTien { get; set; }
        public double soTienGDChuyenTien { get; set; }
    }
}