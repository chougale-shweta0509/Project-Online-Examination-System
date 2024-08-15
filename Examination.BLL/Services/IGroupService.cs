using Examination.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.BLL.Services
{
    public interface IGroupService
    {
        PagedResult<GroupViewModel> GetAllGroup(int pageNumber, int pageSize);

        Task<GroupViewModel> AddGroupAsync(GroupViewModel groupViewModel);

        GroupViewModel GetGroup(int id);

    }
}
