using DataAccess.DAO;
using DataAccess.IRepository;
using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly SupplierDAO _supplierDao;

        public SupplierRepository(ProjectPRN221Context context)
        {
            _supplierDao = new SupplierDAO(context);
        }

        public async Task AddSupplierAsync(Supplier supplier)
        {
            await _supplierDao.CreateAsync(supplier);
        }

        public async Task UpdateSupplierAsync(Supplier supplier)
        {
            await _supplierDao.UpdateAsync(supplier);
        }

        public async Task RemoveSupplierAsync(int supplierId)
        {
            await _supplierDao.DeleteSupplierAsync(supplierId);
        }

        public async Task<List<Supplier>> GetAllSuppliersAsync()
        {
            return await _supplierDao.GetAllAsync();
        }

        public async Task<Supplier> GetSupplierByIdAsync(int supplierId)
        {
            return await _supplierDao.GetByIdAsync(supplierId);
        }
    }
}
