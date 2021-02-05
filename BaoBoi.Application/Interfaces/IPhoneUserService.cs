using BaoBoi.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BaoBoi.Application.Interfaces
{
    public interface IPhoneUserService
    {
        Task<int> Create(PhoneUserViewModel model);
        Task<int> Update(PhoneUserViewModel model);
        Task<int> Delete(string phone);

        Task<List<PhoneUserViewModel>> GetAll();
        Task<PageViewModel<PhoneUserViewModel>> GetAllPaging(string phone, int pageIndex, int pageSize);
    }
}
