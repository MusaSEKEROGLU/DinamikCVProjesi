<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="İstatistik.aspx.cs" Inherits="ProjectMyCV.İstatistik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="web2/css/style.css" rel="stylesheet" />
    <link href="web2/css/jqvmap.css" rel="stylesheet" />
    <script src="web2/js/Chart1.js"></script>
    <script src="web2/js/jquery.min.js"></script>
    <script src="web2/js/jquery.vmap.js"></script>
    <script src="web2/js/jquery.vmap.sampledata.js"></script>
    <script src="web2/js/jquery.vmap.world.js"></script>
    <script type="text/javascript">
    jQuery(document).ready(function () {
        jQuery('#vmap').vectorMap({
            map: 'world_en',
            backgroundColor: '#333333',
            color: '#ffffff',
            hoverOpacity: 0.7,
            selectedColor: '#666666',
            enableZoom: true,
            showTooltip: true,
            values: sample_data,
            scaleColors: ['#C8EEFF', '#006491'],
            normalizeFunction: 'polynomial'
        });
    });
    </script>
    <script>
    $(document).ready(function (c) {
        $('.alert-close6').on('click', function (c) {
            $('.world-map').fadeOut('slow', function (c) {
                $('.world-map').remove();
            });
        });
    });
    </script>
    <div class="list_of_members">
        <div class="sales">
            <div class="icon">
                <i class="dollar"></i>
            </div>
            <div class="icon-text">
                <h3>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </h3>
                <p>Toplam Yetenek</p>
            </div>
            <div class="clearfix"></div>
        </div>
        <div class="new-users">
            <div class="icon">
                <i class="user1"></i>
            </div>
            <div class="icon-text">
                <h3>
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </h3>
                <p>Gelen Mesaj</p>
            </div>
            <div class="clearfix"></div>
        </div>
        <div class="orders">
            <div class="icon">
                <i class="order"></i>
            </div>
            <div class="icon-text">
                <h3>
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                </h3>
                <p>Yetenek Puanı(ortalama)</p>
            </div>
            <div class="clearfix"></div>
        </div>
        <div class="visitors">
            <div class="icon">
                <i class="visit"></i>
            </div>
            <div class="icon-text">
                <h3>
                    <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                </h3>
                <p>En Yüksek Yetenek Derecesi</p>
            </div>
            <div class="clearfix"></div>
        </div>
        <div class="clearfix"></div>
    </div>    
</asp:Content>
