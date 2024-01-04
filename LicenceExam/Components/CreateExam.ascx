<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CreateExam.ascx.cs" Inherits="LicenceExam.Components.CreateExam" %>
<div class="create-exam w-50 mx-auto mt-4">
    <div class="card">
        <div class="card-header">
            <asp:Label ID="lbl_title" runat="server" Text=""></asp:Label>
        </div>
        <div class="card-body">

            <div class="exam-input-group mb-3">
                <label>عنوان آزمون</label>
                <input type="text" id="txt_title" runat="server" class="form-control" />
                
            </div>
            <div class="exam-input-group mb-3">
                <label>تاریخ شروع</label>
                <input type="date" class="date-input form-control" runat="server" id="date_start" />
            </div>
            <div class="exam-input-group mb-3">
                <label>تاریخ اتمام</label>
                <input type="date" class="date-input form-control" runat="server" id="date_end" />
            </div>
            <div class="alert alert-warning" visible="false" runat="server" id="div_exception">
                <asp:Label ID="lbl_exception_message" runat="server" Text=""></asp:Label>
            </div>


            <div class="action-buttons">
                <asp:Button CssClass="btn btn-primary" ID="Button1" runat="server" Text="ثبت" OnClick="Button1_Click" />
                <a class="btn btn-danger" href="../Exam.aspx?view=manage">بازگشت</a>
            </div>
        </div>
    </div>
</div>

