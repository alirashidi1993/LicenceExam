using LicenceExam.Repositories;
using System;

namespace LicenceExam.Components
{
    public partial class CreateExam : System.Web.UI.UserControl
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                div_exception.Visible = false;
                ExamRepository examRepository = new ExamRepository();
                examRepository
                    .CreateExam(txt_title.Value, date_start.Value, date_end.Value);
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