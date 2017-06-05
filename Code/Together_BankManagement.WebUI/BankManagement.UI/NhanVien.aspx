<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageOne.Master" AutoEventWireup="true" CodeBehind="NhanVien.aspx.cs" Inherits="BankManagement.UI.NhanVien" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="assets/js/bootstrap-datepicker-1.6.4-dist/css/bootstrap-datepicker3.min.css" rel="stylesheet" />
    <script src="assets/js/bootstrap-datepicker-1.6.4-dist/js/bootstrap-datepicker.min.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContainer" runat="server">

    <div class="row">
        <div class="col-md-12 text-center">
            <div class="filter-left">
                <div>
                    <asp:DropDownList ID="cbxTimKiem" runat="server" CssClass="form-control" Width="316px">
                        <asp:ListItem Value="All" Text="Tất cả"></asp:ListItem>
                        <asp:ListItem Value="MaNV" Text="Mã Nhân Viên"></asp:ListItem>
                        <asp:ListItem Value="HoTen" Text="Họ Tên"></asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <div class="filter-right">
                <div class="control-inline">
                    <asp:TextBox ID="txtTimKiem" runat="server" CssClass="form-control" Width="316px" TextMode="Search" />
                </div>
            </div>
            <div class="control-inline">
                <asp:Button ID="btnTimKiem" runat="server" Text="Tìm Kiếm" CssClass="btn btn-default" OnClick="btnTimKiem_Click" />
            </div>
        </div>
    </div>

    <div class="row">
        <div class="col-md-12">
            <h3>Danh Sách Nhân Viên</h3>
            <asp:GridView ID="gvNhanVien" runat="server" AutoGenerateColumns="false" AllowPaging="true" PageSize="5"
                Width="100%" CssClass="table table-bordered" RowStyle-CssClass="grid-row"
                AlternatingRowStyle-BackColor="White" OnPageIndexChanging="gvNhanVien_PageIndexChanging" OnRowDataBound="gvNhanVien_RowDataBound">
                <PagerSettings Mode="Numeric" />
                <PagerStyle CssClass="pagination-ys" />
                <Columns>
                    <asp:BoundField DataField="maNhanVien" HeaderText="Mã NV" HeaderStyle-Wrap="false" ItemStyle-HorizontalAlign="Center" />
                    <asp:BoundField DataField="hoTen" HeaderText="Họ Tên" />
                    <asp:BoundField DataField="ngaySinh" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Ngày Sinh" />
                    <asp:BoundField DataField="soDienThoai" HeaderText="Điện Thoại" />
                    <asp:BoundField DataField="diaChi" HeaderText="Địa Chỉ Thường Trú" />
                    <asp:BoundField DataField="gioiTinh" HeaderText="Giới Tính" />
                    <asp:BoundField DataField="maCNLamViec" HeaderText="Chi Nhánh" />
                    <asp:BoundField DataField="tenDangNhap" HeaderText="Tên Đăng Nhập" />
                    <asp:BoundField DataField="matKhau" HeaderText="Mật Khẩu" />
                </Columns>
            </asp:GridView>

        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <a onclick="openPopupModal('InsertUpdateNhanVien.aspx');" class="btn btn-default">Tạo Mới Nhân Viên</a>
        </div>
    </div>
    <script type="text/javascript">
        $('#dtNgaySinh1 .input-daterange').datepicker({
            autoclose: true,
            endDate: "-1d",
            dateFormat: "yyyy-MM-dd"
        });
    </script>

</asp:Content>
