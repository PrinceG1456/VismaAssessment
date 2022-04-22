using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VismaTest.Domain.Models;
using VismaTest.Domain.ViewModel;

namespace VismaTest.Service.IService
{
    public interface IInvoiceService
    {
        InvoiceViewModel Get(int id);

        IEnumerable<InvoiceViewModel> GetAll();

        InvoiceViewModel Create(InvoiceBindingModel model);

        InvoiceViewModel Update(int id, InvoiceBindingModel model);

    }
}
