﻿using Examination.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.ViewModel
{
    public class ExamViewModel
    {
        public ExamViewModel()
        {
            
        }

        public ExamViewModel(Exams model)
        {
            Id= model.Id;   
            Title= model.Title ?? "";
            Description= model.Description ?? "";
            StartDate = model.StartDate;
            Time = model.Time;
            GroupId = model.GroupId;

        }

        public Exams ConvertViewModel(ExamViewModel model)
        {
            return new Exams
            {
                Id = model.Id,
                Title = model.Title ?? "",
                Description = model.Description ?? "",
                StartDate = model.StartDate,
                Time = model.Time,
                GroupId = model.GroupId
            };
        }


        public int Id { get; set; }
        [Required,Display(Name ="Exam Name")]
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public int Time { get; set; }

        public int GroupId { get; set; }

        public List<ExamViewModel> ExamList { get; set; }

        public int TotalCount { get; set; }

        public IEnumerable<Groups> GroupList { get; set; }
        
    }
}
