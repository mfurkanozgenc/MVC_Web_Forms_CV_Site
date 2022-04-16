<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Yeteneklerim.aspx.cs" Inherits="CvProje.Hakkimda" %>

<%@ Register Assembly="DevExpress.Web.v20.1, Version=20.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-bordered" style="margin-left: 20px; margin-right: 20px">
        <tr>
            <th>ID</th>
            <th>YETENEK</th>
            <th>SİL</th>
            <th>GÜNCELLE</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("ID") %></td>
                    <td><%# Eval("YETENEK") %></td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server"
                            NavigateUrl='<%# "YetenekSil.aspx?ID="+Eval("ID") %>' CssClass="btn btn-danger">SİL</asp:HyperLink>
                    </td>
                    <td>
                        <asp:HyperLink ID="HyperLink2" runat="server"
                            NavigateUrl='<%# "YetenekGuncelle.aspx?ID="+Eval("ID") %>' CssClass="btn btn-warning">GÜNCELLE</asp:HyperLink>
                    </td>

                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <a href="YeniYetenek.aspx" class="btn btn-success" style="margin-left: 20px">YENİ YETENEK EKLE</a>
</asp:Content>
