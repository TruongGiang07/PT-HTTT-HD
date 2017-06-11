using BankManagement.UI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using System.Text;
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

        private string _CurrentPassword
        {
            get
            {
                if (ViewState["CurPassword"] == null)
                {
                    ViewState["CurPassword"] = "";
                }
                return (string)ViewState["CurPassword"];
            }
            set
            {
                ViewState["CurPassword"] = value;
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
            Page.ClientScript.RegisterStartupScript(this.GetType(), "reload", "parent.closePopupModal(); parent.reloadPage();", true);
        }

        private void BindRefData()
        {
            cbxChiNhanh.DataSource = ServiceConnector.GetDataFromServiceByGet<ChiNhanh>("api/chinhanh/all", true);
            cbxChiNhanh.DataBind();
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
            nv.matKhau = _IsUpdateMode ? _CurrentPassword : CreatePassword(10);
            if (cbxgioitinh.SelectedValue == "Nam")
                nv.gioiTinh= true;
            else
                nv.gioiTinh = false;
          
            nv.maCNLamViec = int.Parse(cbxChiNhanh.SelectedValue);
            nv.loaiNV = 2;
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
                _CurrentPassword = nv[0].matKhau;
                if (nv[0].gioiTinh == true)
                    cbxgioitinh.SelectedIndex = 0;
                else
                    cbxgioitinh.SelectedIndex = 1;
                cbxChiNhanh.SelectedValue = nv[0].maCNLamViec.ToString();
                divLabelMaNV.Visible = divTextboxMaNV.Visible = true;
            }
        }

        private string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

    }
 }
