<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/template.Master" CodeBehind="ManageQuestions.aspx.cs" Inherits="LicenceExam.ManageQuestions" %>
<%@ Register TagPrefix="question" TagName="GridView" Src="~/Components/GridQuestion.ascx" %>
<%@ Register TagPrefix="question" TagName="Create" Src="~/Components/CreateQuestion.ascx" %>

<asp:Content runat="server" ID="content1" ContentPlaceHolderID="ContentPlaceHolder1">
    <div class="manage-questions">
       <question:Create runat="server" id="c1">

       </question:Create>
    </div>
</asp:Content>
