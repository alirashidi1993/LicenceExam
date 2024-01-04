using LicenceExam.Repositories;
using System;

namespace LicenceExam.Components
{
    public partial class CreateExam : System.Web.UI.UserControl
    {
        ExamRepository repository;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack == false)
            {
                if (Request.QueryString["view"] != null)
                {
                    string viewMode = Request.QueryString["view"];
                    if (viewMode == "create")
                    {
                        lbl_title.Text = "ایجاد آزمون جدید";
                    }
                    else if (viewMode == "edit")
                    {
                        lbl_title.Text = "ویرایش آزمون";
                    }
                }
                repository = new ExamRepository();
                if (Request.QueryString["examId"] != null)
                {
                    long examId = Convert.ToInt64(Request.QueryString["examId"]);
                    if (examId != 0)
                    {
                        Database.Exam azmoon = repository.GetById(examId);
                        if (azmoon == null)
                        {
                            //آزمون یافت نشد
                        }
                        else
                        {
                            txt_title.Value = azmoon.Title;

                            date_start.Value = azmoon.StartDate.ToString("yyyy-MM-dd");

                            date_end.Value = azmoon.EndDate.ToString("yyyy-MM-dd");
                        }
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string viewMode = Request.QueryString["view"];

                div_exception.Visible = false;
                ExamRepository examRepository = new ExamRepository();
                if (viewMode == "create")
                {
                    examRepository
                    .CreateExam(txt_title.Value, date_start.Value, date_end.Value);
                }
                else if (viewMode == "edit")
                {
                    if (Request.QueryString["examId"] != null)
                    {
                        long id = Convert.ToInt64(Request.QueryString["examId"]);
                        examRepository
                            .UpdateExam(id, txt_title.Value, date_start.Value, date_end.Value);
                    }
                    else
                    {
                        throw new ApplicationException("شناسه ی آزمون نامعتبر است");
                    }
                }
                Response.Redirect("Exam.aspx?view=manage");
            }
            catch (Exception ex)
            {
                lbl_exception_message.Text = ex.Message;
                div_exception.Visible = true;
            }
        }
    }
}