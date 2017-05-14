<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageOne.Master" AutoEventWireup="true" CodeBehind="BaoCaoTKGiaoDich.aspx.cs" Inherits="BankManagement.UI.BaoCaoTKGiaoDich" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="assets/js/bootstrap-datepicker-1.6.4-dist/css/bootstrap-datepicker3.min.css" rel="stylesheet" />
    <script src="assets/js/bootstrap-datepicker-1.6.4-dist/js/bootstrap-datepicker.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContainer" runat="server">
    <div class="row">
        <div class="col-md-6 text-right">
            <div>
                <label>Ngày Giao Dịch</label>
            </div>
            <div>
                <label>Trụ Sở</label>
            </div>
            <div>
                <label>Chi Nhánh</label>
            </div>
            <div>
                <label>Loại Giao Dịch</label>
            </div>
        </div>
        <div class="col-md-6">
            <div id="dtNgayGiaoDich">
                <div class="input-group input-daterange">
                    <input type="text" class="form-control" id="dtTuNgay" /><span class="input-group-addon">Đến</span>
                    <input type="text" class="form-control" id="dtDenNgay" />
                </div>
                
            </div>
            <div>
                <asp:DropDownList ID="cbxTruSo" runat="server"></asp:DropDownList>
            </div>
            <div>
                <asp:DropDownList ID="cbxChiNhanh" runat="server"></asp:DropDownList>
            </div>
            <div>
                <asp:DropDownList ID="cbxLoaiGD" runat="server"></asp:DropDownList>
            </div>
        </div>
    </div>

    <div class="row">
        <div class="col-md-12">
            <h3>Báo Cáo Giao Dịch</h3>
            <asp:GridView ID="gvBaoCaoGiaoDich" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="ngayGiaoDich" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Ngày Giao Dịch" />
                    <asp:BoundField DataField="maChiNhanh" HeaderText="Chi Nhánh" />
                    <asp:BoundField DataField="maTruSo" HeaderText="Trụ Sở" />
                    <asp:BoundField DataField="slGDRutTien" HeaderText="Số Lượng Rút Tiền" />
                    <asp:BoundField DataField="soTienGDRutTien" DataFormatString="{0:0,00 VND}" HeaderText="Số Tiền Đã Rút" />
                    <asp:BoundField DataField="slGDGuiTien" HeaderText="Số Lượng Gửi Tiền" />
                    <asp:BoundField DataField="soTienGDGuiTien" DataFormatString="{0:0,00 VND}" HeaderText="Số Tiền Đã Gửi" />
                    <asp:BoundField DataField="slGDChuyenTien" HeaderText="Số Lượng Chuyển Tiền" />
                    <asp:BoundField DataField="soTienGDChuyenTien" DataFormatString="{0:0,00 VND}" HeaderText="Số Tiền Đã Chuyển" />
                </Columns>
            </asp:GridView>
        </div>
    </div>

    <script type="text/javascript">
        $('#dtNgayGiaoDich .input-daterange').datepicker({
            autoclose: true,
            endDate: "-1d"
        });
    </script>
</asp:Content>
