using BusinessObject.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessObject.IService
{
    public interface ISupplierService
    {
        Task AddSupplierAsync(SupplierDTO supplierDTO);
        Task UpdateSupplierAsync(SupplierDTO supplierDTO);
        Task<bool> DeleteSupplierAsync(int supplierId);
        Task<SupplierDTO> GetSupplierByIdAsync(int supplierId);
        Task<IEnumerable<SupplierDTO>> GetAllSuppliersAsync();
    }
}
