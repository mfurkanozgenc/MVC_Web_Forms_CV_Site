﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YeniYetenek.aspx.cs" Inherits="CvProje.YeniYetenek" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>YENİ YETENEK EKLEME SAYFASI</h2>
    <br />
    <%--<asp:Label ID="Label1" runat="server" Text="Yetenek Açıklama : "></asp:Label>--%>
    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Yetenek Açıklama"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass="btn btn-success" OnClick="Button1_Click" />
</asp:Content>
