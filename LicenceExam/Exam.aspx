<%@ Page MasterPageFile="~/template.Master" Language="C#" AutoEventWireup="true" CodeBehind="Exam.aspx.cs" Inherits="LicenceExam.Exam" %>

<%@ Register TagPrefix="exam" TagName="Create" Src="~/Components/CreateExam.ascx" %>
<%@ Register TagPrefix="exam" TagName="GridView" Src="~/Components/GridExam.ascx" %>

<asp:Content runat="server" ID="content1" ContentPlaceHolderID="ContentPlaceHolder1">
    <%if (targetView == "manage")
        {  %>
    <exam:GridView runat="server" ID="ExamGridView" />
    <%}
        else if (targetView == "create" || targetView == "edit")
        { %>
    <exam:Create runat="server" ID="ExamCreateView" />
    <%} %>
</asp:Content>
