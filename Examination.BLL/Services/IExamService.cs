using Examination.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.BLL.Services
{
    public interface IExamService
    {
        PagedResult<ExamViewModel> GetAllExam(int pageNumber, int pageSize);

        Task<ExamViewModel> AddAsync(ExamViewModel examViewModel);
    }
}
