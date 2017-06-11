<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageOne.Master" AutoEventWireup="true" CodeBehind="SoTietKiem.aspx.cs" Inherits="BankManagement.UI.SoTietKiems" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContainer" runat="server">
    <div class="row">
        <div class="col-md-12">
            <h3>Danh Sách Sổ Tiết Kiệm</h3>
            <asp:GridView ID="gvSoTietKiem" runat="server" AutoGenerateColumns="false" AllowPaging="true" PageSize="6"
                Width="100%" CssClass="table table-bordered" RowStyle-CssClass="grid-row" AlternatingRowStyle-BackColor="White"
                OnPageIndexChanging="gvSoTietKiem_PageIndexChanging" OnRowDataBound="gvSoTietKiem_RowDataBound">
                <PagerSettings Mode="Numeric" />
                <PagerStyle CssClass="pagination-ys" />
                <EmptyDataTemplate>
                    <label>Không có dữ liệu để hiển thị</label>
                </EmptyDataTemplate>
                <Columns>
                    <asp:BoundField DataField="MaSoTietKiem" ItemStyle-HorizontalAlign="Center" HeaderText="Mã STK" />
                    <asp:BoundField DataField="SoTienGui" HeaderText="Số Tiền Gửi" DataFormatString="{0:0,00 VND}" ItemStyle-HorizontalAlign="Right"/>
                    <asp:BoundField DataField="NgayGui" HeaderText="Ngày Gửi" DataFormatString="{0:dd/MM/yyyy}" ItemStyle-HorizontalAlign="Center" />
                    <asp:BoundField DataField="NgayDaoHan" HeaderText="Ngày Đáo Hạn" DataFormatString="{0:dd/MM/yyyy}" ItemStyle-HorizontalAlign="Center"/>
                    <asp:BoundField DataField="KyHan" HeaderText="Kỳ Hạn" DataFormatString="{0} tháng" />
                    <asp:BoundField DataField="LaiSuat" HeaderText="Lãi Suất" DataFormatString="{0} %" />
                    <asp:BoundField DataField="HoTen" HeaderText="Khách Hàng Gửi" />
                    <asp:BoundField DataField="" HeaderText="" ItemStyle-HorizontalAlign="Center"/>
                </Columns>
            </asp:GridView>
        </div>
    </div>

    <div class="row">
        <div class="col-md-12">
            <a onclick="openPopupModal('LapSTK.aspx');" class="btn btn-default">Lập Sổ Tiết Kiệm</a>
        </div>
    </div>

    <asp:Button ID="btnHuySo" runat="server" CssClass="hide" OnClick="btnHuySo_Click" />
    <asp:HiddenField ID="hddMaSTKHuy" runat="server" />

    <script type="text/javascript">
        function huySo(id) {
            var decision = confirm("Ban co chac chan muon Huy So Tiet Kiem nay!");
            if (decision == true) {
                $('[id$=hddMaSTKHuy]').val(id);
                $('[id$=btnHuySo]').click();
            }
        }
        
    </script>
</asp:Content>
