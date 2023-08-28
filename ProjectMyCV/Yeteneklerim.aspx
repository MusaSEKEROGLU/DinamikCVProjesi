<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Yeteneklerim.aspx.cs" Inherits="ProjectMyCV.Hakkımda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3 style="color: darkblue; margin-left: 20px; font-weight: bolder">Yeteneklerim</h3>
    <table class="table table-bordered" style="margin-left: 20px; margin-right: 20px;">
        <tr>          
            <th>Yetenekler</th>
            <th>Güncelle</th>
            <th>Sil</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>            
                    <td><%# Eval("Yetenek") %></td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server"
                            NavigateUrl='<%# "YetenekGüncelle.aspx?Id=" + Eval("Id")%>' CssClass="btn btn-warning">
                        Güncelle
                        </asp:HyperLink>
                    </td>

                    <td>
                        <asp:HyperLink ID="HyperLink2" runat="server"
                            NavigateUrl='<%# "YetenekSil.aspx?Id="+ Eval("Id")%>' CssClass="btn btn-danger">
                        Sil
                        </asp:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <a class="btn btn-primary" href="YeniYetenek.aspx" style="margin-left: 20px;">Yeni Yetenek Ekle</a>
</asp:Content>
