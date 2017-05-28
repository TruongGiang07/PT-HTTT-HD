<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageOne.Master" AutoEventWireup="true" CodeBehind="BaoCaoTKGiaoDich.aspx.cs" Inherits="BankManagement.UI.BaoCaoTKGiaoDich" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="assets/js/bootstrap-datepicker-1.6.4-dist/css/bootstrap-datepicker3.min.css" rel="stylesheet" />
    <script src="assets/js/bootstrap-datepicker-1.6.4-dist/js/bootstrap-datepicker.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContainer" runat="server">
    <div class="row">
        <div class="col-md-12 text-center">
            <div class="filter-left">
                <div>
                    <label>Ngày Giao Dịch</label>
                </div>
                <div>
                    <label>Trụ Sở</label>
                </div>
                <div>
                    <label>Chi Nhánh</label>                    
                </div>
            </div>
            <div class="filter-right">
                <div id="dtNgayGiaoDich">
                    <div class="input-group input-daterange">
                        <asp:TextBox ID="dtTuNgay" runat="server" CssClass="form-control" Width="140px" /><span class="input-group-addon">Đến</span>
                        <asp:TextBox ID="dtDenNgay" runat="server" CssClass="form-control" Width="140px"/>
                    </div>
                </div>
                <div class="dropdown">
                    <asp:DropDownList ID="cbxTruSo" runat="server" CssClass="form-control" Width="316px" DataValueField="maTruSo" DataTextField="tenTruSo"></asp:DropDownList>
                </div>
                <div class="dropdown control-inline">
                    <asp:DropDownList ID="cbxChiNhanh" runat="server" CssClass="form-control" Width="316px" DataValueField="maChiNhanh" DataTextField="tenChiNhanh"></asp:DropDownList>
                </div>
                <div class="control-inline">
                    <asp:Button ID="btnSearch" runat="server" Text="Xem Báo Cáo" CssClass="btn btn-default search-btn" OnClick="btnSearch_Click" />
                </div>
            </div>
        </div>
    </div>

    <div class="row">
        <div class="col-md-12">
            <h3>Báo Cáo Giao Dịch</h3>
            <asp:GridView ID="gvBaoCaoGiaoDich" runat="server" AutoGenerateColumns="false" AllowPaging="true" PageSize="4" 
                Width="100%" CssClass="table table-bordered" RowStyle-CssClass="grid-row" AlternatingRowStyle-BackColor="White"
                OnPageIndexChanging="gvBaoCaoGiaoDich_PageIndexChanging" OnRowDataBound="gvBaoCaoGiaoDich_RowDataBound">
                <PagerSettings Mode="Numeric" />  
                <PagerStyle CssClass="pagination-ys"/>            
                <Columns>
                    <asp:BoundField DataField="ngayGiaoDich" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Ngày Giao Dịch" />
                    <asp:BoundField DataField="tenTruSo" HeaderText="Trụ Sở" />
                    <asp:BoundField DataField="tenChiNhanh" HeaderText="Chi Nhánh" />
                    <asp:BoundField DataField="slGDRutTien" HeaderText="Số Lượng Rút Tiền" ItemStyle-HorizontalAlign="Right" />
                    <asp:BoundField DataField="soTienGDRutTien" DataFormatString="{0:0,00 VND}" HeaderText="Số Tiền Đã Rút" />
                    <asp:BoundField DataField="slGDGuiTien" HeaderText="Số Lượng Gửi Tiền" ItemStyle-HorizontalAlign="Right" />
                    <asp:BoundField DataField="soTienGDGuiTien" DataFormatString="{0:0,00 VND}" HeaderText="Số Tiền Đã Gửi" />
                    <asp:BoundField DataField="slGDChuyenTien" HeaderText="Số Lượng Chuyển Tiền" ItemStyle-HorizontalAlign="Right" />
                    <asp:BoundField DataField="soTienGDChuyenTien" DataFormatString="{0:0,00 VND}" HeaderText="Số Tiền Đã Chuyển" />
                </Columns>
            </asp:GridView>
        </div>
    </div>

    <script type="text/javascript">
        $('#dtNgayGiaoDich .input-daterange').datepicker({
            autoclose: true,
            endDate: "-1d",
            format: "dd/mm/yyyy"
        });
    </script>
</asp:Content>
