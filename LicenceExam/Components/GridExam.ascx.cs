using LicenceExam.Models.Enums;
using LicenceExam.Models.Extensions;
using LicenceExam.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LicenceExam.Components
{
    public partial class GridExam : System.Web.UI.UserControl
    {
        ExamRepository examRepository;
        protected void Page_Load(object sender, EventArgs e)
        {
            examRepository = new ExamRepository();

            List<Database.Exam> azmunha = examRepository.GetExams();
            grid_exams.DataSource = azmunha;
            grid_exams.DataBind();

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

        protected void grid_exams_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            long id = (long)grid_exams.DataKeys[e.NewEditIndex].Value;
            Response.Redirect("Exam.aspx?view=edit&examId=" + id);
        }

        protected void grid_exams_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            TableCell cell = e.Row.Cells[7];
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                long id = Convert.ToInt64(grid_exams.DataKeys[e.Row.RowIndex].Value);
                Database.Exam azmoon = examRepository.GetById(id);
                Button btn = new Button();
                if (azmoon.Status == (int)ExamStatus.Active)
                {
                    btn.CssClass = "btn btn-outline-danger";
                    btn.Text = "غیر فعال سازی";
                    btn.Click += (se, ev) =>
                    {
                        examRepository.DeactivateExam(id);
                        Response.Redirect("Exam.aspx?view=manage");
                    };
                }
                else if (azmoon.Status == (int)ExamStatus.InActive)
                {
                    btn.CssClass = "btn btn-outline-success";
                    btn.Text = "فعال سازی";
                    btn.Click += (se, ev) =>
                    {
                        examRepository.ActivateExam(id);
                        Response.Redirect("Exam.aspx?view=manage");
                    };
                }
                cell.Controls.Clear();
                cell.Controls.Add(btn);
            }

            
        }



        protected void grid_exams_DataBinding(object sender, EventArgs e)
        {
            int r = grid_exams.Rows.Count;
        }
    }

}