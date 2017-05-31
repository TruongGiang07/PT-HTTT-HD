<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageOne.Master" AutoEventWireup="true" CodeBehind="KhachHang.aspx.cs" Inherits="BankManagement.UI.KhachHang" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="assets/js/bootstrap-datepicker-1.6.4-dist/css/bootstrap-datepicker3.min.css" rel="stylesheet" />
    <script src="assets/js/bootstrap-datepicker-1.6.4-dist/js/bootstrap-datepicker.min.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContainer" runat="server">
    
    <br/>
    <div class="row">
        <div class="col-md-12 text-center">
            <div class="filter-left">
                <div>
                    <asp:DropDownList ID="cbxTimKiem" runat="server" CssClass="form-control" Width="316px" DataValueField="value"></asp:DropDownList>
                </div>
            </div>
            <div class="filter-right">
                <div class="control-inline">
                    <asp:TextBox ID="txtTimKiem" runat="server" CssClass="form-control" Width="316px" TextMode="Number"/>
                </div>
            </div>
            <div class="control-inline">
                <asp:Button ID="btnTimKiem" runat="server" Text="Tìm Kiếm" CssClass="btn btn-default search-btn" OnClick="btnTimKiem_Click"/>
            </div>
        </div>
    </div>

    <div class="row">
        <div class="col-md-12">
            <h3>Danh Sách Khách Hàng</h3>
            <asp:GridView ID="gvKhachHang" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanging="gvKhachHang_SelectedIndexChanging" 
                AutoGenerateSelectButton="True" AllowPaging="true" PageSize="5" Width="100%" CssClass="table table-bordered" RowStyle-CssClass="grid-row" 
                AlternatingRowStyle-BackColor="White" OnPageIndexChanging="gvKhachHang_PageIndexChanging">
                <PagerSettings Mode="Numeric" />  
                <PagerStyle CssClass="pagination-ys"/>
                <Columns>
                    <asp:BoundField DataField="maKhachHang" HeaderText="Mã Khách Hàng" />
                    <asp:BoundField DataField="hoTen" HeaderText="Họ Tên" />
                    <asp:BoundField DataField="soCMND" HeaderText="CMND" />
                    <asp:BoundField DataField="ngaySinh" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Ngày Sinh" />
                    <asp:BoundField DataField="dienThoai" HeaderText="Điện Thoại" />
                    <asp:BoundField DataField="email" HeaderText="Email" />
                    <asp:BoundField DataField="diaChiThuongTru" HeaderText="Địa Chỉ Thường Trú" />
                    <asp:BoundField DataField="diaChiLienLac" HeaderText="Địa Chỉ Liên Lạc" />
                    <asp:BoundField DataField="soDuTaiKhoan" HeaderText="Số Dư Tài Khoản" />
                    <asp:BoundField DataField="gioiTinh" HeaderText="Giới Tính" />
                    <asp:BoundField DataField="tinhTrangHonNhan" HeaderText="Tình Trạng Hôn Nhân" />
                    <asp:BoundField DataField="ngayLap" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Ngày Lập" />
                    <asp:BoundField DataField="tinhTrangHoatDong" HeaderText="Tình Trạng Hoạt Động" />
                    <asp:BoundField DataField="maCNDangky" HeaderText="Chi Nhánh" />
                </Columns>
            </asp:GridView>
        </div>
    </div>

    <div class="row">
        <div class="col-md-12 text-center">
            <div class="filter-left">
                <div>
                    <asp:Label ID="lbMaKH" runat="server" Visible="False" Enabled="False" Font-Bold="True">Mã Khách Hàng:</asp:Label>
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
                    <asp:TextBox ID="stMaKH" runat="server" CssClass="form-control" Width="316px" Enabled="False" Visible="False" />
                </div>
                <div>
                    <asp:TextBox ID="stHoTen" runat="server" CssClass="form-control" Width="316px"/>
                </div>
                <div>
                    <asp:TextBox ID="stCMND" runat="server" CssClass="form-control" Width="316px" TextMode="Number"/>
                </div>
                <div id="dtNgay">
                    <div class="input-group input-daterange">
                        <asp:TextBox ID="dtNgaySinh" runat="server" CssClass="form-control" Width="316px" />
                    </div>
                </div>
                <div>
                    <asp:TextBox ID="stDienThoai" runat="server" CssClass="form-control" Width="316px" TextMode="Number"/>
                </div>
                <div>
                    <asp:TextBox ID="stEmail" runat="server" CssClass="form-control" Width="316px" TextMode="Email"/>
                </div>
                <div>
                    <asp:TextBox ID="stDCThuongTru" runat="server" CssClass="form-control" Width="316px"/>
                </div>
                <div>
                    <asp:TextBox ID="stDCLienLac" runat="server" CssClass="form-control" Width="316px"/>
                </div>
                <div>
                    <asp:TextBox ID="dbSoDuTaiKhoan" runat="server" CssClass="form-control" Width="316px" TextMode="Number"/>
                </div>
                <div class="dropdown">
                    <asp:DropDownList ID="cbxGioiTinh" runat="server" CssClass="form-control" Width="316px" DataValueField="value"></asp:DropDownList>
                </div>
                <div class="dropdown control-inline">
                    <asp:DropDownList ID="cbxTinhTrangHonNhan" runat="server" CssClass="form-control" Width="316px" DataValueField="value"></asp:DropDownList>
                </div>
                <div id="dtNgay">
                    <div class="input-group input-daterange">
                        <asp:TextBox ID="dtNgayLap" runat="server" CssClass="form-control" Width="316px" />
                    </div>
                </div>
                <div class="dropdown">
                    <asp:DropDownList ID="cbxTinhTrangHoatDong" runat="server" CssClass="form-control" Width="316px" DataValueField="value"></asp:DropDownList>
                </div>
               <div class="dropdown">
                    <asp:DropDownList ID="cbxChiNhanh" runat="server" CssClass="form-control" Width="316px" DataValueField="maChiNhanh" DataTextField="tenChiNhanh"></asp:DropDownList>
               </div>
            </div>
            <div>
                <asp:Button ID="btnInsert" runat="server" Text="Thêm Khách Hàng" CssClass="btn btn-default search-btn" OnClick="btnInsert_Click" />
                <asp:Button ID="btnUpDate" runat="server" Text="Sửa Khách Hàng" CssClass="btn btn-default search-btn" OnClick="btnUpDate_Click"/>
                <asp:Button ID="btnDelete" runat="server" Text="Xóa Khách Hàng" CssClass="btn btn-default search-btn" OnClick="btnDelete_Click"/>
            </div>
        </div>
    </div>

    <script type="text/javascript">
        $('#dtNgay .input-daterange').datepicker({
            autoclose: true,
            endDate: "-1d",
            format: "dd/mm/yyyy"
        });
    </script>

</asp:Content>
