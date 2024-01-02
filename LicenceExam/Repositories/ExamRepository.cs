using LicenceExam.Database;
using LicenceExam.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LicenceExam.Repositories
{
    public class ExamRepository
    {
        private AzmoonEntities dbContext;
        public ExamRepository()
        {


            dbContext = new AzmoonEntities();
        }
        public void CreateExam(string title, string startDate, string endDate)
        {
            try
            {
                if (string.IsNullOrEmpty(title))
                {
                    throw new ApplicationException("عنوان نمی تواند خالی باشد");
                }
                if (string.IsNullOrEmpty(startDate))
                {
                    throw new ApplicationException("تاریخ شروع نامعتبر است");
                }
                if (string.IsNullOrEmpty(endDate))
                {
                    throw new ApplicationException("تاریخ پایان نامعتبر است");
                }

                Database.Exam azmoon = new Database.Exam();
                azmoon.Title = title;
                azmoon.StartDate = Convert.ToDateTime(startDate);
                azmoon.EndDate = Convert.ToDateTime(endDate);
                azmoon.Status = (int)ExamStatus.Active;

                dbContext.Exams.Add(azmoon);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Database.Exam> GetExams(string title = "")
        {
            if (string.IsNullOrEmpty(title))
            {
                return dbContext.Exams.ToList();
            }
            else
            {
                return dbContext.Exams.Where(e => e.Title.Contains(title)).ToList();
            }
        }

        public void DeleteExam(long id)
        {
            Database.Exam azmoon = dbContext.Exams.FirstOrDefault(i => i.Id == id);
            if (azmoon != null)
            {
                dbContext.Exams.Remove(azmoon);
                dbContext.SaveChanges();
            }
        }
    }
}