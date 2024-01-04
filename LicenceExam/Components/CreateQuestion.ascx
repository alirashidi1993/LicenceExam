<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CreateQuestion.ascx.cs" Inherits="LicenceExam.Components.CreateQuestion" %>
<div class="create-question w-50 mx-auto">
    <div class="card m-4">
        <div class="card-header">
            <asp:Label ID="lbl_title" runat="server" Text="افزودن سوال جدید"></asp:Label>
        </div>
        <div class="card-body">
            <div class="row">
                <div class="col-md-6">
                    <div class="question-input-group">
                        <label>متن سوال</label>
                        <textarea rows="1" runat="server" id="txt_question_text" class="form-control"></textarea>
                    </div>
                </div>
                <div class="col-md-6">
                    <label>تصویر سوال</label>
                    <asp:FileUpload ID="FileUpload1" CssClass="form-control" runat="server" />
                </div>
            </div>
            <hr />
            <div class="row">

            </div>
        </div>
    </div>
</div>
