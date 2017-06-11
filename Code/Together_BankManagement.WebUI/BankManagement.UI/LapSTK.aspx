<%@ Page Title="Lập Sổ Tiết Kiệm" Language="C#" MasterPageFile="~/MasterPageModal.Master" AutoEventWireup="true" CodeBehind="LapSTK.aspx.cs" Inherits="BankManagement.UI.LapSTK" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <link href="assets/js/bootstrap-datepicker-1.6.4-dist/css/bootstrap-datepicker3.min.css" rel="stylesheet" />
    <script src="assets/js/bootstrap-datepicker-1.6.4-dist/js/bootstrap-datepicker.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-12 text-center">
            <div class="filter-left">                
                <div>
                    <label>Số Tiền Gửi:</label>
                </div>
                <div>
                    <label>Kỳ Hạn:</label>
                </div>
                <div>
                    <label>Lãi Suất:</label>
                </div>
                <div>
                    <label>CMND Khách Hàng Gửi:</label>
                </div>
                <div>
                    <label>Mã Khách Hàng Gửi:</label>
                </div>
                <div>
                    <label>Tên Khách Hàng Gửi:</label>
                </div>
            </div>
            <div class="filter-right">                
                <div>
                    <asp:TextBox ID="txtSoTienGui" runat="server" CssClass="form-control" Width="316px" />
                </div>
                <div>
                    <asp:TextBox ID="txtKyHan" runat="server" CssClass="form-control" Width="316px" />
                </div>
                <div>
                    <asp:TextBox ID="txtLaiSuat" runat="server" CssClass="form-control" Width="316px" />
                </div>
                <div>
                    <asp:TextBox ID="txtCMND" runat="server" CssClass="form-control" Width="316px" />
                </div>
                <div>
                    <asp:TextBox ID="txtMaKHGui" runat="server" CssClass="hide" Width="316px" />
                    <asp:TextBox ID="txtMaKHshow" runat="server" CssClass="form-control" Width="316px" Enabled="false" />
                </div>
                <div>
                    <asp:TextBox ID="txtHoten" runat="server" CssClass="form-control" Enabled="false" Width="316px" />
                </div>
                
                <div class="text-right">
                    <asp:Button ID="btnTaoSTK" runat="server" Text="Lập Sổ Tiết Kiệm" CssClass="btn btn-default" OnClick="btnTaoSTK_Click" />
                    <asp:Button ID="btnCancel" runat="server" Text="Hủy" CssClass="btn btn-default" OnClientClick="return parent.closePopupModal();" />
                </div>
            </div>
        </div>
    </div>

    <script type="text/javascript">

        $('[id$=txtCMND]').keypress(function (event) {
            var keycode = (event.keyCode ? event.keyCode : event.which);
            if (keycode == '32') {
                if ($('[id$=txtCMND]').val() == '') {
                    alert('Chua Nhap Chung Minh Nhan Dan');
                }
                else {
                    var req = $.ajax({
                        url: 'http://localhost:8080/api/kh/cmnd/' + $('[id$=txtCMND]').val(),
                        contentType: "application/json; charset=utf-8",
                        dataType: 'json',
                        timeout: 30 * 1000
                    });
                    req.done(function (data) {
                        $.each(data, function (index, kh) {
                            $("[id$=txtMaKHGui]").val(kh.maKhachHang);
                            $("[id$=txtMaKHshow]").val(kh.maKhachHang);
                            $("[id$=txtHoten]").val(kh.hoTen);
                        });

                    });
                    req.fail(function (jqXHR, textStatus, error) {
                        console.log(textStatus);
                        console.log(error);
                        console.log(jqXHR);
                    });
                }
            }
            event.stopPropagation();
        });
     </script>
</asp:Content>
