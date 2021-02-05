using BaoBoi.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BaoBoi.Application.Interfaces
{
    public interface ILoiChucService
    {
        Task<int> Create(LoiChucViewModel model);
        Task<int> Update(LoiChucViewModel model);
        Task<int> Delete(int ID);

        Task<List<LoiChucViewModel>> GetAll();
        Task<PageViewModel<LoiChucViewModel>> GetAllPaging(int ID, int pageIndex, int pageSize);
    }
}
