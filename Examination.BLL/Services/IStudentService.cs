using Examination.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.BLL.Services
{
    public interface IStudentService
    {
        PagedResult<StudentViewModel> GetAll(int pageNumber, int pageSize);
        Task<StudentViewModel> AddAsync(StudentViewModel student);

        bool SetGroupIdToStudents(GroupViewModel groupViewModel);

        bool SetExamResult(AttendExamViewModel attendExamViewModel);

        IEnumerable<ResultViewModel> GetAllExamResult(int studentId);

        StudentViewModel GetById(int studentId);


        Task<StudentViewModel> UpdateAsync(StudentViewModel student);


    }
}
