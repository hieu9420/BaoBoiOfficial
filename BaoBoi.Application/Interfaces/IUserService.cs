using BaoBoi.Application.Dtos;
using BaoBoi.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BaoBoi.Application.Interfaces
{
    public interface IUserService
    {
        Task<string> Authencate(LoginRequest model);
        Task<UserViewModel> FindUser(UserViewModel model);
    }
}
