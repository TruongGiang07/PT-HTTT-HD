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
    public partial class InsertUpdateKhachHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindRefData();

                cbxgioitinh.Items.Add("Nam");
                cbxgioitinh.Items.Add("Nữ");

                cbxtinhtranghonnhan.Items.Add("Độc Thân");
                cbxtinhtranghonnhan.Items.Add("Gia Đình");

                cbxtinhtranghoatdong.Items.Add("Có");
                cbxtinhtranghoatdong.Items.Add("Không");

                GetKhachHang(12);
            }
        }

        protected void btninsert_Click(object sender, EventArgs e)
        {
            var kh = new khachHang();
            kh.hoTen = txthoten.Text.ToString();
            kh.soCMND = txtsocmnd.Text.ToString();
            kh.ngaySinh = DateTime.Parse(DateTime.ParseExact(txtngaysinh.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-mm-dd"));
            kh.dienThoai = txtdienthoai.Text.ToString();
            kh.email = txtemail.Text.ToString();
            kh.diaChiThuongTru = txtdcthuongtru.Text.ToString();
            kh.diaChiLienLac = txtdclienlac.Text.ToString();
            kh.soDuTaiKhoan = Double.Parse(txtsdtaikhoan.Text.ToString());
            if (cbxgioitinh.Text == "Nam")
                kh.gioiTinh = true;
            else
                kh.gioiTinh = false;
            if (cbxtinhtranghonnhan.Text == "Độc Thân")
                kh.tinhTrangHonNhan = false;
            else
                kh.tinhTrangHonNhan = true;
            kh.ngayLap = DateTime.Parse(DateTime.ParseExact(txtngaylap.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-mm-dd"));
            if (cbxtinhtranghoatdong.Text == "Có")
                kh.tinhTrangHoatDong = true;
            else
                kh.tinhTrangHoatDong = false;
            kh.maCNDangky = int.Parse(cbxchinhanh.SelectedItem.Value.ToString());
            ServiceConnector.GetDataFromServiceByPost<khachHang>("api/kh/addkh", kh, true);
            ClearData();
        }

        protected void btnupDate_Click(object sender, EventArgs e)
        {
            var kh = new khachHang();
            kh.maKhachHang = int.Parse(txtmakh.Text.ToString());
            kh.hoTen = txthoten.Text.ToString();
            kh.soCMND = txtsocmnd.Text.ToString();
            kh.ngaySinh = DateTime.Parse(DateTime.ParseExact(txtngaysinh.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-mm-dd"));
            kh.dienThoai = txtdienthoai.Text.ToString();
            kh.email = txtemail.Text.ToString();
            kh.diaChiThuongTru = txtdcthuongtru.Text.ToString();
            kh.diaChiLienLac = txtdclienlac.Text.ToString();
            kh.soDuTaiKhoan = Double.Parse(txtsdtaikhoan.Text.ToString());
            if (cbxgioitinh.Text == "Nam")
                kh.gioiTinh = true;
            else
                kh.gioiTinh = false;
            if (cbxtinhtranghonnhan.Text == "Độc Thân")
                kh.tinhTrangHonNhan = false;
            else
                kh.tinhTrangHonNhan = true;
            kh.ngayLap = DateTime.Parse(DateTime.ParseExact(txtngaylap.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-mm-dd"));
            if (cbxtinhtranghoatdong.Text == "Có")
                kh.tinhTrangHoatDong = true;
            else
                kh.tinhTrangHoatDong = false;
            kh.maCNDangky = int.Parse(cbxchinhanh.SelectedItem.Value.ToString());
            ServiceConnector.GetDataFromServiceByPost<khachHang>("api/kh/upkh", kh, true);
            ClearData();
            lbmakh.Visible = false;
            txtmakh.Visible = false;
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            var kh = new khachHang();
            kh.maKhachHang = int.Parse(txtmakh.Text.ToString());
            kh.hoTen = txthoten.Text.ToString();
            kh.soCMND = txtsocmnd.Text.ToString();
            kh.ngaySinh = DateTime.Parse(DateTime.ParseExact(txtngaysinh.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-mm-dd"));
            kh.dienThoai = txtdienthoai.Text.ToString();
            kh.email = txtemail.Text.ToString();
            kh.diaChiThuongTru = txtdcthuongtru.Text.ToString();
            kh.diaChiLienLac = txtdclienlac.Text.ToString();
            kh.soDuTaiKhoan = Double.Parse(txtsdtaikhoan.Text.ToString());
            if (cbxgioitinh.Text == "Nam")
                kh.gioiTinh = true;
            else
                kh.gioiTinh = false;
            if (cbxtinhtranghonnhan.Text == "Độc Thân")
                kh.tinhTrangHonNhan = false;
            else
                kh.tinhTrangHonNhan = true;
            kh.ngayLap = DateTime.Parse(DateTime.ParseExact(txtngaylap.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-mm-dd"));
            if (cbxtinhtranghoatdong.Text == "Có")
                kh.tinhTrangHoatDong = true;
            else
                kh.tinhTrangHoatDong = false;
            kh.maCNDangky = int.Parse(cbxchinhanh.SelectedItem.Value.ToString());
            ServiceConnector.GetDataFromServiceByPost<khachHang>("api/kh/delkh", kh, true);
            ClearData();
            lbmakh.Visible = false;
            txtmakh.Visible = false;
        }

        private void BindRefData()
        {
            cbxchinhanh.DataSource = ServiceConnector.GetDataFromServiceByGet<ChiNhanh>("api/chinhanh/all", true);
            cbxchinhanh.DataBind();
        }

        private void ClearData()
        {
            txtmakh.Text = null;
            txthoten.Text = null;
            txtsocmnd.Text = null;
            txtngaysinh.Text = null;
            txtdienthoai.Text = null;
            txtemail.Text = null;
            txtdcthuongtru.Text = null;
            txtdclienlac.Text = null;
            txtsdtaikhoan.Text = null;
            cbxgioitinh.SelectedIndex = 0;
            cbxtinhtranghonnhan.SelectedIndex = 0;
            txtngaylap.Text = null;
            cbxtinhtranghoatdong.SelectedIndex = 0;
            cbxchinhanh.SelectedIndex = 0;
        }

        private void GetKhachHang(int makh)
        {
            List<khachHang> kh = new List<khachHang>();
            string url = "api/kh/id/" + makh.ToString();
            kh = ServiceConnector.GetDataFromServiceByGet<khachHang>(url, true);
            txtmakh.Text = kh[0].maKhachHang.ToString();
            txthoten.Text = kh[0].hoTen.ToString();
            txtsocmnd.Text = kh[0].soCMND.ToString();
            txtngaysinh.Text = kh[0].ngaySinh.ToString("dd/mm/yyyy");
            txtdienthoai.Text = kh[0].dienThoai.ToString();
            txtemail.Text = kh[0].email.ToString();
            txtdcthuongtru.Text = kh[0].diaChiThuongTru.ToString();
            txtdclienlac.Text = kh[0].diaChiLienLac.ToString();
            txtsdtaikhoan.Text = kh[0].soDuTaiKhoan.ToString();
            if (kh[0].gioiTinh == true)
                cbxgioitinh.SelectedIndex = 0;
            else
                cbxgioitinh.SelectedIndex = 1;
            if (kh[0].tinhTrangHonNhan == true)
                cbxtinhtranghonnhan.SelectedIndex = 1;
            else
                cbxtinhtranghonnhan.SelectedIndex = 0;
            txtngaylap.Text = kh[0].ngayLap.ToString("dd/mm/yyyy");
            if (kh[0].tinhTrangHoatDong == true)
                cbxtinhtranghoatdong.SelectedIndex = 0;
            else
                cbxtinhtranghoatdong.SelectedIndex = 1;
            cbxchinhanh.SelectedValue = kh[0].maCNDangky.ToString();
            lbmakh.Visible = true;
            txtmakh.Visible = true;
        }
    }
}