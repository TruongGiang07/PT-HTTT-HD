using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BankManagement.UI.Common;
using System.Globalization;

namespace BankManagement.UI
{
    public partial class KhachHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                BindRefData();

                cbxGioiTinh.Items.Add("Nam");
                cbxGioiTinh.Items.Add("Nữ");

                cbxTinhTrangHonNhan.Items.Add("Độc Thân");
                cbxTinhTrangHonNhan.Items.Add("Gia Đình");

                cbxTinhTrangHoatDong.Items.Add("Có");
                cbxTinhTrangHoatDong.Items.Add("Không");

                cbxTimKiem.Items.Add("Mã Khách Hàng");
                cbxTimKiem.Items.Add("CMND");

                LoadDSKH();
            }

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {

            var kh = new khachHang();
            kh.hoTen = stHoTen.Text.ToString();
            kh.soCMND = stCMND.Text.ToString();
            kh.ngaySinh = DateTime.Parse(DateTime.ParseExact(dtNgaySinh.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-mm-dd"));
            kh.dienThoai = stDienThoai.Text.ToString();
            kh.email = stEmail.Text.ToString();
            kh.diaChiThuongTru = stDCThuongTru.Text.ToString();
            kh.diaChiLienLac = stDCLienLac.Text.ToString();
            kh.soDuTaiKhoan = Double.Parse(dbSoDuTaiKhoan.Text.ToString());
            if (cbxGioiTinh.Text == "Nam")
                kh.gioiTinh = true;
            else
                kh.gioiTinh = false;
            if (cbxTinhTrangHonNhan.Text == "Độc Thân")
                kh.tinhTrangHonNhan = false;
            else
                kh.tinhTrangHonNhan = true;
            kh.ngayLap = DateTime.Parse(DateTime.ParseExact(dtNgayLap.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-mm-dd"));
            if (cbxTinhTrangHoatDong.Text == "Có")
                kh.tinhTrangHoatDong = true;
            else
                kh.tinhTrangHoatDong = false;
            kh.maCNDangky = int.Parse(cbxChiNhanh.SelectedItem.Value.ToString());
            ServiceConnector.GetDataFromServiceByPost<khachHang>("api/kh/addkh", kh, true);
            ClearData();
            LoadDSKH();

        }

        private void LoadDSKH()
        {
            gvKhachHang.DataSource = ServiceConnector.GetDataFromServiceByGet<khachHang>("api/kh/all", true);
            gvKhachHang.DataBind();
        }

        private void BindRefData()
        {

            cbxChiNhanh.DataSource = ServiceConnector.GetDataFromServiceByGet<ChiNhanh>("api/chinhanh/all", true);
            cbxChiNhanh.DataBind();
        }

        private void ClearData()
        {

            stMaKH.Text = null;
            stHoTen.Text = null;
            stCMND.Text = null;
            dtNgaySinh.Text = null;
            stDienThoai.Text = null;
            stEmail.Text = null;
            stDCThuongTru.Text = null;
            stDCLienLac.Text = null;
            dbSoDuTaiKhoan.Text = null;
            cbxGioiTinh.SelectedIndex = 0;
            cbxTinhTrangHonNhan.SelectedIndex = 0;
            dtNgayLap.Text = null;
            cbxTinhTrangHoatDong.SelectedIndex = 0;
            cbxChiNhanh.SelectedIndex = 0;

        }

        protected void gvKhachHang_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

            stMaKH.Text = gvKhachHang.Rows[e.NewSelectedIndex].Cells[1].Text;
            stHoTen.Text = gvKhachHang.Rows[e.NewSelectedIndex].Cells[2].Text;
            stCMND.Text = gvKhachHang.Rows[e.NewSelectedIndex].Cells[3].Text;
            dtNgaySinh.Text = gvKhachHang.Rows[e.NewSelectedIndex].Cells[4].Text;
            stDienThoai.Text = gvKhachHang.Rows[e.NewSelectedIndex].Cells[5].Text;
            stEmail.Text = gvKhachHang.Rows[e.NewSelectedIndex].Cells[6].Text;
            stDCThuongTru.Text = gvKhachHang.Rows[e.NewSelectedIndex].Cells[7].Text;
            stDCLienLac.Text = gvKhachHang.Rows[e.NewSelectedIndex].Cells[8].Text;
            dbSoDuTaiKhoan.Text = gvKhachHang.Rows[e.NewSelectedIndex].Cells[9].Text;
            if (Boolean.Parse(gvKhachHang.Rows[e.NewSelectedIndex].Cells[10].Text) == true)
                cbxGioiTinh.SelectedIndex = 0;
            else
                cbxGioiTinh.SelectedIndex = 1;
            if (Boolean.Parse(gvKhachHang.Rows[e.NewSelectedIndex].Cells[11].Text) == true)
                cbxTinhTrangHonNhan.SelectedIndex = 1;
            else
                cbxTinhTrangHonNhan.SelectedIndex = 0;
            dtNgayLap.Text = gvKhachHang.Rows[e.NewSelectedIndex].Cells[12].Text;
            if (Boolean.Parse(gvKhachHang.Rows[e.NewSelectedIndex].Cells[13].Text) == true)
                cbxTinhTrangHoatDong.SelectedIndex = 0;
            else
                cbxTinhTrangHoatDong.SelectedIndex = 1;
            cbxChiNhanh.SelectedValue = gvKhachHang.Rows[e.NewSelectedIndex].Cells[14].Text;
            lbMaKH.Visible = true;
            stMaKH.Visible = true;

        }

        protected void btnUpDate_Click(object sender, EventArgs e)
        {
            var kh = new khachHang();
            kh.maKhachHang = int.Parse(stMaKH.Text.ToString());
            kh.hoTen = stHoTen.Text.ToString();
            kh.soCMND = stCMND.Text.ToString();
            kh.ngaySinh = DateTime.Parse(DateTime.ParseExact(dtNgaySinh.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-mm-dd"));
            kh.dienThoai = stDienThoai.Text.ToString();
            kh.email = stEmail.Text.ToString();
            kh.diaChiThuongTru = stDCThuongTru.Text.ToString();
            kh.diaChiLienLac = stDCLienLac.Text.ToString();
            kh.soDuTaiKhoan = Double.Parse(dbSoDuTaiKhoan.Text.ToString());
            if (cbxGioiTinh.Text == "Nam")
                kh.gioiTinh = true;
            else
                kh.gioiTinh = false;
            if (cbxTinhTrangHonNhan.Text == "Độc Thân")
                kh.tinhTrangHonNhan = false;
            else
                kh.tinhTrangHonNhan = true;
            kh.ngayLap = DateTime.Parse(DateTime.ParseExact(dtNgayLap.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-mm-dd"));
            if (cbxTinhTrangHoatDong.Text == "Có")
                kh.tinhTrangHoatDong = true;
            else
                kh.tinhTrangHoatDong = false;
            kh.maCNDangky = int.Parse(cbxChiNhanh.SelectedItem.Value.ToString());
            ServiceConnector.GetDataFromServiceByPost<khachHang>("api/kh/upkh", kh, true);
            ClearData();
            lbMaKH.Visible = false;
            stMaKH.Visible = false;
            LoadDSKH();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            var kh = new khachHang();
            kh.maKhachHang = int.Parse(stMaKH.Text.ToString());
            kh.hoTen = stHoTen.Text.ToString();
            kh.soCMND = stCMND.Text.ToString();
            kh.ngaySinh = DateTime.Parse(DateTime.ParseExact(dtNgaySinh.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-mm-dd"));
            kh.dienThoai = stDienThoai.Text.ToString();
            kh.email = stEmail.Text.ToString();
            kh.diaChiThuongTru = stDCThuongTru.Text.ToString();
            kh.diaChiLienLac = stDCLienLac.Text.ToString();
            kh.soDuTaiKhoan = Double.Parse(dbSoDuTaiKhoan.Text.ToString());
            if (cbxGioiTinh.Text == "Nam")
                kh.gioiTinh = true;
            else
                kh.gioiTinh = false;
            if (cbxTinhTrangHonNhan.Text == "Độc Thân")
                kh.tinhTrangHonNhan = false;
            else
                kh.tinhTrangHonNhan = true;
            kh.ngayLap = DateTime.Parse(DateTime.ParseExact(dtNgayLap.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-mm-dd"));
            if (cbxTinhTrangHoatDong.Text == "Có")
                kh.tinhTrangHoatDong = true;
            else
                kh.tinhTrangHoatDong = false;
            kh.maCNDangky = int.Parse(cbxChiNhanh.SelectedItem.Value.ToString());
            ServiceConnector.GetDataFromServiceByPost<khachHang>("api/kh/delkh", kh, true);
            ClearData();
            lbMaKH.Visible = false;
            stMaKH.Visible = false;
            LoadDSKH();
        }

        protected void gvKhachHang_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvKhachHang.PageIndex = e.NewPageIndex;
            LoadDSKH();
            ClearData();
        }

        protected void btnTimKiem_Click(object sender, EventArgs e)
        {

            if (cbxTimKiem.Text == "Mã Khách Hàng")
            {
                string url = "api/kh/id/" + txtTimKiem.Text.ToString();
                gvKhachHang.DataSource = ServiceConnector.GetDataFromServiceByGet<khachHang>(url, true);
                gvKhachHang.DataBind();
            }
            else
            {
                string url = "api/kh/cmnd/" + txtTimKiem.Text.ToString();
                gvKhachHang.DataSource = ServiceConnector.GetDataFromServiceByGet<khachHang>(url, true);
                gvKhachHang.DataBind();
            }
            ClearData();

        }

    }

    public class khachHang
    {

        public int maKhachHang { get; set; }
        public String hoTen { get; set; }
        public Double soDuTaiKhoan { get; set; }
        public DateTime ngaySinh { get; set; }
        public Boolean gioiTinh { get; set; }
        public String diaChiThuongTru { get; set; }
        public String diaChiLienLac { get; set; }
        public String soCMND { get; set; }
        public String dienThoai { get; set; }
        public String email { get; set; }
        public Boolean tinhTrangHonNhan { get; set; }
        public DateTime ngayLap { get; set; }
        public Boolean tinhTrangHoatDong { get; set; }
        public int maCNDangky { get; set; }

    }

}