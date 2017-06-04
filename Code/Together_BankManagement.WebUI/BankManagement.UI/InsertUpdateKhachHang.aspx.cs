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
        private int _MaKhachHang
        {
            get
            {
                if (Request.QueryString.Count > 0)
                {
                    int maKH;
                    if (!int.TryParse(Request.QueryString["maKH"].Trim(), out maKH))
                    {
                        maKH = -1;
                    }
                    return maKH;
                }
                return -1;
            }
        }

        private bool _IsUpdateMode
        {
            get
            {
                return _MaKhachHang > 0;
            }
        }

        private double _SoDu
        {
            get
            {
                if (ViewState["SoDu"] == null)
                {
                    ViewState["SoDu"] = 0;
                }
                return (double)ViewState["SoDu"];
            }
            set
            {
                ViewState["SoDu"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindRefData();
                if (_IsUpdateMode)
                {
                    GetKhachHang(_MaKhachHang);
                    btnInsertOrUpdate.Text = "Lưu Khách Hàng";
                    Title = "Chỉnh Sửa Tài Khoản Khách Hàng";
                }
            }
        }

        protected void btnInsertOrUpdate_Click(object sender, EventArgs e)
        {
            string url = _IsUpdateMode ? "api/kh/upkh" : "api/kh/addkh";
            ServiceConnector.InsertOrUpdate<khachHang>(url, CreateKhachHang(), true);
            ClearData();
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
            cbxgioitinh.SelectedIndex = 0;
            cbxtinhtranghonnhan.SelectedIndex = 0;
            txtngaylap.Text = null;
            cbxtinhtranghoatdong.SelectedIndex = 0;
            cbxchinhanh.SelectedIndex = 0;
        }

        private khachHang CreateKhachHang()
        {
            var kh = new khachHang();
            kh.maKhachHang = _MaKhachHang;
            kh.hoTen = txthoten.Text.Trim();
            kh.soCMND = txtsocmnd.Text.Trim();
            kh.ngaySinh = DateTime.ParseExact(txtngaysinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            kh.dienThoai = txtdienthoai.Text.Trim();
            kh.email = txtemail.Text.ToString();
            kh.diaChiThuongTru = txtdcthuongtru.Text.Trim();
            kh.diaChiLienLac = txtdclienlac.Text.Trim();
            kh.soDuTaiKhoan = _SoDu;
            if (cbxgioitinh.SelectedValue == "Nam")
                kh.gioiTinh = true;
            else
                kh.gioiTinh = false;
            if (cbxtinhtranghonnhan.SelectedValue == "DT")
                kh.tinhTrangHonNhan = false;
            else
                kh.tinhTrangHonNhan = true;
            kh.ngayLap = DateTime.ParseExact(txtngaylap.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            if (cbxtinhtranghoatdong.SelectedValue == "Co")
                kh.tinhTrangHoatDong = true;
            else
                kh.tinhTrangHoatDong = false;
            kh.maCNDangky = int.Parse(cbxchinhanh.SelectedValue);

            return kh;
        }

        private void GetKhachHang(int makh)
        {
            List<khachHang> kh = new List<khachHang>();
            string url = "api/kh/id/" + makh.ToString();
            kh = ServiceConnector.GetDataFromServiceByGet<khachHang>(url, true);
            if (kh.Count > 0)
            {
                txtmakh.Text = kh[0].maKhachHang.ToString();
                txthoten.Text = kh[0].hoTen.ToString();
                txtsocmnd.Text = kh[0].soCMND.ToString();
                txtngaysinh.Text = kh[0].ngaySinh.ToString("dd/MM/yyyy");
                txtdienthoai.Text = kh[0].dienThoai.ToString();
                txtemail.Text = kh[0].email.ToString();
                txtdcthuongtru.Text = kh[0].diaChiThuongTru.ToString();
                txtdclienlac.Text = kh[0].diaChiLienLac.ToString();
                if (kh[0].gioiTinh == true)
                    cbxgioitinh.SelectedIndex = 0;
                else
                    cbxgioitinh.SelectedIndex = 1;
                if (kh[0].tinhTrangHonNhan == true)
                    cbxtinhtranghonnhan.SelectedIndex = 1;
                else
                    cbxtinhtranghonnhan.SelectedIndex = 0;
                txtngaylap.Text = kh[0].ngayLap.ToString("dd/MM/yyyy");
                if (kh[0].tinhTrangHoatDong == true)
                    cbxtinhtranghoatdong.SelectedIndex = 0;
                else
                    cbxtinhtranghoatdong.SelectedIndex = 1;
                cbxchinhanh.SelectedValue = kh[0].maCNDangky.ToString();
                divLabelMaKH.Visible = divTextboxMaKH.Visible = true;
                _SoDu = kh[0].soDuTaiKhoan;
            }
        }
    }
}