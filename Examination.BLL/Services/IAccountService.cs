using Examination.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.BLL.Services
{
    public interface IAccountService
    {


        bool AddTeacher(UserViewModel userViewModel);
        PagedResult<UserViewModel>
            GetAllTeacher(int pageNumber,int pageSize);

    }
}
