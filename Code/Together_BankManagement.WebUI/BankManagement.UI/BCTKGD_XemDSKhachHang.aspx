<%@ Page Title="Xem Danh Sách Khách Hàng Đã Giao Dịch" Language="C#" MasterPageFile="~/MasterPageModal.Master" AutoEventWireup="true" CodeBehind="BCTKGD_XemDSKhachHang.aspx.cs" Inherits="BankManagement.UI.BCTKGD_XemDSKhachHang" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4>Danh Sách Khách Hàng Giao Dịch</h4>
    <asp:Label ID="lblNgay" runat="server"></asp:Label>
    <asp:GridView ID="gvDSGiaoDich" runat="server" AutoGenerateColumns="false" AllowPaging="true" PageSize="6"
                Width="100%" CssClass="table table-bordered" RowStyle-CssClass="grid-row" AlternatingRowStyle-BackColor="White"
                OnPageIndexChanging="gvDSGiaoDich_PageIndexChanging" OnRowDataBound="gvDSGiaoDich_RowDataBound">              
                <PagerStyle CssClass="pagination-ys" />
                <Columns>
                    <asp:BoundField DataField="maKhachHang" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" HeaderText="Mã Khách Hàng" />
                    <asp:BoundField DataField="hoTen" HeaderText="Họ Tên" HeaderStyle-HorizontalAlign="Center" />
                    <asp:BoundField DataField="soCMND" HeaderText="CMND" />
                    <asp:BoundField DataField="soTienGD" DataFormatString="{0:0,00 VND}" HeaderText="Số Tiền Giao Dịch" ItemStyle-HorizontalAlign="Right" />
                    <asp:BoundField DataField="loaiGD" HeaderText="Giao Dịch" />                    
                </Columns>
            </asp:GridView>
</asp:Content>
