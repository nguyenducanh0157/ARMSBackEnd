using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.SupplierRepo
{
    public interface ISupplierRepository
    {
        Task<int> CountSupplier();
        Task<List<Supplier>> GetSuppliers();
    }
}
