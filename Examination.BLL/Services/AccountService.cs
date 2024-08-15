using Examination.Data.Entity;
using Examination.Data.UnitOfWork;
using Examination.ViewModel;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.BLL.Services
{
    public class AccountService : IAccountService
    {
        IUnitOfWork _unitOfWork;
        

        public AccountService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool AddTeacher(UserViewModel userViewModel)
        {
            try
            {
                Users obj = new Users()
                {
                    Name = userViewModel.Name,
                    UserName = userViewModel.UserName,
                    Password = userViewModel.Password,
                    Role = (int)EnumRoles.Teacher
                };
                _unitOfWork.GenericRepository<Users>().Add(obj);
                _unitOfWork.Save();
            }
            catch(Exception ex)
            {
                throw;
                return false;
            }
            return true;
        }
    }
}
