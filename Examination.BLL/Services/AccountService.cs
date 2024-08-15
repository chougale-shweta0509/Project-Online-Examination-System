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
            catch (Exception ex)
            {
                throw;
                return false;
            }
            return true;
        }

        public PagedResult<UserViewModel> GetAllTeacher(int pageNumber, int pageSize)
        {
            var vm = new UserViewModel();
            try
            {
                int ExcludeRecords = (pageSize * pageNumber) - pageSize;
                List<UserViewModel> detailList = new List<UserViewModel>();
                var model = _unitOfWork.GenericRepository<Users>().GetAll().
                    Where(a => a.Role == (int)EnumRoles.Teacher).Skip(ExcludeRecords)
                    .Take(pageSize).ToList();

                detailList = ListInfo(model);
                if (detailList != null)
                {
                    vm.UserList = detailList;
                    vm.TotalCount = _unitOfWork.GenericRepository<Users>().
                        GetAll().Count(x => x.Role == (int)EnumRoles.Teacher);
                }

            }
            catch (Exception ex)
            {
                throw;
            }
            var result = new PagedResult<UserViewModel>
            {
                Data = vm.UserList,
                TotalItems = vm.TotalCount,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
            return result;

        }

        private List<UserViewModel> ListInfo(List<Users> model)
        {
            return model.Select(o => new UserViewModel(o)).ToList();
        }
    }
}