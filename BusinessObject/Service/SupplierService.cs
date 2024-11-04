using BusinessObject.DTO;
using BusinessObject.IService;
using DataAccess.IRepository;
using DataAccess.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessObject.Service
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository _supplierRepository;

        public SupplierService(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public async Task AddSupplierAsync(SupplierDTO supplierDTO)
        {
            var supplier = new Supplier
            {
                SupplierName = supplierDTO.SupplierName,
                Email = supplierDTO.Email,
                PhoneNumber = supplierDTO.PhoneNumber,
                Address = supplierDTO.Address,
                CreatedAt = supplierDTO.CreatedAt
            };
            await _supplierRepository.AddSupplierAsync(supplier);
        }

        public async Task UpdateSupplierAsync(SupplierDTO supplierDTO)
        {
            var supplier = new Supplier
            {
                SupplierId = supplierDTO.SupplierId,
                SupplierName = supplierDTO.SupplierName,
                Email = supplierDTO.Email,
                PhoneNumber = supplierDTO.PhoneNumber,
                Address = supplierDTO.Address,
                CreatedAt = supplierDTO.CreatedAt
            };

            await _supplierRepository.UpdateSupplierAsync(supplier);
        }

        public async Task<bool> DeleteSupplierAsync(int supplierId)
        {
            var supplier = await _supplierRepository.GetSupplierByIdAsync(supplierId);
            if (supplier == null)
            {
                return false;
            }

            await _supplierRepository.RemoveSupplierAsync(supplierId);
            return true;
        }

        public async Task<SupplierDTO> GetSupplierByIdAsync(int supplierId)
        {
            var supplier = await _supplierRepository.GetSupplierByIdAsync(supplierId);
            if (supplier == null)
            {
                return null;
            }

            return new SupplierDTO
            {
                SupplierId = supplier.SupplierId,
                SupplierName = supplier.SupplierName,
                Email = supplier.Email,
                PhoneNumber = supplier.PhoneNumber,
                Address = supplier.Address,
                CreatedAt = supplier.CreatedAt
            };
        }

        public async Task<IEnumerable<SupplierDTO>> GetAllSuppliersAsync()
        {
            var suppliers = await _supplierRepository.GetAllSuppliersAsync();
            return suppliers.Select(supplier => new SupplierDTO
            {
                SupplierId = supplier.SupplierId,
                SupplierName = supplier.SupplierName,
                Email = supplier.Email,
                PhoneNumber = supplier.PhoneNumber,
                Address = supplier.Address,
                CreatedAt = supplier.CreatedAt
            }).ToList();
        }
    }
}
