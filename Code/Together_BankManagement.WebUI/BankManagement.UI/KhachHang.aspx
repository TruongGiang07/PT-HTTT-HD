<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageOne.Master" AutoEventWireup="true" CodeBehind="KhachHang.aspx.cs" Inherits="BankManagement.UI.KhachHang" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContainer" runat="server">
    
    <div class="row">
        <div class="col-md-12 text-center">
            <div class="filter-left">
                <div>
                    <asp:DropDownList ID="cbxTimKiem" runat="server" CssClass="form-control" Width="316px">
                        <asp:ListItem Value="All" Text="Tất cả"></asp:ListItem>
                        <asp:ListItem Value="MaKH" Text="Mã Khách Hàng"></asp:ListItem>
                        <asp:ListItem Value="CMND" Text="CMND"></asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <div class="filter-right">
                <div class="control-inline">
                    <asp:TextBox ID="txtTimKiem" runat="server" CssClass="form-control" Width="316px" TextMode="Number"/>
                </div>
            </div>
            <div class="control-inline">
                <asp:Button ID="btnTimKiem" runat="server" Text="Tìm Kiếm" CssClass="btn btn-default" OnClick="btnTimKiem_Click"/>
            </div>
        </div>
    </div>

    <div class="row">
        <div class="col-md-12">
            <h3>Danh Sách Khách Hàng</h3>
            <asp:GridView ID="gvKhachHang" runat="server" AutoGenerateColumns="false" AllowPaging="true" PageSize="5" 
                Width="100%" CssClass="table table-bordered" RowStyle-CssClass="grid-row" 
                AlternatingRowStyle-BackColor="White" OnPageIndexChanging="gvKhachHang_PageIndexChanging" OnRowDataBound="gvKhachHang_RowDataBound">
                <PagerSettings Mode="Numeric" />  
                <PagerStyle CssClass="pagination-ys"/>
                <EmptyDataTemplate>
                    <label>Không có dữ liệu để hiển thị</label>
                </EmptyDataTemplate>
                <Columns>
                    <asp:BoundField DataField="maKhachHang" HeaderText="Mã KH" HeaderStyle-Wrap="false" ItemStyle-HorizontalAlign="Center" />
                    <asp:BoundField DataField="hoTen" HeaderText="Họ Tên" />
                    <asp:BoundField DataField="soCMND" HeaderText="CMND" />
                    <asp:BoundField DataField="ngaySinh" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Ngày Sinh" />
                    <asp:BoundField DataField="dienThoai" HeaderText="Điện Thoại" />
                    <asp:BoundField DataField="email" HeaderText="Email" />
                    <asp:BoundField DataField="diaChiThuongTru" HeaderText="ĐC Thường Trú" />
                    <asp:BoundField DataField="diaChiLienLac" HeaderText="ĐC Liên Lạc"  />
                    <asp:BoundField DataField="soDuTaiKhoan" HeaderText="Số Dư" DataFormatString="{0:0,00 d}" ItemStyle-Wrap="false" />
                    <asp:BoundField DataField="gioiTinh" HeaderText="Giới Tính" />
                    <asp:BoundField DataField="ngayLap" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Ngày Lập" />
                </Columns>
            </asp:GridView>
        </div>
    </div>

    <div class="row">
        <div class="col-md-12">
            <a onclick="openPopupModal('InsertUpdateKhachHang.aspx');" class="btn btn-default">Tạo Mới Khách Hàng</a>
        </div>
    </div>
</asp:Content>
