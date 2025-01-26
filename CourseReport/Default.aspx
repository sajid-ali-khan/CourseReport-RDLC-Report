<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CourseReport._Default" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div style="padding: 15px">
        <div align="center" style="font-size: 30px;">Course Info</div>
        <br />
        <div align="center">
            <asp:Button ID="Button1" runat="server" Text="Load Course Details" Width="164px" OnClick="Button1_Click" BackColor="#FF66CC" />
            <br />
            <br />
            Branch: <asp:TextBox ID="et_branch" runat="server"></asp:TextBox>
&nbsp;Sem:
            <asp:TextBox ID="et_sem" runat="server"></asp:TextBox>
&nbsp;SubjectCode:
            <asp:TextBox ID="et_subjectCode" runat="server"></asp:TextBox>
            <br />
            <br />
        </div>
        <div align="center">
            <rsweb:ReportViewer align="center" ID="ReportViewer1" runat="server" Width="768px"></rsweb:ReportViewer>
        </div>
    </div>

</asp:Content>
