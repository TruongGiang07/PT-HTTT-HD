<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageOne.Master" AutoEventWireup="true" CodeBehind="ChuyenTien.aspx.cs" Inherits="BankManagement.UI.ChuyenTien" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="assets/js/bootstrap-datepicker-1.6.4-dist/css/bootstrap-datepicker3.min.css" rel="stylesheet" />
    <script src="assets/js/bootstrap-datepicker-1.6.4-dist/js/bootstrap-datepicker.min.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="BodyContainer" runat="server">

    <div class="row">
        <div class="col-md-12 text-center" style="height: 235px;">
            <div class="filter-left">
                <div>
                    <label>Mã Khách Hàng Chuyển:</label>
                </div>
                <div>
                    <label>CMND Khách Hàng Chuyển:</label>
                </div>
                <div>
                    <label>Số Tiền Chuyển:</label>
                </div>
                <div>
                    <label>Nội Dung:</label>
                </div>
            </div>
            <div class="filter-right">
                <div>
                    <asp:TextBox ID="txtmakhchuyen" runat="server" CssClass="form-control" Width="316px" Enabled="False" />
                    <asp:TextBox ID="txtMaKHChuyenThat" runat="server" CssClass="hide" Width="316px" />
                </div>
                <div>
                    <asp:TextBox ID="txtcmndchuyen" runat="server" CssClass="form-control" Width="316px" TextMode="Number" />
                </div>
                <div>
                    <asp:TextBox ID="txtsotienchuyen" runat="server" CssClass="form-control" Width="316px" TextMode="Number" />
                </div>
                <div>
                    <asp:TextBox ID="txtnoidung" runat="server" CssClass="form-control" Width="316px" Height="79px" TextMode="MultiLine" />
                </div>
            </div>
            <div class="filter-left">
                <div>
                    <label>Mã Khách Hàng Nhận:</label>
                </div>
                <div>
                    <label>CMND Khách Hàng Nhận:</label>
                </div>
                <div>
                    <label>Họ Tên:</label>
                </div>
            </div>
            <div class="filter-right">
                <div>
                    <asp:TextBox ID="txtmakhnhan" runat="server" CssClass="form-control" Width="316px" Enabled="False" />
                    <asp:TextBox ID="txtMaKHNhanThat" runat="server" CssClass="hide" Width="316px" />
                </div>
                <div>
                    <asp:TextBox ID="txtcmndnhan" runat="server" CssClass="form-control" Width="316px" TextMode="Number" />
                </div>
                <div>
                    <asp:TextBox ID="txthoten" runat="server" CssClass="form-control" Width="316px" Enabled="false" />
                </div>
                <div class="text-right">
                    <asp:Button ID="btnchuyentien" runat="server" Text="Chuyển Tiền" CssClass="btn btn-default" OnClick="btnchuyentien_Click" />
                </div>
            </div>

        </div>
    </div>

    <script type="text/javascript">
        $('[id$=txtcmndchuyen]').keypress(function (event) {

            var keycode = (event.keyCode ? event.keyCode : event.which);
            if (keycode == '32') {
                if ($('[id$=txtcmndchuyen]').val() == '') {
                    alert('Chua Nhap Chung Minh Nhan Dan');
                }
                else {
                    var req = $.ajax({
                        url: 'http://localhost:8080/api/kh/cmnd/' + $('[id$=txtcmndchuyen]').val(),
                        dataType: 'json',
                        timeout: 30 * 1000
                    });
                    req.done(function (data) {
                        //alert('Lấy Thông tin thành công');
                        //console.log(data);
                        $.each(data, function (index, kh) {
                            $("[id$=txtmakhchuyen]").val(kh.maKhachHang);
                            $("[id$=txtMaKHChuyenThat]").val(kh.maKhachHang);
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

        $('[id$=txtcmndnhan]').keypress(function (event) {

            var keycode = (event.keyCode ? event.keyCode : event.which);
            if (keycode == '32') {
                if ($('[id$=txtcmndnhan]').val() == '') {
                    alert('Chua Nhap Chung Minh Nhan Dan');
                }
                else {
                    var req = $.ajax({
                        url: 'http://localhost:8080/api/kh/cmnd/' + $('[id$=txtcmndnhan]').val(),
                        dataType: 'json',
                        timeout: 30 * 1000
                    });
                    req.done(function (data) {
                        //alert('Lấy Thông tin thành công');
                        //console.log(data);
                        $.each(data, function (index, kh) {
                            $("[id$=txtmakhnhan]").val(kh.maKhachHang);
                            $("[id$=txtMaKHNhanThat]").val(kh.maKhachHang);
                            $("[id$=txthoten]").val(kh.hoTen);
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
