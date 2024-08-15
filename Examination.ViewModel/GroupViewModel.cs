using Examination.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.ViewModel
{
    public class GroupViewModel
    {
        public int Id { get; set; }
        [Required,Display(Name="Group Name")]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public int UsersId { get; set; }
        public int TotalCount { get; set; }
        public List<StudentCheckBoxListModel> StudentCheckList { get; set; }    
        public List<GroupViewModel> GroupList { get; set; }

        public GroupViewModel()
        {
            
        }

        public GroupViewModel(Groups model)
        {
            Id = model.Id;
            Name = model.Name ?? "";
            Description = model.Description ?? "";
            UsersId = model.UsersId;
            
        }

        public Groups ConvertViewModel(GroupViewModel model)
        {
            return new Groups
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description,
                UsersId = model.UsersId,
            };
        }



    }
}
