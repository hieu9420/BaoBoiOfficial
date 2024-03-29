﻿using System;
using System.Collections.Generic;
using System.Text;
using BaoBoi.Data.EF;
using System.Threading.Tasks;
using BaoBoi.Data.Entities;
using BaoBoi.Utilities.Exceptions;
using BaoBoi.Application.ViewModel;

namespace BaoBoi.Application.Interfaces
{
    public class PhoneUserService : IPhoneUserService
    {
        private readonly BaoBoiDbContext _context;
        public PhoneUserService(BaoBoiDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(PhoneUserViewModel model)
        {
            var phoneUser = new PhoneUser()
            {
                Phone = model.Phone,
                Name = model.Name,
                Amount = model.Amount,
                Type = model.Type,
                Pay = model.Pay,
            };
            _context.PhoneUsers.Add(phoneUser);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(string phone)
        {
            var phoneUser = await _context.PhoneUsers.FindAsync(phone);
            if(phoneUser == null)
            {
                throw new BaoBoiException($"Can not Found Phone: {phone}");
            }
            _context.PhoneUsers.Remove(phoneUser);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<PhoneUserViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<PageViewModel<PhoneUserViewModel>> GetAllPaging(string phone, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(PhoneUserViewModel model)
        {
            var phoneUser = await _context.PhoneUsers.FindAsync(model.Phone);
            if (phoneUser == null)
            {
                throw new BaoBoiException($"Can not Found Phone: {model.Phone}");
            }

            phoneUser.Name = model.Name;
            phoneUser.Amount = model.Amount;
            phoneUser.Pay = model.Pay;
            phoneUser.Type = model.Type;
            _context.PhoneUsers.Update(phoneUser);
            return await _context.SaveChangesAsync();
        }
    }
}
