<%@ Page Title="Tạo Tài Khoản Nhân Viên" Language="C#" MasterPageFile="~/MasterPageModal.Master" AutoEventWireup="true" CodeBehind="InsertUpdateNhanVien.aspx.cs" Inherits="BankManagement.UI.InsertUpdateNhanVien" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="assets/js/bootstrap-datepicker-1.6.4-dist/css/bootstrap-datepicker3.min.css" rel="stylesheet" />
    <script src="assets/js/bootstrap-datepicker-1.6.4-dist/js/bootstrap-datepicker.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-12 text-center">
            <div class="filter-left">
                <div id="divLabelMaNV" runat="server" Visible="False">
                    <asp:Label ID="lbmakh" runat="server" Enabled="False" Font-Bold="True">Mã NV:</asp:Label>
                </div>
                <div>
                    <label>Họ Tên</label>
                </div>
                <div>
                    <label>Ngày Sinh:</label>
                </div>
                <div>
                    <label>Điện Thoại:</label>
                </div>
                <div>
                    <label>Địa Chỉ:</label>
                </div>
                <div>
                    <label>Giới Tính:</label>
                </div>
                <div>
                    <label>Chi Nhánh Làm Việc:</label>
                </div>
                <div>
                    <label>Tên Đăng Nhập:</label>
                </div>
                <div>
                    <label>Mật Khẩu:</label>
                </div>
            </div>
            <div class="filter-right">
                <div id="divTextboxMaNV" runat="server" Visible="False">
                    <asp:TextBox ID="txtMaNV" runat="server" CssClass="form-control" Width="316px" Enabled="False" />
                </div>
                <div>
                    <asp:TextBox ID="txtHoTen" runat="server" CssClass="form-control" Width="316px"/>
                </div>
                <div id="dtNgaySinh1">
                    <div class="input-group input-daterange">
                        <asp:TextBox ID="dtNgaySinh" runat="server" CssClass="form-control" Width="316px" />
                    </div>
                </div>
                <div>
                    <asp:TextBox ID="stDienThoai" runat="server" CssClass="form-control" Width="316px"/>
                </div>
                <div>
                    <asp:TextBox ID="stDCThuongTru" runat="server" CssClass="form-control" Width="316px"/>
                </div>
                 <div class="dropdown">
                    <asp:DropDownList ID="cbxgioitinh" runat="server" CssClass="form-control" Width="316px" DataValueField="value">
                        <asp:ListItem Value="Nam" Text="Nam"></asp:ListItem>
                        <asp:ListItem Value="Nu" Text="Nữ"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="dropdown">
                    <asp:DropDownList ID="cbxChiNhanh" runat="server" CssClass="form-control" Width="316px" DataValueField="maChiNhanh" DataTextField="tenChiNhanh"></asp:DropDownList>
               </div>
                 <div>
                    <asp:TextBox ID="stTenDangNhap" runat="server" CssClass="form-control" Width="316px"/>
                </div>
                 <div>
                    <asp:TextBox ID="stMatKhau" runat="server" CssClass="form-control" Width="316px"/>
                </div>
            <div class="text-right">
                <asp:Button ID="btnInsertOrUpdateNV" runat="server" Text="Thêm Nhân Viên" CssClass="btn btn-default" OnClick="btnInsertOrUpdate_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Hủy" CssClass="btn btn-default" OnClientClick="return parent.closePopupModal();" />
            </div>
        </div>
    </div>
        </>
        </div> 
    <script type="text/javascript">
        $('.input-daterange').datepicker({
            autoclose: true,
            endDate: "-1d",
            format: "dd/mm/yyyy"
        });
    </script>
</asp:Content>
