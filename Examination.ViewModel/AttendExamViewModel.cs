using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.ViewModel
{
    public class AttendExamViewModel
    {
        public int StudentId { get; set; }

        public string ExamName { get; set; }

        public string Message { get; set; }

        public List<QnAViewModel> QnAs { get; set; }
    }
}
