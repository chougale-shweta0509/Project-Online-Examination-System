﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Data.Entity
{
    public class Exams
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime  StartDate { get; set; }

        public int time { get; set; }

        public int GroupId { get; set; }

        public Groups Groups  { get; set; }

        public ICollection<ExamResults> ExamResults { get; set; } = new HashSet<ExamResults>();

        public ICollection<QnAs> QnAs { get; set; } 
    }
}
