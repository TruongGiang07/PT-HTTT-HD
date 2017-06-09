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
                    <asp:RadioButtonList ID="rdLoaiNgay" runat="server" CssClass="radio-list" RepeatDirection="Horizontal" RepeatLayout="Flow">
                        <asp:ListItem Text="Ngày" Value="Ngay" Selected="True" onclick="onRadioLoaiNgayClick(this);"></asp:ListItem>
                        <asp:ListItem Text="Tháng" Value="Thang" onclick="onRadioLoaiNgayClick(this);"></asp:ListItem>
                        <asp:ListItem Text="Năm" Value="Nam" onclick="onRadioLoaiNgayClick(this);"></asp:ListItem>
                    </asp:RadioButtonList>

                </div>
                <div>
                    <label>Trụ Sở</label>
                </div>
                <div>
                    <label>Chi Nhánh</label>
                </div>
            </div>
            <div class="filter-right">
                <div id="dtNgayGiaoDich" runat="server">
                    <div class="input-group input-daterange">
                        <asp:TextBox ID="dtTuNgay" runat="server" CssClass="form-control" Width="140px" /><span class="input-group-addon">Đến</span>
                        <asp:TextBox ID="dtDenNgay" runat="server" CssClass="form-control" Width="140px" />
                    </div>
                </div>
                <div id="dtThang" style="display:none" runat="server">
                    <asp:TextBox ID="dtThangOrNam" runat="server" CssClass="form-control" Width="140px" />
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

    <asp:Panel ID="chartContainer" runat="server" CssClass="row">
        <div class="col-md-2"></div>
        <div class="col-md-4">
            <canvas id="chartSL" width="200" height="200"></canvas>
        </div>
        <div class="col-md-4">
            <canvas id="chartSoTien" width="200" height="200"></canvas>
        </div>
        <div class="col-md-2"></div>
    </asp:Panel>

    <div class="row">
        <div class="col-md-12">
            <h3>Báo Cáo Giao Dịch</h3>
            <asp:GridView ID="gvBaoCaoGiaoDich" runat="server" AutoGenerateColumns="false" AllowPaging="true" PageSize="6"
                Width="100%" CssClass="table table-bordered" RowStyle-CssClass="grid-row" AlternatingRowStyle-BackColor="White"
                OnPageIndexChanging="gvBaoCaoGiaoDich_PageIndexChanging" OnRowDataBound="gvBaoCaoGiaoDich_RowDataBound">
                <PagerSettings Mode="Numeric" />
                <PagerStyle CssClass="pagination-ys" />
                <EmptyDataTemplate>
                    <label>Không có dữ liệu để hiển thị</label>
                </EmptyDataTemplate>
                <Columns>
                    <asp:BoundField DataField="ngayGiaoDich" ItemStyle-HorizontalAlign="Center" HeaderText="Ngày Giao Dịch" />
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
        $('#BodyContainer_dtNgayGiaoDich .input-daterange').datepicker({
            autoclose: true,
            endDate: "-1d",
            format: "dd/mm/yyyy"
        });

        $('#BodyContainer_dtThang input').datepicker({
            autoclose: true,
            endDate: "-1d",
            format: "dd/mm/yyyy"
        });

        function onRadioLoaiNgayClick(rd) {
            if ($(rd).val() != "Ngay") {
                $("#BodyContainer_dtThang").show();
                $("#BodyContainer_dtNgayGiaoDich").hide();
            }
            else {
                $("#BodyContainer_dtNgayGiaoDich").show();
                $("#BodyContainer_dtThang").hide();
            }
            return false;
        }

        function drawChart(filter) {
            $.ajax({
                type: "POST",
                url: "http://localhost:8080/api/tongketgd/getTotalByFilter",
                data: filter,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: OnSuccess,
                error: OnErrorCall
            });

            function OnSuccess(response) {                
                var arrDataQuantity = [response.sumSLGDRutTien, response.sumSLGDGuiTien, response.sumSLGDChuyenTien];
                var arrDataAmount = [response.sumSoTienGDRutTien, response.sumSoTienGDGuiTien, response.sumSoTienGDChuyenTien];
                
                var config = {
                    type: 'pie',
                    data: {
                        datasets: [{
                            data: arrDataQuantity,
                            backgroundColor: [
                                '#ff6384',
                                '#36a2eb',
                                '#ffce56'
                            ]                            
                        }],
                        labels: [
                            "Rút Tiền",
                            "Gửi Tiền",
                            "Chuyển Tiền"
                        ]
                    },
                    options: {
                        maintainAspectRatio: false,
                        legend: {
                            display: true,
                            position: 'bottom'
                        },
                        title: {
                            display: true,
                            text: 'Số Lượng Giao Dịch',
                            fontSize: 14
                        }
                    }
                };

                var config2 = {
                    type: 'pie',
                    data: {
                        datasets: [{
                            data: arrDataAmount,
                            backgroundColor: [
                                '#ff6384',
                                '#36a2eb',
                                '#ffce56'
                            ]
                        }],
                        labels: [
                            "Rút Tiền",
                            "Gửi Tiền",
                            "Chuyển Tiền"
                        ]
                    },
                    options: {
                        maintainAspectRatio: false,
                        legend: {
                            display: true,
                            position: 'bottom'
                        },
                        title: {
                            display: true,
                            text: 'Số Tiền Giao Dịch',
                            fontSize: 14
                        },
                        tooltips: {
                            mode: 'label',
                            callbacks: {
                                label: function (tooltipItem, data) {
                                    var allData = data.datasets[tooltipItem.datasetIndex].data;
                                    var tooltipLabel = data.labels[tooltipItem.index];
                                    var tooltipData = allData[tooltipItem.index];
                                    return tooltipLabel + ": " + tooltipData.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",") + " VND";
                                },
                            },

                        }
                    }
                };

                var ctx = $("#chartSL").get(0).getContext("2d");
                var ctx2 = $("#chartSoTien").get(0).getContext("2d");
                var PieChartSL = new Chart(ctx, config);
                var PieChartSoTien = new Chart(ctx2, config2);
            }

            function OnErrorCall(response) {
                console.log(response);
            }
        }
    </script>
</asp:Content>
