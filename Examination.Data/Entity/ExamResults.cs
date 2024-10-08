﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Data.Entity
{
    public class ExamResults
    {
        public int Id { get; set; }

        public int Answer { get; set; }

        public int StudentsId { get; set; }

        public Students Student { get; set; }

        public int QnAsId { get; set; }

        public QnAs QnAs { get; set; }

        public int ExamId { get; set; }

        public Exams Exams { get; set; }
    }
}
