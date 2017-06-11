<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangNhap.aspx.cs" Inherits="BankManagement.UI.DangNhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="assets/js/bootstrap-3.3.4-dist/css/bootstrap.min.css" rel="stylesheet" />
    <link href="assets/css/master.css" rel="stylesheet" />
</head>
<body style="background-color: #263238">
    <form id="form1" runat="server">
        <div class="row">
            <div class="col-md-12 text-center">
                <div class="login-panel">
                    <div class="login-content">
                        <label>TÊN ĐĂNG NHẬP:</label>
                        <asp:TextBox ID="txtUserName" runat="server" CssClass="form-control"></asp:TextBox>
                        <label style="margin-top: 10px;">MẬT KHẨU:</label>
                        <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                        <div style="height: 35px; color: red; padding-top: 5px;">
                            <asp:Label ID="lblError" runat="server" Visible="false" Text="Tên Đăng Nhập hoặc Mật Khẩu không đúng."></asp:Label>
                        </div>
                        <div class="control-inline">
                            <a href="#">Quên Mật Khẩu?</a>
                        </div>
                        <div class="control-inline text-right" style="width: 278px">
                            <asp:Button ID="btnLogin" runat="server" Text="Đăng Nhập" CssClass="btn btn-default" OnClick="btnLogin_Click" />
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </form>
</body>
</html>
