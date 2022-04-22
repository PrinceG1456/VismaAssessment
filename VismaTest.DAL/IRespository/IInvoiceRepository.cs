using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VismaTest.Domain.ViewModel;

namespace VismaTest.DAL.IRespository
{
    public interface IInvoiceRepository:IBaseRepository<InvoiceViewModel>
    {
        IReadOnlyCollection<InvoiceViewModel> GetByInvoiceNumber(int invoiceNumber);
    }
}
