<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageOne.Master" AutoEventWireup="true" CodeBehind="InsertUpdateKhachHang.aspx.cs" Inherits="BankManagement.UI.InsertUpdateKhachHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="assets/js/bootstrap-datepicker-1.6.4-dist/css/bootstrap-datepicker3.min.css" rel="stylesheet" />
    <script src="assets/js/bootstrap-datepicker-1.6.4-dist/js/bootstrap-datepicker.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContainer" runat="server">
    <div class="row">
        <div class="col-md-12 text-center">
            <div class="filter-left">
                <div>
                    <asp:Label ID="lbmakh" runat="server" Visible="False" Enabled="False" Font-Bold="True">Mã Khách Hàng:</asp:Label>
                </div>
                <div>
                    <label>Họ Tên:</label>
                </div>
                <div>
                    <label>CMND:</label>
                </div>
                <div>
                    <label>Ngày Sinh:</label>
                </div>
                <div>
                    <label>Điện Thoại:</label>
                </div>
                <div>
                    <label>Email:</label>
                </div>
                <div>
                    <label>Địa Chỉ Thường Trú:</label>
                </div>
                <div>
                    <label>Địa Chỉ Liên Lạc:</label>
                </div>
                <div>
                    <label>Số Dư Tài Khoản:</label>
                </div>
                <div>
                    <label>Giới Tính:</label>
                </div>
                <div>
                    <label>Tình Trạng hôn nhân:</label>
                </div>
                <div>
                    <label>Ngày Lập:</label>
                </div>
                <div>
                    <label>Tình Trạng Hoạt Động:</label>
                </div>
                <div>
                    <label>Chi Nhánh Đăng Kí:</label>
                </div>
            </div>
            <div class="filter-right">
                <div>
                    <asp:TextBox ID="txtmakh" runat="server" CssClass="form-control" Width="316px" Enabled="False" Visible="False" />
                </div>
                <div>
                    <asp:TextBox ID="txthoten" runat="server" CssClass="form-control" Width="316px"/>
                </div>
                <div>
                    <asp:TextBox ID="txtsocmnd" runat="server" CssClass="form-control" Width="316px" TextMode="Number"/>
                </div>
                <div id="dtNgay">
                    <div class="input-group input-daterange">
                        <asp:TextBox ID="txtngaysinh" runat="server" CssClass="form-control" Width="316px" />
                    </div>
                </div>
                <div>
                    <asp:TextBox ID="txtdienthoai" runat="server" CssClass="form-control" Width="316px" TextMode="Number"/>
                </div>
                <div>
                    <asp:TextBox ID="txtemail" runat="server" CssClass="form-control" Width="316px" TextMode="Email"/>
                </div>
                <div>
                    <asp:TextBox ID="txtdcthuongtru" runat="server" CssClass="form-control" Width="316px"/>
                </div>
                <div>
                    <asp:TextBox ID="txtdclienlac" runat="server" CssClass="form-control" Width="316px"/>
                </div>
                <div>
                    <asp:TextBox ID="txtsdtaikhoan" runat="server" CssClass="form-control" Width="316px" TextMode="Number"/>
                </div>
                <div class="dropdown">
                    <asp:DropDownList ID="cbxgioitinh" runat="server" CssClass="form-control" Width="316px" DataValueField="value"></asp:DropDownList>
                </div>
                <div class="dropdown control-inline">
                    <asp:DropDownList ID="cbxtinhtranghonnhan" runat="server" CssClass="form-control" Width="316px" DataValueField="value"></asp:DropDownList>
                </div>
                <div id="dtNgay">
                    <div class="input-group input-daterange">
                        <asp:TextBox ID="txtngaylap" runat="server" CssClass="form-control" Width="316px" />
                    </div>
                </div>
                <div class="dropdown">
                    <asp:DropDownList ID="cbxtinhtranghoatdong" runat="server" CssClass="form-control" Width="316px" DataValueField="value"></asp:DropDownList>
                </div>
               <div class="dropdown">
                    <asp:DropDownList ID="cbxchinhanh" runat="server" CssClass="form-control" Width="316px" DataValueField="maChiNhanh" DataTextField="tenChiNhanh"></asp:DropDownList>
               </div>
            </div>
            <div>
                <asp:Button ID="btninsert" runat="server" Text="Thêm Khách Hàng" CssClass="btn btn-default search-btn" OnClick="btninsert_Click" />
                <asp:Button ID="btnipDate" runat="server" Text="Sửa Khách Hàng" CssClass="btn btn-default search-btn" OnClick="btnupDate_Click" />
                <asp:Button ID="btndelete" runat="server" Text="Xóa Khách Hàng" CssClass="btn btn-default search-btn" OnClick="btndelete_Click" />
            </div>
        </div>
    </div>

</asp:Content>
