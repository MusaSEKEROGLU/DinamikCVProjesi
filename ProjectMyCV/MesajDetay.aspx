<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="MesajDetay.aspx.cs" Inherits="ProjectMyCV.MesajDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3 style="color: darkblue; margin-left: 20px; font-weight: bolder">Gelen Mesaj Detayı</h3>
    <br />
    <div style="margin-left: 20px;">
        <asp:Label CssClass="form-control" ID="lblAdSoyad" runat="server" Text="Ad Soyad"></asp:Label>
        <asp:TextBox CssClass="form-control" ID="txtAdSoyad" runat="server"></asp:TextBox>
        <br />
        <asp:Label CssClass="form-control" ID="lblEmail" runat="server" Text="Email"></asp:Label>
        <asp:TextBox CssClass="form-control" ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        <asp:Label CssClass="form-control" ID="lblKonu" runat="server" Text="Mesaj Konusu"></asp:Label>
        <asp:TextBox CssClass="form-control" ID="txtKonu" runat="server"></asp:TextBox>
        <br />
        <asp:Label CssClass="form-control" ID="lblMesaj" runat="server" Text="Mesaj İçeriği"></asp:Label>
        <asp:TextBox TextMode="MultiLine" CssClass="form-control" ID="txtMesaj" runat="server" Height="100px"></asp:TextBox>
        <br />
        <asp:Button ID="btnGeri" runat="server" Text="Geri" CssClass="btn btn-info" OnClick="btnGeri_Click"/>
    </div>
</asp:Content>
