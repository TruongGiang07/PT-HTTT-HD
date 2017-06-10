<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageOne.Master" AutoEventWireup="true" CodeBehind="RutGoiTien.aspx.cs" Inherits="BankManagement.UI.RutGoiTien" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="assets/js/bootstrap-datepicker-1.6.4-dist/css/bootstrap-datepicker3.min.css" rel="stylesheet" />
    <script src="assets/js/bootstrap-datepicker-1.6.4-dist/js/bootstrap-datepicker.min.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="BodyContainer" runat="server">

    <div class="row">
        <div class="col-md-12 text-center">
            <div class="filter-left">
                <div>
                    <b><asp:Label ID="maKhachHang" runat="server" Enabled="True"></asp:Label></b>
                </div>
                <div>
                   <b> <asp:Label ID="hoTen" runat="server"  Enabled="True"></asp:Label></b>
                </div>
                <div>
                    <b><asp:Label ID="cMND" runat="server"  Enabled="True"></asp:Label></b>
                </div>
                <div>
                  <b> <asp:Label ID="soTien" runat="server"  Enabled="True"></asp:Label></b>
                </div>
            </div>
            <div class="filter-right">
                <div>
                    <asp:TextBox ID="txtMaKhachHang" runat="server" CssClass="form-control" Width="316px" Enabled="False" /><asp:TextBox ID="txtMaKhachHangThiet" runat="server" CssClass="hide" Width="316px" />
                </div>
                <div>
                    <asp:TextBox ID="txtHoTenKhachHang" runat="server" CssClass="form-control" Width="316px" Enabled="false" />
                </div>
                <div>
                    <asp:TextBox ID="txtCMND" runat="server" CssClass="form-control" Width="316px" TextMode="Number" />
                </div>
                <div>
                    <asp:TextBox ID="txtSoTien" runat="server" CssClass="form-control" Width="316px" TextMode="Number" />
                </div>
                <div class="text-right">
                    <asp:Button ID="btnRutGoi" runat="server" Text="" CssClass="active" OnClick="btnRutGoi_Click" />
                </div>
            </div>
        </div>


        </div>
    

    <script type="text/javascript">

        $('.input-daterange').datepicker({
            autoclose: true,
            endDate: "-1d",
            format: "dd/mm/yyyy"
        });

      

        $('[id$=txtCMND]').keypress(function (event) {

            var keycode = (event.keyCode ? event.keyCode : event.which);
            if (keycode == '32') {
                if ($('[id$=txtCMND]').val() == '') {
                    alert('Chua Nhap Chung Minh Nhan Dan');
                }
                else {
                    var req = $.ajax({
                        url: 'http://localhost:8080/api/kh/cmnd/' + $('[id$=txtCMND]').val(),
                        dataType: 'json',
                        timeout: 30 * 1000
                    });
                    alert(req);
                    req.done(function (data) {
                        //alert('Lấy Thông tin thành công');
                        //console.log(data);
                        $.each(data, function (index, kh) {
                            $("[id$=txtMaKhachHang]").val(kh.maKhachHang);
                            $("[id$=txtHoTenKhachHang]").val(kh.hoTen);
                            $("[id$=txtMaKhachHangThiet]").val(kh.maKhachHang);
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

