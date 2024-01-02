<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GridExam.ascx.cs" Inherits="LicenceExam.Components.GridExam" %>
<div class="exam-grid-view m-4">
    <div class="card">
        <div class="card-header">
            مدیریت آزمون ها
        </div>
        <div class="card-body">
            <div class="search-box">
                <div class="input-group">
                    <asp:Button ID="Button1" CssClass="input-group-text bg-primary text-white" runat="server" Text="جستجو" OnClick="Button1_Click" />
                    <input type="text" runat="server" id="txt_search" class="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-default">
                </div>
                <a href="../Exam.aspx?view=create" class="btn btn-success btn-create">
                    <i class="fa fa-plus"></i>
                    ایجاد آزمون جدید
                </a>
            </div>
            <asp:GridView ID="grid_exams" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered table-striped w-100 grid-table mt-4" EmptyDataText="هیچ آزمونی یافت نشد" DataKeyNames="Id" OnRowDeleting="grid_exams_RowDeleting">
                <Columns>
                    <asp:BoundField DataField="Id" Visible="False" />
                    <asp:BoundField DataField="Title" HeaderText="عنوان" />

                    <asp:TemplateField HeaderText="تاریخ شروع">
                        <ItemTemplate>
                            <span><%# ConvertToShamsi(Eval("StartDate").ToString()) %></span>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="تاریخ پایان">
                        <ItemTemplate>
                            <span><%# ConvertToShamsi(Eval("EndDate").ToString()) %></span>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="وضیعت">
                        <ItemTemplate>

                            <span>
                                <%#
                                    GetStatus(Eval("Status").ToString())
                                %>
                            </span>

                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField ButtonType="Image" CancelText="" EditText="" HeaderText="ویرایش" ShowEditButton="True" UpdateText="" CancelImageUrl="~/Media/Images/cancel.png" DeleteImageUrl="~/Media/Images/delete.png" EditImageUrl="~/Media/Images/edit.png" UpdateImageUrl="~/Media/Images/save.png">
                        <ControlStyle Height="48px" Width="48px" />
                    </asp:CommandField>
                    <asp:CommandField ButtonType="Image" HeaderText="حذف" ShowDeleteButton="True" DeleteImageUrl="~/Media/Images/delete.png">
                        <ControlStyle Height="48px" Width="48px" />
                    </asp:CommandField>
                </Columns>
            </asp:GridView>
        </div>
    </div>

</div>
