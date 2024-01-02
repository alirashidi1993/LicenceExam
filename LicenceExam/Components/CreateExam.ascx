<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CreateExam.ascx.cs" Inherits="LicenceExam.Components.CreateExam" %>
<div class="create-exam">
    <div class="create-exam-content col-md-6 mx-auto">
        <div class="create-exam-title">
            ایجاد آزمون جدید
        </div>
        <div class="create-exam-form">
            <div class="row">
                <div class="col-md-12">
                    <div class="exam-input-group">
                        <label class="text-white">عنوان آزمون</label>
                        <input type="text" runat="server" id="txt_title"  />
                    </div>
                </div>
                <div class="col-md-12 mt-3">
                    <div class="exam-input-group">
                        <label class="text-white">تاریخ شروع</label>
                        <input type="date" class="date-input" runat="server" id="date_start" />
                    </div>
                </div>
                <div class="col-md-12 mt-3">
                    <div class="exam-input-group">
                        <label class="text-white">تاریخ اتمام</label>
                        <input type="date" class="date-input" runat="server" id="date_end" />
                    </div>
                </div>
            </div>
            <div class="row mt-3" runat="server" visible="false" id="div_exception">
                <div class="col-md-12">
                    <div class="alert alert-warning">
                        <asp:Label ID="lbl_exception_message" runat="server" Text=""></asp:Label>
                    </div>
                </div>
            </div>
            <div class="action-buttons">
                <asp:Button CssClass="btn btn-primary" ID="Button1" runat="server" Text="ثبت" OnClick="Button1_Click" />
                <a class="btn btn-danger" href="../Exam.aspx?view=manage">بازگشت</a>
            </div>
        </div>
    </div>
</div>
