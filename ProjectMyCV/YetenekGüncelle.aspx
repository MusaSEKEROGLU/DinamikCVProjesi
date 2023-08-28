<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YetenekGüncelle.aspx.cs" Inherits="ProjectMyCV.YetenekGüncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h3 style="color: darkblue; margin-left: 20px; font-weight: bolder">Yetenek Güncelleme İşlemleri</h3>
    <br />
    <div style="margin-left: 20px;">
        <asp:Label CssClass="form-control" ID="lblAciklama" runat="server" Text="Yetenek Açıklması"></asp:Label>
        <asp:TextBox CssClass="form-control" ID="txtYetenekAd" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnGuncelle" runat="server" Text="Güncelle" CssClass="btn btn-success" OnClick="btnGuncelle_Click"/>
        <asp:Button ID="btnVazgec" runat="server" Text="Vazgeç" CssClass="btn btn-primary" OnClick="btnVazgec_Click" />
    </div>

</asp:Content>
