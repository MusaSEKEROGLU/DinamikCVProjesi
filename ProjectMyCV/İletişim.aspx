<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="İletişim.aspx.cs" Inherits="ProjectMyCV.İletişim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h3 style="color: darkblue; margin-left: 20px; font-weight: bolder">Gelen Mesajlar</h3>
    <table class="table table-bordered" style="margin-left: 20px; margin-right: 20px;">
        <tr>
            <th>Ad Soyad</th>
            <th>Email</th>
            <th>Konu</th>
            <th>Mesajı Gör</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("AdSoyad") %></td>
                    <td><%# Eval("Email") %></td>
                    <td><%# Eval("Konu") %></td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server"
                            NavigateUrl='<%# "MesajDetay.aspx?Id=" + Eval("Id")%>' CssClass="btn btn-info" BackColor="#CC0066" ForeColor="Black">
                        Mesajı Gör
                        </asp:HyperLink>
                    </td>                  
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</asp:Content>
