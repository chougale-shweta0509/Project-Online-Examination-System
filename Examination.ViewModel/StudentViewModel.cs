using Examination.Data.Entity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.ViewModel
{
    public class StudentViewModel
    {
        public StudentViewModel() 
        {
        
        }

        public StudentViewModel(Students model)
        {
            Id = model.Id;
            Name = model.Name ?? "";
            UserName = model.UserName;
            Password = model.Password;
            Contact = model.Contact ?? "";
            CvfileName = model.CvfileName ?? "";
            PictureFileName = model.PictureFileName ?? "";
            GroupId = model.GroupsId;
        }

        public Students ConvertViewModel (StudentViewModel model)
        {
            return new Students
            {
                Id = model.Id,
                Name = model.Name ?? "",
                UserName = model.UserName,
                Password = model.Password,
                Contact = model.Contact ?? "",
                CvfileName = model.CvfileName ?? "",
                PictureFileName = model.PictureFileName ?? "",
                GroupsId = model.GroupId
            };
        }


        public int Id { get; set; }
        [Required,Display(Name="Student Name")]
        public string Name { get; set; }
        [Required, Display(Name = "User Name")]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Display(Name = "Contact Number")]
        public string Contact { get; set; }
        [Display(Name = "CVr")]
        public string CvfileName { get; set; }

        public string PictureFileName { get; set; }

        public int? GroupId { get; set; }

        public int? Class { get; set; }

        public List<StudentViewModel> StudentList { get; set; }

        public int TotalCountty { get; set; }

        public IFormFile PictureFile { get; set; }

        public IFormFile CVFile { get; set; }

    }
}
