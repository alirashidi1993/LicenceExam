<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GridQuestion.ascx.cs" Inherits="LicenceExam.Components.GridQuestion" %>
<div class="card m-4">
    <div class="card-header">
        مدیریت سوالات
    </div>
    <div class="card-body">
        <div class="search-box">
            <div class="input-group">
                <asp:Button ID="Button1" CssClass="input-group-text bg-primary text-white" runat="server" Text="جستجو" OnClick="Button1_Click" />
                <input type="text" runat="server" id="txt_search" class="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-default">
            </div>
            <a href="../Exam.aspx?view=create" class="btn btn-success btn-create">
                <i class="fa fa-plus"></i>
                ایجاد سوال جدید
            </a>
        </div>
        <div class="question-grid">
            <asp:GridView ID="GridView1" runat="server">

            </asp:GridView>
        </div>
    </div>
</div>
