using Examination.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.ViewModel
{
    public class QnAViewModel
    {

        public int Id { get; set; }
        [Required]
        public string Question { get; set; }
        [Required]
        public string Answer { get; set; }
        [Required]
        public string Option1 { get; set; }
        [Required]
        public string Option2 { get; set; }
        [Required]
        public string Option3 { get; set; }
        [Required]
        public string Option4 { get; set; }
        [Required,Display(Name = "Exam")]
        public int ExamId { get; set; }

       public List<QnAViewModel> QnAList { get; set; } 
        
        public IEnumerable<Exams> ExamList { get; set; }

        public int TotalCount { get; set; }

        public int SelectedAnswer { get; set; }

        public QnAViewModel()
        {
            
        }

        public QnAViewModel(QnAs model)
        {
            Id = model.Id;
            ExamId = model.ExamId;
            Answer = model.Answer;
            Option1 = model.Option1 ?? "";
            Option2 = model.Option2 ?? "";
            Option3 = model.Option3 ?? ""; 
            Option4 = model.Option4 ?? "";
            Question = model.Question ?? "";
        }

        public QnAs ConvertViewModel(QnAViewModel model)
        {
            return new QnAs
            {
                Id = model.Id,
                ExamId = model.ExamId,
                Answer = model.Answer,
                Option1 = model.Option1 ?? "",
                Option2 = model.Option2 ?? "",
                Option3 = model.Option3 ?? "",
                Option4 = model.Option4 ?? "",
                Question = model.Question ?? ""
            };
        }
    }
}
