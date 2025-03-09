using Examination.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.BLL.Services
{
    public interface IQnAService
    {
        PagedResult<QnAViewModel> GetAll(int pageNumber,int pageSize);

        Task<QnAViewModel> AddAsync(QnAViewModel model);

        IEnumerable<QnAViewModel> GetAllQnAByExam(int examId);

        bool IsExamAttended(int examId, int studentId);

    }
}
