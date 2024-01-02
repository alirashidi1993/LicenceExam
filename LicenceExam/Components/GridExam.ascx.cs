using LicenceExam.Models.Enums;
using LicenceExam.Models.Extensions;
using LicenceExam.Repositories;
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace LicenceExam.Components
{
    public partial class GridExam : System.Web.UI.UserControl
    {
        ExamRepository examRepository;
        protected void Page_Load(object sender, EventArgs e)
        {
            examRepository = new ExamRepository();
            if (Page.IsPostBack == false)
            {
                List<Database.Exam> azmunha = examRepository.GetExams();
                grid_exams.DataSource = azmunha;
                grid_exams.DataBind();
            }
        }
        public string ConvertToShamsi(string miladi)
        {
            DateTime miladiDate = Convert.ToDateTime(miladi);
            return miladiDate.ToPersianDate();
        }
        public string GetStatus(string status)
        {
            int s = Convert.ToInt32(status);

            if (s == (int)ExamStatus.Active)
            {
                return "فعال";
            }
            else if (s == (int)ExamStatus.InActive)
            {
                return "غیر فعال";
            }
            else
            {
                return "";
            }
        }

        protected void grid_exams_RowDeleting(object sender, System.Web.UI.WebControls.GridViewDeleteEventArgs e)
        {
            long id = (long)e.Keys["Id"];
            examRepository.DeleteExam(id);
            Response.Redirect("Exam.aspx?view=manage");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<Database.Exam> azmunha = examRepository.GetExams(txt_search.Value);
            grid_exams.DataSource = azmunha;
            grid_exams.DataBind();
        }
    }

}