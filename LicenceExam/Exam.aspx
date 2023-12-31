<%@ Page MasterPageFile="~/template.Master" Language="C#" AutoEventWireup="true" CodeBehind="Exam.aspx.cs" Inherits="LicenceExam.Exam" %>

<%@ Register TagPrefix="exam" TagName="Create" Src="~/Components/CreateExam.ascx" %>
<asp:Content runat="server" ID="content1" ContentPlaceHolderID="ContentPlaceHolder1">
    <exam:Create runat="server" ID="create_exam" />
</asp:Content>
