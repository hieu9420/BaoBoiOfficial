using BaoBoi.Application.Dtos;
using BaoBoi.Data.EF;
using BaoBoi.Data.Entities;
using BaoBoi.Utilities.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoBoi.Application.Interfaces
{
    public class LoiChucService : ILoiChucService
    {
        private readonly BaoBoiDbContext _context;
        public LoiChucService(BaoBoiDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(LoiChucViewModel model)
        {
            LoiChuc loiChuc = new LoiChuc()
            {
                CauChuc = model.CauChuc,
                Type = model.Type,
            };
            _context.LoiChucs.Add(loiChuc);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int ID)
        {
            var loiChuc = await _context.LoiChucs.FindAsync(ID);
            if (loiChuc == null)
            {
                throw new BaoBoiException($"Can not Found Loi Chuc: {ID}");
            }
            _context.LoiChucs.Remove(loiChuc);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<LoiChucViewModel>> GetAll()
        {
            var data = await _context.LoiChucs.Select( 
                x => new LoiChucViewModel()
                {
                    ID = x.ID,
                    CauChuc = x.CauChuc,
                    Type = x.Type,
                }
            ).ToListAsync();
            return data;
        }

        public Task<PageViewModel<LoiChucViewModel>> GetAllPaging(int ID, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(LoiChucViewModel model)
        {
            var loiChuc = await _context.LoiChucs.FindAsync(model.ID);
            if (loiChuc == null)
            {
                throw new BaoBoiException($"Can not Found Loi Chuc: {model.ID}");
            }
            loiChuc.CauChuc = model.CauChuc;
            loiChuc.Type = model.Type;

            _context.LoiChucs.Update(loiChuc);
            return await _context.SaveChangesAsync();
        }
    }
}
