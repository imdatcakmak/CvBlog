<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="BilgiGuncelle.aspx.cs" Inherits="CvEntityProje.BilgiGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4>Bilgi Güncelleme Sayfası</h4>
<br />
    <asp:TextBox ID="TxtBilgiler" runat="server" CssClass="form-control" TextMode="MultiLine" ></asp:TextBox>
    <br />
    <asp:TextBox ID="TxtEgitim" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
    <br />
    <asp:TextBox ID="TxtIsDeneyimleri" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-primary" OnClick="Button1_Click" />
</asp:Content>
