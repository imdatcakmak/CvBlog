<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Deneyim.aspx.cs" Inherits="CvEntityProje.Deneyim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
		<table class="table table-bordered" >
        <tr>
            <th>ID</th>
            <th>BİLGİLER</th>
            <th>EĞİTİM</th>
            <th>İŞ DENEYİMLERİ</th>
            <th>GÜNCELLE</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("ID") %></td>
                    <td><%#Eval("Bilgiler")%></td>
                    <td><%#Eval("Egitim")%></td>
                    <td><%#Eval("IsDeneyimleri")%></td>
             <td><asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# "BilgiGuncelle.aspx?ID=" + Eval("ID") %>' CssClass="btn btn-success">Güncelle</asp:HyperLink></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
            </table>
</asp:Content>
