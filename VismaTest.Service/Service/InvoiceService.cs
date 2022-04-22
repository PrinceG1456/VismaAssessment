using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VismaTest.DAL.IRespository;
using VismaTest.Domain.Models;
using VismaTest.Domain.ViewModel;
using VismaTest.Service.IService;

namespace VismaTest.Service.Service
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository _invoiceRepository;

        public InvoiceService(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }
        public InvoiceViewModel Create(InvoiceBindingModel model)
        {
            throw new NotImplementedException();
        }

        public InvoiceViewModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InvoiceViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public InvoiceViewModel Update(int id, InvoiceBindingModel model)
        {
            throw new NotImplementedException();
        }
    }
}
