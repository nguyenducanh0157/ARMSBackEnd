using Data.ArmsContext;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.SupplierRepo
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly ArmsDbContext _context;
        public SupplierRepository(ArmsDbContext context) { _context = context; }
        public async Task<List<Supplier>> GetSuppliers()
        {
            try
            {
                List<Supplier> suppliers = await _context.Suppliers
                    .ToListAsync();
                return suppliers;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
        public async Task<int> CountSupplier()
        {
            try
            {
                int suppliers = _context.Suppliers.Count();
                return suppliers;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
