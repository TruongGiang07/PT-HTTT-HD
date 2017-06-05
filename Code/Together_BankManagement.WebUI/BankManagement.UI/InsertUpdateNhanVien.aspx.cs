using BankManagement.UI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
namespace BankManagement.UI
{
    public partial class InsertUpdateNhanVien : System.Web.UI.Page
    {
       private int _MaNhanVien
        {
            get
            {
                if (Request.QueryString.Count > 0)
                {
                    int maNV;
                    if (!int.TryParse(Request.QueryString["maNV"].Trim(), out maNV))
                    {
                        maNV = -1;
                    }
                    return maNV;
                }
                return -1;
            }
        }

        private bool _IsUpdateMode
        {
            get
            {
                return _MaNhanVien > 0;
            }
        }

 

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindRefData();
                if (_IsUpdateMode)
                {
                    GetNhanVien(_MaNhanVien);
                    btnInsertOrUpdateNV.Text = "Lưu Nhân Viên";
                    Title = "Chỉnh Sửa Tài Khoản Nhân Viên";
                }
            }
        }

        protected void btnInsertOrUpdate_Click(object sender, EventArgs e)
        {
            string url = _IsUpdateMode ? "api/nv/up" : "api/nv/add";
            ServiceConnector.InsertOrUpdate<nhanVien>(url, CreateNhanVien(), true);
            ClearData();
        }

        private void BindRefData()
        {
            cbxChiNhanh.DataSource = ServiceConnector.GetDataFromServiceByGet<ChiNhanh>("api/chinhanh/all", true);
            cbxChiNhanh.DataBind();
        }

        private void ClearData()
        {
            txtMaNV.Text = null;
            txtHoTen.Text = null;
            dtNgaySinh.Text = null;
            stDienThoai.Text = null;
            stDCThuongTru.Text = null;
            stTenDangNhap.Text = null;
            stMatKhau.Text = null;
            cbxgioitinh.SelectedIndex = 0;
            cbxChiNhanh.SelectedIndex = 0;
        }

        private nhanVien CreateNhanVien()
        {
            var nv = new nhanVien();
            if (_IsUpdateMode)
            {
                nv.maNhanVien = _MaNhanVien;
            }
            nv.hoTen = txtHoTen.Text.Trim();
            nv.ngaySinh = DateTime.ParseExact(dtNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            nv.soDienThoai = stDienThoai.Text.Trim();
            nv.diaChi = stDCThuongTru.Text.Trim();
            nv.tenDangNhap = stTenDangNhap.Text.Trim();
            nv.matKhau = stMatKhau.Text.Trim();
            if (cbxgioitinh.SelectedValue == "Nam")
                nv.gioiTinh= true;
            else
                nv.gioiTinh = false;
          
            nv.maCNLamViec = int.Parse(cbxChiNhanh.SelectedValue);
            return nv;
        }

        private void GetNhanVien(int manv)
        {
            List<nhanVien> nv = new List<nhanVien>();
            string url = "api/nv/id/" + manv.ToString();
            nv = ServiceConnector.GetDataFromServiceByGet<nhanVien>(url, true);
            if (nv.Count > 0)
            {
                txtMaNV.Text = nv[0].maNhanVien.ToString();
                txtHoTen.Text = nv[0].hoTen.ToString();
                dtNgaySinh.Text = nv[0].ngaySinh.ToString("dd/MM/yyyy");
                stDienThoai.Text = nv[0].soDienThoai.ToString();
                stDCThuongTru.Text = nv[0].diaChi.ToString();
                stTenDangNhap.Text = nv[0].tenDangNhap.ToString();
                stMatKhau.Text = nv[0].matKhau.ToString();
                if (nv[0].gioiTinh == true)
                    cbxgioitinh.SelectedIndex = 0;
                else
                    cbxgioitinh.SelectedIndex = 1;
                cbxChiNhanh.SelectedValue = nv[0].maCNLamViec.ToString();
                divLabelMaNV.Visible = divTextboxMaNV.Visible = true;
            }
        }
    }
 }
