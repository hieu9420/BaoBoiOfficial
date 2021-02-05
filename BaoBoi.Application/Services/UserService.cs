using BaoBoi.Application.Dtos;
using BaoBoi.Application.Interfaces;
using BaoBoi.Application.ViewModel;
using BaoBoi.Data.EF;
using BaoBoi.Data.Entities;
using BaoBoi.Utilities.Exceptions;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BaoBoi.Application.Services
{
    public class UserService : IUserService
    {
        private readonly BaoBoiDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IConfiguration _configuration;
        public UserService(BaoBoiDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IConfiguration configuration)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }

        public async Task<string> Authencate(LoginRequest model)
        {
            var user = await _userManager.FindByNameAsync(model.UserName);
            if (user == null)
            {
                throw new BaoBoiException($"Can not Account: {model.UserName}");
            }

            var result = await _signInManager.PasswordSignInAsync(user, model.Password, model.Remember ?? false, true);
            if (!result.Succeeded)
            {
                return null;
            }

            var claims = new[]
            {
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.MobilePhone, user.PhoneNumber)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Tokens:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_configuration["Tokens:Issuer"],
                _configuration["Tokens:Issuer"],
                claims,
                expires: DateTime.Now.AddHours(3),
                signingCredentials: creds);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<UserViewModel> FindUser(UserViewModel model)
        {
            AppUser result = new AppUser();
            result = await _context.Users.FindAsync(model.UserName, model.PasswordHash);
            if (result == null)
            {
                throw new BaoBoiException($"Can not Account: {model.UserName}");
            }

            UserViewModel data = new UserViewModel();

            data.UserName = result.UserName;
            data.Email = result.Email;
            data.PasswordHash = result.PasswordHash;
            data.Dob = result.Dob;
            data.PhoneNumber = result.PhoneNumber;

            return data;
        }
    }
}
