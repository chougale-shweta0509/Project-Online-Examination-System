﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Data.Entity
{
    public class QnAs
    {
        public int Id { get; set; }
        public string Question { get; set; }

        public string Answer { get; set; }

        public string Option1 { get; set; }
         
        public string Option2 { get; set; }

        public string Option3 { get; set; }

        public string Option4 { get; set; }
        public int ExamId { get; set; }

        public Exams Exams { get; set; }
        public ICollection<ExamResults> ExamResults { get; set; } = new HashSet<ExamResults>();
    }
}
